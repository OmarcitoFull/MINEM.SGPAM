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
    /// Creado Por:	Mateo Salvador Paucar
    /// Fecha Creación:	08/02/2022
    /// </summary>
    public class T_Sgpad_Eum_OperacionLN: BaseLN, IT_Sgpad_Eum_OperacionLN
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

        public Eum_OperacionDTO InsertarEum_OperacionDTO(Eum_OperacionDTO vEum_OperacionDTO)
        {
            try
            {
                var vRegistro = new T_Sgpad_Eum_Operacion();
                var vResultado = Eum_OperacionAD.InsertarT_Sgpad_Eum_Operacion(vRegistro);
                return vEum_OperacionDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Eum_OperacionDTO ActualizarEum_OperacionDTO(Eum_OperacionDTO vEum_OperacionDTO)
        {
            try
            {
                var vRegistro = new T_Sgpad_Eum_Operacion();
                var vResultado = Eum_OperacionAD.ActualizarT_Sgpad_Eum_Operacion(vRegistro);
                return vEum_OperacionDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }

        }

        public int AnularEum_OperacionDTOPorCodigo(Eum_OperacionDTO vEum_OperacionDTO)
        {
            try
            {
                return Eum_OperacionAD.AnularT_Sgpad_Eum_OperacionPorCodigo(0);
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
                IEnumerable<T_Sgpad_Eum_Operacion> vResultado = Eum_OperacionAD.ListarPorIdEumT_Sgpad_Eum_Operacion(vId_Eum);
                if (vResultado != null)
                {
                    List<Eum_OperacionDTO> vLista = new List<Eum_OperacionDTO>();
                    Eum_OperacionDTO vEntidad;
                    foreach (T_Sgpad_Eum_Operacion item in vResultado)
                    {
                        vEntidad = new Eum_OperacionDTO()
                        {
                            Fec_Ingreso = item.FEC_INGRESO,
                            Flg_Estado = item.FLG_ESTADO,
                            Id_Eum = item.ID_EUM,
                            Id_Eum_Operacion = item.ID_EUM_OPERACION,
                            Ip_Ingreso = item.IP_INGRESO,
                            Id_Tipo_Operacion = item.ID_TIPO_OPERACION,
                            Usu_Ingreso = item.USU_INGRESO,
                            Tipo_Operacion = item.TIPO_OPERACION
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
            catch (Exception)
            {

                throw;
            }
            throw new NotImplementedException();
        }

        public Eum_OperacionDTO GrabarEum_OperacionDTO(Eum_OperacionDTO vEum_OperacionDTO)
        {
            try
            {
                if (vEum_OperacionDTO != null)
                {
                    var vRegistro = new T_Sgpad_Eum_Operacion
                    {
                        FEC_INGRESO = vEum_OperacionDTO.Fec_Ingreso,
                        FEC_MODIFICA = vEum_OperacionDTO.Fec_Modifica,
                        FLG_ESTADO = vEum_OperacionDTO.Flg_Estado,
                        IP_INGRESO = vEum_OperacionDTO.Ip_Ingreso,
                        IP_MODIFICA = vEum_OperacionDTO.Ip_Modifica,
                        USU_INGRESO = vEum_OperacionDTO.Usu_Ingreso,
                        USU_MODIFICA = vEum_OperacionDTO.Usu_Modifica,
                        ID_EUM = vEum_OperacionDTO.Id_Eum,
                        ID_EUM_OPERACION = vEum_OperacionDTO.Id_Eum_Operacion,
                        ID_TIPO_OPERACION = vEum_OperacionDTO.Id_Tipo_Operacion
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
            catch (Exception)
            {

                throw;
            }
        }

    }
}
