using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Extensions.Configuration;
using Minem.Sgpam.AccesoDatos.Base;
using Minem.Sgpam.AccesoDatos.Interfaces;
using Minem.Sgpam.Entidades;
using Minem.Sgpam.InfraEstructura;
using Oracle.ManagedDataAccess.Client;

namespace Minem.Sgpam.AccesoDatos.Implementaciones
{
    /// <summary>
    /// Objetivo:	Clase que genera las operaciones para la tabla T_GENL_UBIGEO_INEI
    /// Creado Por:	Mateo Salvador Paucar
    /// Fecha Creación:	31/03/2022
    /// </summary>
    public partial class T_Genl_Ubigeo_IneiAD : BaseAD, IT_Genl_Ubigeo_IneiAD
    {
        public T_Genl_Ubigeo_IneiAD(IConfiguration vConfiguration)
        {
            CnnString = vConfiguration.GetSection(Constantes.BD).Value;
        }

        public IEnumerable<V_Genl_Ubigeo_Inei> ListarT_Genl_Ubigeo_Inei()
        {
            List<V_Genl_Ubigeo_Inei> vLista = new List<V_Genl_Ubigeo_Inei>();
            V_Genl_Ubigeo_Inei vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_UBIGEO_INEI.USP_LIS_UBIGEO_INEI", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new V_Genl_Ubigeo_Inei(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

    }
}
