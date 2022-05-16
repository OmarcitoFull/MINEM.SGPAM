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
    public class T_Sgpal_Tipo_LnrLN : BaseLN, IT_Sgpal_Tipo_LnrLN
    {
        private readonly IT_Sgpal_Tipo_LnrAD Tipo_LnrAD;

        public T_Sgpal_Tipo_LnrLN(IT_Sgpal_Tipo_LnrAD vT_Sgpal_Tipo_LnrAD)
        {
            Tipo_LnrAD = vT_Sgpal_Tipo_LnrAD;
        }

        public IEnumerable<Tipo_LnrDTO> ListarTipo_LnrDTO()
        {
            try
            {
                IEnumerable<T_Sgpal_Tipo_Lnr> vResultado = Tipo_LnrAD.ListarT_Sgpal_Tipo_Lnr();
                if (vResultado != null)
                {
                    List<Tipo_LnrDTO> vLista = new List<Tipo_LnrDTO>();
                    Tipo_LnrDTO vEntidad;
                    foreach (T_Sgpal_Tipo_Lnr item in vResultado)
                    {
                        vEntidad = new Tipo_LnrDTO()
                        {
                            Fec_Ingreso = item.FEC_INGRESO,
                            Flg_Estado = item.FLG_ESTADO,
                            Ip_Ingreso = item.IP_INGRESO,
                            Usu_Ingreso = item.USU_INGRESO,
                            Descripcion = item.DESCRIPCION,
                            Id_Tipo_Lnr = item.ID_TIPO_LNR
                        };
                        vLista.Add(vEntidad);
                    }
                    return vLista;
                }
                return null;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Tipo_LnrDTO RecuperarTipo_LnrDTOPorCodigo(int vId_Tipo_Lnr)
        {
            try
            {
                var vResultado = Tipo_LnrAD.RecuperarT_Sgpal_Tipo_LnrPorCodigo(vId_Tipo_Lnr);
                return new Tipo_LnrDTO();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Tipo_LnrDTO InsertarTipo_LnrDTO(Tipo_LnrDTO vTipo_LnrDTO)
        {
            try
            {
                var vRegistro = new T_Sgpal_Tipo_Lnr();
                var vResultado = Tipo_LnrAD.InsertarT_Sgpal_Tipo_Lnr(vRegistro);
                return vTipo_LnrDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Tipo_LnrDTO ActualizarTipo_LnrDTO(Tipo_LnrDTO vTipo_LnrDTO)
        {
            try
            {
                var vRegistro = new T_Sgpal_Tipo_Lnr();
                var vResultado = Tipo_LnrAD.ActualizarT_Sgpal_Tipo_Lnr(vRegistro);
                return vTipo_LnrDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
        
        public int AnularTipo_LnrDTOPorCodigo(Tipo_LnrDTO vTipo_LnrDTO)
        {
            try
            {
                return Tipo_LnrAD.AnularT_Sgpal_Tipo_LnrPorCodigo(0);
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<Tipo_LnrDTO> ListarPaginadoTipo_LnrDTO(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            try
            {
                var vResultado = Tipo_LnrAD.ListarPaginadoT_Sgpal_Tipo_Lnr(vFiltro, vNumPag, vCantRegxPag);
                return new List<Tipo_LnrDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
    }
}
