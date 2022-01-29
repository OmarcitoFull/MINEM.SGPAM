using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Extensions.Configuration;
using Minem.Sgpam.AccesoDatos.Base;
using Minem.Sgpam.AccesoDatos.Interfaces;
using Minem.Sgpam.Entidades;
using Oracle.ManagedDataAccess.Client;

namespace Minem.Sgpam.AccesoDatos.Implementaciones
{
    /// <summary>
    /// Objetivo:	Clase que genera las operaciones para la tabla T_SGPAD_COMP_DD_MINERO
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	27/10/2021
    /// </summary>
    public partial class T_Sgpad_Comp_Dd_MineroAD: BaseAD, IT_Sgpad_Comp_Dd_MineroAD
    {   
        public IEnumerable<T_Sgpad_Comp_Dd_Minero> ListarT_Sgpad_Comp_Dd_Minero()
        {
           List<T_Sgpad_Comp_Dd_Minero> vLista = new List<T_Sgpad_Comp_Dd_Minero>();
           T_Sgpad_Comp_Dd_Minero vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_DD_MINERO.USP_LIS_COMP_DD_MINERO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpad_Comp_Dd_Minero(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public T_Sgpad_Comp_Dd_Minero RecuperarT_Sgpad_Comp_Dd_MineroPorCodigo(int vId_Comp_Dm)
        {
           T_Sgpad_Comp_Dd_Minero vEntidad = null;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_DD_MINERO.USP_SEL_COMP_DD_MINERO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_COMP_DM", vId_Comp_Dm);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpad_Comp_Dd_Minero(vRdr);
                    }
                }
                vCnn.Close();
            }
            return vEntidad;
        }

        public T_Sgpad_Comp_Dd_Minero InsertarT_Sgpad_Comp_Dd_Minero(T_Sgpad_Comp_Dd_Minero vT_Sgpad_Comp_Dd_Minero)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_DD_MINERO.USP_INS_COMP_DD_MINERO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pCODIGO_DM", vT_Sgpad_Comp_Dd_Minero.CODIGO_DM); 
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpad_Comp_Dd_Minero;
        }
        
        public T_Sgpad_Comp_Dd_Minero ActualizarT_Sgpad_Comp_Dd_Minero(T_Sgpad_Comp_Dd_Minero vT_Sgpad_Comp_Dd_Minero)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_DD_MINERO.USP_UPD_COMP_DD_MINERO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pCODIGO_DM", vT_Sgpad_Comp_Dd_Minero.CODIGO_DM); 
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpad_Comp_Dd_Minero;
        }

        public int AnularT_Sgpad_Comp_Dd_MineroPorCodigo(int vId_Comp_Dm)
        {
            int vResultado = 0;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_DD_MINERO.USP_DEL_COMP_DD_MINERO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_COMP_DM", vId_Comp_Dm);
                    vCnn.Open();
                    vResultado = vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vResultado;
        }

        public IEnumerable<T_Sgpad_Comp_Dd_Minero> ListarPaginadoT_Sgpad_Comp_Dd_Minero(string vFiltro, int vNumPag, int vCantRegxPag)
        {
           List<T_Sgpad_Comp_Dd_Minero> vLista = new List<T_Sgpad_Comp_Dd_Minero>();
           T_Sgpad_Comp_Dd_Minero vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_DD_MINERO.USP_PAG_COMP_DD_MINERO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pFiltro", vFiltro);
                    vCmd.Parameters.Add("pNumPag", vNumPag);
                    vCmd.Parameters.Add("pCantRegxPag", vCantRegxPag);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpad_Comp_Dd_Minero(vRdr);
                        vEntidad.TotalVirtual = System.Convert.ToInt32(vRdr["TotalVirtual"]);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }
    }
}