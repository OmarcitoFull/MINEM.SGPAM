using System;
using System.Linq;
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

        public Lnr_Info_DocumentoDTO GrabarLnr_Info_DocumentoDTO(Lnr_Info_DocumentoDTO vLnr_Info_DocumentoDTO)
        {
            try
            {
                if (vLnr_Info_DocumentoDTO != null)
                {
                    var vRegistro = new T_Sgpad_Lnr_Info_Documento
                    {
                        ID_LNR_INFO_DOCUMENTO = vLnr_Info_DocumentoDTO.Id_Lnr_Info_Documento,
                        ID_LNR = vLnr_Info_DocumentoDTO.Id_Lnr,
                        FECHA_DOCUMENTO = vLnr_Info_DocumentoDTO.Fecha_Documento,
                        NOMBRE_INFORME = vLnr_Info_DocumentoDTO.Nombre_Informe,
                        DESCRIPCION = vLnr_Info_DocumentoDTO.Descripcion,
                        NOMBRE_DOCUMENTO = vLnr_Info_DocumentoDTO.Nombre_Documento,
                        RUTA_DOCUMENTO = vLnr_Info_DocumentoDTO.Ruta_Documento,
                        EXTENCION = vLnr_Info_DocumentoDTO.Extencion,
                        TAMANO = vLnr_Info_DocumentoDTO.Tamano,
                        ID_LASERFICHE = vLnr_Info_DocumentoDTO.Id_LaserFiche,
                        USU_INGRESO = vLnr_Info_DocumentoDTO.Usu_Ingreso,
                        FEC_INGRESO = vLnr_Info_DocumentoDTO.Fec_Ingreso,
                        IP_INGRESO = vLnr_Info_DocumentoDTO.Ip_Ingreso,
                        USU_MODIFICA = vLnr_Info_DocumentoDTO.Usu_Modifica,
                        FEC_MODIFICA = vLnr_Info_DocumentoDTO.Fec_Modifica,
                        IP_MODIFICA = vLnr_Info_DocumentoDTO.Ip_Modifica,
                        FLG_ESTADO = vLnr_Info_DocumentoDTO.Flg_Estado
                    };
                    if (vLnr_Info_DocumentoDTO.Id_Lnr_Info_Documento == 0)
                    {
                        var vResultado = Lnr_Info_DocumentoAD.InsertarT_Sgpad_Lnr_Info_Documento(vRegistro);
                        vLnr_Info_DocumentoDTO.Id_Lnr_Info_Documento = vResultado.ID_LNR_INFO_DOCUMENTO;
                    }
                    else
                    {
                        var vResultado = Lnr_Info_DocumentoAD.ActualizarT_Sgpad_Lnr_Info_Documento(vRegistro);
                        vLnr_Info_DocumentoDTO = RecuperarLnr_Info_DocumentoDTOPorCodigo(vResultado.ID_LNR_INFO_DOCUMENTO);
                    }
                }
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
                var vResultado = (from vTmp in Lnr_Info_DocumentoAD.ListarPorIdLnrT_Sgpad_Lnr_Info_Documento(vId_Lnr)
                                  select new Lnr_Info_DocumentoDTO
                                  {
                                      Id_Lnr_Info_Documento = vTmp.ID_LNR_INFO_DOCUMENTO,
                                      Id_Lnr = vTmp.ID_LNR,
                                      Fecha_Documento = vTmp.FECHA_DOCUMENTO,
                                      Nombre_Informe = vTmp.NOMBRE_INFORME,
                                      Descripcion = vTmp.DESCRIPCION,
                                      Nombre_Documento = vTmp.NOMBRE_DOCUMENTO,
                                      Ruta_Documento = vTmp.RUTA_DOCUMENTO,
                                      Extencion = vTmp.EXTENCION,
                                      Tamano = vTmp.TAMANO,
                                      Id_LaserFiche = vTmp.ID_LASERFICHE,
                                      Usu_Ingreso = vTmp.USU_INGRESO,
                                      Fec_Ingreso = vTmp.FEC_INGRESO,
                                      Ip_Ingreso = vTmp.IP_INGRESO,
                                      Usu_Modifica = vTmp.USU_MODIFICA,
                                      Fec_Modifica = vTmp.FEC_MODIFICA,
                                      Ip_Modifica = vTmp.IP_MODIFICA,
                                      Flg_Estado = vTmp.FLG_ESTADO
                                  }).ToList();
                return vResultado;
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }
    }
}
