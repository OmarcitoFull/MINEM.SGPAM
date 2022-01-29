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
    /// Objetivo:	Clase que genera las operaciones para la tabla T_SGPAL_PROVINCIA
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	27/10/2021
    /// </summary>
    public partial class T_Sgpal_ProvinciaAD: BaseAD, IT_Sgpal_ProvinciaAD
    {   
        public IEnumerable<T_Sgpal_Provincia> ListarT_Sgpal_Provincia()
        {
           List<T_Sgpal_Provincia> vLista = new List<T_Sgpal_Provincia>();
           T_Sgpal_Provincia vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_PROVINCIA.USP_LIS_PROVINCIA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpal_Provincia(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public T_Sgpal_Provincia RecuperarT_Sgpal_ProvinciaPorCodigo(int vId_Provincia)
        {
           T_Sgpal_Provincia vEntidad = null;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_PROVINCIA.USP_SEL_PROVINCIA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_PROVINCIA", vId_Provincia);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpal_Provincia(vRdr);
                    }
                }
                vCnn.Close();
            }
            return vEntidad;
        }

        public T_Sgpal_Provincia InsertarT_Sgpal_Provincia(T_Sgpal_Provincia vT_Sgpal_Provincia)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_PROVINCIA.USP_INS_PROVINCIA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpal_Provincia.FEC_INGRESO); 				vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpal_Provincia.IP_INGRESO); 				vCmd.Parameters.Add("pID_REGION", vT_Sgpal_Provincia.ID_REGION); 				vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpal_Provincia.USU_MODIFICA); 				vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpal_Provincia.IP_MODIFICA); 				vCmd.Parameters.Add("pCOD_REFERENCIAL", vT_Sgpal_Provincia.COD_REFERENCIAL); 				vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpal_Provincia.FEC_MODIFICA); 				vCmd.Parameters.Add("pDESCRIPCION", vT_Sgpal_Provincia.DESCRIPCION); 				vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpal_Provincia.FLG_ESTADO); 				vCmd.Parameters.Add("pID_PROVINCIA", vT_Sgpal_Provincia.ID_PROVINCIA); 				vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpal_Provincia.USU_INGRESO);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpal_Provincia;
        }
        
        public T_Sgpal_Provincia ActualizarT_Sgpal_Provincia(T_Sgpal_Provincia vT_Sgpal_Provincia)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_PROVINCIA.USP_UPD_PROVINCIA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpal_Provincia.FEC_INGRESO); 				vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpal_Provincia.IP_INGRESO); 				vCmd.Parameters.Add("pID_REGION", vT_Sgpal_Provincia.ID_REGION); 				vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpal_Provincia.USU_MODIFICA); 				vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpal_Provincia.IP_MODIFICA); 				vCmd.Parameters.Add("pCOD_REFERENCIAL", vT_Sgpal_Provincia.COD_REFERENCIAL); 				vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpal_Provincia.FEC_MODIFICA); 				vCmd.Parameters.Add("pDESCRIPCION", vT_Sgpal_Provincia.DESCRIPCION); 				vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpal_Provincia.FLG_ESTADO); 				vCmd.Parameters.Add("pID_PROVINCIA", vT_Sgpal_Provincia.ID_PROVINCIA); 				vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpal_Provincia.USU_INGRESO);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpal_Provincia;
        }

        public int AnularT_Sgpal_ProvinciaPorCodigo(int vId_Provincia)
        {
            int vResultado = 0;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_PROVINCIA.USP_DEL_PROVINCIA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_PROVINCIA", vId_Provincia);
                    vCnn.Open();
                    vResultado = vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vResultado;
        }

        public IEnumerable<T_Sgpal_Provincia> ListarPaginadoT_Sgpal_Provincia(string vFiltro, int vNumPag, int vCantRegxPag)
        {
           List<T_Sgpal_Provincia> vLista = new List<T_Sgpal_Provincia>();
           T_Sgpal_Provincia vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_PROVINCIA.USP_PAG_PROVINCIA", vCnn))
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
                        vEntidad = new T_Sgpal_Provincia(vRdr);
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