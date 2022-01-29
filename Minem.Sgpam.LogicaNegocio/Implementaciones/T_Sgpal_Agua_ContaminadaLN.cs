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
    public class T_Sgpal_Agua_ContaminadaLN : BaseLN, IT_Sgpal_Agua_ContaminadaLN
    {
        private readonly IT_Sgpal_Agua_ContaminadaAD Agua_ContaminadaAD;

        public T_Sgpal_Agua_ContaminadaLN(IT_Sgpal_Agua_ContaminadaAD vT_Sgpal_Agua_ContaminadaAD)
        {
            Agua_ContaminadaAD = vT_Sgpal_Agua_ContaminadaAD;
        }

        public IEnumerable<Agua_ContaminadaDTO> ListarAgua_ContaminadaDTO()
        {
            try
            {
                var vResultado = (from vTmp in Agua_ContaminadaAD.ListarT_Sgpal_Agua_Contaminada()
                                  select new Agua_ContaminadaDTO
                                  {
                                      Descripcion = vTmp.DESCRIPCION,
                                      Fec_Ingreso = vTmp.FEC_INGRESO,
                                      Fec_Modifica = vTmp.FEC_MODIFICA,
                                      Flg_Estado = vTmp.FLG_ESTADO,
                                      Ip_Ingreso = vTmp.IP_INGRESO,
                                      Ip_Modifica = vTmp.IP_MODIFICA,
                                      Usu_Ingreso = vTmp.USU_INGRESO,
                                      Usu_Modifica = vTmp.USU_MODIFICA,
                                      Id_Agua_Contaminada = vTmp.ID_AGUA_CONTAMINADA,
                                      Peso_I = vTmp.PESO_I,
                                      Peso_Rm = vTmp.PESO_RM,
                                      Peso_Pq = vTmp.PESO_PQ,
                                      Peso_Orm = vTmp.PESO_ORM,
                                      Peso_Lb = vTmp.PESO_LB
                                  }).ToList();
                return vResultado;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Agua_ContaminadaDTO RecuperarAgua_ContaminadaDTOPorCodigo(int vId_Agua_Contaminada)
        {
            try
            {
                var vResultado = Agua_ContaminadaAD.RecuperarT_Sgpal_Agua_ContaminadaPorCodigo(vId_Agua_Contaminada);
                return new Agua_ContaminadaDTO();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Agua_ContaminadaDTO InsertarAgua_ContaminadaDTO(Agua_ContaminadaDTO vAgua_ContaminadaDTO)
        {
            try
            {
                var vRegistro = new T_Sgpal_Agua_Contaminada();
                var vResultado = Agua_ContaminadaAD.InsertarT_Sgpal_Agua_Contaminada(vRegistro);
                return vAgua_ContaminadaDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Agua_ContaminadaDTO ActualizarAgua_ContaminadaDTO(Agua_ContaminadaDTO vAgua_ContaminadaDTO)
        {
            try
            {
                var vRegistro = new T_Sgpal_Agua_Contaminada();
                var vResultado = Agua_ContaminadaAD.ActualizarT_Sgpal_Agua_Contaminada(vRegistro);
                return vAgua_ContaminadaDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public int AnularAgua_ContaminadaDTOPorCodigo(Agua_ContaminadaDTO vAgua_ContaminadaDTO)
        {
            try
            {
                return Agua_ContaminadaAD.AnularT_Sgpal_Agua_ContaminadaPorCodigo(0);
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<Agua_ContaminadaDTO> ListarPaginadoAgua_ContaminadaDTO(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            try
            {
                var vResultado = Agua_ContaminadaAD.ListarPaginadoT_Sgpal_Agua_Contaminada(vFiltro, vNumPag, vCantRegxPag);
                return new List<Agua_ContaminadaDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
    }
}
