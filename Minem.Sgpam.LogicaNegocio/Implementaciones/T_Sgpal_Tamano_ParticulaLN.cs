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
    public class T_Sgpal_Tamano_ParticulaLN : BaseLN, IT_Sgpal_Tamano_ParticulaLN
    {
        private readonly IT_Sgpal_Tamano_ParticulaAD Tamano_ParticulaAD;

        public T_Sgpal_Tamano_ParticulaLN(IT_Sgpal_Tamano_ParticulaAD vT_Sgpal_Tamano_ParticulaAD)
        {
            Tamano_ParticulaAD = vT_Sgpal_Tamano_ParticulaAD;
        }

        public IEnumerable<Tamano_ParticulaDTO> ListarTamano_ParticulaDTO()
        {
            try
            {
                var vResultado = (from vTmp in Tamano_ParticulaAD.ListarT_Sgpal_Tamano_Particula()
                                  select new Tamano_ParticulaDTO
                                  {
                                      Descripcion = vTmp.DESCRIPCION,
                                      Fec_Modifica = vTmp.FEC_MODIFICA,
                                      Id_Tamano_Particula = vTmp.ID_TAMANO_PARTICULA,
                                      Ip_Modifica = vTmp.IP_MODIFICA,
                                      Usu_Modifica = vTmp.USU_MODIFICA,
                                      Fec_Ingreso = vTmp.FEC_INGRESO,
                                      Flg_Estado = vTmp.FLG_ESTADO,
                                      Ip_Ingreso = vTmp.IP_INGRESO,
                                      Usu_Ingreso = vTmp.USU_INGRESO
                                  }).ToList();
                return vResultado;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Tamano_ParticulaDTO RecuperarTamano_ParticulaDTOPorCodigo(int vId_Tamano_Particula)
        {
            try
            {
                var vResultado = Tamano_ParticulaAD.RecuperarT_Sgpal_Tamano_ParticulaPorCodigo(vId_Tamano_Particula);
                return new Tamano_ParticulaDTO();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Tamano_ParticulaDTO InsertarTamano_ParticulaDTO(Tamano_ParticulaDTO vTamano_ParticulaDTO)
        {
            try
            {
                var vRegistro = new T_Sgpal_Tamano_Particula();
                var vResultado = Tamano_ParticulaAD.InsertarT_Sgpal_Tamano_Particula(vRegistro);
                return vTamano_ParticulaDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public Tamano_ParticulaDTO ActualizarTamano_ParticulaDTO(Tamano_ParticulaDTO vTamano_ParticulaDTO)
        {
            try
            {
                var vRegistro = new T_Sgpal_Tamano_Particula();
                var vResultado = Tamano_ParticulaAD.ActualizarT_Sgpal_Tamano_Particula(vRegistro);
                return vTamano_ParticulaDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
        
        public int AnularTamano_ParticulaDTOPorCodigo(Tamano_ParticulaDTO vTamano_ParticulaDTO)
        {
            try
            {
                return Tamano_ParticulaAD.AnularT_Sgpal_Tamano_ParticulaPorCodigo(0);
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<Tamano_ParticulaDTO> ListarPaginadoTamano_ParticulaDTO(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            try
            {
                var vResultado = Tamano_ParticulaAD.ListarPaginadoT_Sgpal_Tamano_Particula(vFiltro, vNumPag, vCantRegxPag);
                return new List<Tamano_ParticulaDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
    }
}
