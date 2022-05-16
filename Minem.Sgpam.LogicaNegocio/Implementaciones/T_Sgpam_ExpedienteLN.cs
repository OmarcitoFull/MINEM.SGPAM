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
    public class T_Sgpam_ExpedienteLN : BaseLN, IT_Sgpam_ExpedienteLN
    {
        private readonly IT_Sgpam_ExpedienteAD ExpedienteAD;
        private readonly IT_Sgpad_LnrLN LnrLN;

        public T_Sgpam_ExpedienteLN(IT_Sgpam_ExpedienteAD vT_Sgpam_ExpedienteAD, IT_Sgpad_LnrLN vIT_Sgpad_LnrLN)
        {
            ExpedienteAD = vT_Sgpam_ExpedienteAD;
            LnrLN = vIT_Sgpad_LnrLN;
        }

        public IEnumerable<ExpedienteDTO> ListarExpedienteDTO()
        {
            try
            {
                var vResultado = ExpedienteAD.ListarT_Sgpam_Expediente();
                return new List<ExpedienteDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public ExpedienteDTO RecuperarExpedienteDTOPorCodigo(int vId_Expediente)
        {
            try
            {
                var vRegistro = ExpedienteAD.RecuperarT_Sgpam_ExpedientePorCodigo(vId_Expediente);
                if (vRegistro != null)
                {
                    var vResultado = new ExpedienteDTO
                    {
                        Declarante = vRegistro.DECLARANTE,
                        Id_Expediente = vRegistro.ID_EXPEDIENTE,
                        Nro_Expediente = vRegistro.NRO_EXPEDIENTE,
                        Zona = vRegistro.ZONA,
                        
                        //anio = vRegistro.
                        Fec_Ingreso = vRegistro.FEC_INGRESO,
                        Fec_Modifica = vRegistro.FEC_MODIFICA,
                        Flg_Estado = vRegistro.FLG_ESTADO,
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

        public ExpedienteDTO InsertarExpedienteDTO(ExpedienteDTO vExpedienteDTO)
        {
            try
            {
                var vRegistro = new T_Sgpam_Expediente();
                var vResultado = ExpedienteAD.InsertarT_Sgpam_Expediente(vRegistro);
                return vExpedienteDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public ExpedienteDTO ActualizarExpedienteDTO(ExpedienteDTO vExpedienteDTO)
        {
            try
            {
                var vRegistro = new T_Sgpam_Expediente();
                var vResultado = ExpedienteAD.ActualizarT_Sgpam_Expediente(vRegistro);
                return vExpedienteDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
        
        public int AnularExpedienteDTOPorCodigo(ExpedienteDTO vExpedienteDTO)
        {
            try
            {
                return ExpedienteAD.AnularT_Sgpam_ExpedientePorCodigo(0);
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<ExpedienteDTO> ListarPaginadoExpedienteDTO(string vNroExp, string vFiltro, int vNumPag, int vCantRegxPag)
        {
            try
            {
                IEnumerable<T_Sgpam_Expediente> vResultado = ExpedienteAD.ListarPaginadoT_Sgpam_Expediente(vNroExp, vFiltro, vNumPag, vCantRegxPag);
                if (vResultado != null)
                {
                    List<ExpedienteDTO> vLista = new List<ExpedienteDTO>();
                    ExpedienteDTO vEntidad;
                    foreach (T_Sgpam_Expediente item in vResultado)
                    {
                        vEntidad = new ExpedienteDTO()
                        {
                            Declarante = item.DECLARANTE,
                            Id_Expediente = item.ID_EXPEDIENTE,
                            Nro_Expediente = item.NRO_EXPEDIENTE,
                            Zona = item.ZONA,
                            Fec_Ingreso = item.FEC_INGRESO,
                            Flg_Estado = item.FLG_ESTADO,
                            Ip_Ingreso = item.IP_INGRESO,
                            Usu_Ingreso = item.USU_INGRESO,
                            anio = 2022
                        };
                        vLista.Add(vEntidad);
                    }
                    return vLista;
                }
                return null;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public RegistrarExpedienteDTO RecuperarFullExpedienteDTOPorCodigo(int vId_Expediente)
        {
            try
            {
                //if (vId_Eum > 0)
                //{
                RegistrarExpedienteDTO vResultado = new RegistrarExpedienteDTO()
                {
                    Expediente = RecuperarExpedienteDTOPorCodigo(vId_Expediente),
                    //CboTipoOperacion = (List<Tipo_OperacionDTO>)Tipo_OperacionLN.ListarTipo_OperacionDTO(),
                    ListaLNR = (List<LnrDTO>)LnrLN.ListarPorIdExpedienteLnrDTO(vId_Expediente)
                    //ListaInspeccion = (List<Eum_InspeccionDTO>)Eum_InspeccionLN.ListarPorIdEumEum_InspeccionDTO(vId_Eum),
                };
                return vResultado;
                //}
                //return null;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
