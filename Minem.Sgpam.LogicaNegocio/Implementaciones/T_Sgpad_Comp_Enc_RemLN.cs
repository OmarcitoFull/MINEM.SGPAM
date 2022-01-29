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
    public class T_Sgpad_Comp_Enc_RemLN : BaseLN, IT_Sgpad_Comp_Enc_RemLN
    {
        private readonly IT_Sgpad_Comp_Enc_RemAD Comp_Enc_RemAD;
        private readonly IT_Sgpal_Tipo_EncargoLN Tipo_EncargoLN;
        private readonly IT_Sgpal_Tipo_ResolucionLN Tipo_ResolucionLN;
        

        public T_Sgpad_Comp_Enc_RemLN(IT_Sgpad_Comp_Enc_RemAD vT_Sgpad_Comp_Enc_RemAD, IT_Sgpal_Tipo_EncargoLN vIT_Sgpal_Tipo_EncargoLN, IT_Sgpal_Tipo_ResolucionLN vIT_Sgpal_Tipo_ResolucionLN)
        {
            Comp_Enc_RemAD = vT_Sgpad_Comp_Enc_RemAD;
            Tipo_EncargoLN = vIT_Sgpal_Tipo_EncargoLN;
            Tipo_ResolucionLN = vIT_Sgpal_Tipo_ResolucionLN;
        }

        public IEnumerable<Comp_Enc_RemDTO> ListarComp_Enc_RemDTO(int vIdComponente)
        {
            try
            {
                var vResultado = (from vTmp in Comp_Enc_RemAD.ListarT_Sgpad_Comp_Enc_Rem(vIdComponente)
                                  select new Comp_Enc_RemDTO
                                  {
                                      Id_Componente = vTmp.ID_COMPONENTE,
                                      Fec_Ingreso = vTmp.FEC_INGRESO,
                                      Flg_Estado = vTmp.FLG_ESTADO,
                                      Ip_Ingreso = vTmp.IP_INGRESO,
                                      Usu_Ingreso = vTmp.USU_INGRESO,
                                      Fec_Modifica = vTmp.FEC_MODIFICA,
                                      Ip_Modifica = vTmp.IP_MODIFICA,
                                      Usu_Modifica = vTmp.USU_MODIFICA,
                                      Id_Comp_Enc_Rem = vTmp.ID_COMP_ENC_REM,
                                      Nro_Remediacion = vTmp.NRO_REMEDIACION,
                                      Resolucion_Exc_Enc = vTmp.RESOLUCION_EXC_ENC,
                                      Anio_Resolucion = vTmp.ANIO_RESOLUCION,
                                      Id_Tipo_Encargo = vTmp.ID_TIPO_ENCARGO,
                                      Id_Tipo_Resolucion = vTmp.ID_TIPO_RESOLUCION,
                                      Responsable_Remediacion = vTmp.RESPONSABLE_REMEDIACION
                                  }).ToList();
                return vResultado;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Comp_Enc_RemDTO RecuperarComp_Enc_RemDTOPorCodigo(int vId_Comp_Enc_Rem)
        {
            try
            {
                if (vId_Comp_Enc_Rem > 0)
                {
                    var vRegistro = Comp_Enc_RemAD.RecuperarT_Sgpad_Comp_Enc_RemPorCodigo(vId_Comp_Enc_Rem);
                    if (vRegistro != null)
                    {
                        var vResultado = new Comp_Enc_RemDTO
                        {
                            Fec_Ingreso = vRegistro.FEC_INGRESO,
                            Fec_Modifica = vRegistro.FEC_MODIFICA,
                            Flg_Estado = vRegistro.FLG_ESTADO,
                            Ip_Ingreso = vRegistro.IP_INGRESO,
                            Ip_Modifica = vRegistro.IP_MODIFICA,
                            Usu_Ingreso = vRegistro.USU_INGRESO,
                            Usu_Modifica = vRegistro.USU_MODIFICA,
                            Id_Componente = vRegistro.ID_COMPONENTE,
                            Anio_Resolucion = vRegistro.ANIO_RESOLUCION,
                            Id_Comp_Enc_Rem = vRegistro.ID_COMP_ENC_REM,
                            Id_Tipo_Encargo = vRegistro.ID_TIPO_ENCARGO,
                            Id_Tipo_Resolucion = vRegistro.ID_TIPO_RESOLUCION,
                            Nro_Remediacion = vRegistro.NRO_REMEDIACION,
                            Resolucion_Exc_Enc = vRegistro.RESOLUCION_EXC_ENC,
                            Responsable_Remediacion = vRegistro.RESPONSABLE_REMEDIACION
                        };
                        return vResultado;
                    }
                    return null;
                }
                else
                {
                    var vResultado = new Comp_Enc_RemDTO
                    {
                        CboTipoEncargo = Tipo_EncargoLN.ListarTipo_EncargoDTO().ToList(),
                        CboTipoResolucion = Tipo_ResolucionLN.ListarTipo_ResolucionDTO().ToList()

                    };
                    return vResultado;
                }
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Comp_Enc_RemDTO GrabarComp_Enc_RemDTO(Comp_Enc_RemDTO vComp_Enc_RemDTO)
        {
            try
            {
                if (vComp_Enc_RemDTO != null)
                {
                    var vRegistro = new T_Sgpad_Comp_Enc_Rem
                    {
                        FEC_INGRESO = vComp_Enc_RemDTO.Fec_Ingreso,
                        FEC_MODIFICA = vComp_Enc_RemDTO.Fec_Modifica,
                        FLG_ESTADO = vComp_Enc_RemDTO.Flg_Estado,
                        IP_INGRESO = vComp_Enc_RemDTO.Ip_Ingreso,
                        IP_MODIFICA = vComp_Enc_RemDTO.Ip_Modifica,
                        USU_INGRESO = vComp_Enc_RemDTO.Usu_Ingreso,
                        USU_MODIFICA = vComp_Enc_RemDTO.Usu_Modifica,
                        ID_COMPONENTE = vComp_Enc_RemDTO.Id_Componente,
                        ID_COMP_ENC_REM = vComp_Enc_RemDTO.Id_Comp_Enc_Rem,
                        NRO_REMEDIACION = vComp_Enc_RemDTO.Nro_Remediacion,
                        RESOLUCION_EXC_ENC = vComp_Enc_RemDTO.Resolucion_Exc_Enc,
                        ANIO_RESOLUCION = vComp_Enc_RemDTO.Anio_Resolucion,
                        RESPONSABLE_REMEDIACION = vComp_Enc_RemDTO.Responsable_Remediacion,
                        ID_TIPO_RESOLUCION = vComp_Enc_RemDTO.Id_Tipo_Resolucion,
                        ID_TIPO_ENCARGO = vComp_Enc_RemDTO.Id_Tipo_Encargo
                    };
                    if (vComp_Enc_RemDTO.Id_Comp_Enc_Rem == 0)
                    {
                        var vResultado = Comp_Enc_RemAD.InsertarT_Sgpad_Comp_Enc_Rem(vRegistro);
                        vComp_Enc_RemDTO.Id_Comp_Enc_Rem = vResultado.ID_COMP_ENC_REM;
                    }
                    else
                    {
                        var vResultado = Comp_Enc_RemAD.ActualizarT_Sgpad_Comp_Enc_Rem(vRegistro);
                        vComp_Enc_RemDTO = RecuperarComp_Enc_RemDTOPorCodigo(vResultado.ID_COMP_ENC_REM);
                    }
                }
                return vComp_Enc_RemDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public int AnularComp_Enc_RemDTOPorCodigo(Comp_Enc_RemDTO vComp_Enc_RemDTO)
        {
            try
            {
                return Comp_Enc_RemAD.AnularT_Sgpad_Comp_Enc_RemPorCodigo(0);
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<Comp_Enc_RemDTO> ListarPaginadoComp_Enc_RemDTO(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            try
            {
                var vResultado = Comp_Enc_RemAD.ListarPaginadoT_Sgpad_Comp_Enc_Rem(vFiltro, vNumPag, vCantRegxPag);
                return new List<Comp_Enc_RemDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
    }
}
