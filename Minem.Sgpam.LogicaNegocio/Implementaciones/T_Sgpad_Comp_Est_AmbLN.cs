using System;
using System.Collections.Generic;
using System.Linq;
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
    public class T_Sgpad_Comp_Est_AmbLN : BaseLN, IT_Sgpad_Comp_Est_AmbLN
    {
        private readonly IT_Sgpad_Comp_Est_AmbAD Comp_Est_AmbAD;

        public T_Sgpad_Comp_Est_AmbLN(IT_Sgpad_Comp_Est_AmbAD vT_Sgpad_Comp_Est_AmbAD)
        {
            Comp_Est_AmbAD = vT_Sgpad_Comp_Est_AmbAD;
        }

        public IEnumerable<Comp_Est_AmbDTO> ListarComp_Est_AmbDTO(int vIdComponente)
        {
            try
            {
                var vResultado = (from vTmp in Comp_Est_AmbAD.ListarT_Sgpad_Comp_Est_Amb(vIdComponente)
                                  select new Comp_Est_AmbDTO
                                  {
                                      Fec_Ingreso = vTmp.FEC_INGRESO,
                                      Fec_Modifica = vTmp.FEC_MODIFICA,
                                      Flg_Estado = vTmp.FLG_ESTADO,
                                      Ip_Ingreso = vTmp.IP_INGRESO,
                                      Ip_Modifica = vTmp.IP_MODIFICA,
                                      Usu_Ingreso = vTmp.USU_INGRESO,
                                      Usu_Modifica = vTmp.USU_MODIFICA,
                                      Id_Componente = vTmp.ID_COMPONENTE,
                                      Des_Nom_Proyecto = vTmp.DES_NOM_PROYECTO,
                                      Des_Nom_Titular = vTmp.DES_NOM_TITULAR,
                                      Des_Situacion = vTmp.DES_SITUACION,
                                      Des_Und_Ambiental = vTmp.DES_UND_AMBIENTAL,
                                      Fec_Expediente = vTmp.FEC_EXPEDIENTE,
                                      Fec_Resolucion = vTmp.FEC_RESOLUCION,
                                      Id_Comp_Est_Amb = vTmp.ID_COMP_EST_AMB,
                                      Nro_Expediente = vTmp.NRO_EXPEDIENTE,
                                      Res_Aprobacion = vTmp.RES_APROBACION,
                                      Tipo_Estudio = vTmp.TIPO_ESTUDIO,
                                      Extension = vTmp.EXTENCION,
                                      Nombre_Documento = vTmp.NOMBRE_DOCUMENTO,
                                      Ruta_Documento = vTmp.RUTA_DOCUMENTO,
                                      Tamano = vTmp.TAMANO
                                  }).ToList();
                return vResultado;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Comp_Est_AmbDTO RecuperarComp_Est_AmbDTOPorCodigo(int vId_Comp_Est_Amb)
        {
            try
            {
                var vRegistro = Comp_Est_AmbAD.RecuperarT_Sgpad_Comp_Est_AmbPorCodigo(vId_Comp_Est_Amb);
                if (vRegistro != null)
                {
                    var vResultado = new Comp_Est_AmbDTO
                    {
                        Fec_Ingreso = vRegistro.FEC_INGRESO,
                        Fec_Modifica = vRegistro.FEC_MODIFICA,
                        Flg_Estado = vRegistro.FLG_ESTADO,
                        Ip_Ingreso = vRegistro.IP_INGRESO,
                        Ip_Modifica = vRegistro.IP_MODIFICA,
                        Usu_Ingreso = vRegistro.USU_INGRESO,
                        Usu_Modifica = vRegistro.USU_MODIFICA,
                        Id_Componente = vRegistro.ID_COMPONENTE,
                        Des_Nom_Proyecto = vRegistro.DES_NOM_PROYECTO,
                        Des_Nom_Titular = vRegistro.DES_NOM_TITULAR,
                        Des_Situacion = vRegistro.DES_SITUACION,
                        Des_Und_Ambiental = vRegistro.DES_UND_AMBIENTAL,
                        Fec_Expediente = vRegistro.FEC_EXPEDIENTE,
                        Fec_Resolucion = vRegistro.FEC_RESOLUCION,
                        Id_Comp_Est_Amb = vRegistro.ID_COMP_EST_AMB,
                        Nro_Expediente = vRegistro.NRO_EXPEDIENTE,
                        Res_Aprobacion = vRegistro.RES_APROBACION,
                        Tipo_Estudio = vRegistro.TIPO_ESTUDIO,
                        Extension = vRegistro.EXTENCION,
                        Nombre_Documento = vRegistro.NOMBRE_DOCUMENTO,
                        Ruta_Documento = vRegistro.RUTA_DOCUMENTO,
                        Tamano = vRegistro.TAMANO
                    };
                    return vResultado;
                }
                return new Comp_Est_AmbDTO();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Comp_Est_AmbDTO GrabarComp_Est_AmbDTO(Comp_Est_AmbDTO vComp_Est_AmbDTO)
        {
            try
            {
                if (vComp_Est_AmbDTO != null)
                {
                    var vRegistro = new T_Sgpad_Comp_Est_Amb
                    {
                        FEC_INGRESO = vComp_Est_AmbDTO.Fec_Ingreso,
                        FEC_MODIFICA = vComp_Est_AmbDTO.Fec_Modifica,
                        FLG_ESTADO = vComp_Est_AmbDTO.Flg_Estado,
                        IP_INGRESO = vComp_Est_AmbDTO.Ip_Ingreso,
                        IP_MODIFICA = vComp_Est_AmbDTO.Ip_Modifica,
                        USU_INGRESO = vComp_Est_AmbDTO.Usu_Ingreso,
                        USU_MODIFICA = vComp_Est_AmbDTO.Usu_Modifica,
                        ID_COMPONENTE = vComp_Est_AmbDTO.Id_Componente,
                        DES_NOM_PROYECTO = vComp_Est_AmbDTO.Des_Nom_Proyecto,
                        DES_NOM_TITULAR = vComp_Est_AmbDTO.Des_Nom_Titular,
                        DES_SITUACION = vComp_Est_AmbDTO.Des_Situacion,
                        DES_UND_AMBIENTAL = vComp_Est_AmbDTO.Des_Und_Ambiental,
                        FEC_EXPEDIENTE = vComp_Est_AmbDTO.Fec_Expediente,
                        FEC_RESOLUCION = vComp_Est_AmbDTO.Fec_Resolucion,
                        ID_COMP_EST_AMB = vComp_Est_AmbDTO.Id_Comp_Est_Amb,
                        NRO_EXPEDIENTE = vComp_Est_AmbDTO.Nro_Expediente,
                        RES_APROBACION = vComp_Est_AmbDTO.Res_Aprobacion,
                        TIPO_ESTUDIO = vComp_Est_AmbDTO.Tipo_Estudio,
                        EXTENCION = vComp_Est_AmbDTO.Extension,
                        TAMANO = vComp_Est_AmbDTO.Tamano,
                        RUTA_DOCUMENTO = vComp_Est_AmbDTO.Ruta_Documento,
                        NOMBRE_DOCUMENTO = vComp_Est_AmbDTO.Nombre_Documento
                    };
                    if (vComp_Est_AmbDTO.Id_Comp_Est_Amb == 0)
                    {
                        var vResultado = Comp_Est_AmbAD.InsertarT_Sgpad_Comp_Est_Amb(vRegistro);
                        vComp_Est_AmbDTO.Id_Comp_Est_Amb = vResultado.ID_COMP_EST_AMB;
                    }
                    else
                    {
                        var vResultado = Comp_Est_AmbAD.ActualizarT_Sgpad_Comp_Est_Amb(vRegistro);
                        vComp_Est_AmbDTO = RecuperarComp_Est_AmbDTOPorCodigo(vResultado.ID_COMP_EST_AMB);
                    }
                }
                return vComp_Est_AmbDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public int AnularComp_Est_AmbDTOPorCodigo(Comp_Est_AmbDTO vComp_Est_AmbDTO)
        {
            try
            {
                return Comp_Est_AmbAD.AnularT_Sgpad_Comp_Est_AmbPorCodigo(0);
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<Comp_Est_AmbDTO> ListarPaginadoComp_Est_AmbDTO(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            try
            {
                var vResultado = Comp_Est_AmbAD.ListarPaginadoT_Sgpad_Comp_Est_Amb(vFiltro, vNumPag, vCantRegxPag);
                return new List<Comp_Est_AmbDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
    }
}
