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
    public class T_Sgpal_Cerca_Area_ProtegidaLN : BaseLN, IT_Sgpal_Cerca_Area_ProtegidaLN
    {
        private readonly IT_Sgpal_Cerca_Area_ProtegidaAD Cerca_Area_ProtegidaAD;

        public T_Sgpal_Cerca_Area_ProtegidaLN(IT_Sgpal_Cerca_Area_ProtegidaAD vT_Sgpal_Cerca_Area_ProtegidaAD)
        {
            Cerca_Area_ProtegidaAD = vT_Sgpal_Cerca_Area_ProtegidaAD;
        }

        public IEnumerable<Cerca_Area_ProtegidaDTO> ListarCerca_Area_ProtegidaDTO()
        {
            try
            {
                var vResultado = (from vTmp in Cerca_Area_ProtegidaAD.ListarT_Sgpal_Cerca_Area_Protegida()
                                  select new Cerca_Area_ProtegidaDTO
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
                                      Id_Cerca_Area_Protegida = vTmp.ID_CERCA_AREA_PROTEGIDA
                                  }).ToList();
                return vResultado;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Cerca_Area_ProtegidaDTO RecuperarCerca_Area_ProtegidaDTOPorCodigo(int vId_Cerca_Area_Protegida)
        {
            try
            {
                var vResultado = Cerca_Area_ProtegidaAD.RecuperarT_Sgpal_Cerca_Area_ProtegidaPorCodigo(vId_Cerca_Area_Protegida);
                return new Cerca_Area_ProtegidaDTO();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Cerca_Area_ProtegidaDTO InsertarCerca_Area_ProtegidaDTO(Cerca_Area_ProtegidaDTO vCerca_Area_ProtegidaDTO)
        {
            try
            {
                var vRegistro = new T_Sgpal_Cerca_Area_Protegida();
                var vResultado = Cerca_Area_ProtegidaAD.InsertarT_Sgpal_Cerca_Area_Protegida(vRegistro);
                return vCerca_Area_ProtegidaDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Cerca_Area_ProtegidaDTO ActualizarCerca_Area_ProtegidaDTO(Cerca_Area_ProtegidaDTO vCerca_Area_ProtegidaDTO)
        {
            try
            {
                var vRegistro = new T_Sgpal_Cerca_Area_Protegida();
                var vResultado = Cerca_Area_ProtegidaAD.ActualizarT_Sgpal_Cerca_Area_Protegida(vRegistro);
                return vCerca_Area_ProtegidaDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public int AnularCerca_Area_ProtegidaDTOPorCodigo(Cerca_Area_ProtegidaDTO vCerca_Area_ProtegidaDTO)
        {
            try
            {
                return Cerca_Area_ProtegidaAD.AnularT_Sgpal_Cerca_Area_ProtegidaPorCodigo(0);
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<Cerca_Area_ProtegidaDTO> ListarPaginadoCerca_Area_ProtegidaDTO(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            try
            {
                var vResultado = Cerca_Area_ProtegidaAD.ListarPaginadoT_Sgpal_Cerca_Area_Protegida(vFiltro, vNumPag, vCantRegxPag);
                return new List<Cerca_Area_ProtegidaDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
    }
}
