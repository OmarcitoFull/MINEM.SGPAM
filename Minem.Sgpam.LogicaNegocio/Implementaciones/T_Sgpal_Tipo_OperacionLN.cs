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
    public class T_Sgpal_Tipo_OperacionLN : BaseLN, IT_Sgpal_Tipo_OperacionLN
    {
        private readonly IT_Sgpal_Tipo_OperacionAD Tipo_OperacionAD;

        public T_Sgpal_Tipo_OperacionLN(IT_Sgpal_Tipo_OperacionAD vT_Sgpal_Tipo_OperacionAD)
        {
            Tipo_OperacionAD = vT_Sgpal_Tipo_OperacionAD;
        }

        public IEnumerable<Tipo_OperacionDTO> ListarTipo_OperacionDTO()
        {
            try
            {
                var vResultado = (from vTmp in Tipo_OperacionAD.ListarT_Sgpal_Tipo_Operacion()
                                  select new Tipo_OperacionDTO
                                  {
                                      Descripcion = vTmp.DESCRIPCION,
                                      Fec_Ingreso = vTmp.FEC_INGRESO,
                                      Fec_Modifica = vTmp.FEC_MODIFICA,
                                      Flg_Estado = vTmp.FLG_ESTADO,
                                      Id_Tipo_Operacion = vTmp.ID_TIPO_OPERACION,
                                      Ip_Ingreso = vTmp.IP_INGRESO,
                                      Ip_Modifica = vTmp.IP_MODIFICA,
                                      Usu_Ingreso = vTmp.USU_INGRESO,
                                      Usu_Modifica = vTmp.USU_MODIFICA
                                  }).ToList();
                return vResultado;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Tipo_OperacionDTO RecuperarTipo_OperacionDTOPorCodigo(int vId_Tipo_Operacion)
        {
            try
            {
                var vRegistro = Tipo_OperacionAD.RecuperarT_Sgpal_Tipo_OperacionPorCodigo(vId_Tipo_Operacion);

                if (vRegistro != null)
                {
                    var vResultado = new Tipo_OperacionDTO
                    {
                        Descripcion = vRegistro.DESCRIPCION,
                        Fec_Ingreso = vRegistro.FEC_INGRESO,
                        Fec_Modifica = vRegistro.FEC_MODIFICA,
                        Flg_Estado = vRegistro.FLG_ESTADO,
                        Id_Tipo_Operacion = vRegistro.ID_TIPO_OPERACION,
                        Ip_Ingreso = vRegistro.IP_INGRESO,
                        Ip_Modifica = vRegistro.IP_MODIFICA,
                        Usu_Ingreso = vRegistro.USU_INGRESO,
                        Usu_Modifica = vRegistro.USU_MODIFICA
                    };
                    return vResultado;
                }
                return null;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Tipo_OperacionDTO GrabarTipo_OperacionDTO(Tipo_OperacionDTO vTipo_OperacionDTO)
        {
            try
            {
                if (vTipo_OperacionDTO != null)
                {
                    var vRegistro = new T_Sgpal_Tipo_Operacion
                    {
                        DESCRIPCION = vTipo_OperacionDTO.Descripcion,
                        FEC_INGRESO = vTipo_OperacionDTO.Fec_Ingreso,
                        FEC_MODIFICA = vTipo_OperacionDTO.Fec_Modifica,
                        FLG_ESTADO = vTipo_OperacionDTO.Flg_Estado,
                        ID_TIPO_OPERACION = vTipo_OperacionDTO.Id_Tipo_Operacion,
                        IP_INGRESO = vTipo_OperacionDTO.Ip_Ingreso,
                        IP_MODIFICA = vTipo_OperacionDTO.Ip_Modifica,
                        USU_INGRESO = vTipo_OperacionDTO.Usu_Ingreso,
                        USU_MODIFICA = vTipo_OperacionDTO.Usu_Modifica
                    };
                    if (vTipo_OperacionDTO.Id_Tipo_Operacion == 0)
                    {
                        var vResultado = Tipo_OperacionAD.InsertarT_Sgpal_Tipo_Operacion(vRegistro);
                        vTipo_OperacionDTO.Id_Tipo_Operacion = vResultado.ID_TIPO_OPERACION;
                    }
                    else
                    {
                        var vResultado = Tipo_OperacionAD.ActualizarT_Sgpal_Tipo_Operacion(vRegistro);
                        vTipo_OperacionDTO = RecuperarTipo_OperacionDTOPorCodigo(vResultado.ID_TIPO_OPERACION);
                    }
                }
                return vTipo_OperacionDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public int AnularTipo_OperacionDTOPorCodigo(Tipo_OperacionDTO vTipo_OperacionDTO)
        {
            try
            {
                if (vTipo_OperacionDTO != null)
                {
                    var vRegistro = new T_Sgpal_Tipo_Operacion
                    {
                        DESCRIPCION = vTipo_OperacionDTO.Descripcion,
                        FEC_INGRESO = vTipo_OperacionDTO.Fec_Ingreso,
                        FEC_MODIFICA = vTipo_OperacionDTO.Fec_Modifica,
                        FLG_ESTADO = vTipo_OperacionDTO.Flg_Estado,
                        ID_TIPO_OPERACION = vTipo_OperacionDTO.Id_Tipo_Operacion,
                        IP_INGRESO = vTipo_OperacionDTO.Ip_Ingreso,
                        IP_MODIFICA = vTipo_OperacionDTO.Ip_Modifica,
                        USU_INGRESO = vTipo_OperacionDTO.Usu_Ingreso,
                        USU_MODIFICA = vTipo_OperacionDTO.Usu_Modifica
                    };
                    if (vTipo_OperacionDTO.Id_Tipo_Operacion == 0)
                    {
                        return 0;
                    }
                    else
                    {
                        var vResultado = Tipo_OperacionAD.AnularT_Sgpal_Tipo_OperacionPorCodigo(vRegistro);
                        return vResultado;
                    }
                }
                return 0;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<Tipo_OperacionDTO> ListarPaginadoTipo_OperacionDTO(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            try
            {
                var vResultado = Tipo_OperacionAD.ListarPaginadoT_Sgpal_Tipo_Operacion(vFiltro, vNumPag, vCantRegxPag);
                return new List<Tipo_OperacionDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<Tipo_OperacionDTO> ListarSinIdEumTipo_OperacionDTO(int vIdEum)
        {
            try
            {
                var vResultado = (from vTmp in Tipo_OperacionAD.ListarSinIdEumT_Sgpal_Tipo_Operacion(vIdEum)
                                  select new Tipo_OperacionDTO
                                  {
                                      Descripcion = vTmp.DESCRIPCION,
                                      Fec_Ingreso = vTmp.FEC_INGRESO,
                                      Fec_Modifica = vTmp.FEC_MODIFICA,
                                      Flg_Estado = vTmp.FLG_ESTADO,
                                      Id_Tipo_Operacion = vTmp.ID_TIPO_OPERACION,
                                      Ip_Ingreso = vTmp.IP_INGRESO,
                                      Ip_Modifica = vTmp.IP_MODIFICA,
                                      Usu_Ingreso = vTmp.USU_INGRESO,
                                      Usu_Modifica = vTmp.USU_MODIFICA
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
