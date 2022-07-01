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
                        Usu_Ingreso = vRegistro.USU_INGRESO,
                        Fec_Ingreso = vRegistro.FEC_INGRESO,
                        Ip_Ingreso = vRegistro.IP_INGRESO,
                        Usu_Modifica = vRegistro.USU_MODIFICA,
                        Fec_Modifica = vRegistro.FEC_MODIFICA,
                        Ip_Modifica = vRegistro.IP_MODIFICA,
                        Flg_Estado = vRegistro.FLG_ESTADO
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

        public ExpedienteDTO GrabarExpedienteDTO(ExpedienteDTO vExpedienteDTO)
        {
            try
            {
                if (vExpedienteDTO.Id_Expediente == 0)
                    return InsertarExpedienteDTO(vExpedienteDTO);
                else
                    return ActualizarExpedienteDTO(vExpedienteDTO);
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
                var vRegistro = new T_Sgpam_Expediente 
                {
                    ID_EXPEDIENTE = vExpedienteDTO.Id_Expediente,
                    NRO_EXPEDIENTE = vExpedienteDTO.Nro_Expediente,
                    ZONA = vExpedienteDTO.Zona,
                    DECLARANTE = vExpedienteDTO.Declarante.ToUpper(),
                    USU_INGRESO = vExpedienteDTO.Usu_Ingreso,
                    FEC_INGRESO = vExpedienteDTO.Fec_Ingreso,
                    IP_INGRESO = vExpedienteDTO.Ip_Ingreso,
                    FLG_ESTADO = "1"
                };
                var vResultado = ExpedienteAD.InsertarT_Sgpam_Expediente(vRegistro);
                vExpedienteDTO = RecuperarExpedienteDTOPorCodigo(vResultado.ID_EXPEDIENTE);

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
                var vRegistro = new T_Sgpam_Expediente {
                    ID_EXPEDIENTE = vExpedienteDTO.Id_Expediente,
                    NRO_EXPEDIENTE = vExpedienteDTO.Nro_Expediente,
                    ZONA = vExpedienteDTO.Zona,
                    DECLARANTE = vExpedienteDTO.Declarante.ToUpper(),
                    USU_MODIFICA = vExpedienteDTO.Usu_Modifica,
                    FEC_MODIFICA = vExpedienteDTO.Fec_Modifica,
                    IP_MODIFICA = vExpedienteDTO.Ip_Modifica
                };
                var vResultado = ExpedienteAD.ActualizarT_Sgpam_Expediente(vRegistro);
                vExpedienteDTO = RecuperarExpedienteDTOPorCodigo(vResultado.ID_EXPEDIENTE);

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
            int vResult = 0;
            try
            {
                if (vExpedienteDTO != null)
                {
                    var vRegistro = new T_Sgpam_Expediente
                    {
                        ID_EXPEDIENTE = vExpedienteDTO.Id_Expediente,
                        USU_MODIFICA = vExpedienteDTO.Usu_Modifica,
                        FEC_MODIFICA = vExpedienteDTO.Fec_Modifica,
                        IP_MODIFICA = vExpedienteDTO.Ip_Modifica
                    };
                    vResult = ExpedienteAD.AnularT_Sgpam_ExpedientePorCodigo(vRegistro); // != 0;
                }
                return vResult;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<ExpedienteDTO> ListarPaginadoExpedienteDTO(string vNroExp, string vZona, string vUbigeo, int vNumPag, int vCantRegxPag)
        {
            try
            {
                if (vNroExp == null || vNroExp.Trim().Length == 0)
                    vNroExp = "";
                else
                    vNroExp = vNroExp.ToUpper();

                if (vZona == null || vZona.Trim().Length == 0)
                    vZona = "";
                else
                    vZona = vZona.ToUpper();

                if (vUbigeo == null || vUbigeo.Trim().Length == 0)
                    vUbigeo = "0";

                IEnumerable<T_Sgpam_Expediente> vResultado = ExpedienteAD.ListarPaginadoT_Sgpam_Expediente(vNroExp, vZona, vUbigeo, vNumPag, vCantRegxPag);
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
                            anio = 2022,

                            Total_Lnr = item.TOTAL_LNR,
                            Nro_Informe = item.NRO_INFORME
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
                RegistrarExpedienteDTO vResultado = new RegistrarExpedienteDTO()
                {
                    Expediente = RecuperarExpedienteDTOPorCodigo(vId_Expediente),
                    //CboTipoOperacion = (List<Tipo_OperacionDTO>)Tipo_OperacionLN.ListarTipo_OperacionDTO(),
                    ListaLNR = (List<LnrDTO>)LnrLN.ListarPorIdExpedienteLnrDTO(vId_Expediente)
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
