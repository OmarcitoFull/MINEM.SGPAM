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
    public class T_Sgpal_Sub_Tipo_LnrLN : BaseLN, IT_Sgpal_Sub_Tipo_LnrLN
    {
        private readonly IT_Sgpal_Sub_Tipo_LnrAD Sub_Tipo_LnrAD;

        public T_Sgpal_Sub_Tipo_LnrLN(IT_Sgpal_Sub_Tipo_LnrAD vT_Sgpal_Sub_Tipo_LnrAD)
        {
            Sub_Tipo_LnrAD = vT_Sgpal_Sub_Tipo_LnrAD;
        }

        public IEnumerable<Sub_Tipo_LnrDTO> ListarSub_Tipo_LnrDTO()
        {
            try
            {
                IEnumerable<T_Sgpal_Sub_Tipo_Lnr> vResultado = Sub_Tipo_LnrAD.ListarT_Sgpal_Sub_Tipo_Lnr();
                if (vResultado != null)
                {
                    List<Sub_Tipo_LnrDTO> vLista = new List<Sub_Tipo_LnrDTO>();
                    Sub_Tipo_LnrDTO vEntidad;
                    foreach (T_Sgpal_Sub_Tipo_Lnr item in vResultado)
                    {
                        vEntidad = new Sub_Tipo_LnrDTO()
                        {
                            Fec_Ingreso = item.FEC_INGRESO,
                            Flg_Estado = item.FLG_ESTADO,
                            Ip_Ingreso = item.IP_INGRESO,
                            Usu_Ingreso = item.USU_INGRESO,
                            Descripcion = item.DESCRIPCION,
                            Id_Tipo_Lnr = item.ID_TIPO_LNR,
                            Id_Sub_Tipo_Lnr = item.ID_SUB_TIPO_LNR
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

        public Sub_Tipo_LnrDTO RecuperarSub_Tipo_LnrDTOPorCodigo(int vId_Sub_Tipo_Lnr)
        {
            try
            {
                var vResultado = Sub_Tipo_LnrAD.RecuperarT_Sgpal_Sub_Tipo_LnrPorCodigo(vId_Sub_Tipo_Lnr);
                return new Sub_Tipo_LnrDTO();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Sub_Tipo_LnrDTO InsertarSub_Tipo_LnrDTO(Sub_Tipo_LnrDTO vSub_Tipo_LnrDTO)
        {
            try
            {
                var vRegistro = new T_Sgpal_Sub_Tipo_Lnr();
                var vResultado = Sub_Tipo_LnrAD.InsertarT_Sgpal_Sub_Tipo_Lnr(vRegistro);
                return vSub_Tipo_LnrDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Sub_Tipo_LnrDTO ActualizarSub_Tipo_LnrDTO(Sub_Tipo_LnrDTO vSub_Tipo_LnrDTO)
        {
            try
            {
                var vRegistro = new T_Sgpal_Sub_Tipo_Lnr();
                var vResultado = Sub_Tipo_LnrAD.ActualizarT_Sgpal_Sub_Tipo_Lnr(vRegistro);
                return vSub_Tipo_LnrDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
        
        public int AnularSub_Tipo_LnrDTOPorCodigo(Sub_Tipo_LnrDTO vSub_Tipo_LnrDTO)
        {
            try
            {
                return Sub_Tipo_LnrAD.AnularT_Sgpal_Sub_Tipo_LnrPorCodigo(0);
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<Sub_Tipo_LnrDTO> ListarPaginadoSub_Tipo_LnrDTO(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            try
            {
                var vResultado = Sub_Tipo_LnrAD.ListarPaginadoT_Sgpal_Sub_Tipo_Lnr(vFiltro, vNumPag, vCantRegxPag);
                return new List<Sub_Tipo_LnrDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
    }
}
