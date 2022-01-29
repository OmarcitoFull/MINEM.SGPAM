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
    public class T_Sgpad_Comp_ComentarioLN : BaseLN, IT_Sgpad_Comp_ComentarioLN
    {
        private readonly IT_Sgpad_Comp_ComentarioAD Comp_ComentarioAD;

        public T_Sgpad_Comp_ComentarioLN(IT_Sgpad_Comp_ComentarioAD vT_Sgpad_Comp_ComentarioAD)
        {
            Comp_ComentarioAD = vT_Sgpad_Comp_ComentarioAD;
        }

        public IEnumerable<Comp_ComentarioDTO> ListarComp_ComentarioDTO(int vIdComponente)
        {
            try
            {
                var vResultado = (from vTmp in Comp_ComentarioAD.ListarT_Sgpad_Comp_Comentario(vIdComponente)
                                  select new Comp_ComentarioDTO
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
                                      Id_Comp_Comentario = vTmp.ID_COMP_COMENTARIO,
                                      Fecha = vTmp.FECHA
                                  }).ToList();
                return vResultado;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Comp_ComentarioDTO RecuperarComp_ComentarioDTOPorCodigo(int vId_Comp_Comentario)
        {
            try
            {
                var vRegistro = Comp_ComentarioAD.RecuperarT_Sgpad_Comp_ComentarioPorCodigo(vId_Comp_Comentario);

                if (vRegistro != null)
                {
                    var vResultado = new Comp_ComentarioDTO
                    {
                        Descripcion = vRegistro.DESCRIPCION,
                        Fec_Ingreso = vRegistro.FEC_INGRESO,
                        Fec_Modifica = vRegistro.FEC_MODIFICA,
                        Flg_Estado = vRegistro.FLG_ESTADO,
                        Ip_Ingreso = vRegistro.IP_INGRESO,
                        Ip_Modifica = vRegistro.IP_MODIFICA,
                        Usu_Ingreso = vRegistro.USU_INGRESO,
                        Usu_Modifica = vRegistro.USU_MODIFICA,
                        Fecha = vRegistro.FECHA,
                        Id_Comp_Comentario = vRegistro.ID_COMP_COMENTARIO,
                        Id_Componente = vRegistro.ID_COMPONENTE
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

        public Comp_ComentarioDTO GrabarComp_ComentarioDTO(Comp_ComentarioDTO vComp_ComentarioDTO)
        {
            try
            {
                if (vComp_ComentarioDTO != null)
                {
                    var vRegistro = new T_Sgpad_Comp_Comentario
                    {
                        DESCRIPCION = vComp_ComentarioDTO.Descripcion,
                        FEC_INGRESO = vComp_ComentarioDTO.Fec_Ingreso,
                        FEC_MODIFICA = vComp_ComentarioDTO.Fec_Modifica,
                        FLG_ESTADO = vComp_ComentarioDTO.Flg_Estado,
                        IP_INGRESO = vComp_ComentarioDTO.Ip_Ingreso,
                        IP_MODIFICA = vComp_ComentarioDTO.Ip_Modifica,
                        USU_INGRESO = vComp_ComentarioDTO.Usu_Ingreso,
                        USU_MODIFICA = vComp_ComentarioDTO.Usu_Modifica,
                        FECHA = vComp_ComentarioDTO.Fecha,
                        ID_COMPONENTE = vComp_ComentarioDTO.Id_Componente,
                        ID_COMP_COMENTARIO = vComp_ComentarioDTO.Id_Comp_Comentario
                    };
                    if (vComp_ComentarioDTO.Id_Comp_Comentario == 0)
                    {
                        var vResultado = Comp_ComentarioAD.InsertarT_Sgpad_Comp_Comentario(vRegistro);
                        vComp_ComentarioDTO.Id_Comp_Comentario = vResultado.ID_COMP_COMENTARIO;
                    }
                    else
                    {
                        var vResultado = Comp_ComentarioAD.ActualizarT_Sgpad_Comp_Comentario(vRegistro);
                        vComp_ComentarioDTO = RecuperarComp_ComentarioDTOPorCodigo(vResultado.ID_COMP_COMENTARIO);
                    }
                }
                return vComp_ComentarioDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public int AnularComp_ComentarioDTOPorCodigo(Comp_ComentarioDTO vComp_ComentarioDTO)
        {
            try
            {
                return Comp_ComentarioAD.AnularT_Sgpad_Comp_ComentarioPorCodigo(0);
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<Comp_ComentarioDTO> ListarPaginadoComp_ComentarioDTO(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            try
            {
                var vResultado = Comp_ComentarioAD.ListarPaginadoT_Sgpad_Comp_Comentario(vFiltro, vNumPag, vCantRegxPag);
                return new List<Comp_ComentarioDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
    }
}
