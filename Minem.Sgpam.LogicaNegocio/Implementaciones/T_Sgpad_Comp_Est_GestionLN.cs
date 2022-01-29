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
    public class T_Sgpad_Comp_Est_GestionLN : BaseLN, IT_Sgpad_Comp_Est_GestionLN
    {
        private readonly IT_Sgpad_Comp_Est_GestionAD Comp_Est_GestionAD;

        public T_Sgpad_Comp_Est_GestionLN(IT_Sgpad_Comp_Est_GestionAD vT_Sgpad_Comp_Est_GestionAD)
        {
            Comp_Est_GestionAD = vT_Sgpad_Comp_Est_GestionAD;
        }

        public IEnumerable<Comp_Est_GestionDTO> ListarComp_Est_GestionDTO(int vIdComponente)
        {
            try
            {
                var vResultado = (from vTmp in Comp_Est_GestionAD.ListarT_Sgpad_Comp_Est_Gestion(vIdComponente)
                                  select new Comp_Est_GestionDTO
                                  {
                                      Id_Componente = vTmp.ID_COMPONENTE,
                                      Fec_Ingreso = vTmp.FEC_INGRESO,
                                      Flg_Estado = vTmp.FLG_ESTADO,
                                      Ip_Ingreso = vTmp.IP_INGRESO,
                                      Usu_Ingreso = vTmp.USU_INGRESO,
                                      Fecha = vTmp.FECHA,
                                      Fec_Modifica = vTmp.FEC_MODIFICA,
                                      Id_Comp_Est_Gestion = vTmp.ID_COMP_EST_GESTION,
                                      Id_Estado_Gestion = vTmp.ID_ESTADO_GESTION,
                                      Ip_Modifica = vTmp.IP_MODIFICA,
                                      Sustento = vTmp.SUSTENTO,
                                      Usu_Modifica = vTmp.USU_MODIFICA,
                                      Descripcion = vTmp.DESCRIPCION
                                  }).ToList();
                return vResultado;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Comp_Est_GestionDTO RecuperarComp_Est_GestionDTOPorCodigo(int vId_Comp_Est_Gestion)
        {
            try
            {
                var vResultado = Comp_Est_GestionAD.RecuperarT_Sgpad_Comp_Est_GestionPorCodigo(vId_Comp_Est_Gestion);
                return new Comp_Est_GestionDTO();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Comp_Est_GestionDTO GrabarComp_Est_GestionDTO(Comp_Est_GestionDTO vComp_Est_GestionDTO)
        {
            try
            {
                if (vComp_Est_GestionDTO != null)
                {
                    var vRegistro = new T_Sgpad_Comp_Est_Gestion
                    {
                        FEC_INGRESO = vComp_Est_GestionDTO.Fec_Ingreso,
                        FEC_MODIFICA = vComp_Est_GestionDTO.Fec_Modifica,
                        FLG_ESTADO = vComp_Est_GestionDTO.Flg_Estado,
                        IP_INGRESO = vComp_Est_GestionDTO.Ip_Ingreso,
                        IP_MODIFICA = vComp_Est_GestionDTO.Ip_Modifica,
                        USU_INGRESO = vComp_Est_GestionDTO.Usu_Ingreso,
                        USU_MODIFICA = vComp_Est_GestionDTO.Usu_Modifica,
                        FECHA = vComp_Est_GestionDTO.Fecha,
                        ID_COMPONENTE = vComp_Est_GestionDTO.Id_Componente,
                        ID_COMP_EST_GESTION = vComp_Est_GestionDTO.Id_Comp_Est_Gestion,
                        ID_ESTADO_GESTION = vComp_Est_GestionDTO.Id_Estado_Gestion,
                        SUSTENTO = vComp_Est_GestionDTO.Sustento
                    };
                    if (vComp_Est_GestionDTO.Id_Comp_Est_Gestion == 0)
                    {
                        var vResultado = Comp_Est_GestionAD.InsertarT_Sgpad_Comp_Est_Gestion(vRegistro);
                        vComp_Est_GestionDTO.Id_Comp_Est_Gestion = vResultado.ID_COMP_EST_GESTION;
                    }
                    else
                    {
                        var vResultado = Comp_Est_GestionAD.ActualizarT_Sgpad_Comp_Est_Gestion(vRegistro);
                        vComp_Est_GestionDTO = RecuperarComp_Est_GestionDTOPorCodigo(vResultado.ID_COMP_EST_GESTION);
                    }
                }
                return vComp_Est_GestionDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Comp_Est_GestionDTO ActualizarComp_Est_GestionDTO(Comp_Est_GestionDTO vComp_Est_GestionDTO)
        {
            try
            {
                var vRegistro = new T_Sgpad_Comp_Est_Gestion();
                return vComp_Est_GestionDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public int AnularComp_Est_GestionDTOPorCodigo(Comp_Est_GestionDTO vComp_Est_GestionDTO)
        {
            try
            {
                return Comp_Est_GestionAD.AnularT_Sgpad_Comp_Est_GestionPorCodigo(0);
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<Comp_Est_GestionDTO> ListarPaginadoComp_Est_GestionDTO(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            try
            {
                var vResultado = Comp_Est_GestionAD.ListarPaginadoT_Sgpad_Comp_Est_Gestion(vFiltro, vNumPag, vCantRegxPag);
                return new List<Comp_Est_GestionDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
    }
}
