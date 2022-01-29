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
    /// Objetivo:	Clase que genera las operaciones para la tabla T_SGPAD_COMP_DM_TITULAR
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	27/10/2021
    /// </summary>
    public partial class T_Sgpad_Comp_Dm_TitularAD: BaseAD, IT_Sgpad_Comp_Dm_TitularAD
    {   
        public IEnumerable<T_Sgpad_Comp_Dm_Titular> ListarT_Sgpad_Comp_Dm_Titular()
        {
           List<T_Sgpad_Comp_Dm_Titular> vLista = new List<T_Sgpad_Comp_Dm_Titular>();
           T_Sgpad_Comp_Dm_Titular vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_DM_TITULAR.USP_LIS_COMP_DM_TITULAR", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpad_Comp_Dm_Titular(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public T_Sgpad_Comp_Dm_Titular RecuperarT_Sgpad_Comp_Dm_TitularPorCodigo(int vId_Comp_Dm_Titular)
        {
           T_Sgpad_Comp_Dm_Titular vEntidad = null;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_DM_TITULAR.USP_SEL_COMP_DM_TITULAR", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_COMP_DM_TITULAR", vId_Comp_Dm_Titular);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpad_Comp_Dm_Titular(vRdr);
                    }
                }
                vCnn.Close();
            }
            return vEntidad;
        }

        public T_Sgpad_Comp_Dm_Titular InsertarT_Sgpad_Comp_Dm_Titular(T_Sgpad_Comp_Dm_Titular vT_Sgpad_Comp_Dm_Titular)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_DM_TITULAR.USP_INS_COMP_DM_TITULAR", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_ESTADO", vT_Sgpad_Comp_Dm_Titular.ID_ESTADO); 
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpad_Comp_Dm_Titular;
        }
        
        public T_Sgpad_Comp_Dm_Titular ActualizarT_Sgpad_Comp_Dm_Titular(T_Sgpad_Comp_Dm_Titular vT_Sgpad_Comp_Dm_Titular)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_DM_TITULAR.USP_UPD_COMP_DM_TITULAR", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_ESTADO", vT_Sgpad_Comp_Dm_Titular.ID_ESTADO); 
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpad_Comp_Dm_Titular;
        }

        public int AnularT_Sgpad_Comp_Dm_TitularPorCodigo(int vId_Comp_Dm_Titular)
        {
            int vResultado = 0;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_DM_TITULAR.USP_DEL_COMP_DM_TITULAR", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_COMP_DM_TITULAR", vId_Comp_Dm_Titular);
                    vCnn.Open();
                    vResultado = vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vResultado;
        }

        public IEnumerable<T_Sgpad_Comp_Dm_Titular> ListarPaginadoT_Sgpad_Comp_Dm_Titular(string vFiltro, int vNumPag, int vCantRegxPag)
        {
           List<T_Sgpad_Comp_Dm_Titular> vLista = new List<T_Sgpad_Comp_Dm_Titular>();
           T_Sgpad_Comp_Dm_Titular vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_DM_TITULAR.USP_PAG_COMP_DM_TITULAR", vCnn))
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
                        vEntidad = new T_Sgpad_Comp_Dm_Titular(vRdr);
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