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
    /// Objetivo:	Clase que genera las operaciones para la tabla T_SGPAL_INSPECTOR
    /// Creado Por:	Mateo Salvador Paucar
    /// Fecha Creación:	20/02/2022
    /// </summary>
    public partial class T_Sgpal_InspectorAD : BaseAD, IT_Sgpal_InspectorAD
    {
        public T_Sgpal_InspectorAD(IConfiguration vConfiguration)
        {
            CnnString = vConfiguration.GetSection(Constantes.BD).Value;
        }

        public IEnumerable<T_Sgpal_Inspector> ListarT_Sgpal_Inspector()
        {
            List<T_Sgpal_Inspector> vLista = new List<T_Sgpal_Inspector>();
            T_Sgpal_Inspector vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_INSPECTOR.USP_LIS_INSPECTOR", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpal_Inspector(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public T_Sgpal_Inspector RecuperarT_Sgpal_InspectorPorCodigo(int vId_Inspector)
        {
            throw new NotImplementedException();
        }

        public T_Sgpal_Inspector InsertarT_Sgpal_Inspector(T_Sgpal_Inspector vT_Sgpal_Inspector)
        {
            throw new NotImplementedException();
        }

        public T_Sgpal_Inspector ActualizarT_Sgpal_Inspector(T_Sgpal_Inspector vT_Sgpal_Inspector)
        {
            throw new NotImplementedException();
        }

        public int AnularT_Sgpal_InspectorPorCodigo(int vId_Inspector)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T_Sgpal_Inspector> ListarPaginadoT_Sgpal_Inspector(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            throw new NotImplementedException();
        }

    }
}
