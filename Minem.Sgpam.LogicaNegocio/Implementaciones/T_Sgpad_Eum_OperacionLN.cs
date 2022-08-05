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
    /// Creado Por:	Mateo Salvador Paucar
    /// Fecha Creación:	08/02/2022
    /// </summary>
    public class T_Sgpad_Eum_OperacionLN : BaseLN, IT_Sgpad_Eum_OperacionLN
    {
        private readonly IT_Sgpad_Eum_OperacionAD Eum_OperacionAD;
        private readonly IT_Sgpal_Tipo_OperacionLN Tipo_OperacionLN;
        public T_Sgpad_Eum_OperacionLN(IT_Sgpad_Eum_OperacionAD vT_Sgpad_Eum_OperacionAD, IT_Sgpal_Tipo_OperacionLN vIT_Sgpal_Tipo_OperacionLN)
        {
            Eum_OperacionAD = vT_Sgpad_Eum_OperacionAD;
            Tipo_OperacionLN = vIT_Sgpal_Tipo_OperacionLN;
        }

        public IEnumerable<Eum_OperacionDTO> ListarEum_OperacionDTO()
        {
            try
            {
                var vResultado = Eum_OperacionAD.ListarT_Sgpad_Eum_Operacion();
                return new List<Eum_OperacionDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Eum_OperacionDTO RecuperarEum_OperacionDTOPorCodigo(int vId_Eum_Operacion)
        {
            try
            {
                var vResultado = Eum_OperacionAD.RecuperarT_Sgpad_Eum_OperacionPorCodigo(vId_Eum_Operacion);
                return new Eum_OperacionDTO();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Eum_OperacionDTO GrabarEum_OperacionDTO(Eum_OperacionDTO vEum_OperacionDTO)
        {
            try
            {
                if (vEum_OperacionDTO != null)
                {
                    var vRegistro = new T_Sgpad_Eum_Operacion
                    {
                        ID_EUM_OPERACION = vEum_OperacionDTO.Id_Eum_Operacion,
                        ID_EUM = vEum_OperacionDTO.Id_Eum,
                        ID_TIPO_OPERACION = vEum_OperacionDTO.Id_Tipo_Operacion,
                        USU_INGRESO = vEum_OperacionDTO.Usu_Ingreso,
                        FEC_INGRESO = vEum_OperacionDTO.Fec_Ingreso,
                        IP_INGRESO = vEum_OperacionDTO.Ip_Ingreso,
                        USU_MODIFICA = vEum_OperacionDTO.Usu_Modifica,
                        FEC_MODIFICA = vEum_OperacionDTO.Fec_Modifica,
                        IP_MODIFICA = vEum_OperacionDTO.Ip_Modifica,
                        FLG_ESTADO = vEum_OperacionDTO.Flg_Estado
                    };
                    if (vEum_OperacionDTO.Id_Eum_Operacion == 0)
                    {
                        var vResultado = Eum_OperacionAD.InsertarT_Sgpad_Eum_Operacion(vRegistro);
                        vEum_OperacionDTO.Id_Eum_Operacion = vResultado.ID_EUM_OPERACION;
                    }
                    else
                    {
                        var vResultado = Eum_OperacionAD.ActualizarT_Sgpad_Eum_Operacion(vRegistro);
                        vEum_OperacionDTO = RecuperarFullEum_OperacionDTOPorCodigo(vResultado.ID_EUM_OPERACION).Eum_Operacion;
                    }
                }
                return vEum_OperacionDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public bool AnularEum_OperacionDTOPorCodigo(Eum_OperacionDTO vEum_OperacionDTO)
        {
            bool vResult = false;
            try
            {
                if (vEum_OperacionDTO != null)
                {
                    var vRegistro = new T_Sgpad_Eum_Operacion
                    {
                        FEC_MODIFICA = vEum_OperacionDTO.Fec_Modifica,
                        ID_EUM_OPERACION = vEum_OperacionDTO.Id_Eum_Operacion,
                        IP_MODIFICA = vEum_OperacionDTO.Ip_Modifica,
                        USU_MODIFICA = vEum_OperacionDTO.Usu_Modifica
                    };
                    vResult = Eum_OperacionAD.AnularT_Sgpad_Eum_OperacionPorCodigo(vRegistro) != 0;
                }
                return vResult;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<Eum_OperacionDTO> ListarPaginadoEum_OperacionDTO(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            try
            {
                var vResultado = Eum_OperacionAD.ListarPaginadoT_Sgpad_Eum_Operacion(vFiltro, vNumPag, vCantRegxPag);
                return new List<Eum_OperacionDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<Eum_OperacionDTO> ListarPorIdEumEum_OperacionDTO(int vId_Eum)
        {
            try
            {
                var vResultado = (from vTmp in Eum_OperacionAD.ListarPorIdEumT_Sgpad_Eum_Operacion(vId_Eum)
                                  select new Eum_OperacionDTO
                                  {
                                      Id_Eum_Operacion = vTmp.ID_EUM_OPERACION,
                                      Id_Eum = vTmp.ID_EUM,
                                      Id_Tipo_Operacion = vTmp.ID_TIPO_OPERACION,

                                      Tipo_Operacion = vTmp.TIPO_OPERACION,
                                      //Fecha_Toma = vTmp.FECHA_TOMA,
                                      //Nombre_Imagen = vTmp.NOMBRE_IMAGEN,
                                      //Ruta_Imagen = vTmp.RUTA_IMAGEN,
                                      //Extencion = vTmp.EXTENCION,
                                      //Tamano = vTmp.TAMANO,
                                      //Id_LaserFiche = vTmp.ID_LASERFICHE,
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

        public RegistrarEumOperacionDTO RecuperarFullEum_OperacionDTOPorCodigo(int vId_Eum_Operacion)
        {
            try
            {
                RegistrarEumOperacionDTO vResultado = new RegistrarEumOperacionDTO
                {
                    Eum_Operacion = RecuperarEum_OperacionDTOPorCodigo(vId_Eum_Operacion),
                    CboTipoOperacion = (List<Tipo_OperacionDTO>)Tipo_OperacionLN.ListarTipo_OperacionDTO()
                };
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
