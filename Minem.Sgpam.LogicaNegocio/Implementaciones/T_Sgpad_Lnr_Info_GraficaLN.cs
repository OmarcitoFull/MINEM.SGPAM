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
    public class T_Sgpad_Lnr_Info_GraficaLN : BaseLN, IT_Sgpad_Lnr_Info_GraficaLN
    {
        private readonly IT_Sgpad_Lnr_Info_GraficaAD Lnr_Info_GraficaAD;

        public T_Sgpad_Lnr_Info_GraficaLN(IT_Sgpad_Lnr_Info_GraficaAD vT_Sgpad_Lnr_Info_GraficaAD)
        {
            Lnr_Info_GraficaAD = vT_Sgpad_Lnr_Info_GraficaAD;
        }

        public IEnumerable<Lnr_Info_GraficaDTO> ListarLnr_Info_GraficaDTO()
        {
            try
            {
                var vResultado = Lnr_Info_GraficaAD.ListarT_Sgpad_Lnr_Info_Grafica();
                return new List<Lnr_Info_GraficaDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Lnr_Info_GraficaDTO RecuperarLnr_Info_GraficaDTOPorCodigo(int vId_Lnr_Info_Grafica)
        {
            try
            {
                var vResultado = Lnr_Info_GraficaAD.RecuperarT_Sgpad_Lnr_Info_GraficaPorCodigo(vId_Lnr_Info_Grafica);
                return new Lnr_Info_GraficaDTO();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Lnr_Info_GraficaDTO GrabarLnr_Info_GraficaDTO(Lnr_Info_GraficaDTO vLnr_Info_GraficaDTO)
        {
            try
            {
                if (vLnr_Info_GraficaDTO != null)
                {
                    var vRegistro = new T_Sgpad_Lnr_Info_Grafica
                    {
                        ID_LNR_INFO_GRAFICA = vLnr_Info_GraficaDTO.Id_Lnr_Info_Grafica,
                        ID_LNR = vLnr_Info_GraficaDTO.Id_Lnr,
                        FECHA_TOMA = vLnr_Info_GraficaDTO.Fecha_Toma,
                        DESCRIPCION = vLnr_Info_GraficaDTO.Descripcion,
                        NOMBRE_IMAGEN = vLnr_Info_GraficaDTO.Nombre_Imagen,
                        RUTA_IMAGEN = vLnr_Info_GraficaDTO.Ruta_Imagen,
                        EXTENCION = vLnr_Info_GraficaDTO.Extencion,
                        TAMANO = vLnr_Info_GraficaDTO.Tamano,
                        ID_LASERFICHE = vLnr_Info_GraficaDTO.Id_LaserFiche,
                        USU_INGRESO = vLnr_Info_GraficaDTO.Usu_Ingreso,
                        FEC_INGRESO = vLnr_Info_GraficaDTO.Fec_Ingreso,
                        IP_INGRESO = vLnr_Info_GraficaDTO.Ip_Ingreso,
                        USU_MODIFICA = vLnr_Info_GraficaDTO.Usu_Modifica,
                        FEC_MODIFICA = vLnr_Info_GraficaDTO.Fec_Modifica,
                        IP_MODIFICA = vLnr_Info_GraficaDTO.Ip_Modifica,
                        FLG_ESTADO = vLnr_Info_GraficaDTO.Flg_Estado
                    };
                    if (vLnr_Info_GraficaDTO.Id_Lnr_Info_Grafica == 0)
                    {
                        var vResultado = Lnr_Info_GraficaAD.InsertarT_Sgpad_Lnr_Info_Grafica(vRegistro);
                        vLnr_Info_GraficaDTO.Id_Lnr_Info_Grafica = vResultado.ID_LNR_INFO_GRAFICA;
                    }
                    else
                    {
                        var vResultado = Lnr_Info_GraficaAD.ActualizarT_Sgpad_Lnr_Info_Grafica(vRegistro);
                        vLnr_Info_GraficaDTO = RecuperarLnr_Info_GraficaDTOPorCodigo(vResultado.ID_LNR_INFO_GRAFICA);
                    }
                }
                return vLnr_Info_GraficaDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public int AnularLnr_Info_GraficaDTOPorCodigo(Lnr_Info_GraficaDTO vLnr_Info_GraficaDTO)
        {
            try
            {
                return Lnr_Info_GraficaAD.AnularT_Sgpad_Lnr_Info_GraficaPorCodigo(0);
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<Lnr_Info_GraficaDTO> ListarPaginadoLnr_Info_GraficaDTO(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            try
            {
                var vResultado = Lnr_Info_GraficaAD.ListarPaginadoT_Sgpad_Lnr_Info_Grafica(vFiltro, vNumPag, vCantRegxPag);
                return new List<Lnr_Info_GraficaDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<Lnr_Info_GraficaDTO> ListarPorIdLnrLnr_Info_GraficaDTO(int vId_Lnr)
        {
            try
            {
                var vResultado = (from vTmp in Lnr_Info_GraficaAD.ListarPorIdLnrT_Sgpad_Lnr_Info_Grafica(vId_Lnr)
                                  select new Lnr_Info_GraficaDTO
                                  {
                                      Id_Lnr_Info_Grafica = vTmp.ID_LNR_INFO_GRAFICA,
                                      Id_Lnr = vTmp.ID_LNR,
                                      Fecha_Toma = vTmp.FECHA_TOMA,
                                      Descripcion = vTmp.DESCRIPCION,
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
