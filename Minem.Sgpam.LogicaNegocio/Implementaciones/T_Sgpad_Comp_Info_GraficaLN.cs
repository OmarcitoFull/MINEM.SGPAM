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
    public class T_Sgpad_Comp_Info_GraficaLN : BaseLN, IT_Sgpad_Comp_Info_GraficaLN
    {
        private readonly IT_Sgpad_Comp_Info_GraficaAD Comp_Info_GraficaAD;

        public T_Sgpad_Comp_Info_GraficaLN(IT_Sgpad_Comp_Info_GraficaAD vT_Sgpad_Comp_Info_GraficaAD)
        {
            Comp_Info_GraficaAD = vT_Sgpad_Comp_Info_GraficaAD;
        }

        public IEnumerable<Comp_Info_GraficaDTO> ListarComp_Info_GraficaDTO(int vIdComponente)
        {
            try
            {
                var vResultado = (from vTmp in Comp_Info_GraficaAD.ListarT_Sgpad_Comp_Info_Grafica(vIdComponente)
                                  select new Comp_Info_GraficaDTO
                                  {
                                      Id_Componente = vTmp.ID_COMPONENTE,
                                      Fec_Ingreso = vTmp.FEC_INGRESO,
                                      Flg_Estado = vTmp.FLG_ESTADO,
                                      Ip_Ingreso = vTmp.IP_INGRESO,
                                      Usu_Ingreso = vTmp.USU_INGRESO,
                                      Fec_Modifica = vTmp.FEC_MODIFICA,
                                      Ip_Modifica = vTmp.IP_MODIFICA,
                                      Usu_Modifica = vTmp.USU_MODIFICA,
                                      Extencion = vTmp.EXTENCION,
                                      Id_Comp_Info_Grafica = vTmp.ID_COMP_INFO_GRAFICA,
                                      Nombre_Imagen = vTmp.NOMBRE_IMAGEN,
                                      Ruta_Imagen = vTmp.RUTA_IMAGEN,
                                      Tamano = vTmp.TAMANO,
                                      Fecha = vTmp.FECHA,
                                      Id_LaserFiche = vTmp.ID_LASERFICHE
                                  }).ToList();
                return vResultado;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Comp_Info_GraficaDTO RecuperarComp_Info_GraficaDTOPorCodigo(int vId_Comp_Info_Grafica)
        {
            try
            {
                var vResultado = Comp_Info_GraficaAD.RecuperarT_Sgpad_Comp_Info_GraficaPorCodigo(vId_Comp_Info_Grafica);
                return new Comp_Info_GraficaDTO();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Comp_Info_GraficaDTO GrabarComp_Info_GraficaDTO(Comp_Info_GraficaDTO vComp_Info_GraficaDTO)
        {
            try
            {
                if (vComp_Info_GraficaDTO != null)
                {
                    var vRegistro = new T_Sgpad_Comp_Info_Grafica
                    {
                        FEC_INGRESO = vComp_Info_GraficaDTO.Fec_Ingreso,
                        FEC_MODIFICA = vComp_Info_GraficaDTO.Fec_Modifica,
                        FLG_ESTADO = vComp_Info_GraficaDTO.Flg_Estado,
                        IP_INGRESO = vComp_Info_GraficaDTO.Ip_Ingreso,
                        IP_MODIFICA = vComp_Info_GraficaDTO.Ip_Modifica,
                        USU_INGRESO = vComp_Info_GraficaDTO.Usu_Ingreso,
                        USU_MODIFICA = vComp_Info_GraficaDTO.Usu_Modifica,
                        ID_COMPONENTE = vComp_Info_GraficaDTO.Id_Componente,
                        EXTENCION = vComp_Info_GraficaDTO.Extencion,
                        ID_COMP_INFO_GRAFICA = vComp_Info_GraficaDTO.Id_Comp_Info_Grafica,
                        NOMBRE_IMAGEN = vComp_Info_GraficaDTO.Nombre_Imagen,
                        RUTA_IMAGEN = vComp_Info_GraficaDTO.Ruta_Imagen,
                        TAMANO = vComp_Info_GraficaDTO.Tamano,
                        FECHA = vComp_Info_GraficaDTO.Fecha,
                        ID_LASERFICHE = vComp_Info_GraficaDTO.Id_LaserFiche
                    };
                    if (vComp_Info_GraficaDTO.Id_Comp_Info_Grafica == 0)
                    {
                        var vResultado = Comp_Info_GraficaAD.InsertarT_Sgpad_Comp_Info_Grafica(vRegistro);
                        vComp_Info_GraficaDTO.Id_Comp_Info_Grafica = vResultado.ID_COMP_INFO_GRAFICA;
                    }
                    else
                    {
                        var vResultado = Comp_Info_GraficaAD.ActualizarT_Sgpad_Comp_Info_Grafica(vRegistro);
                        vComp_Info_GraficaDTO = RecuperarComp_Info_GraficaDTOPorCodigo(vResultado.ID_COMP_INFO_GRAFICA);
                    }
                }
                return vComp_Info_GraficaDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public int AnularComp_Info_GraficaDTOPorCodigo(Comp_Info_GraficaDTO vComp_Info_GraficaDTO)
        {
            try
            {
                return Comp_Info_GraficaAD.AnularT_Sgpad_Comp_Info_GraficaPorCodigo(0);
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<Comp_Info_GraficaDTO> ListarPaginadoComp_Info_GraficaDTO(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            try
            {
                var vResultado = Comp_Info_GraficaAD.ListarPaginadoT_Sgpad_Comp_Info_Grafica(vFiltro, vNumPag, vCantRegxPag);
                return new List<Comp_Info_GraficaDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
    }
}
