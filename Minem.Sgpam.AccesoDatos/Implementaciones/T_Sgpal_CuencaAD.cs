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
    /// Objetivo:	Clase que genera las operaciones para la tabla T_SGPAL_CUENCA
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	27/10/2021
    /// </summary>
    public partial class T_Sgpal_CuencaAD: BaseAD, IT_Sgpal_CuencaAD
    {   
        public IEnumerable<T_Sgpal_Cuenca> ListarT_Sgpal_Cuenca()
        {
           List<T_Sgpal_Cuenca> vLista = new List<T_Sgpal_Cuenca>();
           T_Sgpal_Cuenca vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_CUENCA.USP_LIS_CUENCA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpal_Cuenca(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public T_Sgpal_Cuenca RecuperarT_Sgpal_CuencaPorCodigo(int vId_Cuenca)
        {
           T_Sgpal_Cuenca vEntidad = null;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_CUENCA.USP_SEL_CUENCA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_CUENCA", vId_Cuenca);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpal_Cuenca(vRdr);
                    }
                }
                vCnn.Close();
            }
            return vEntidad;
        }

        public T_Sgpal_Cuenca InsertarT_Sgpal_Cuenca(T_Sgpal_Cuenca vT_Sgpal_Cuenca)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_CUENCA.USP_INS_CUENCA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_CUENCA", vT_Sgpal_Cuenca.ID_CUENCA); 				vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpal_Cuenca.FEC_MODIFICA); 				vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpal_Cuenca.FLG_ESTADO); 				vCmd.Parameters.Add("pDESCRIPCION", vT_Sgpal_Cuenca.DESCRIPCION); 				vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpal_Cuenca.IP_MODIFICA); 				vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpal_Cuenca.USU_MODIFICA); 				vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpal_Cuenca.USU_INGRESO); 				vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpal_Cuenca.IP_INGRESO); 				vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpal_Cuenca.FEC_INGRESO);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpal_Cuenca;
        }
        
        public T_Sgpal_Cuenca ActualizarT_Sgpal_Cuenca(T_Sgpal_Cuenca vT_Sgpal_Cuenca)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_CUENCA.USP_UPD_CUENCA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_CUENCA", vT_Sgpal_Cuenca.ID_CUENCA); 				vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpal_Cuenca.FEC_MODIFICA); 				vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpal_Cuenca.FLG_ESTADO); 				vCmd.Parameters.Add("pDESCRIPCION", vT_Sgpal_Cuenca.DESCRIPCION); 				vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpal_Cuenca.IP_MODIFICA); 				vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpal_Cuenca.USU_MODIFICA); 				vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpal_Cuenca.USU_INGRESO); 				vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpal_Cuenca.IP_INGRESO); 				vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpal_Cuenca.FEC_INGRESO);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpal_Cuenca;
        }

        public int AnularT_Sgpal_CuencaPorCodigo(int vId_Cuenca)
        {
            int vResultado = 0;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_CUENCA.USP_DEL_CUENCA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_CUENCA", vId_Cuenca);
                    vCnn.Open();
                    vResultado = vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vResultado;
        }

        public IEnumerable<T_Sgpal_Cuenca> ListarPaginadoT_Sgpal_Cuenca(string vFiltro, int vNumPag, int vCantRegxPag)
        {
           List<T_Sgpal_Cuenca> vLista = new List<T_Sgpal_Cuenca>();
           T_Sgpal_Cuenca vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_CUENCA.USP_PAG_CUENCA", vCnn))
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
                        vEntidad = new T_Sgpal_Cuenca(vRdr);
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