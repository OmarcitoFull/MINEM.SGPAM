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

        //public Eum_Info_DescargoDTO InsertarEum_Info_DescargoDTO(Eum_Info_DescargoDTO vEum_Info_DescargoDTO)
        //{
        //    try
        //    {
        //        var vRegistro = new T_Sgpad_Eum_Info_Descargo();
        //        var vResultado = Eum_Info_DescargoAD.InsertarT_Sgpad_Eum_Info_Descargo(vRegistro);
        //        return vEum_Info_DescargoDTO;
        //    }
        //    catch (Exception ex)
        //    {
        //        //Log.Error(ex.Message, ex);
        //        throw;
        //    }
        //}

        //public Eum_Info_DescargoDTO ActualizarEum_Info_DescargoDTO(Eum_Info_DescargoDTO vEum_Info_DescargoDTO)
        //{
        //    try
        //    {
        //        var vRegistro = new T_Sgpad_Eum_Info_Descargo();
        //        var vResultado = Eum_Info_DescargoAD.ActualizarT_Sgpad_Eum_Info_Descargo(vRegistro);
        //        return vEum_Info_DescargoDTO;
        //    }
        //    catch (Exception ex)
        //    {
        //        //Log.Error(ex.Message, ex);
        //        throw;
        //    }
        //}

        public Eum_Info_DescargoDTO GrabarEum_Info_DescargoDTO(Eum_Info_DescargoDTO vEum_Info_DescargoDTO)
        {
            try
            {
                if (vEum_Info_DescargoDTO != null)
                {
                    var vRegistro = new T_Sgpad_Eum_Info_Descargo
                    {
                        FEC_INGRESO = vEum_Info_DescargoDTO.Fec_Ingreso,
                        FEC_MODIFICA = vEum_Info_DescargoDTO.Fec_Modifica,
                        FLG_ESTADO = vEum_Info_DescargoDTO.Flg_Estado,
                        IP_INGRESO = vEum_Info_DescargoDTO.Ip_Ingreso,
                        IP_MODIFICA = vEum_Info_DescargoDTO.Ip_Modifica,
                        USU_INGRESO = vEum_Info_DescargoDTO.Usu_Ingreso,
                        USU_MODIFICA = vEum_Info_DescargoDTO.Usu_Modifica,
                        ID_EUM = vEum_Info_DescargoDTO.Id_Eum,
                        EXTENCION = vEum_Info_DescargoDTO.Extencion,
                        ID_EUM_INFO_DESCARGO = vEum_Info_DescargoDTO.Id_Eum_Info_Descargo,
                        ASUNTO = vEum_Info_DescargoDTO.Asunto,
                        DECLARACION = vEum_Info_DescargoDTO.Declaracion,
                        TAMANO = vEum_Info_DescargoDTO.Tamano,
                        FECHA_DESCARGO = vEum_Info_DescargoDTO.Fecha_Descargo,
                        NOMBRE_DOCUMENTO = vEum_Info_DescargoDTO.Nombre_Documento,
                        RUTA_DOCUMENTO = vEum_Info_DescargoDTO.Ruta_Documento,
                        TITULAR = vEum_Info_DescargoDTO.Titular
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

        public int AnularEum_Info_DescargoDTOPorCodigo(Eum_Info_DescargoDTO vEum_Info_DescargoDTO)
        {
            try
            {
                return Eum_Info_DescargoAD.AnularT_Sgpad_Eum_Info_DescargoPorCodigo(0);
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
                IEnumerable<T_Sgpad_Eum_Info_Descargo> vResultado = Eum_Info_DescargoAD.ListarPorIdEumT_Sgpad_Eum_Info_Descargo(vId_Eum);
                if (vResultado != null)
                {
                    List<Eum_Info_DescargoDTO> vLista = new List<Eum_Info_DescargoDTO>();
                    Eum_Info_DescargoDTO vEntidad;
                    foreach (T_Sgpad_Eum_Info_Descargo item in vResultado)
                    {
                        vEntidad = new Eum_Info_DescargoDTO()
                        {
                            Fec_Ingreso = item.FEC_INGRESO,
                            Flg_Estado = item.FLG_ESTADO,
                            Id_Eum = item.ID_EUM,
                            Id_Eum_Info_Descargo = item.ID_EUM_INFO_DESCARGO,
                            Ip_Ingreso = item.IP_INGRESO,
                            Usu_Ingreso = item.USU_INGRESO,
                            Asunto = item.ASUNTO,
                            Declaracion = item.DECLARACION,
                            Extencion = item.EXTENCION,
                            Fecha_Descargo = item.FECHA_DESCARGO,
                            Nombre_Documento = item.NOMBRE_DOCUMENTO,
                            Ruta_Documento = item.RUTA_DOCUMENTO,
                            Tamano = item.TAMANO,
                            Titular = item.TITULAR
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
