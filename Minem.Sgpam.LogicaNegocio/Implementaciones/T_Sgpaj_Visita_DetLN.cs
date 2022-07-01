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
    public class T_Sgpaj_Visita_DetLN : BaseLN, IT_Sgpaj_Visita_DetLN
    {
        private readonly IT_Sgpaj_Visita_DetAD Visita_DetAD;

        public T_Sgpaj_Visita_DetLN(IT_Sgpaj_Visita_DetAD vT_Sgpaj_Visita_DetAD)
        {
            Visita_DetAD = vT_Sgpaj_Visita_DetAD;
        }

        public IEnumerable<Visita_DetDTO> ListarVisita_DetDTO()
        {
            try
            {
                var vResultado = Visita_DetAD.ListarT_Sgpaj_Visita_Det();
                return new List<Visita_DetDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Visita_DetDTO RecuperarVisita_DetDTOPorCodigo(int vId_Visita_Det)
        {
            try
            {
                var vResultado = Visita_DetAD.RecuperarT_Sgpaj_Visita_DetPorCodigo(vId_Visita_Det);
                return new Visita_DetDTO();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Visita_DetDTO GrabarVisita_DetDTO(Visita_DetDTO vVisita_DetDTO)
        {
            try
            {
                if (vVisita_DetDTO != null)
                {
                    var vRegistro = new T_Sgpaj_Visita_Det
                    {
                        FEC_INGRESO = vVisita_DetDTO.Fec_Ingreso,
                        FEC_MODIFICA = vVisita_DetDTO.Fec_Modifica,
                        FLG_ESTADO = vVisita_DetDTO.Flg_Estado,
                        IP_INGRESO = vVisita_DetDTO.Ip_Ingreso,
                        IP_MODIFICA = vVisita_DetDTO.Ip_Modifica,
                        USU_INGRESO = vVisita_DetDTO.Usu_Ingreso,
                        USU_MODIFICA = vVisita_DetDTO.Usu_Modifica,
                        ID_EXPEDIENTE = vVisita_DetDTO.Id_Expediente,
                        ID_EUM = vVisita_DetDTO.Id_Eum,
                        ID_TIPO_REGISTRO = vVisita_DetDTO.Id_Tipo_Registro,
                        ID_VISITA = vVisita_DetDTO.Id_Visita,
                        ID_VISITA_DET = vVisita_DetDTO.Id_Visita_Det,
                        MOTIVO = vVisita_DetDTO.Motivo,
                        OBSERVACION = vVisita_DetDTO.Observacion
                    };
                    if (vVisita_DetDTO.Id_Visita_Det == 0)
                    {
                        var vResultado = Visita_DetAD.InsertarT_Sgpaj_Visita_Det(vRegistro);
                        vVisita_DetDTO.Id_Visita_Det = vResultado.ID_VISITA_DET;
                    }
                    else
                    {
                        var vResultado = Visita_DetAD.ActualizarT_Sgpaj_Visita_Det(vRegistro);
                        vVisita_DetDTO = RecuperarFullVisita_DetDTOPorCodigo(vResultado.ID_VISITA_DET).Visita_Det;
                    }
                }
                return vVisita_DetDTO;
            }

            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public bool AnularVisita_DetDTOPorCodigo(Visita_DetDTO vVisita_DetDTO)
        {
            bool vResult = false;
            try
            {
                if (vVisita_DetDTO != null)
                {
                    var vRegistro = new T_Sgpaj_Visita_Det
                    {
                        ID_VISITA_DET = vVisita_DetDTO.Id_Visita_Det,
                        USU_MODIFICA = vVisita_DetDTO.Usu_Modifica,
                        FEC_MODIFICA = vVisita_DetDTO.Fec_Modifica,
                        IP_MODIFICA = vVisita_DetDTO.Ip_Modifica
                    };
                    vResult = Visita_DetAD.AnularT_Sgpaj_Visita_DetPorCodigo(vRegistro) != 0;
                }
                return vResult;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<Visita_DetDTO> ListarPaginadoVisita_DetDTO(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            try
            {
                var vResultado = Visita_DetAD.ListarPaginadoT_Sgpaj_Visita_Det(vFiltro, vNumPag, vCantRegxPag);
                return new List<Visita_DetDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<Visita_DetDTO> ListarPorIdVisitaVisita_DetDTO(int vId_Visita)
        {
            try
            {
                IEnumerable<T_Sgpaj_Visita_Det> vResultado = Visita_DetAD.ListarPorIdVisitaT_Sgpaj_Visita_Det(vId_Visita);
                if (vResultado != null)
                {
                    List<Visita_DetDTO> vLista = new List<Visita_DetDTO>();
                    Visita_DetDTO vEntidad;
                    foreach (T_Sgpaj_Visita_Det item in vResultado)
                    {
                        vEntidad = new Visita_DetDTO()
                        {
                            Id_Visita_Det = item.ID_VISITA_DET,
                            Id_Visita = item.ID_VISITA,
                            Id_Tipo_Registro = item.ID_TIPO_REGISTRO,
                            Id_Eum = item.ID_EUM,
                            Id_Expediente = item.ID_EXPEDIENTE,
                            Motivo = item.MOTIVO,
                            Observacion = item.OBSERVACION,
                            Usu_Ingreso = item.USU_INGRESO,
                            Fec_Ingreso = item.FEC_INGRESO,
                            Ip_Ingreso = item.IP_INGRESO,
                            Flg_Estado = item.FLG_ESTADO,
                            Tipo_Registro = item.ID_EUM == null ? "Expediente" : "EUM",
                            Nro_Expediente = item.NRO_EXPEDIENTE,
                            Nombre_Eum = item.NOMBRE_EUM
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

        public RegistrarVisitaDetDTO RecuperarFullVisita_DetDTOPorCodigo(int vId_Visita_Det)
        {
            try
            {
                RegistrarVisitaDetDTO vResultado = new RegistrarVisitaDetDTO
                {
                    Visita_Det = RecuperarVisita_DetDTOPorCodigo(vId_Visita_Det)//,
                    //CboTipoClima = (List<Tipo_ClimaDTO>)Tipo_ClimaLN.ListarTipo_ClimaDTO(),
                    //CboInspector = (List<InspectorDTO>)InspectorLN.ListarInspectorDTO()
                };
                return vResultado;
            }
            catch (Exception)
            {

                throw;
            }
            throw new NotImplementedException();

        }

    }
}
