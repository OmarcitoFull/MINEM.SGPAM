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
    public class T_Sgpal_Vegetacion_InvasivaLN : BaseLN, IT_Sgpal_Vegetacion_InvasivaLN
    {
        private readonly IT_Sgpal_Vegetacion_InvasivaAD Vegetacion_InvasivaAD;

        public T_Sgpal_Vegetacion_InvasivaLN(IT_Sgpal_Vegetacion_InvasivaAD vT_Sgpal_Vegetacion_InvasivaAD)
        {
            Vegetacion_InvasivaAD = vT_Sgpal_Vegetacion_InvasivaAD;
        }

        public IEnumerable<Vegetacion_InvasivaDTO> ListarVegetacion_InvasivaDTO()
        {
            try
            {
                var vResultado = (from vTmp in Vegetacion_InvasivaAD.ListarT_Sgpal_Vegetacion_Invasiva()
                                  select new Vegetacion_InvasivaDTO
                                  {
                                      Descripcion = vTmp.DESCRIPCION,
                                      Fec_Ingreso = vTmp.FEC_INGRESO,
                                      Fec_Modifica = vTmp.FEC_MODIFICA,
                                      Flg_Estado = vTmp.FLG_ESTADO,
                                      Ip_Ingreso = vTmp.IP_INGRESO,
                                      Ip_Modifica = vTmp.IP_MODIFICA,
                                      Usu_Ingreso = vTmp.USU_INGRESO,
                                      Usu_Modifica = vTmp.USU_MODIFICA,
                                      Peso_I = vTmp.PESO_I,
                                      Peso_Rm = vTmp.PESO_RM,
                                      Peso_Pq = vTmp.PESO_PQ,
                                      Peso_Orm = vTmp.PESO_ORM,
                                      Peso_Lb = vTmp.PESO_LB,
                                      Id_Vegetacion_Invasiva = vTmp.ID_VEGETACION_INVASIVA
                                  }).ToList();
                return vResultado;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Vegetacion_InvasivaDTO RecuperarVegetacion_InvasivaDTOPorCodigo(int vId_Vegetacion_Invasiva)
        {
            try
            {
                var vResultado = Vegetacion_InvasivaAD.RecuperarT_Sgpal_Vegetacion_InvasivaPorCodigo(vId_Vegetacion_Invasiva);
                return new Vegetacion_InvasivaDTO();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Vegetacion_InvasivaDTO InsertarVegetacion_InvasivaDTO(Vegetacion_InvasivaDTO vVegetacion_InvasivaDTO)
        {
            try
            {
                var vRegistro = new T_Sgpal_Vegetacion_Invasiva();
                var vResultado = Vegetacion_InvasivaAD.InsertarT_Sgpal_Vegetacion_Invasiva(vRegistro);
                return vVegetacion_InvasivaDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Vegetacion_InvasivaDTO ActualizarVegetacion_InvasivaDTO(Vegetacion_InvasivaDTO vVegetacion_InvasivaDTO)
        {
            try
            {
                var vRegistro = new T_Sgpal_Vegetacion_Invasiva();
                var vResultado = Vegetacion_InvasivaAD.ActualizarT_Sgpal_Vegetacion_Invasiva(vRegistro);
                return vVegetacion_InvasivaDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public int AnularVegetacion_InvasivaDTOPorCodigo(Vegetacion_InvasivaDTO vVegetacion_InvasivaDTO)
        {
            try
            {
                return Vegetacion_InvasivaAD.AnularT_Sgpal_Vegetacion_InvasivaPorCodigo(0);
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<Vegetacion_InvasivaDTO> ListarPaginadoVegetacion_InvasivaDTO(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            try
            {
                var vResultado = Vegetacion_InvasivaAD.ListarPaginadoT_Sgpal_Vegetacion_Invasiva(vFiltro, vNumPag, vCantRegxPag);
                return new List<Vegetacion_InvasivaDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
    }
}
