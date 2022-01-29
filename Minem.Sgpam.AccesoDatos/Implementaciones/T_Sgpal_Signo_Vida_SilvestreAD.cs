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
    /// Objetivo:	Clase que genera las operaciones para la tabla T_SGPAL_SIGNO_VIDA_SILVESTRE
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	27/10/2021
    /// </summary>
    public partial class T_Sgpal_Signo_Vida_SilvestreAD: BaseAD, IT_Sgpal_Signo_Vida_SilvestreAD
    {   
        public IEnumerable<T_Sgpal_Signo_Vida_Silvestre> ListarT_Sgpal_Signo_Vida_Silvestre()
        {
           List<T_Sgpal_Signo_Vida_Silvestre> vLista = new List<T_Sgpal_Signo_Vida_Silvestre>();
           T_Sgpal_Signo_Vida_Silvestre vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_SIGNO_VIDA_SILVESTRE.USP_LIS_SIGNO_VIDA_SILVESTRE", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpal_Signo_Vida_Silvestre(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public T_Sgpal_Signo_Vida_Silvestre RecuperarT_Sgpal_Signo_Vida_SilvestrePorCodigo(int vId_Signo_Vida_Silvestre)
        {
           T_Sgpal_Signo_Vida_Silvestre vEntidad = null;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_SIGNO_VIDA_SILVESTRE.USP_SEL_SIGNO_VIDA_SILVESTRE", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_SIGNO_VIDA_SILVESTRE", vId_Signo_Vida_Silvestre);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpal_Signo_Vida_Silvestre(vRdr);
                    }
                }
                vCnn.Close();
            }
            return vEntidad;
        }

        public T_Sgpal_Signo_Vida_Silvestre InsertarT_Sgpal_Signo_Vida_Silvestre(T_Sgpal_Signo_Vida_Silvestre vT_Sgpal_Signo_Vida_Silvestre)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_SIGNO_VIDA_SILVESTRE.USP_INS_SIGNO_VIDA_SILVESTRE", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_SIGNO_VIDA_SILVESTRE", vT_Sgpal_Signo_Vida_Silvestre.ID_SIGNO_VIDA_SILVESTRE); 
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpal_Signo_Vida_Silvestre;
        }
        
        public T_Sgpal_Signo_Vida_Silvestre ActualizarT_Sgpal_Signo_Vida_Silvestre(T_Sgpal_Signo_Vida_Silvestre vT_Sgpal_Signo_Vida_Silvestre)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_SIGNO_VIDA_SILVESTRE.USP_UPD_SIGNO_VIDA_SILVESTRE", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_SIGNO_VIDA_SILVESTRE", vT_Sgpal_Signo_Vida_Silvestre.ID_SIGNO_VIDA_SILVESTRE); 
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpal_Signo_Vida_Silvestre;
        }

        public int AnularT_Sgpal_Signo_Vida_SilvestrePorCodigo(int vId_Signo_Vida_Silvestre)
        {
            int vResultado = 0;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_SIGNO_VIDA_SILVESTRE.USP_DEL_SIGNO_VIDA_SILVESTRE", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_SIGNO_VIDA_SILVESTRE", vId_Signo_Vida_Silvestre);
                    vCnn.Open();
                    vResultado = vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vResultado;
        }

        public IEnumerable<T_Sgpal_Signo_Vida_Silvestre> ListarPaginadoT_Sgpal_Signo_Vida_Silvestre(string vFiltro, int vNumPag, int vCantRegxPag)
        {
           List<T_Sgpal_Signo_Vida_Silvestre> vLista = new List<T_Sgpal_Signo_Vida_Silvestre>();
           T_Sgpal_Signo_Vida_Silvestre vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_SIGNO_VIDA_SILVESTRE.USP_PAG_SIGNO_VIDA_SILVESTRE", vCnn))
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
                        vEntidad = new T_Sgpal_Signo_Vida_Silvestre(vRdr);
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