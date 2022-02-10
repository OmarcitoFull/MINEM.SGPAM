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

        public T_Sgpam_ExpedienteLN(IT_Sgpam_ExpedienteAD vT_Sgpam_ExpedienteAD)
        {
            ExpedienteAD = vT_Sgpam_ExpedienteAD;
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
                var vResultado = ExpedienteAD.RecuperarT_Sgpam_ExpedientePorCodigo(vId_Expediente);
                return new ExpedienteDTO();
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
                //var vListComponente = ExpedienteLN.ListarComponenteEumDTO(vId_Eum);
                RegistrarExpedienteDTO vResultado = new RegistrarExpedienteDTO();
                //{
                //    Expediente = RecuperarExpedienteDTOPorCodigo(vId_Expediente),
                    //CboConflictoSocial = (List<Conflicto_SocialDTO>)Conflicto_SocialLN.ListarConflicto_SocialDTO(),
                    //CboTipoOperacion = (List<Tipo_OperacionDTO>)Tipo_OperacionLN.ListarTipo_OperacionDTO(),
                    //CboTipoSustancia = (List<Tipo_SustanciaDTO>)Tipo_SustanciaLN.ListarTipo_SustanciaDTO(),
                    //CboTipoPam = (List<Tipo_PamDTO>)Tipo_PamLN.ListarTipo_PamDTO(),
                    //ListaHistorial = (List<Eum_ModDTO>)Eum_ModLN.ListarPorIdEumEum_ModDTO(vId_Eum),
                    //ListaInspeccion = (List<Eum_InspeccionDTO>)Eum_InspeccionLN.ListarPorIdEumEum_InspeccionDTO(vId_Eum),
                    //ListaUbicacion = new List<Eum_UbicacionDTO>(), // (List<Eum_UbicacionDTO>)Eum_UbicacionLN.ListarEum_UbicacionDTO(),
                    //                                               //ListaInfor = (List<Eum_InspeccionDTO>)Eum_InspeccionLN.ListarPorIdEumEum_InspeccionDTO(vId_Eum),
                    //ListaInformacionDescargo = (List<Eum_Info_DescargoDTO>)Eum_Info_DescargoLN.ListarPorIdEumEum_Info_DescargoDTO(vId_Eum),
                    //ListaInformacionGrafica = (List<Eum_Info_GraficaDTO>)Eum_Info_GraficaLN.ListarPorIdEumEum_Info_GraficaDTO(vId_Eum),

                    //ListaDerechosMineros = (List<Comp_Dd_MineroDTO>)Comp_Dd_MineroLN.ListarPorIdEumComp_Dd_MineroDTO(vId_Eum),
                    //ListaSituacionPrincipalesProducto = (List<Comp_Dm_SituacionDTO>)Comp_Dm_SituacionLN.ListarPorIdEumComp_Dm_Situacion(vId_Eum),
                    //ListaTitularesReferencialesDerechos = (List<Comp_Dm_TitularDTO>)Comp_Dm_TitularLN.ListarPorIdEumComp_Dm_Titular(vId_Eum),

                    //ListaComponenteActivo = vListComponente.Where(x => x.Flg_Estado == Constantes.Activo).ToList(),
                    //ListaComponenteInactivo = vListComponente.Where(x => x.Flg_Estado == Constantes.Inactivo).ToList()
                //};
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
