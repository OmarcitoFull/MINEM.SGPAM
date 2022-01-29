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
    /// Objetivo:	Clase que genera las operaciones para la tabla T_SGPAL_DESCARGA_DRENAJE
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	27/10/2021
    /// </summary>
    public partial class T_Sgpal_Descarga_DrenajeAD: BaseAD, IT_Sgpal_Descarga_DrenajeAD
    {   
        public IEnumerable<T_Sgpal_Descarga_Drenaje> ListarT_Sgpal_Descarga_Drenaje()
        {
           List<T_Sgpal_Descarga_Drenaje> vLista = new List<T_Sgpal_Descarga_Drenaje>();
           T_Sgpal_Descarga_Drenaje vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_DESCARGA_DRENAJE.USP_LIS_DESCARGA_DRENAJE", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpal_Descarga_Drenaje(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public T_Sgpal_Descarga_Drenaje RecuperarT_Sgpal_Descarga_DrenajePorCodigo(int vId_Descarga_Drenaje)
        {
           T_Sgpal_Descarga_Drenaje vEntidad = null;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_DESCARGA_DRENAJE.USP_SEL_DESCARGA_DRENAJE", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_DESCARGA_DRENAJE", vId_Descarga_Drenaje);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpal_Descarga_Drenaje(vRdr);
                    }
                }
                vCnn.Close();
            }
            return vEntidad;
        }

        public T_Sgpal_Descarga_Drenaje InsertarT_Sgpal_Descarga_Drenaje(T_Sgpal_Descarga_Drenaje vT_Sgpal_Descarga_Drenaje)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_DESCARGA_DRENAJE.USP_INS_DESCARGA_DRENAJE", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpal_Descarga_Drenaje.USU_MODIFICA); 				vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpal_Descarga_Drenaje.FLG_ESTADO); 				vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpal_Descarga_Drenaje.FEC_MODIFICA); 				vCmd.Parameters.Add("pID_DESCARGA_DRENAJE", vT_Sgpal_Descarga_Drenaje.ID_DESCARGA_DRENAJE); 				vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpal_Descarga_Drenaje.IP_MODIFICA); 				vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpal_Descarga_Drenaje.FEC_INGRESO); 				vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpal_Descarga_Drenaje.IP_INGRESO); 				vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpal_Descarga_Drenaje.USU_INGRESO); 				vCmd.Parameters.Add("pDESCRIPCION", vT_Sgpal_Descarga_Drenaje.DESCRIPCION);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpal_Descarga_Drenaje;
        }
        
        public T_Sgpal_Descarga_Drenaje ActualizarT_Sgpal_Descarga_Drenaje(T_Sgpal_Descarga_Drenaje vT_Sgpal_Descarga_Drenaje)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_DESCARGA_DRENAJE.USP_UPD_DESCARGA_DRENAJE", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpal_Descarga_Drenaje.USU_MODIFICA); 				vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpal_Descarga_Drenaje.FLG_ESTADO); 				vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpal_Descarga_Drenaje.FEC_MODIFICA); 				vCmd.Parameters.Add("pID_DESCARGA_DRENAJE", vT_Sgpal_Descarga_Drenaje.ID_DESCARGA_DRENAJE); 				vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpal_Descarga_Drenaje.IP_MODIFICA); 				vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpal_Descarga_Drenaje.FEC_INGRESO); 				vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpal_Descarga_Drenaje.IP_INGRESO); 				vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpal_Descarga_Drenaje.USU_INGRESO); 				vCmd.Parameters.Add("pDESCRIPCION", vT_Sgpal_Descarga_Drenaje.DESCRIPCION);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpal_Descarga_Drenaje;
        }

        public int AnularT_Sgpal_Descarga_DrenajePorCodigo(int vId_Descarga_Drenaje)
        {
            int vResultado = 0;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_DESCARGA_DRENAJE.USP_DEL_DESCARGA_DRENAJE", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_DESCARGA_DRENAJE", vId_Descarga_Drenaje);
                    vCnn.Open();
                    vResultado = vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vResultado;
        }

        public IEnumerable<T_Sgpal_Descarga_Drenaje> ListarPaginadoT_Sgpal_Descarga_Drenaje(string vFiltro, int vNumPag, int vCantRegxPag)
        {
           List<T_Sgpal_Descarga_Drenaje> vLista = new List<T_Sgpal_Descarga_Drenaje>();
           T_Sgpal_Descarga_Drenaje vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_DESCARGA_DRENAJE.USP_PAG_DESCARGA_DRENAJE", vCnn))
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
                        vEntidad = new T_Sgpal_Descarga_Drenaje(vRdr);
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