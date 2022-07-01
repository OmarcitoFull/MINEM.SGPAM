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
    public class T_Sgpad_Visita_PersonaLN : BaseLN, IT_Sgpad_Visita_PersonaLN
    {
        private readonly IT_Sgpad_Visita_PersonaAD Visita_PersonaAD;
        private readonly IT_Sgpal_CargoLN CargoLN;
        public T_Sgpad_Visita_PersonaLN(IT_Sgpad_Visita_PersonaAD vT_Sgpad_Visita_PersonaAD, IT_Sgpal_CargoLN vIT_Sgpal_CargoLN)
        {
            Visita_PersonaAD = vT_Sgpad_Visita_PersonaAD;
            CargoLN = vIT_Sgpal_CargoLN;
        }

        public IEnumerable<Visita_PersonaDTO> ListarVisita_PersonaDTO()
        {
            try
            {
                var vResultado = Visita_PersonaAD.ListarT_Sgpad_Visita_Persona();
                return new List<Visita_PersonaDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Visita_PersonaDTO RecuperarVisita_PersonaDTOPorCodigo(int vId_Visita_Persona)
        {
            try
            {
                var vResultado = Visita_PersonaAD.RecuperarT_Sgpad_Visita_PersonaPorCodigo(vId_Visita_Persona);
                return new Visita_PersonaDTO();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Visita_PersonaDTO GrabarVisita_PersonaDTO(Visita_PersonaDTO vVisita_PersonaDTO)
        {
            try
            {
                if (vVisita_PersonaDTO != null)
                {
                    var vRegistro = new T_Sgpad_Visita_Persona
                    {
                        ID_VISITA_PERSONA = vVisita_PersonaDTO.Id_Visita_Persona,
                        ID_VISITA = vVisita_PersonaDTO.Id_Visita,
                        CONTACTO = vVisita_PersonaDTO.Contacto,
                        CORREO = vVisita_PersonaDTO.Correo,
                        DNI = vVisita_PersonaDTO.Dni,
                        ID_CARGO = vVisita_PersonaDTO.Id_Cargo,
                        NOMBRE_COMPLETO = vVisita_PersonaDTO.Nombre_Completo,
                        USU_INGRESO = vVisita_PersonaDTO.Usu_Ingreso,
                        FEC_INGRESO = vVisita_PersonaDTO.Fec_Ingreso,
                        IP_INGRESO = vVisita_PersonaDTO.Ip_Ingreso,
                        USU_MODIFICA = vVisita_PersonaDTO.Usu_Modifica,
                        FEC_MODIFICA = vVisita_PersonaDTO.Fec_Modifica,
                        IP_MODIFICA = vVisita_PersonaDTO.Ip_Modifica,
                        FLG_ESTADO = vVisita_PersonaDTO.Flg_Estado
                    };
                    if (vVisita_PersonaDTO.Id_Visita_Persona == 0)
                    {
                        var vResultado = Visita_PersonaAD.InsertarT_Sgpad_Visita_Persona(vRegistro);
                        vVisita_PersonaDTO.Id_Visita_Persona = vResultado.ID_VISITA_PERSONA;
                    }
                    else
                    {
                        var vResultado = Visita_PersonaAD.ActualizarT_Sgpad_Visita_Persona(vRegistro);
                        vVisita_PersonaDTO = RecuperarFullVisita_PersonaDTOPorCodigo(vResultado.ID_VISITA_PERSONA).Visita_Persona;
                    }
                }
                return vVisita_PersonaDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public bool AnularVisita_PersonaDTOPorCodigo(Visita_PersonaDTO vVisita_PersonaDTO)
        {
            bool vResult = false;
            try
            {
                if (vVisita_PersonaDTO != null)
                {
                    var vRegistro = new T_Sgpad_Visita_Persona
                    {
                        ID_VISITA_PERSONA = vVisita_PersonaDTO.Id_Visita_Persona,
                        USU_MODIFICA = vVisita_PersonaDTO.Usu_Modifica,
                        FEC_MODIFICA = vVisita_PersonaDTO.Fec_Modifica,
                        IP_MODIFICA = vVisita_PersonaDTO.Ip_Modifica
                    };
                    vResult = Visita_PersonaAD.AnularT_Sgpad_Visita_PersonaPorCodigo(vRegistro) != 0;
                }
                return vResult;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<Visita_PersonaDTO> ListarPaginadoVisita_PersonaDTO(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            try
            {
                var vResultado = Visita_PersonaAD.ListarPaginadoT_Sgpad_Visita_Persona(vFiltro, vNumPag, vCantRegxPag);
                return new List<Visita_PersonaDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<Visita_PersonaDTO> ListarPorIdVisitaVisita_PersonaDTO(int vId_Visita)
        {
            try
            {
                var vResultado = (from vTmp in Visita_PersonaAD.ListarPorIdVisitaT_Sgpad_Visita_Persona(vId_Visita)
                                  select new Visita_PersonaDTO
                                  {
                                      Id_Visita_Persona = vTmp.ID_VISITA_PERSONA,
                                      Id_Visita = vTmp.ID_VISITA,
                                      Id_Cargo = vTmp.ID_VISITA_PERSONA,

                                      Cargo = vTmp.CARGO,
                                      Contacto = vTmp.CONTACTO,
                                      Correo = vTmp.CORREO,
                                      Dni = vTmp.DNI,
                                      Nombre_Completo = vTmp.NOMBRE_COMPLETO,
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

        public RegistrarVisitaPersonaDTO RecuperarFullVisita_PersonaDTOPorCodigo(int vId_Visita_Persona)
        {
            try
            {
                RegistrarVisitaPersonaDTO vResultado = new RegistrarVisitaPersonaDTO
                {
                    Visita_Persona = RecuperarVisita_PersonaDTOPorCodigo(vId_Visita_Persona),
                    CboCargo = (List<CargoDTO>)CargoLN.ListarCargoDTO()
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
