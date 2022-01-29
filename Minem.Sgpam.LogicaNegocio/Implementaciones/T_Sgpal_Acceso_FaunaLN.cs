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
    public class T_Sgpal_Acceso_FaunaLN : BaseLN, IT_Sgpal_Acceso_FaunaLN
    {
        private readonly IT_Sgpal_Acceso_FaunaAD Acceso_FaunaAD;

        public T_Sgpal_Acceso_FaunaLN(IT_Sgpal_Acceso_FaunaAD vT_Sgpal_Acceso_FaunaAD)
        {
            Acceso_FaunaAD = vT_Sgpal_Acceso_FaunaAD;
        }

        public IEnumerable<Acceso_FaunaDTO> ListarAcceso_FaunaDTO()
        {
            try
            {
                var vResultado = (from vTmp in Acceso_FaunaAD.ListarT_Sgpal_Acceso_Fauna()
                                  select new Acceso_FaunaDTO
                                  {
                                      Descripcion = vTmp.DESCRIPCION,
                                      Fec_Ingreso = vTmp.FEC_INGRESO,
                                      Fec_Modifica = vTmp.FEC_MODIFICA,
                                      Flg_Estado = vTmp.FLG_ESTADO,
                                      Ip_Ingreso = vTmp.IP_INGRESO,
                                      Ip_Modifica = vTmp.IP_MODIFICA,
                                      Usu_Ingreso = vTmp.USU_INGRESO,
                                      Usu_Modifica = vTmp.USU_MODIFICA,
                                      Id_Acceso_Fauna = vTmp.ID_ACCESO_FAUNA,
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

        public Acceso_FaunaDTO RecuperarAcceso_FaunaDTOPorCodigo(int vId_Acceso_Fauna)
        {
            try
            {
                var vResultado = Acceso_FaunaAD.RecuperarT_Sgpal_Acceso_FaunaPorCodigo(vId_Acceso_Fauna);
                return new Acceso_FaunaDTO();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Acceso_FaunaDTO InsertarAcceso_FaunaDTO(Acceso_FaunaDTO vAcceso_FaunaDTO)
        {
            try
            {
                var vRegistro = new T_Sgpal_Acceso_Fauna();
                var vResultado = Acceso_FaunaAD.InsertarT_Sgpal_Acceso_Fauna(vRegistro);
                return vAcceso_FaunaDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Acceso_FaunaDTO ActualizarAcceso_FaunaDTO(Acceso_FaunaDTO vAcceso_FaunaDTO)
        {
            try
            {
                var vRegistro = new T_Sgpal_Acceso_Fauna();
                var vResultado = Acceso_FaunaAD.ActualizarT_Sgpal_Acceso_Fauna(vRegistro);
                return vAcceso_FaunaDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public int AnularAcceso_FaunaDTOPorCodigo(Acceso_FaunaDTO vAcceso_FaunaDTO)
        {
            try
            {
                return Acceso_FaunaAD.AnularT_Sgpal_Acceso_FaunaPorCodigo(0);
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<Acceso_FaunaDTO> ListarPaginadoAcceso_FaunaDTO(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            try
            {
                var vResultado = Acceso_FaunaAD.ListarPaginadoT_Sgpal_Acceso_Fauna(vFiltro, vNumPag, vCantRegxPag);
                return new List<Acceso_FaunaDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
    }
}
