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

        //public Eum_Info_GraficaDTO InsertarEum_Info_GraficaDTO(Eum_Info_GraficaDTO vEum_Info_GraficaDTO)
        //{
        //    try
        //    {
        //        var vRegistro = new T_Sgpad_Eum_Info_Grafica();
        //        var vResultado = Eum_Info_GraficaAD.InsertarT_Sgpad_Eum_Info_Grafica(vRegistro);
        //        return vEum_Info_GraficaDTO;
        //    }
        //    catch (Exception ex)
        //    {
        //        //Log.Error(ex.Message, ex);
        //        throw;
        //    }
        //}

        //public Eum_Info_GraficaDTO ActualizarEum_Info_GraficaDTO(Eum_Info_GraficaDTO vEum_Info_GraficaDTO)
        //{
        //    try
        //    {
        //        var vRegistro = new T_Sgpad_Eum_Info_Grafica();
        //        var vResultado = Eum_Info_GraficaAD.ActualizarT_Sgpad_Eum_Info_Grafica(vRegistro);
        //        return vEum_Info_GraficaDTO;
        //    }
        //    catch (Exception ex)
        //    {
        //        //Log.Error(ex.Message, ex);
        //        throw;
        //    }
        //}

        public Eum_Info_GraficaDTO GrabarEum_Info_GraficaDTO(Eum_Info_GraficaDTO vEum_Info_GraficaDTO)
        {
            try
            {
                if (vEum_Info_GraficaDTO != null)
                {
                    var vRegistro = new T_Sgpad_Eum_Info_Grafica
                    {
                        FEC_INGRESO = vEum_Info_GraficaDTO.Fec_Ingreso,
                        FEC_MODIFICA = vEum_Info_GraficaDTO.Fec_Modifica,
                        FLG_ESTADO = vEum_Info_GraficaDTO.Flg_Estado,
                        IP_INGRESO = vEum_Info_GraficaDTO.Ip_Ingreso,
                        IP_MODIFICA = vEum_Info_GraficaDTO.Ip_Modifica,
                        USU_INGRESO = vEum_Info_GraficaDTO.Usu_Ingreso,
                        USU_MODIFICA = vEum_Info_GraficaDTO.Usu_Modifica,
                        ID_EUM = vEum_Info_GraficaDTO.Id_Eum,
                        EXTENCION = vEum_Info_GraficaDTO.Extencion,
                        ID_EUM_INFO_GRAFICA = vEum_Info_GraficaDTO.Id_Eum_Info_Grafica,
                        NOMBRE_IMAGEN = vEum_Info_GraficaDTO.Nombre_Imagen,
                        RUTA_IMAGEN = vEum_Info_GraficaDTO.Ruta_Imagen,
                        TAMANO = vEum_Info_GraficaDTO.Tamano,
                        FECHA_TOMA = vEum_Info_GraficaDTO.Fecha_Toma,
                        DESCRIPCION = vEum_Info_GraficaDTO.Descripcion
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

        public int AnularEum_Info_GraficaDTOPorCodigo(Eum_Info_GraficaDTO vEum_Info_GraficaDTO)
        {
            try
            {
                return Eum_Info_GraficaAD.AnularT_Sgpad_Eum_Info_GraficaPorCodigo(0);
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
                IEnumerable<T_Sgpad_Eum_Info_Grafica> vResultado = Eum_Info_GraficaAD.ListarPorIdEumT_Sgpad_Eum_Info_Grafica(vId_Eum);
                if (vResultado != null)
                {
                    List<Eum_Info_GraficaDTO> vLista = new List<Eum_Info_GraficaDTO>();
                    Eum_Info_GraficaDTO vEntidad;
                    foreach (T_Sgpad_Eum_Info_Grafica item in vResultado)
                    {
                        vEntidad = new Eum_Info_GraficaDTO()
                        {
                            Fec_Ingreso = item.FEC_INGRESO,
                            Flg_Estado = item.FLG_ESTADO,
                            Id_Eum = item.ID_EUM,
                            Id_Eum_Info_Grafica = item.ID_EUM_INFO_GRAFICA,
                            Ip_Ingreso = item.IP_INGRESO,
                            Usu_Ingreso = item.USU_INGRESO,
                            Extencion = item.EXTENCION,
                            Nombre_Imagen = item.NOMBRE_IMAGEN,
                            Ruta_Imagen = item.RUTA_IMAGEN,
                            Tamano = item.TAMANO,
                            Fecha_Toma = item.FECHA_TOMA,
                            Descripcion = item.DESCRIPCION
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
