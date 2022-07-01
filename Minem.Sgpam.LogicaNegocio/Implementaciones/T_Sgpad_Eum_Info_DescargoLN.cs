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
    public class T_Sgpad_Eum_Info_DescargoLN : BaseLN, IT_Sgpad_Eum_Info_DescargoLN
    {
        private readonly IT_Sgpad_Eum_Info_DescargoAD Eum_Info_DescargoAD;

        public T_Sgpad_Eum_Info_DescargoLN(IT_Sgpad_Eum_Info_DescargoAD vT_Sgpad_Eum_Info_DescargoAD)
        {
            Eum_Info_DescargoAD = vT_Sgpad_Eum_Info_DescargoAD;
        }

        public IEnumerable<Eum_Info_DescargoDTO> ListarEum_Info_DescargoDTO()
        {
            try
            {
                var vResultado = Eum_Info_DescargoAD.ListarT_Sgpad_Eum_Info_Descargo();
                return new List<Eum_Info_DescargoDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Eum_Info_DescargoDTO RecuperarEum_Info_DescargoDTOPorCodigo(int vId_Eum_Info_Descargo)
        {
            try
            {
                var vResultado = Eum_Info_DescargoAD.RecuperarT_Sgpad_Eum_Info_DescargoPorCodigo(vId_Eum_Info_Descargo);
                return new Eum_Info_DescargoDTO();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Eum_Info_DescargoDTO GrabarEum_Info_DescargoDTO(Eum_Info_DescargoDTO vEum_Info_DescargoDTO)
        {
            try
            {
                if (vEum_Info_DescargoDTO != null)
                {
                    var vRegistro = new T_Sgpad_Eum_Info_Descargo
                    {
                        ID_EUM_INFO_DESCARGO = vEum_Info_DescargoDTO.Id_Eum_Info_Descargo,
                        ID_EUM = vEum_Info_DescargoDTO.Id_Eum,
                        FECHA_DESCARGO = vEum_Info_DescargoDTO.Fecha_Descargo,
                        TITULAR = vEum_Info_DescargoDTO.Titular,
                        DECLARACION = vEum_Info_DescargoDTO.Declaracion,
                        ASUNTO = vEum_Info_DescargoDTO.Asunto,
                        NOMBRE_DOCUMENTO = vEum_Info_DescargoDTO.Nombre_Documento,
                        RUTA_DOCUMENTO = vEum_Info_DescargoDTO.Ruta_Documento,
                        EXTENCION = vEum_Info_DescargoDTO.Extencion,
                        TAMANO = vEum_Info_DescargoDTO.Tamano,
                        ID_LASERFICHE = vEum_Info_DescargoDTO.Id_LaserFiche,
                        USU_INGRESO = vEum_Info_DescargoDTO.Usu_Ingreso,
                        FEC_INGRESO = vEum_Info_DescargoDTO.Fec_Ingreso,
                        IP_INGRESO = vEum_Info_DescargoDTO.Ip_Ingreso,
                        USU_MODIFICA = vEum_Info_DescargoDTO.Usu_Modifica,
                        FEC_MODIFICA = vEum_Info_DescargoDTO.Fec_Modifica,
                        IP_MODIFICA = vEum_Info_DescargoDTO.Ip_Modifica,
                        FLG_ESTADO = vEum_Info_DescargoDTO.Flg_Estado
                    };
                    if (vEum_Info_DescargoDTO.Id_Eum_Info_Descargo == 0)
                    {
                        var vResultado = Eum_Info_DescargoAD.InsertarT_Sgpad_Eum_Info_Descargo(vRegistro);
                        vEum_Info_DescargoDTO.Id_Eum_Info_Descargo = vResultado.ID_EUM_INFO_DESCARGO;
                    }
                    else
                    {
                        var vResultado = Eum_Info_DescargoAD.ActualizarT_Sgpad_Eum_Info_Descargo(vRegistro);
                        vEum_Info_DescargoDTO = RecuperarEum_Info_DescargoDTOPorCodigo(vResultado.ID_EUM_INFO_DESCARGO);
                    }
                }
                return vEum_Info_DescargoDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public bool AnularEum_Info_DescargoDTOPorCodigo(Eum_Info_DescargoDTO vEum_Info_DescargoDTO)
        {
            bool vResult = false;
            try
            {
                if (vEum_Info_DescargoDTO != null)
                {
                    var vRegistro = new T_Sgpad_Eum_Info_Descargo
                    {
                        FEC_MODIFICA = vEum_Info_DescargoDTO.Fec_Modifica,
                        ID_EUM_INFO_DESCARGO = vEum_Info_DescargoDTO.Id_Eum_Info_Descargo,
                        IP_MODIFICA = vEum_Info_DescargoDTO.Ip_Modifica,
                        USU_MODIFICA = vEum_Info_DescargoDTO.Usu_Modifica
                    };
                    vResult = Eum_Info_DescargoAD.AnularT_Sgpad_Eum_Info_DescargoPorCodigo(vRegistro) != 0;
                }
                return vResult;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<Eum_Info_DescargoDTO> ListarPaginadoEum_Info_DescargoDTO(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            try
            {
                var vResultado = Eum_Info_DescargoAD.ListarPaginadoT_Sgpad_Eum_Info_Descargo(vFiltro, vNumPag, vCantRegxPag);
                return new List<Eum_Info_DescargoDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<Eum_Info_DescargoDTO> ListarPorIdEumEum_Info_DescargoDTO(int vId_Eum)
        {
            try
            {
                var vResultado = (from vTmp in Eum_Info_DescargoAD.ListarPorIdEumT_Sgpad_Eum_Info_Descargo(vId_Eum)
                                  select new Eum_Info_DescargoDTO
                                  {
                                      Id_Eum_Info_Descargo = vTmp.ID_EUM_INFO_DESCARGO,
                                      Id_Eum = vTmp.ID_EUM,
                                      Titular = vTmp.TITULAR,
                                      Declaracion = vTmp.DECLARACION,
                                      Asunto = vTmp.ASUNTO,
                                      Fecha_Descargo = vTmp.FECHA_DESCARGO,
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
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

    }
}
