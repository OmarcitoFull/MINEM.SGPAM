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
    public class T_Sgpad_Comp_ReconocimientoLN : BaseLN, IT_Sgpad_Comp_ReconocimientoLN
    {
        private readonly IT_Sgpad_Comp_ReconocimientoAD Comp_ReconocimientoAD;

        public T_Sgpad_Comp_ReconocimientoLN(IT_Sgpad_Comp_ReconocimientoAD vT_Sgpad_Comp_ReconocimientoAD)
        {
            Comp_ReconocimientoAD = vT_Sgpad_Comp_ReconocimientoAD;
        }

        public IEnumerable<Comp_ReconocimientoDTO> ListarComp_ReconocimientoDTO(int vIdComponente)
        {
            try
            {
                var vResultado = (from vTmp in Comp_ReconocimientoAD.ListarT_Sgpad_Comp_Reconocimiento(vIdComponente)
                                  select new Comp_ReconocimientoDTO
                                  {
                                      Descripcion = vTmp.DESCRIPCION,
                                      Fec_Ingreso = vTmp.FEC_INGRESO,
                                      Fec_Modifica = vTmp.FEC_MODIFICA,
                                      Flg_Estado = vTmp.FLG_ESTADO,
                                      Ip_Ingreso = vTmp.IP_INGRESO,
                                      Ip_Modifica = vTmp.IP_MODIFICA,
                                      Usu_Ingreso = vTmp.USU_INGRESO,
                                      Usu_Modifica = vTmp.USU_MODIFICA,
                                      Id_Componente = vTmp.ID_COMPONENTE,
                                      Altura = vTmp.ALTURA,
                                      Ancho = vTmp.ANCHO,
                                      Area = vTmp.AREA,
                                      Base = vTmp.BASE,
                                      Cantidad = vTmp.CANTIDAD,
                                      Id_Comp_Reconocimiento = vTmp.ID_COMP_RECONOCIMIENTO,
                                      Id_Tipo_Mineria = vTmp.ID_TIPO_MINERIA,
                                      Id_Tipo_Reconocimiento = vTmp.ID_TIPO_RECONOCIMIENTO,
                                      Largo = vTmp.LARGO,
                                      Profundidad = vTmp.PROFUNDIDAD,
                                      Volumen = vTmp.VOLUMEN
                                  }).ToList();
                return vResultado;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Comp_ReconocimientoDTO RecuperarComp_ReconocimientoDTOPorCodigo(int vId_Comp_Reconocimiento)
        {
            try
            {
                var vRegistro = Comp_ReconocimientoAD.RecuperarT_Sgpad_Comp_ReconocimientoPorCodigo(vId_Comp_Reconocimiento);

                if (vRegistro != null)
                {
                    var vResultado = new Comp_ReconocimientoDTO
                    {
                        Fec_Ingreso = vRegistro.FEC_INGRESO,
                        Fec_Modifica = vRegistro.FEC_MODIFICA,
                        Flg_Estado = vRegistro.FLG_ESTADO,
                        Ip_Ingreso = vRegistro.IP_INGRESO,
                        Ip_Modifica = vRegistro.IP_MODIFICA,
                        Usu_Ingreso = vRegistro.USU_INGRESO,
                        Usu_Modifica = vRegistro.USU_MODIFICA,
                        Id_Componente = vRegistro.ID_COMPONENTE,
                        Altura = vRegistro.ALTURA,
                        Ancho = vRegistro.ANCHO,
                        Area = vRegistro.AREA,
                        Base = vRegistro.BASE,
                        Cantidad = vRegistro.CANTIDAD,
                        Id_Comp_Reconocimiento = vRegistro.ID_COMP_RECONOCIMIENTO,
                        Id_Tipo_Mineria = vRegistro.ID_TIPO_MINERIA,
                        Id_Tipo_Reconocimiento = vRegistro.ID_TIPO_RECONOCIMIENTO,
                        Largo = vRegistro.LARGO,
                        Profundidad = vRegistro.PROFUNDIDAD,
                        Volumen = vRegistro.VOLUMEN
                    };
                    return vResultado;
                }
                return new Comp_ReconocimientoDTO();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Comp_ReconocimientoDTO GrabarComp_ReconocimientoDTO(Comp_ReconocimientoDTO vComp_ReconocimientoDTO)
        {
            try
            {
                if (vComp_ReconocimientoDTO != null)
                {
                    if (vComp_ReconocimientoDTO.Id_Componente > 0 && vComp_ReconocimientoDTO.Id_Tipo_Reconocimiento > 0)
                    {
                        var vRegistro = new T_Sgpad_Comp_Reconocimiento
                        {
                            FEC_INGRESO = vComp_ReconocimientoDTO.Fec_Ingreso,
                            FEC_MODIFICA = vComp_ReconocimientoDTO.Fec_Modifica,
                            FLG_ESTADO = vComp_ReconocimientoDTO.Flg_Estado,
                            IP_INGRESO = vComp_ReconocimientoDTO.Ip_Ingreso,
                            IP_MODIFICA = vComp_ReconocimientoDTO.Ip_Modifica,
                            USU_INGRESO = vComp_ReconocimientoDTO.Usu_Ingreso,
                            USU_MODIFICA = vComp_ReconocimientoDTO.Usu_Modifica,
                            ID_COMPONENTE = vComp_ReconocimientoDTO.Id_Componente,
                            ALTURA = vComp_ReconocimientoDTO.Altura,
                            ANCHO = vComp_ReconocimientoDTO.Ancho,
                            AREA = vComp_ReconocimientoDTO.Area,
                            BASE = vComp_ReconocimientoDTO.Base,
                            CANTIDAD = vComp_ReconocimientoDTO.Cantidad,
                            ID_TIPO_MINERIA = vComp_ReconocimientoDTO.Id_Tipo_Mineria,
                            ID_TIPO_RECONOCIMIENTO = vComp_ReconocimientoDTO.Id_Tipo_Reconocimiento,
                            ID_COMP_RECONOCIMIENTO = vComp_ReconocimientoDTO.Id_Comp_Reconocimiento,
                            LARGO = vComp_ReconocimientoDTO.Largo,
                            PROFUNDIDAD = vComp_ReconocimientoDTO.Profundidad,
                            VOLUMEN = vComp_ReconocimientoDTO.Volumen
                        };
                        if (vComp_ReconocimientoDTO.Id_Comp_Reconocimiento == 0)
                        {
                            var vResultado = Comp_ReconocimientoAD.InsertarT_Sgpad_Comp_Reconocimiento(vRegistro);
                            vComp_ReconocimientoDTO.Id_Comp_Reconocimiento = vResultado.ID_COMP_RECONOCIMIENTO;
                        }
                        else
                        {
                            var vResultado = Comp_ReconocimientoAD.ActualizarT_Sgpad_Comp_Reconocimiento(vRegistro);
                            vComp_ReconocimientoDTO = RecuperarComp_ReconocimientoDTOPorCodigo(vResultado.ID_COMP_RECONOCIMIENTO);
                        }
                    }
                    return vComp_ReconocimientoDTO;
                }
                return vComp_ReconocimientoDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public int AnularComp_ReconocimientoDTOPorCodigo(Comp_ReconocimientoDTO vComp_ReconocimientoDTO)
        {
            try
            {
                return Comp_ReconocimientoAD.AnularT_Sgpad_Comp_ReconocimientoPorCodigo(0);
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<Comp_ReconocimientoDTO> ListarPaginadoComp_ReconocimientoDTO(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            try
            {
                var vResultado = Comp_ReconocimientoAD.ListarPaginadoT_Sgpad_Comp_Reconocimiento(vFiltro, vNumPag, vCantRegxPag);
                return new List<Comp_ReconocimientoDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public int Insertar_Reconocimiento_Tipo(Comp_ReconocimientoDTO vComp_ReconocimientoDTO)
        {
            try
            {
                int vResult = 0;
                if (vComp_ReconocimientoDTO != null)
                {
                    if (vComp_ReconocimientoDTO.Id_Componente > 0 && vComp_ReconocimientoDTO.Id_Tipo_Pam > 0)
                    {
                        var vRegistro = new T_Sgpad_Comp_Reconocimiento
                        {
                            ID_COMPONENTE = vComp_ReconocimientoDTO.Id_Componente,
                            ID_TIPO_MINERIA = vComp_ReconocimientoDTO.Id_Tipo_Mineria,
                            USU_INGRESO = vComp_ReconocimientoDTO.Usu_Ingreso,
                            IP_INGRESO = vComp_ReconocimientoDTO.Ip_Ingreso,
                            FEC_INGRESO = vComp_ReconocimientoDTO.Fec_Ingreso,
                            USU_MODIFICA = vComp_ReconocimientoDTO.Usu_Modifica,
                            IP_MODIFICA = vComp_ReconocimientoDTO.Ip_Modifica,
                            FEC_MODIFICA = vComp_ReconocimientoDTO.Fec_Modifica,
                        };

                        vResult = Comp_ReconocimientoAD.InsertarT_Sgpad_Comp_Reconocimiento_Tipo(vRegistro, vComp_ReconocimientoDTO.Id_Tipo_Pam);
                    }
                    return vResult;
                }
                return vResult;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
    }
}
