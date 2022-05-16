using System;
using System.Linq;
using System.Collections.Generic;
using Minem.Sgpam.AccesoDatos.Interfaces;
using Minem.Sgpam.Entidades;
using Minem.Sgpam.LogicaNegocio.Base;
using Minem.Sgpam.LogicaNegocio.Interfaces;
using Minem.Sgpam.TransporteDatos.DtoEntidades;
using Minem.Sgpam.InfraEstructura;

namespace Minem.Sgpam.LogicaNegocio.Implementaciones
{
    /// <summary>
    /// Objetivo:	Clase que genera las operaciones para la tabla T_GENL_UBIGEO_INEI
    /// Creado Por:	Mateo Salvador Paucar
    /// Fecha Creación:	31/03/2022
    /// </summary>
    public class T_Genl_Ubigeo_IneiLN : BaseLN, IT_Genl_Ubigeo_IneiLN
    {
        private readonly IT_Genl_Ubigeo_IneiAD Ubigeo_IneiAD;

        public T_Genl_Ubigeo_IneiLN(IT_Genl_Ubigeo_IneiAD vT_Genl_Ubigeo_IneiAD) { Ubigeo_IneiAD = vT_Genl_Ubigeo_IneiAD; }

        public IEnumerable<Ubigeo_IneiDTO> ListarUbigeoDTO()
        {
            try
            {
                var vResultado = (from vTmp in Ubigeo_IneiAD.ListarT_Genl_Ubigeo_Inei()
                                  select new Ubigeo_IneiDTO
                                  {
                                      Id_Ubigeo_Inei = vTmp.ID_UBIGEO_INEI,
                                      Departamento = vTmp.DEPARTAMENTO,
                                      Provincia = vTmp.PROVINCIA,
                                      Distrito = vTmp.DISTRITO,
                                      Id_Departamento = vTmp.ID_DEPARTAMENTO,
                                      Id_Distrito = vTmp.ID_DISTRITO,
                                      Id_Provincia = vTmp.ID_PROVINCIA,
                                      Flg_Estado = vTmp.FLG_ESTADO
                                  }).ToList();
                return vResultado;
            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message, ex);
                throw;
            }
        }
    }
}
