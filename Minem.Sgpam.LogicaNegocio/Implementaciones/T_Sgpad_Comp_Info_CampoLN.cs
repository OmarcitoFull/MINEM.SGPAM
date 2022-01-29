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
    public class T_Sgpad_Comp_Info_CampoLN : BaseLN, IT_Sgpad_Comp_Info_CampoLN
    {
        private readonly IT_Sgpad_Comp_Info_CampoAD Comp_Info_CampoAD;

        public T_Sgpad_Comp_Info_CampoLN(IT_Sgpad_Comp_Info_CampoAD vT_Sgpad_Comp_Info_CampoAD)
        {
            Comp_Info_CampoAD = vT_Sgpad_Comp_Info_CampoAD;
        }

        public IEnumerable<Comp_Info_CampoDTO> ListarComp_Info_CampoDTO(int vIdComponente)
        {
            try
            {
                var vResultado = (from vTmp in Comp_Info_CampoAD.ListarT_Sgpad_Comp_Info_Campo(vIdComponente)
                                  select new Comp_Info_CampoDTO
                                  {
                                      Id_Componente = vTmp.ID_COMPONENTE,
                                      Fec_Ingreso = vTmp.FEC_INGRESO,
                                      Flg_Estado = vTmp.FLG_ESTADO,
                                      Ip_Ingreso = vTmp.IP_INGRESO,
                                      Usu_Ingreso = vTmp.USU_INGRESO,
                                      Fec_Modifica = vTmp.FEC_MODIFICA,
                                      Ip_Modifica = vTmp.IP_MODIFICA,
                                      Usu_Modifica = vTmp.USU_MODIFICA,
                                      Fecha_Informe = vTmp.FECHA_INFORME,
                                      Id_Comp_Info_Campo = vTmp.ID_COMP_INFO_CAMPO,
                                      Nro_Informe = vTmp.NRO_INFORME
                                  }).ToList();
                return vResultado;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Comp_Info_CampoDTO RecuperarComp_Info_CampoDTOPorCodigo(int vId_Comp_Info_Campo)
        {
            try
            {
                var vResultado = Comp_Info_CampoAD.RecuperarT_Sgpad_Comp_Info_CampoPorCodigo(vId_Comp_Info_Campo);
                return new Comp_Info_CampoDTO();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Comp_Info_CampoDTO GrabarComp_Info_CampoDTO(Comp_Info_CampoDTO vComp_Info_CampoDTO)
        {
            try
            {
                if (vComp_Info_CampoDTO != null)
                {
                    var vRegistro = new T_Sgpad_Comp_Info_Campo
                    {
                        FEC_INGRESO = vComp_Info_CampoDTO.Fec_Ingreso,
                        FEC_MODIFICA = vComp_Info_CampoDTO.Fec_Modifica,
                        FLG_ESTADO = vComp_Info_CampoDTO.Flg_Estado,
                        IP_INGRESO = vComp_Info_CampoDTO.Ip_Ingreso,
                        IP_MODIFICA = vComp_Info_CampoDTO.Ip_Modifica,
                        USU_INGRESO = vComp_Info_CampoDTO.Usu_Ingreso,
                        USU_MODIFICA = vComp_Info_CampoDTO.Usu_Modifica,
                        ID_COMPONENTE = vComp_Info_CampoDTO.Id_Componente,
                        FECHA_INFORME = vComp_Info_CampoDTO.Fecha_Informe,
                        ID_COMP_INFO_CAMPO = vComp_Info_CampoDTO.Id_Comp_Info_Campo,
                        NRO_INFORME = vComp_Info_CampoDTO.Nro_Informe
                    };
                    if (vComp_Info_CampoDTO.Id_Comp_Info_Campo == 0)
                    {
                        var vResultado = Comp_Info_CampoAD.InsertarT_Sgpad_Comp_Info_Campo(vRegistro);
                        vComp_Info_CampoDTO.Id_Comp_Info_Campo = vResultado.ID_COMP_INFO_CAMPO;
                    }
                    else
                    {
                        var vResultado = Comp_Info_CampoAD.ActualizarT_Sgpad_Comp_Info_Campo(vRegistro);
                        vComp_Info_CampoDTO = RecuperarComp_Info_CampoDTOPorCodigo(vResultado.ID_COMP_INFO_CAMPO);
                    }
                }
                return vComp_Info_CampoDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public int AnularComp_Info_CampoDTOPorCodigo(Comp_Info_CampoDTO vComp_Info_CampoDTO)
        {
            try
            {
                return Comp_Info_CampoAD.AnularT_Sgpad_Comp_Info_CampoPorCodigo(0);
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<Comp_Info_CampoDTO> ListarPaginadoComp_Info_CampoDTO(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            try
            {
                var vResultado = Comp_Info_CampoAD.ListarPaginadoT_Sgpad_Comp_Info_Campo(vFiltro, vNumPag, vCantRegxPag);
                return new List<Comp_Info_CampoDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
    }
}
