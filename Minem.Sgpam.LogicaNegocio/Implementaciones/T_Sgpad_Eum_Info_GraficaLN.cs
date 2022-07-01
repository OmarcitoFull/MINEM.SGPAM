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
    public class T_Sgpad_Eum_Info_GraficaLN : BaseLN, IT_Sgpad_Eum_Info_GraficaLN
    {
        private readonly IT_Sgpad_Eum_Info_GraficaAD Eum_Info_GraficaAD;

        public T_Sgpad_Eum_Info_GraficaLN(IT_Sgpad_Eum_Info_GraficaAD vT_Sgpad_Eum_Info_GraficaAD)
        {
            Eum_Info_GraficaAD = vT_Sgpad_Eum_Info_GraficaAD;
        }

        public IEnumerable<Eum_Info_GraficaDTO> ListarEum_Info_GraficaDTO()
        {
            try
            {
                var vResultado = Eum_Info_GraficaAD.ListarT_Sgpad_Eum_Info_Grafica();
                return new List<Eum_Info_GraficaDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Eum_Info_GraficaDTO RecuperarEum_Info_GraficaDTOPorCodigo(int vId_Eum_Info_Grafica)
        {
            try
            {
                var vResultado = Eum_Info_GraficaAD.RecuperarT_Sgpad_Eum_Info_GraficaPorCodigo(vId_Eum_Info_Grafica);
                return new Eum_Info_GraficaDTO();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Eum_Info_GraficaDTO GrabarEum_Info_GraficaDTO(Eum_Info_GraficaDTO vEum_Info_GraficaDTO)
        {
            try
            {
                if (vEum_Info_GraficaDTO != null)
                {
                    var vRegistro = new T_Sgpad_Eum_Info_Grafica
                    {
                        ID_EUM_INFO_GRAFICA = vEum_Info_GraficaDTO.Id_Eum_Info_Grafica,
                        ID_EUM = vEum_Info_GraficaDTO.Id_Eum,
                        FECHA_TOMA = vEum_Info_GraficaDTO.Fecha_Toma,
                        DESCRIPCION = vEum_Info_GraficaDTO.Descripcion,
                        NOMBRE_IMAGEN = vEum_Info_GraficaDTO.Nombre_Imagen,
                        RUTA_IMAGEN = vEum_Info_GraficaDTO.Ruta_Imagen,
                        EXTENCION = vEum_Info_GraficaDTO.Extencion,
                        TAMANO = vEum_Info_GraficaDTO.Tamano,
                        ID_LASERFICHE = vEum_Info_GraficaDTO.Id_LaserFiche,
                        USU_INGRESO = vEum_Info_GraficaDTO.Usu_Ingreso,
                        FEC_INGRESO = vEum_Info_GraficaDTO.Fec_Ingreso,
                        IP_INGRESO = vEum_Info_GraficaDTO.Ip_Ingreso,
                        USU_MODIFICA = vEum_Info_GraficaDTO.Usu_Modifica,
                        IP_MODIFICA = vEum_Info_GraficaDTO.Ip_Modifica,
                        FEC_MODIFICA = vEum_Info_GraficaDTO.Fec_Modifica,
                        FLG_ESTADO = vEum_Info_GraficaDTO.Flg_Estado
                    };
                    if (vEum_Info_GraficaDTO.Id_Eum_Info_Grafica == 0)
                    {
                        var vResultado = Eum_Info_GraficaAD.InsertarT_Sgpad_Eum_Info_Grafica(vRegistro);
                        vEum_Info_GraficaDTO.Id_Eum_Info_Grafica = vResultado.ID_EUM_INFO_GRAFICA;
                    }
                    else
                    {
                        var vResultado = Eum_Info_GraficaAD.ActualizarT_Sgpad_Eum_Info_Grafica(vRegistro);
                        vEum_Info_GraficaDTO = RecuperarEum_Info_GraficaDTOPorCodigo(vResultado.ID_EUM_INFO_GRAFICA);
                    }
                }
                return vEum_Info_GraficaDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public bool AnularEum_Info_GraficaDTOPorCodigo(Eum_Info_GraficaDTO vEum_Info_GraficaDTO)
        {
            bool vResult = false;
            try
            {
                if (vEum_Info_GraficaDTO != null)
                {
                    var vRegistro = new T_Sgpad_Eum_Info_Grafica
                    {
                        ID_EUM_INFO_GRAFICA = vEum_Info_GraficaDTO.Id_Eum_Info_Grafica,
                        USU_MODIFICA = vEum_Info_GraficaDTO.Usu_Modifica,
                        FEC_MODIFICA = vEum_Info_GraficaDTO.Fec_Modifica,
                        IP_MODIFICA = vEum_Info_GraficaDTO.Ip_Modifica,
                    };
                    vResult = Eum_Info_GraficaAD.AnularT_Sgpad_Eum_Info_GraficaPorCodigo(vRegistro) != 0;
                }
                return vResult;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<Eum_Info_GraficaDTO> ListarPaginadoEum_Info_GraficaDTO(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            try
            {
                var vResultado = Eum_Info_GraficaAD.ListarPaginadoT_Sgpad_Eum_Info_Grafica(vFiltro, vNumPag, vCantRegxPag);
                return new List<Eum_Info_GraficaDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<Eum_Info_GraficaDTO> ListarPorIdEumEum_Info_GraficaDTO(int vId_Eum)
        {
            try
            {
                var vResultado = (from vTmp in Eum_Info_GraficaAD.ListarPorIdEumT_Sgpad_Eum_Info_Grafica(vId_Eum)
                                  select new Eum_Info_GraficaDTO
                                  {
                                      Id_Eum_Info_Grafica = vTmp.ID_EUM_INFO_GRAFICA,
                                      Id_Eum = vTmp.ID_EUM,
                                      Descripcion = vTmp.DESCRIPCION,


                                      Fecha_Toma = vTmp.FECHA_TOMA,
                                      Nombre_Imagen = vTmp.NOMBRE_IMAGEN,
                                      Ruta_Imagen = vTmp.RUTA_IMAGEN,
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
