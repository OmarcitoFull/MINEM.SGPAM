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
    /// Objetivo:	Clase que genera las operaciones para la tabla T_SGPAL_TIPO_LNR
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	27/10/2021
    /// </summary>
    public partial class T_Sgpal_Tipo_LnrAD: BaseAD, IT_Sgpal_Tipo_LnrAD
    {   
        public IEnumerable<T_Sgpal_Tipo_Lnr> ListarT_Sgpal_Tipo_Lnr()
        {
           List<T_Sgpal_Tipo_Lnr> vLista = new List<T_Sgpal_Tipo_Lnr>();
           T_Sgpal_Tipo_Lnr vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_TIPO_LNR.USP_LIS_TIPO_LNR", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpal_Tipo_Lnr(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public T_Sgpal_Tipo_Lnr RecuperarT_Sgpal_Tipo_LnrPorCodigo(int vId_Tipo_Lnr)
        {
           T_Sgpal_Tipo_Lnr vEntidad = null;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_TIPO_LNR.USP_SEL_TIPO_LNR", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_TIPO_LNR", vId_Tipo_Lnr);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpal_Tipo_Lnr(vRdr);
                    }
                }
                vCnn.Close();
            }
            return vEntidad;
        }

        public T_Sgpal_Tipo_Lnr InsertarT_Sgpal_Tipo_Lnr(T_Sgpal_Tipo_Lnr vT_Sgpal_Tipo_Lnr)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_TIPO_LNR.USP_INS_TIPO_LNR", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpal_Tipo_Lnr.IP_INGRESO); 
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpal_Tipo_Lnr;
        }
        
        public T_Sgpal_Tipo_Lnr ActualizarT_Sgpal_Tipo_Lnr(T_Sgpal_Tipo_Lnr vT_Sgpal_Tipo_Lnr)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_TIPO_LNR.USP_UPD_TIPO_LNR", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpal_Tipo_Lnr.IP_INGRESO); 
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpal_Tipo_Lnr;
        }

        public int AnularT_Sgpal_Tipo_LnrPorCodigo(int vId_Tipo_Lnr)
        {
            int vResultado = 0;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_TIPO_LNR.USP_DEL_TIPO_LNR", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_TIPO_LNR", vId_Tipo_Lnr);
                    vCnn.Open();
                    vResultado = vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vResultado;
        }

        public IEnumerable<T_Sgpal_Tipo_Lnr> ListarPaginadoT_Sgpal_Tipo_Lnr(string vFiltro, int vNumPag, int vCantRegxPag)
        {
           List<T_Sgpal_Tipo_Lnr> vLista = new List<T_Sgpal_Tipo_Lnr>();
           T_Sgpal_Tipo_Lnr vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_TIPO_LNR.USP_PAG_TIPO_LNR", vCnn))
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
                        vEntidad = new T_Sgpal_Tipo_Lnr(vRdr);
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