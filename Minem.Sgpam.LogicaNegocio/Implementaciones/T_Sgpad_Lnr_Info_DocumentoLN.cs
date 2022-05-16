using System;
using System.Collections.Generic;
using Minem.Sgpam.AccesoDatos.Interfaces;
using Minem.Sgpam.Entidades;
using Minem.Sgpam.LogicaNegocio.Base;
using Minem.Sgpam.LogicaNegocio.Interfaces;
using Minem.Sgpam.TransporteDatos.DtoEntidades;

namespace Minem.Sgpam.LogicaNegocio.Implementaciones
{
    /// <summary>
    /// Objetivo:	Clase que implementa la lógica del negocio para las operaciones de las entidades
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	29/10/2021
    /// </summary>
    public class T_Sgpad_Lnr_Info_DocumentoLN : BaseLN, IT_Sgpad_Lnr_Info_DocumentoLN
    {
        private readonly IT_Sgpad_Lnr_Info_DocumentoAD Lnr_Info_DocumentoAD;

        public T_Sgpad_Lnr_Info_DocumentoLN(IT_Sgpad_Lnr_Info_DocumentoAD vT_Sgpad_Lnr_Info_DocumentoAD)
        {
            Lnr_Info_DocumentoAD = vT_Sgpad_Lnr_Info_DocumentoAD;
        }

        public IEnumerable<Lnr_Info_DocumentoDTO> ListarLnr_Info_DocumentoDTO()
        {
            try
            {
                var vResultado = Lnr_Info_DocumentoAD.ListarT_Sgpad_Lnr_Info_Documento();
                return new List<Lnr_Info_DocumentoDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Lnr_Info_DocumentoDTO RecuperarLnr_Info_DocumentoDTOPorCodigo(int vId_Lnr_Info_Documento)
        {
            try
            {
                var vResultado = Lnr_Info_DocumentoAD.RecuperarT_Sgpad_Lnr_Info_DocumentoPorCodigo(vId_Lnr_Info_Documento);
                return new Lnr_Info_DocumentoDTO();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Lnr_Info_DocumentoDTO InsertarLnr_Info_DocumentoDTO(Lnr_Info_DocumentoDTO vLnr_Info_DocumentoDTO)
        {
            try
            {
                var vRegistro = new T_Sgpad_Lnr_Info_Documento();
                var vResultado = Lnr_Info_DocumentoAD.InsertarT_Sgpad_Lnr_Info_Documento(vRegistro);
                return vLnr_Info_DocumentoDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Lnr_Info_DocumentoDTO ActualizarLnr_Info_DocumentoDTO(Lnr_Info_DocumentoDTO vLnr_Info_DocumentoDTO)
        {
            try
            {
                var vRegistro = new T_Sgpad_Lnr_Info_Documento();
                var vResultado = Lnr_Info_DocumentoAD.ActualizarT_Sgpad_Lnr_Info_Documento(vRegistro);
                return vLnr_Info_DocumentoDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
        
        public int AnularLnr_Info_DocumentoDTOPorCodigo(Lnr_Info_DocumentoDTO vLnr_Info_DocumentoDTO)
        {
            try
            {
                return Lnr_Info_DocumentoAD.AnularT_Sgpad_Lnr_Info_DocumentoPorCodigo(0);
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<Lnr_Info_DocumentoDTO> ListarPaginadoLnr_Info_DocumentoDTO(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            try
            {
                var vResultado = Lnr_Info_DocumentoAD.ListarPaginadoT_Sgpad_Lnr_Info_Documento(vFiltro, vNumPag, vCantRegxPag);
                return new List<Lnr_Info_DocumentoDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<Lnr_Info_DocumentoDTO> ListarPorIdLnrLnr_Info_DocumentoDTO(int vId_Lnr)
        {
            try
            {
                IEnumerable<T_Sgpad_Lnr_Info_Documento> vResultado = Lnr_Info_DocumentoAD.ListarPorIdLnrT_Sgpad_Lnr_Info_Documento(vId_Lnr);
                if (vResultado != null)
                {
                    List<Lnr_Info_DocumentoDTO> vLista = new List<Lnr_Info_DocumentoDTO>();
                    Lnr_Info_DocumentoDTO vEntidad;
                    foreach (T_Sgpad_Lnr_Info_Documento item in vResultado)
                    {
                        vEntidad = new Lnr_Info_DocumentoDTO()
                        {
                            Fec_Ingreso = item.FEC_INGRESO,
                            Flg_Estado = item.FLG_ESTADO,
                            Id_Lnr = item.ID_LNR,
                            Id_Lnr_Info_Documento = item.ID_LNR_INFO_DOCUMENTO,
                            Ip_Ingreso = item.IP_INGRESO,
                            Usu_Ingreso = item.USU_INGRESO,
                            //Asunto = item.ASUNTO,
                            //Declaracion = item.DECLARACION,
                            Extencion = item.EXTENCION,
                            //Fecha_Descargo = item.FECHA_DESCARGO,
                            Nombre_Documento = item.NOMBRE_DOCUMENTO,
                            Ruta_Documento = item.RUTA_DOCUMENTO,
                            Tamano = item.TAMANO//,
                            //Titular = item.TITULAR
                        };
                        vLista.Add(vEntidad);
                    }
                    return vLista;
                }
                return null;
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }
    }
}
