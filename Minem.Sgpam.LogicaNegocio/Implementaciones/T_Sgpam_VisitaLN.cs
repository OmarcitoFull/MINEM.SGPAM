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
        private readonly IT_Genl_Ubigeo_IneiLN UbigeoLN;
        private readonly IT_Sgpaj_Visita_DetLN Visita_DetLN;
        private readonly IT_Sgpad_Visita_PersonaLN Visita_PersonaLN;


        public T_Sgpam_VisitaLN(
            IT_Sgpam_VisitaAD vT_Sgpam_VisitaAD,
            IT_Genl_Ubigeo_IneiLN vIT_Genl_Ubigeo_IneiLN,
            IT_Sgpaj_Visita_DetLN vIT_Sgpaj_Visita_DetLN,
            IT_Sgpad_Visita_PersonaLN vIT_Sgpad_Visita_PersonaLN
        )
        {
            VisitaAD = vT_Sgpam_VisitaAD;
            UbigeoLN = vIT_Genl_Ubigeo_IneiLN;
            Visita_DetLN = vIT_Sgpaj_Visita_DetLN;
            Visita_PersonaLN = vIT_Sgpad_Visita_PersonaLN;
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
                var vRegistro = VisitaAD.RecuperarT_Sgpam_VisitaPorCodigo(vId_Visita);
                if (vRegistro != null)
                {
                    var vResultado = new VisitaDTO
                    {
                        Fecha_Regreso = vRegistro.FECHA_REGRESO,
                        Fecha_Salida = vRegistro.FECHA_SALIDA,
                        Id_Visita = vRegistro.ID_VISITA,
                        Ubigeo = vRegistro.UBIGEO,
                        Fec_Ingreso = vRegistro.FEC_INGRESO,
                        Fec_Modifica = vRegistro.FEC_MODIFICA,
                        Flg_Estado = vRegistro.FLG_ESTADO,
                        Ip_Ingreso = vRegistro.IP_INGRESO,
                        Ip_Modifica = vRegistro.IP_MODIFICA,
                        Usu_Ingreso = vRegistro.USU_INGRESO,
                        Usu_Modifica = vRegistro.USU_MODIFICA,

                        Id_Distrito = vRegistro.UBIGEO,
                        Id_Provincia = string.IsNullOrEmpty(vRegistro.UBIGEO) ? "" : vRegistro.UBIGEO.Substring(0, 4),
                        Id_Region = string.IsNullOrEmpty(vRegistro.UBIGEO) ? "" : vRegistro.UBIGEO.Substring(0, 2)
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

        public VisitaDTO GrabarVisitaDTO(VisitaDTO vVisitaDTO)
        {
            try
            {
                if (vVisitaDTO.Id_Visita == 0)
                    return InsertarVisitaDTO(vVisitaDTO);
                else
                    return ActualizarVisitaDTO(vVisitaDTO);
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
                var vRegistro = new T_Sgpam_Visita
                {
                    ID_VISITA = vVisitaDTO.Id_Visita,
                    UBIGEO = vVisitaDTO.Ubigeo,
                    FECHA_SALIDA = vVisitaDTO.Fecha_Salida,
                    FECHA_REGRESO = vVisitaDTO.Fecha_Regreso,
                    USU_INGRESO = vVisitaDTO.Usu_Ingreso,
                    FEC_INGRESO = vVisitaDTO.Fec_Ingreso,
                    IP_INGRESO = vVisitaDTO.Ip_Ingreso,
                    FLG_ESTADO = "1"
                };
                var vResultado = VisitaAD.InsertarT_Sgpam_Visita(vRegistro);
                vVisitaDTO = RecuperarVisitaDTOPorCodigo(vResultado.ID_VISITA);

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
                    ID_VISITA = vVisitaDTO.Id_Visita,
                    UBIGEO = vVisitaDTO.Ubigeo,
                    FECHA_SALIDA = vVisitaDTO.Fecha_Salida,
                    FECHA_REGRESO = vVisitaDTO.Fecha_Regreso,
                    USU_MODIFICA = vVisitaDTO.Usu_Modifica,
                    FEC_MODIFICA = vVisitaDTO.Fec_Modifica,
                    IP_MODIFICA = vVisitaDTO.Ip_Modifica,
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
            int vResult = 0;
            try
            {
                if (vVisitaDTO != null)
                {
                    var vRegistro = new T_Sgpam_Visita
                    {
                        ID_VISITA = vVisitaDTO.Id_Visita,
                        USU_MODIFICA = vVisitaDTO.Usu_Modifica,
                        FEC_MODIFICA = vVisitaDTO.Fec_Modifica,
                        IP_MODIFICA = vVisitaDTO.Ip_Modifica
                    };
                    vResult = VisitaAD.AnularT_Sgpam_VisitaPorCodigo(vRegistro); // != 0;
                }
                return vResult;
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
                if (vFiltro == null || vFiltro.Trim().Length == 0)
                    vFiltro = "";
                else
                    vFiltro = vFiltro.ToUpper();

                IEnumerable<T_Sgpam_Visita> vResultado = VisitaAD.ListarPaginadoT_Sgpam_Visita(vFiltro, vNroExpediente, vTipo, vCantAnios, vNumPag, vCantRegxPag);
                if (vResultado != null)
                {
                    List<VisitaDTO> vLista = new List<VisitaDTO>();
                    VisitaDTO vEntidad;
                    foreach (T_Sgpam_Visita item in vResultado)
                    {
                        vEntidad = new VisitaDTO()
                        {
                            //Fecha_Regreso = item.FECHA_REGRESO,
                            Fecha_Salida = item.FECHA_SALIDA,
                            Id_Visita = item.ID_VISITA,
                            Ubigeo = item.UBIGEO,
                            Fec_Ingreso = item.FEC_INGRESO,
                            Flg_Estado = item.FLG_ESTADO,
                            Ip_Ingreso = item.IP_INGRESO,
                            Usu_Ingreso = item.USU_INGRESO,

                            Nro_Expediente = item.NRO_EXPEDIENTE,
                            Nombre_Eum = item.EUM_DESCRIPCION,
                            Declarante = item.DECLARANTE,
                            TiempoSinVisita = item.TIEMPO_SIN_VISITA,
                            Nom_Region = item.DEPARTAMENTO,
                            Nom_Provincia = item.PROVINCIA,
                            Nom_Distrito = item.DISTRITO
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

        public RegistrarVisitaDTO RecuperarFullVisitaDTOPorCodigo(int vId_Visita)
        {
            try
            {
                RegistrarVisitaDTO vResultado = new RegistrarVisitaDTO
                {
                    Visita = RecuperarVisitaDTOPorCodigo(vId_Visita),
                    listaVisitaDet = (List<Visita_DetDTO>)Visita_DetLN.ListarPorIdVisitaVisita_DetDTO(vId_Visita),
                    listaVisitaDetComLnr = new List<Visita_Det_Com_LnrDTO>(),
                    ListaVisitaPersona = (List<Visita_PersonaDTO>)Visita_PersonaLN.ListarPorIdVisitaVisita_PersonaDTO(vId_Visita),
                    CboUbigeo = UbigeoLN.ListarUbigeoDTO().ToList()
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
