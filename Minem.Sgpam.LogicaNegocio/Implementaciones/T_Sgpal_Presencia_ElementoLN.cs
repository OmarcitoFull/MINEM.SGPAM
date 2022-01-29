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
    public class T_Sgpal_Presencia_ElementoLN : BaseLN, IT_Sgpal_Presencia_ElementoLN
    {
        private readonly IT_Sgpal_Presencia_ElementoAD Presencia_ElementoAD;

        public T_Sgpal_Presencia_ElementoLN(IT_Sgpal_Presencia_ElementoAD vT_Sgpal_Presencia_ElementoAD)
        {
            Presencia_ElementoAD = vT_Sgpal_Presencia_ElementoAD;
        }

        public IEnumerable<Presencia_ElementoDTO> ListarPresencia_ElementoDTO()
        {
            try
            {
                var vResultado = (from vTmp in Presencia_ElementoAD.ListarT_Sgpal_Presencia_Elemento()
                                  select new Presencia_ElementoDTO
                                  {
                                      Descripcion = vTmp.DESCRIPCION,
                                      Fec_Ingreso = vTmp.FEC_INGRESO,
                                      Fec_Modifica = vTmp.FEC_MODIFICA,
                                      Flg_Estado = vTmp.FLG_ESTADO,
                                      Ip_Ingreso = vTmp.IP_INGRESO,
                                      Ip_Modifica = vTmp.IP_MODIFICA,
                                      Usu_Ingreso = vTmp.USU_INGRESO,
                                      Usu_Modifica = vTmp.USU_MODIFICA,
                                      Id_Presencia_Elemento = vTmp.ID_PRESENCIA_ELEMENTO,
                                      Peso_I = vTmp.PESO_I,
                                      Peso_Lb = vTmp.PESO_LB,
                                      Peso_Orm = vTmp.PESO_ORM,
                                      Peso_Pq = vTmp.PESO_PQ,
                                      Peso_Rm = vTmp.PESO_RM
                                  }).ToList();
                return vResultado;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Presencia_ElementoDTO RecuperarPresencia_ElementoDTOPorCodigo(int vId_Presencia_Elemento)
        {
            try
            {
                var vResultado = Presencia_ElementoAD.RecuperarT_Sgpal_Presencia_ElementoPorCodigo(vId_Presencia_Elemento);
                return new Presencia_ElementoDTO();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Presencia_ElementoDTO InsertarPresencia_ElementoDTO(Presencia_ElementoDTO vPresencia_ElementoDTO)
        {
            try
            {
                var vRegistro = new T_Sgpal_Presencia_Elemento();
                var vResultado = Presencia_ElementoAD.InsertarT_Sgpal_Presencia_Elemento(vRegistro);
                return vPresencia_ElementoDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Presencia_ElementoDTO ActualizarPresencia_ElementoDTO(Presencia_ElementoDTO vPresencia_ElementoDTO)
        {
            try
            {
                var vRegistro = new T_Sgpal_Presencia_Elemento();
                var vResultado = Presencia_ElementoAD.ActualizarT_Sgpal_Presencia_Elemento(vRegistro);
                return vPresencia_ElementoDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public int AnularPresencia_ElementoDTOPorCodigo(Presencia_ElementoDTO vPresencia_ElementoDTO)
        {
            try
            {
                return Presencia_ElementoAD.AnularT_Sgpal_Presencia_ElementoPorCodigo(0);
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<Presencia_ElementoDTO> ListarPaginadoPresencia_ElementoDTO(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            try
            {
                var vResultado = Presencia_ElementoAD.ListarPaginadoT_Sgpal_Presencia_Elemento(vFiltro, vNumPag, vCantRegxPag);
                return new List<Presencia_ElementoDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
    }
}
