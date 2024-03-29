﻿using System;
using System.IO;
using System.Collections.Generic;
using Laserfiche.DocumentServices;
using Laserfiche.RepositoryAccess;

namespace Minem.Sgpam.SoporteLaserFiche.Utilitarios
{
    /// <summary>
    /// Objetivo:	Clase que implementa métodos para LF
    /// Creado Por:	(ORM) Omar Rodriguez M.
    /// Fecha Creación:	12/01/2022
    /// </summary>
    public static class FullLaserFiche
    {
        private static Session IniciarSesion(string vUsuario, string vClave, string vServidor, string vNombreRepositorio)
        {
            try
            {
                Session vSession = new Session();
                vSession.LogIn(vUsuario, vClave, new RepositoryRegistration(vServidor, vNombreRepositorio));
                return vSession;
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains(Constantes.Constantes.ErrMaxConection))
                {
                    return null;
                }
                else
                {
                    throw;
                }
            }
        }

        private static bool ExisteCarpeta(string vRutaPadre, string vCarpeta, Session vSession)
        {
            bool vResult = false;
            using (Search vSearchFolder = new Search(vSession))
            {
                vSearchFolder.Command = "{LF:Name=\"" + vCarpeta + "\", Type=\"F\"} & {LF:LOOKIN=\"" + vSession.Repository.Name + "\\" + vRutaPadre + "\"}";
                vSearchFolder.Run();

                SearchListingSettings vSearchList = new SearchListingSettings { Refresh = false, SortDirection = SortDirection.Ascending };
                vResult = !(vSearchFolder.GetResultListing(vSearchList).RowCount <= 0);
                vSearchFolder.Close();
            }

            return vResult;
        }

        private static string CrearCarpeta(string vRutaPadre, string vCarpeta, Session vSession)
        {
            using (FolderInfo vContainerFolder = Folder.GetFolderInfo(vRutaPadre, vSession))
            {
                using (FolderInfo vFolderInfo = new FolderInfo(vSession))
                {
                    vFolderInfo.Create(vContainerFolder, vCarpeta, EntryNameOption.None);
                    vFolderInfo.Unlock();
                    vFolderInfo.Refresh(true);
                }
            }

            return vRutaPadre + "\\" + vCarpeta;
        }

        private static long ImportarArchivo(string vRutaRepositorio, string vUbicacionArchivo, string vNombreArchivo, Session vSession)
        {
            string vVolume = Constantes.Constantes.Volume;
            DocumentImporter vImport = new DocumentImporter { Document = new DocumentInfo(vSession), OverwritePages = true, ExtractTextFromEdoc = true };

            vImport.Document.Create(Folder.GetFolderInfo(vRutaRepositorio, vSession), vNombreArchivo, vVolume, EntryNameOption.AutoRename);
            vImport.Document.Extension = Path.GetExtension(vUbicacionArchivo).ToLowerInvariant();
            vImport.GetType();
            vImport.ImportEdoc(ObtenerTipoArchivo(vImport.Document.Extension), vUbicacionArchivo);
            vImport.Document.Save();

            return vImport.Document.Id;
        }

        public static string ObtenerTipoArchivo(string vExtension)
        {
            var vType = TiposArchivos();
            return vType[vExtension];
        }

        private static Dictionary<string, string> TiposArchivos()
        {
            return new Dictionary<string, string>
            {
                {".txt", "text/plain"},
                {".pdf", "application/pdf"},
                {".doc", "application/vnd.ms-word"},
                {".docx", "application/vnd.ms-word"},
                {".xls", "application/vnd.ms-excel"},
                {".xlsx", "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet"},
                {".png", "image/png"},
                {".jpg", "image/jpeg"},
                {".jpeg", "image/jpeg"},
                {".gif", "image/gif"},
                {".csv", "text/csv"}
            };
        }

        public static string CrearCarpeta(string vRutaPadre, string vCarpeta, string vUsuario, string vClave, string vServidor, string vNombreRepositorio)
        {
            string vPath = "";
            if (!string.IsNullOrEmpty(vRutaPadre) && !string.IsNullOrEmpty(vCarpeta))
            {
                try
                {
                    Session vSession = IniciarSesion(vUsuario, vClave, vServidor, vNombreRepositorio);
                    if (vSession != null)
                    {
                        if (!ExisteCarpeta(vRutaPadre, vCarpeta, vSession))
                        {
                            using (FolderInfo vContainerFolder = Folder.GetFolderInfo(vRutaPadre, vSession))
                            {
                                using (FolderInfo vFolderInfo = new FolderInfo(vSession))
                                {
                                    vFolderInfo.Create(vContainerFolder, vCarpeta, EntryNameOption.None);
                                    vFolderInfo.Unlock();
                                    vFolderInfo.Refresh(true);
                                }
                            }

                            vPath = vRutaPadre + "\\" + vCarpeta;
                        }
                        vSession.LogOut();
                        return vPath;
                    }
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
            return null;
        }

        public static long SubirArchivo(string vRutaPadre, string vCarpeta, string vUbicacionArchivo, string vNombreArchivo, string vUsuario, string vClave, string vServidor, string vNombreRepositorio)
        {
            long vIdLaserFiche = 0;

            if (!string.IsNullOrEmpty(vRutaPadre) && !string.IsNullOrEmpty(vCarpeta) && !string.IsNullOrEmpty(vUbicacionArchivo) && !string.IsNullOrEmpty(vNombreArchivo))
            {
                vUbicacionArchivo = vUbicacionArchivo.Trim();
                Session vSession = IniciarSesion(vUsuario, vClave, vServidor, vNombreRepositorio);

                if (vSession != null)
                {
                    if (!ExisteCarpeta(vRutaPadre, vCarpeta, vSession))
                    {
                        CrearCarpeta(vRutaPadre, vCarpeta, vSession);
                    }

                    string vRuta = vRutaPadre + "\\" + vCarpeta;
                    vIdLaserFiche = ImportarArchivo(vRuta, vUbicacionArchivo, vNombreArchivo, vSession);
                    vSession.LogOut();
                }
            }

            return vIdLaserFiche;
        }

        public static bool EliminarArchivo(int vIdArchivo, string vUsuario, string vClave, string vServidor, string vNombreRepositorio)
        {
            Session vSession = IniciarSesion(vUsuario, vClave, vServidor, vNombreRepositorio);
            if (vSession != null)
            {
                using (EntryInfo vGetFile = Entry.GetEntryInfo(vIdArchivo, vSession))
                {
                    if (vGetFile != null)
                    {
                        vGetFile.Lock(LockType.Exclusive);
                        vGetFile.Delete();
                        vGetFile.Save();
                        vGetFile.Unlock();
                        vGetFile.Dispose();
                        vSession.LogOut();
                        return true;
                    }
                }
            }

            return false;
        }

        public static MemoryStream ExportarArchivo(int IdArchivo, string vUsuario, string vClave, string vServidor, string vNombreRepositorio)
        {
            MemoryStream vMemoryStream = new MemoryStream();

            try
            {
                Session vSession = IniciarSesion(vUsuario, vClave, vServidor, vNombreRepositorio);
                if (vSession != null)
                {
                    DocumentExporter vExporter = new DocumentExporter();
                    DocumentInfo vInfoDocument = Document.GetDocumentInfo(IdArchivo, vSession);
                    vExporter.ExportElecDoc(vInfoDocument, vMemoryStream);
                }
            }
            catch (Exception)
            {
                throw;
            }

            return vMemoryStream;
        }

    }
}
