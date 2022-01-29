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
    public class T_Sgpah_Eum_ModLN : BaseLN, IT_Sgpah_Eum_ModLN
    {
        private readonly IT_Sgpah_Eum_ModAD Eum_ModAD;

        public T_Sgpah_Eum_ModLN(IT_Sgpah_Eum_ModAD vT_Sgpah_Eum_ModAD)
        {
            Eum_ModAD = vT_Sgpah_Eum_ModAD;
        }

        public IEnumerable<Eum_ModDTO> ListarEum_ModDTO()
        {
            try
            {
                var vResultado = Eum_ModAD.ListarT_Sgpah_Eum_Mod();
                return new List<Eum_ModDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Eum_ModDTO RecuperarEum_ModDTOPorCodigo(int vId_Eum_Mod)
        {
            try
            {
                var vResultado = Eum_ModAD.RecuperarT_Sgpah_Eum_ModPorCodigo(vId_Eum_Mod);
                return new Eum_ModDTO();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Eum_ModDTO InsertarEum_ModDTO(Eum_ModDTO vEum_ModDTO)
        {
            try
            {
                if (vEum_ModDTO != null)
                {
                    var vRegistro = new T_Sgpah_Eum_Mod
                    { 
                        CARGO = vEum_ModDTO.Cargo,
                        FEC_INGRESO = vEum_ModDTO.Fec_Ingreso,
                        FLG_ESTADO = vEum_ModDTO.Flg_Estado,
                        ID_EUM = vEum_ModDTO.Id_Eum,
                        ID_EUM_MOD = vEum_ModDTO.Id_Eum_Mod,
                        IP_INGRESO = vEum_ModDTO.Ip_Ingreso,
                        USU_INGRESO = vEum_ModDTO.Usu_Ingreso
                    };
                    var vResultado = Eum_ModAD.InsertarT_Sgpah_Eum_Mod(vRegistro);
                    vEum_ModDTO.Id_Eum_Mod = vResultado.ID_EUM_MOD;

                }
                return vEum_ModDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Eum_ModDTO ActualizarEum_ModDTO(Eum_ModDTO vEum_ModDTO)
        {
            try
            {
                var vRegistro = new T_Sgpah_Eum_Mod();
                var vResultado = Eum_ModAD.ActualizarT_Sgpah_Eum_Mod(vRegistro);
                return vEum_ModDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
        
        public int AnularEum_ModDTOPorCodigo(Eum_ModDTO vEum_ModDTO)
        {
            try
            {
                return Eum_ModAD.AnularT_Sgpah_Eum_ModPorCodigo(0);
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<Eum_ModDTO> ListarPaginadoEum_ModDTO(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            try
            {
                var vResultado = Eum_ModAD.ListarPaginadoT_Sgpah_Eum_Mod(vFiltro, vNumPag, vCantRegxPag);
                return new List<Eum_ModDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<Eum_ModDTO> ListarPorIdEumEum_ModDTO(int vId_Eum)
        {
            try
            {
                IEnumerable<T_Sgpah_Eum_Mod>  vResultado = Eum_ModAD.ListarPorIdEumT_Sgpah_Eum_Mod(vId_Eum);
                if (vResultado != null)
                {
                    List<Eum_ModDTO> vLista = new List<Eum_ModDTO>();  
                    Eum_ModDTO vEntidad; 
                    foreach (T_Sgpah_Eum_Mod item in vResultado)
                    {
                        vEntidad = new Eum_ModDTO()
                        {
                            Cargo = item.CARGO,
                            Fec_Ingreso = item.FEC_INGRESO,
                            Flg_Estado = item.FLG_ESTADO,
                            Id_Eum = item.ID_EUM,
                            Id_Eum_Mod = item.ID_EUM_MOD,
                            Ip_Ingreso = item.IP_INGRESO,
                            Usu_Ingreso = item.USU_INGRESO
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

    }
}
