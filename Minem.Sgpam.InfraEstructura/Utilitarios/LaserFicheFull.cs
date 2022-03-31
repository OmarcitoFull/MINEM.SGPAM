using System;
using Laserfiche.DocumentServices;
using Laserfiche.RepositoryAccess;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Minem.Sgpam.InfraEstructura.Utilitarios
{
    /// <summary>
    /// Objetivo:	Clase que permite leer el ip
    /// Creado Por:	(ORM) Omar Rodriguez M.
    /// Fecha Creación:	10/12/2021
    /// </summary>
    public static class LaserFicheFull
    {
        static string Servidor = "";
        static string Repositorio = "";
        static string Volumen = "";

        public static Session IniciarSesion(string vUsuario, string vClave, string vServidor, string vNombreRepositorio)
        {
            try
            {
                Session vSession = new Session();
                vSession.LogIn(vUsuario, vClave, new RepositoryRegistration(vServidor, vNombreRepositorio));
                return vSession;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public static string CrearCarpeta(string vRutaPadre, string Carpeta, string file1, string file2,
            string vUsuario, string vClave, string vServidor, string vNombreRepositorio)
        {
            try
            {
                Session vSession = IniciarSesion(vUsuario, vClave, vServidor, vNombreRepositorio);
                if (vSession != null)
                {
                    FolderInfo carpetaContent = Folder.GetFolderInfo(vRutaPadre, vSession);
                    FolderInfo carpetaDocAdm = new FolderInfo(vSession);
                    FolderInfo carpetaDocGen = new FolderInfo(vSession);
                    FolderInfo carpetaExpediente = new FolderInfo(vSession);
                    carpetaExpediente.Create(carpetaContent, Carpeta, EntryNameOption.None);
                    carpetaExpediente.Unlock();
                    carpetaExpediente.Refresh(true);

                    carpetaDocAdm.Create(carpetaExpediente, file1, EntryNameOption.None);
                    carpetaDocAdm.Unlock();
                    carpetaDocAdm.Refresh(true);
                    carpetaDocGen.Create(carpetaExpediente, file2, EntryNameOption.None);
                    carpetaDocGen.Unlock();
                    carpetaDocGen.Refresh(true);
                }
            }
            catch (Exception)
            {
                throw;
            }

            return vRutaPadre + "\\" + Carpeta;
        }

        public static long SubirArchivoSubSubCarpeta(string vUsuario, string vClave, string vServidor, string vNombreRepositorio,
            string vCarpeta, string vSubCarpeta, string vUbicacionFile, string SubSubCarpeta, string NombreArchivo, string IP)
        {
            long IdLaserFiche = 0;

            try
            {
                vUbicacionFile = vUbicacionFile.Trim();
                Session vSession = IniciarSesion(vUsuario, vClave, vServidor, vNombreRepositorio);

                if (vSession != null)
                {
                    if (!string.IsNullOrEmpty(vCarpeta) && !string.IsNullOrEmpty(vSubCarpeta))
                    {
                        /* VALIDAMOS LA SUB CARPETA*/
                        Search lfSearch1 = new Search(vSession);
                        lfSearch1.Command = "{LF:Name=\"" + vSubCarpeta + "\", Type=\"F\"} & {LF:LOOKIN=\"" + Repositorio + "\\" + vCarpeta + "\"}";
                        lfSearch1.Run();
                        SearchListingSettings searchSettings1 = new SearchListingSettings();
                        searchSettings1.SortDirection = SortDirection.Ascending;
                        SearchResultListing results1 = lfSearch1.GetResultListing(searchSettings1);

                        if (results1.RowCount <= 0)
                        {
                            //No Existe, Creamos la SubCarpeta
                            using (FolderInfo vCarpetaPadreLF = Folder.GetFolderInfo("\\" + vCarpeta, vSession))
                            {
                                using (FolderInfo vContenedorLF = new FolderInfo(vSession))
                                {
                                    vContenedorLF.Create(vCarpetaPadreLF, vSubCarpeta, EntryNameOption.None);
                                    vContenedorLF.Unlock();
                                    vContenedorLF.Refresh(true);
                                }
                            }
                            //FolderInfo vCarpetaPadreLF = Folder.GetFolderInfo("\\" + vCarpeta, vSession);
                            //FolderInfo vContenedorLF = new FolderInfo(vSession);
                            //vContenedorLF.Create(vCarpetaPadreLF, vSubCarpeta, EntryNameOption.None);
                            //vContenedorLF.Unlock();
                            //vContenedorLF.Refresh(true);
                            //vCarpetaPadreLF.Dispose();
                            //vContenedorLF.Dispose();
                        }
                    }


                    ///* VALIDAMOS LA SUB-SUBCARPETA*/
                    //if (SubSubCarpeta.Contains("\\"))
                    //{
                    //    String[] carpetas = SubSubCarpeta.Split('\\');
                    //    String SubSubAuxiliar = "";
                    //    string SubBuscar = "";
                    //    if (carpetas.Length > 0)
                    //    {
                    //        for (int i = 0; i < carpetas.Length; i++)
                    //        {
                    //            SubSubAuxiliar += carpetas[i];
                    //            Search lfSearch2 = new Search(vSession);
                    //            if (i == 0)
                    //            {
                    //                lfSearch2.Command = "{LF:Name=\"" + carpetas[i] + "\", Type=\"F\"} & {LF:LOOKIN=\"" + Repositorio + "\\" + vCarpeta + "\\" + vSubCarpeta + "\"}";
                    //            }
                    //            else
                    //            {
                    //                SubBuscar += carpetas[i - 1];
                    //                lfSearch2.Command = "{LF:Name=\"" + carpetas[i] + "\", Type=\"F\"} & {LF:LOOKIN=\"" + Repositorio + "\\" + vCarpeta + "\\" + vSubCarpeta + "\\" + SubBuscar + "\"}";
                    //                SubBuscar += "\\";
                    //            }
                    //            lfSearch2.Run();
                    //            SearchListingSettings searchSettings2 = new SearchListingSettings();
                    //            searchSettings2.SortDirection = SortDirection.Ascending;
                    //            SearchResultListing results2 = lfSearch2.GetResultListing(searchSettings2);

                    //            if (results2.RowCount <= 0)
                    //            {
                    //                //No existe, creamos ls SubSubCarpeta
                    //                FolderInfo carpetaContent = Folder.GetFolderInfo("\\" + vCarpeta + "\\" + vSubCarpeta, vSession);
                    //                FolderInfo carpetaExpediente = new FolderInfo(vSession);

                    //                if (SubSubAuxiliar.Contains("\\"))
                    //                {
                    //                    String[] carpetas2 = SubSubCarpeta.Split('\\');
                    //                    carpetaContent = Folder.GetFolderInfo("\\" + vCarpeta + "\\" + vSubCarpeta + '\\' + carpetas2[0], vSession);
                    //                }

                    //                carpetaExpediente.Create(carpetaContent, carpetas[i], EntryNameOption.None);
                    //                carpetaExpediente.Unlock();
                    //                carpetaExpediente.Refresh(true);
                    //            }
                    //            SubSubAuxiliar += "\\";
                    //        }
                    //    }
                    //}
                    //else
                    //{
                    //    Search lfSearch = new Search(vSession);
                    //    lfSearch.Command = "{LF:Name=\"" + SubSubCarpeta + "\", Type=\"F\"} & {LF:LOOKIN=\"" + Repositorio + "\\" + vCarpeta + "\\" + vSubCarpeta + "\"}";
                    //    lfSearch.Run();
                    //    SearchListingSettings searchSettings = new SearchListingSettings();
                    //    searchSettings.SortDirection = SortDirection.Ascending;
                    //    SearchResultListing results = lfSearch.GetResultListing(searchSettings);

                    //    if (results.RowCount <= 0)
                    //    {
                    //        //No existe, creamos la SubSubCarpeta
                    //        FolderInfo carpetaContent = Folder.GetFolderInfo("\\" + vCarpeta + "\\" + vSubCarpeta, vSession);
                    //        FolderInfo carpetaExpediente = new FolderInfo(vSession);
                    //        carpetaExpediente.Create(carpetaContent, SubSubCarpeta, EntryNameOption.None);
                    //        carpetaExpediente.Unlock();
                    //        carpetaExpediente.Refresh(true);
                    //    }
                    //}

                    DocumentImporter importer = new DocumentImporter()
                    {
                        Document = new DocumentInfo(vSession),
                        OverwritePages = true,
                        ExtractTextFromEdoc = true
                    };

                    importer.Document.Create(Folder.GetFolderInfo("\\" + vCarpeta + "\\" + vSubCarpeta + "\\" + SubSubCarpeta, vSession), NombreArchivo, Volumen, EntryNameOption.AutoRename);
                    importer.Document.Extension = vUbicacionFile.Substring(vUbicacionFile.LastIndexOf(".") + 1, vUbicacionFile.Length - (vUbicacionFile.LastIndexOf(@".") + 1));
                    importer.GetType();
                    importer.ImportEdoc("application/vnd.ms-word", vUbicacionFile);
                    importer.Document.Save();
                    vSession.LogOut();
                    IdLaserFiche = importer.Document.Id;
                }
                else
                {
                    IdLaserFiche = 0;
                }
            }
            catch (Exception EX)
            {
                //Log.Error(ex.Message, ex);
                //try
                //{
                //    vSession.LogOut();
                //}
                //catch (Exception ex)
                //{
                //    //Log.Error(ex.Message, ex);
                //}
            }
            return IdLaserFiche;
        }

        public static bool EliminarArchivo(int vIdArchivo, string vUsuario, string vClave, string vServidor, string vNombreRepositorio)
        {
            Session vSession = IniciarSesion(vUsuario, vClave, vServidor, vNombreRepositorio);
            if (vSession != null)
            {
                using (EntryInfo vObtenerArchivo = Entry.GetEntryInfo(vIdArchivo, vSession))
                {
                    if (vObtenerArchivo != null)
                    {
                        vObtenerArchivo.Lock(LockType.Exclusive);
                        vObtenerArchivo.Delete();
                        vObtenerArchivo.Save();
                        vObtenerArchivo.Unlock();
                        vObtenerArchivo.Dispose();
                        vSession.LogOut();
                        return true;
                    }
                }
                //EntryInfo vObtenerArchivo = Entry.GetEntryInfo(vIdArchivo, vSession);
                //if (vObtenerArchivo != null)
                //{
                //    vObtenerArchivo.Lock(LockType.Exclusive);
                //    vObtenerArchivo.Delete();
                //    vObtenerArchivo.Save();
                //    vObtenerArchivo.Unlock();
                //    vObtenerArchivo.Dispose();
                //    vSession.LogOut();
                //    return true;
                //}
            }
            return false;
        }

        public static bool MoverArchivo(int IdArchivo, string Servidor, string Repositorio, string Usuario, string Clave, string Carpeta, string newSubCarpeta, string nombreArchivo)
        {
            Session session = new Session();
            session.LogIn(Usuario, Clave, new RepositoryRegistration(Servidor, Repositorio));
            EntryInfo myEntry = Entry.GetEntryInfo(IdArchivo, session);
            myEntry.Lock(LockType.Exclusive);

            bool valor = true;
            try
            {
                valor = Folder.GetFolderInfo("\\" + Carpeta + "\\" + newSubCarpeta, session).IsNew;
            }
            catch (Exception err)
            {
                Console.WriteLine("ERROR: Al mover el archivo escaneado... " + err.ToString());
            }
            if (valor)
            {
                FolderInfo carpetaContent = Folder.GetFolderInfo("\\" + Carpeta, session);
                FolderInfo carpetaExpediente = new FolderInfo(session);
                valor = carpetaExpediente.IsNew;
                carpetaExpediente.Create(carpetaContent, newSubCarpeta, EntryNameOption.None);
                carpetaExpediente.Unlock();
                carpetaExpediente.Refresh(true);
            }

            try
            {
                string nameArch = "";
                nameArch = "\\" + Carpeta + "\\" + newSubCarpeta + "\\" + nombreArchivo;
                myEntry.MoveTo(nameArch, EntryNameOption.AutoRename);
                myEntry.Save();
                myEntry.Unlock();
                myEntry.Dispose();

            }
            catch (Exception err)
            {
                Console.WriteLine("ERROR: Al mover el archivo escaneado... " + err.ToString());
            }


            session.LogOut();
            return true;
        }

    }
}
