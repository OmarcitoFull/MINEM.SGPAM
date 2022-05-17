using System;
using System.Linq;
using System.Collections.Generic;
using Minem.Sgpam.AccesoDatos.Interfaces;
using Minem.Sgpam.Entidades;
using Minem.Sgpam.LogicaNegocio.Base;
using Minem.Sgpam.LogicaNegocio.Interfaces;
using Minem.Sgpam.TransporteDatos.DtoEntidades;
using Minem.Sgpam.InfraEstructura;

namespace Minem.Sgpam.LogicaNegocio.Implementaciones
{
    /// <summary>
    /// Objetivo:	Clase que implementa la lógica del negocio para las operaciones de las entidades
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	29/10/2021
    /// </summary>
    public class T_Sgpam_VisitaLN : BaseLN, IT_Sgpam_VisitaLN
    {
        private readonly IT_Sgpam_VisitaAD VisitaAD;

        public T_Sgpam_VisitaLN(IT_Sgpam_VisitaAD vT_Sgpam_VisitaAD)
        {
            VisitaAD = vT_Sgpam_VisitaAD;
        }

        public IEnumerable<VisitaDTO> ListarVisitaDTO()
        {
            try
            {
                var vResultado = VisitaAD.ListarT_Sgpam_Visita();
                return new List<VisitaDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public VisitaDTO RecuperarVisitaDTOPorCodigo(int vId_Visita)
        {
            try
            {
                var vResultado = VisitaAD.RecuperarT_Sgpam_VisitaPorCodigo(vId_Visita);
                if (vResultado != null)
                {
                    var vRegistro = new VisitaDTO
                    {
                        Fecha_Regreso = vResultado.FECHA_REGRESO,
                        Fecha_Salida = vResultado.FECHA_SALIDA,
                        Id_Visita = vResultado.ID_VISITA,
                        Ubigeo =vResultado.UBIGEO,
                        Fec_Ingreso = vResultado.FEC_INGRESO,
                        Fec_Modifica = vResultado.FEC_MODIFICA,
                        Flg_Estado = vResultado.FLG_ESTADO,
                        Ip_Ingreso = vResultado.IP_INGRESO,
                        Ip_Modifica = vResultado.IP_MODIFICA,
                        Usu_Ingreso = vResultado.USU_INGRESO,
                        Usu_Modifica = vResultado.USU_MODIFICA
                    };
                    return vRegistro;
                }
                return null;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public VisitaDTO InsertarVisitaDTO(VisitaDTO vVisitaDTO)
        {
            try
            {
                var vRegistro = new T_Sgpam_Visita();
                var vResultado = VisitaAD.InsertarT_Sgpam_Visita(vRegistro);
                return vVisitaDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public VisitaDTO ActualizarVisitaDTO(VisitaDTO vVisitaDTO)
        {
            try
            {
                var vRegistro = new T_Sgpam_Visita
                {
                    FEC_MODIFICA = vVisitaDTO.Fec_Modifica,
                    IP_MODIFICA = vVisitaDTO.Ip_Modifica,
                    USU_MODIFICA = vVisitaDTO.Usu_Modifica,
                };
                var vResultado = VisitaAD.ActualizarT_Sgpam_Visita(vRegistro);
                vVisitaDTO = RecuperarVisitaDTOPorCodigo(vResultado.ID_VISITA);
                return vVisitaDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
        
        public int AnularVisitaDTOPorCodigo(VisitaDTO vVisitaDTO)
        {
            try
            {
                return VisitaAD.AnularT_Sgpam_VisitaPorCodigo(0);
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }


        public IEnumerable<VisitaDTO> ListarPaginadoVisitaDTO(string vFiltro, string vNroExpediente, int vTipo, int vCantAnios, int vNumPag, int vCantRegxPag)
        {
            try
            {
                if (vFiltro == null)
                    vFiltro = "";
                else
                {
                    if (vFiltro.Trim().Length == 0)
                        vFiltro = "";
                }

                IEnumerable<T_Sgpam_Visita> vResultado = VisitaAD.ListarPaginadoT_Sgpam_Visita(vFiltro, vNroExpediente, vTipo, vCantAnios, vNumPag, vCantRegxPag);
                if (vResultado != null)
                {
                    List<VisitaDTO> vLista = new List<VisitaDTO>();
                    VisitaDTO vEntidad;
                    foreach (T_Sgpam_Visita item in vResultado)
                    {
                        vEntidad = new VisitaDTO()
                        {
                            Fecha_Regreso = item.FECHA_REGRESO,
                            Fecha_Salida = item.FECHA_SALIDA,
                            Id_Visita = item.ID_VISITA,
                            Ubigeo = item.UBIGEO,
                            Fec_Ingreso = item.FEC_INGRESO,
                            Flg_Estado = item.FLG_ESTADO,
                            Ip_Ingreso = item.IP_INGRESO,
                            Usu_Ingreso = item.USU_INGRESO
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


        RegistrarVisitaDTO IT_Sgpam_VisitaLN.RecuperarFullVisitaDTOPorCodigo(int vId_Visita)
        {
            try
            {
                RegistrarVisitaDTO vResultado = new RegistrarVisitaDTO
                {
                    Visita = RecuperarVisitaDTOPorCodigo(vId_Visita)//,
                    //CboTipoOperacion = (List<Tipo_OperacionDTO>)Tipo_OperacionLN.ListarTipo_OperacionDTO()
                };
                return vResultado;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
