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
    public class T_Sgpah_Componente_ModLN : BaseLN, IT_Sgpah_Componente_ModLN
    {
        private readonly IT_Sgpah_Componente_ModAD Componente_ModAD;

        public T_Sgpah_Componente_ModLN(IT_Sgpah_Componente_ModAD vT_Sgpah_Componente_ModAD)
        {
            Componente_ModAD = vT_Sgpah_Componente_ModAD;
        }

        public IEnumerable<Componente_ModDTO> ListarComponente_ModDTO(int vIdComponente)
        {
            try
            {
                var vResultado = (from vTmp in Componente_ModAD.ListarT_Sgpah_Componente_Mod(vIdComponente)
                                  select new Componente_ModDTO
                                  {
                                      Cargo = vTmp.CARGO,
                                      Id_Componente = vTmp.ID_COMPONENTE,
                                      Id_Componente_Mod = vTmp.ID_COMPONENTE_MOD,
                                      Fec_Ingreso = vTmp.FEC_INGRESO,
                                      Flg_Estado = vTmp.FLG_ESTADO,
                                      Ip_Ingreso = vTmp.IP_INGRESO,
                                      Usu_Ingreso = vTmp.USU_INGRESO,
                                  }).ToList();
                return vResultado;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Componente_ModDTO RecuperarComponente_ModDTOPorCodigo(int vId_Componente_Mod)
        {
            try
            {
                var vResultado = Componente_ModAD.RecuperarT_Sgpah_Componente_ModPorCodigo(vId_Componente_Mod);
                return new Componente_ModDTO();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Componente_ModDTO GrabarComponente_ModDTO(Componente_ModDTO vComponente_ModDTO)
        {
            try
            {
                if (vComponente_ModDTO != null)
                {
                    var vRegistro = new T_Sgpah_Componente_Mod
                    {
                        FEC_INGRESO = vComponente_ModDTO.Fec_Ingreso,
                        FLG_ESTADO = vComponente_ModDTO.Flg_Estado,
                        IP_INGRESO = vComponente_ModDTO.Ip_Ingreso,
                        USU_INGRESO = vComponente_ModDTO.Usu_Ingreso,
                        ID_COMPONENTE = vComponente_ModDTO.Id_Componente,
                        CARGO = vComponente_ModDTO.Cargo,
                        ID_COMPONENTE_MOD = vComponente_ModDTO.Id_Componente_Mod
                    };
                    if (vComponente_ModDTO.Id_Componente_Mod == 0)
                    {
                        var vResultado = Componente_ModAD.InsertarT_Sgpah_Componente_Mod(vRegistro);
                        vComponente_ModDTO.Id_Componente_Mod = vResultado.ID_COMPONENTE_MOD;
                    }
                    else
                    {
                        var vResultado = Componente_ModAD.ActualizarT_Sgpah_Componente_Mod(vRegistro);
                        vComponente_ModDTO = RecuperarComponente_ModDTOPorCodigo(vResultado.ID_COMPONENTE_MOD);
                    }
                }
                return vComponente_ModDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public int AnularComponente_ModDTOPorCodigo(Componente_ModDTO vComponente_ModDTO)
        {
            try
            {
                return Componente_ModAD.AnularT_Sgpah_Componente_ModPorCodigo(0);
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<Componente_ModDTO> ListarPaginadoComponente_ModDTO(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            try
            {
                var vResultado = Componente_ModAD.ListarPaginadoT_Sgpah_Componente_Mod(vFiltro, vNumPag, vCantRegxPag);
                return new List<Componente_ModDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
    }
}
