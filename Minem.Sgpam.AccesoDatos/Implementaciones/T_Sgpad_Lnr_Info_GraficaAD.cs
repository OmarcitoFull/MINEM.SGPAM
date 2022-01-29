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
    /// Objetivo:	Clase que genera las operaciones para la tabla T_SGPAD_LNR_INFO_GRAFICA
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	27/10/2021
    /// </summary>
    public partial class T_Sgpad_Lnr_Info_GraficaAD: BaseAD, IT_Sgpad_Lnr_Info_GraficaAD
    {   
        public IEnumerable<T_Sgpad_Lnr_Info_Grafica> ListarT_Sgpad_Lnr_Info_Grafica()
        {
           List<T_Sgpad_Lnr_Info_Grafica> vLista = new List<T_Sgpad_Lnr_Info_Grafica>();
           T_Sgpad_Lnr_Info_Grafica vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_LNR_INFO_GRAFICA.USP_LIS_LNR_INFO_GRAFICA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpad_Lnr_Info_Grafica(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public T_Sgpad_Lnr_Info_Grafica RecuperarT_Sgpad_Lnr_Info_GraficaPorCodigo(int vId_Lnr_Info_Grafica)
        {
           T_Sgpad_Lnr_Info_Grafica vEntidad = null;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_LNR_INFO_GRAFICA.USP_SEL_LNR_INFO_GRAFICA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_LNR_INFO_GRAFICA", vId_Lnr_Info_Grafica);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpad_Lnr_Info_Grafica(vRdr);
                    }
                }
                vCnn.Close();
            }
            return vEntidad;
        }

        public T_Sgpad_Lnr_Info_Grafica InsertarT_Sgpad_Lnr_Info_Grafica(T_Sgpad_Lnr_Info_Grafica vT_Sgpad_Lnr_Info_Grafica)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_LNR_INFO_GRAFICA.USP_INS_LNR_INFO_GRAFICA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpad_Lnr_Info_Grafica.FEC_INGRESO); 
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpad_Lnr_Info_Grafica;
        }
        
        public T_Sgpad_Lnr_Info_Grafica ActualizarT_Sgpad_Lnr_Info_Grafica(T_Sgpad_Lnr_Info_Grafica vT_Sgpad_Lnr_Info_Grafica)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_LNR_INFO_GRAFICA.USP_UPD_LNR_INFO_GRAFICA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpad_Lnr_Info_Grafica.FEC_INGRESO); 
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpad_Lnr_Info_Grafica;
        }

        public int AnularT_Sgpad_Lnr_Info_GraficaPorCodigo(int vId_Lnr_Info_Grafica)
        {
            int vResultado = 0;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_LNR_INFO_GRAFICA.USP_DEL_LNR_INFO_GRAFICA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_LNR_INFO_GRAFICA", vId_Lnr_Info_Grafica);
                    vCnn.Open();
                    vResultado = vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vResultado;
        }

        public IEnumerable<T_Sgpad_Lnr_Info_Grafica> ListarPaginadoT_Sgpad_Lnr_Info_Grafica(string vFiltro, int vNumPag, int vCantRegxPag)
        {
           List<T_Sgpad_Lnr_Info_Grafica> vLista = new List<T_Sgpad_Lnr_Info_Grafica>();
           T_Sgpad_Lnr_Info_Grafica vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_LNR_INFO_GRAFICA.USP_PAG_LNR_INFO_GRAFICA", vCnn))
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
                        vEntidad = new T_Sgpad_Lnr_Info_Grafica(vRdr);
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