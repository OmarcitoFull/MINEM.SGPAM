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
    public class T_Sgpad_Eum_InformeLN : BaseLN, IT_Sgpad_Eum_InformeLN
    {
        private readonly IT_Sgpad_Eum_InformeAD Eum_InformeAD;

        public T_Sgpad_Eum_InformeLN(IT_Sgpad_Eum_InformeAD vT_Sgpad_Eum_InformeAD)
        {
            Eum_InformeAD = vT_Sgpad_Eum_InformeAD;
        }

        public IEnumerable<Eum_InformeDTO> ListarEum_InformeDTO()
        {
            try
            {
                var vResultado = Eum_InformeAD.ListarT_Sgpad_Eum_Informe();
                return new List<Eum_InformeDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Eum_InformeDTO RecuperarEum_InformeDTOPorCodigo(int vId_Eum_Informe)
        {
            try
            {
                var vResultado = Eum_InformeAD.RecuperarT_Sgpad_Eum_InformePorCodigo(vId_Eum_Informe);
                return new Eum_InformeDTO();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Eum_InformeDTO GrabarEum_InformeDTO(Eum_InformeDTO vEum_InformeDTO)
        {
            try
            {
                if (vEum_InformeDTO != null)
                {
                    var vRegistro = new T_Sgpad_Eum_Informe
                    {
                        ID_EUM_INFORME = vEum_InformeDTO.Id_Eum_Informe,
                        ID_EUM = vEum_InformeDTO.Id_Eum,
                        NRO_EXPEDIENTE = vEum_InformeDTO.Nro_Expediente,
                        NRO_INFORME = vEum_InformeDTO.Nro_Informe,
                        FECHA_INFORME = vEum_InformeDTO.Fecha_Informe,
                        DESCRIPCION = vEum_InformeDTO.Descripcion,
                        NOMBRE_INFORME = vEum_InformeDTO.Nombre_Informe,
                        RUTA_INFORME = vEum_InformeDTO.Ruta_Informe,
                        EXTENCION = vEum_InformeDTO.Extencion,
                        TAMANO = vEum_InformeDTO.Tamano,
                        ID_LASERFICHE = vEum_InformeDTO.Id_LaserFiche,
                        USU_INGRESO = vEum_InformeDTO.Usu_Ingreso,
                        FEC_INGRESO = vEum_InformeDTO.Fec_Ingreso,
                        IP_INGRESO = vEum_InformeDTO.Ip_Ingreso,
                        USU_MODIFICA = vEum_InformeDTO.Usu_Modifica,
                        FEC_MODIFICA = vEum_InformeDTO.Fec_Modifica,
                        IP_MODIFICA = vEum_InformeDTO.Ip_Modifica,
                        FLG_ESTADO = vEum_InformeDTO.Flg_Estado
                    };
                    if (vEum_InformeDTO.Id_Eum_Informe == 0)
                    {
                        var vResultado = Eum_InformeAD.InsertarT_Sgpad_Eum_Informe(vRegistro);
                        vEum_InformeDTO.Id_Eum_Informe = vResultado.ID_EUM_INFORME;
                    }
                    else
                    {
                        var vResultado = Eum_InformeAD.ActualizarT_Sgpad_Eum_Informe(vRegistro);
                        vEum_InformeDTO = RecuperarEum_InformeDTOPorCodigo(vResultado.ID_EUM_INFORME);
                    }
                }
                return vEum_InformeDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
        
        public bool AnularEum_InformeDTOPorCodigo(Eum_InformeDTO vEum_InformeDTO)
        {
            bool vResult = false;
            try
            {
                if (vEum_InformeDTO != null)
                {
                    var vRegistro = new T_Sgpad_Eum_Informe
                    {
                        FEC_MODIFICA = vEum_InformeDTO.Fec_Modifica,
                        ID_EUM_INFORME = vEum_InformeDTO.Id_Eum_Informe,
                        IP_MODIFICA = vEum_InformeDTO.Ip_Modifica,
                        USU_MODIFICA = vEum_InformeDTO.Usu_Modifica
                    };
                    vResult = Eum_InformeAD.AnularT_Sgpad_Eum_InformePorCodigo(vRegistro) != 0;
                }
                return vResult;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<Eum_InformeDTO> ListarPaginadoEum_InformeDTO(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            try
            {
                var vResultado = Eum_InformeAD.ListarPaginadoT_Sgpad_Eum_Informe(vFiltro, vNumPag, vCantRegxPag);
                return new List<Eum_InformeDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<Eum_InformeDTO> ListarPorIdEumEum_InformeDTO(int vId_Eum)
        {
            try
            {
                var vResultado = (from vTmp in Eum_InformeAD.ListarPorIdEumT_Sgpad_Eum_Informe(vId_Eum)
                                  select new Eum_InformeDTO
                                  {
                                      Id_Eum_Informe = vTmp.ID_EUM_INFORME,
                                      Id_Eum = vTmp.ID_EUM,
                                      Descripcion = vTmp.DESCRIPCION,
                                      Nro_Expediente = vTmp.NRO_EXPEDIENTE,
                                      Nro_Informe = vTmp.NRO_INFORME,
                                      Fecha_Informe = vTmp.FECHA_INFORME,
                                      Nombre_Informe = vTmp.NOMBRE_INFORME,
                                      Ruta_Informe = vTmp.RUTA_INFORME,
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
