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
    /// Objetivo:	Clase que genera las operaciones para la tabla T_SGPAL_REGION
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	27/10/2021
    /// </summary>
    public partial class T_Sgpal_RegionAD: BaseAD, IT_Sgpal_RegionAD
    {   
        public IEnumerable<T_Sgpal_Region> ListarT_Sgpal_Region()
        {
           List<T_Sgpal_Region> vLista = new List<T_Sgpal_Region>();
           T_Sgpal_Region vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_REGION.USP_LIS_REGION", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpal_Region(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public T_Sgpal_Region RecuperarT_Sgpal_RegionPorCodigo(int vId_Region)
        {
           T_Sgpal_Region vEntidad = null;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_REGION.USP_SEL_REGION", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_REGION", vId_Region);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpal_Region(vRdr);
                    }
                }
                vCnn.Close();
            }
            return vEntidad;
        }

        public T_Sgpal_Region InsertarT_Sgpal_Region(T_Sgpal_Region vT_Sgpal_Region)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_REGION.USP_INS_REGION", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpal_Region.USU_INGRESO); 				vCmd.Parameters.Add("pCOD_REFERENCIAL", vT_Sgpal_Region.COD_REFERENCIAL); 				vCmd.Parameters.Add("pID_REGION", vT_Sgpal_Region.ID_REGION); 				vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpal_Region.FEC_MODIFICA); 				vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpal_Region.USU_MODIFICA); 				vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpal_Region.IP_MODIFICA); 				vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpal_Region.FLG_ESTADO); 				vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpal_Region.IP_INGRESO); 				vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpal_Region.FEC_INGRESO); 				vCmd.Parameters.Add("pDESCRIPCION", vT_Sgpal_Region.DESCRIPCION);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpal_Region;
        }
        
        public T_Sgpal_Region ActualizarT_Sgpal_Region(T_Sgpal_Region vT_Sgpal_Region)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_REGION.USP_UPD_REGION", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpal_Region.USU_INGRESO); 				vCmd.Parameters.Add("pCOD_REFERENCIAL", vT_Sgpal_Region.COD_REFERENCIAL); 				vCmd.Parameters.Add("pID_REGION", vT_Sgpal_Region.ID_REGION); 				vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpal_Region.FEC_MODIFICA); 				vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpal_Region.USU_MODIFICA); 				vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpal_Region.IP_MODIFICA); 				vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpal_Region.FLG_ESTADO); 				vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpal_Region.IP_INGRESO); 				vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpal_Region.FEC_INGRESO); 				vCmd.Parameters.Add("pDESCRIPCION", vT_Sgpal_Region.DESCRIPCION);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpal_Region;
        }

        public int AnularT_Sgpal_RegionPorCodigo(int vId_Region)
        {
            int vResultado = 0;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_REGION.USP_DEL_REGION", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_REGION", vId_Region);
                    vCnn.Open();
                    vResultado = vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vResultado;
        }

        public IEnumerable<T_Sgpal_Region> ListarPaginadoT_Sgpal_Region(string vFiltro, int vNumPag, int vCantRegxPag)
        {
           List<T_Sgpal_Region> vLista = new List<T_Sgpal_Region>();
           T_Sgpal_Region vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_REGION.USP_PAG_REGION", vCnn))
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
                        vEntidad = new T_Sgpal_Region(vRdr);
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