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
    public class T_Sgpal_CargoLN : BaseLN, IT_Sgpal_CargoLN
    {
        private readonly IT_Sgpal_CargoAD CargoAD;

        public T_Sgpal_CargoLN(IT_Sgpal_CargoAD vT_Sgpal_CargoAD)
        {
            CargoAD = vT_Sgpal_CargoAD;
        }

        public IEnumerable<CargoDTO> ListarCargoDTO()
        {
            try
            {
                var vResultado = (from vTmp in CargoAD.ListarT_Sgpal_Cargo()
                                  select new CargoDTO
                                  {
                                      Descripcion = vTmp.DESCRIPCION,
                                      Fec_Ingreso = vTmp.FEC_INGRESO,
                                      Fec_Modifica = vTmp.FEC_MODIFICA,
                                      Flg_Estado = vTmp.FLG_ESTADO,
                                      Id_Cargo = vTmp.ID_CARGO,
                                      Ip_Ingreso = vTmp.IP_INGRESO,
                                      Ip_Modifica = vTmp.IP_MODIFICA,
                                      Usu_Ingreso = vTmp.USU_INGRESO,
                                      Usu_Modifica = vTmp.USU_MODIFICA
                                  }).ToList();
                return vResultado;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public CargoDTO RecuperarCargoDTOPorCodigo(int vId_Cargo)
        {
            try
            {
                var vResultado = CargoAD.RecuperarT_Sgpal_CargoPorCodigo(vId_Cargo);
                return new CargoDTO();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public CargoDTO InsertarCargoDTO(CargoDTO vCargoDTO)
        {
            try
            {
                var vRegistro = new T_Sgpal_Cargo();
                var vResultado = CargoAD.InsertarT_Sgpal_Cargo(vRegistro);
                return vCargoDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public CargoDTO ActualizarCargoDTO(CargoDTO vCargoDTO)
        {
            try
            {
                var vRegistro = new T_Sgpal_Cargo();
                var vResultado = CargoAD.ActualizarT_Sgpal_Cargo(vRegistro);
                return vCargoDTO;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public int AnularCargoDTOPorCodigo(CargoDTO vCargoDTO)
        {
            try
            {
                return CargoAD.AnularT_Sgpal_CargoPorCodigo(0);
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

        public IEnumerable<CargoDTO> ListarPaginadoCargoDTO(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            try
            {
                var vResultado = CargoAD.ListarPaginadoT_Sgpal_Cargo(vFiltro, vNumPag, vCantRegxPag);
                return new List<CargoDTO>();
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }

    }
}
