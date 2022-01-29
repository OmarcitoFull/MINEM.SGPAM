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
    /// Objetivo:	Clase que genera las operaciones para la tabla T_SGPAL_CONTENCION_RESIDUO
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	27/10/2021
    /// </summary>
    public partial class T_Sgpal_Contencion_ResiduoAD: BaseAD, IT_Sgpal_Contencion_ResiduoAD
    {   
        public IEnumerable<T_Sgpal_Contencion_Residuo> ListarT_Sgpal_Contencion_Residuo()
        {
           List<T_Sgpal_Contencion_Residuo> vLista = new List<T_Sgpal_Contencion_Residuo>();
           T_Sgpal_Contencion_Residuo vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_CONTENCION_RESIDUO.USP_LIS_CONTENCION_RESIDUO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpal_Contencion_Residuo(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public T_Sgpal_Contencion_Residuo RecuperarT_Sgpal_Contencion_ResiduoPorCodigo(int vId_Contencion_Residuo)
        {
           T_Sgpal_Contencion_Residuo vEntidad = null;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_CONTENCION_RESIDUO.USP_SEL_CONTENCION_RESIDUO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_CONTENCION_RESIDUO", vId_Contencion_Residuo);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpal_Contencion_Residuo(vRdr);
                    }
                }
                vCnn.Close();
            }
            return vEntidad;
        }

        public T_Sgpal_Contencion_Residuo InsertarT_Sgpal_Contencion_Residuo(T_Sgpal_Contencion_Residuo vT_Sgpal_Contencion_Residuo)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_CONTENCION_RESIDUO.USP_INS_CONTENCION_RESIDUO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpal_Contencion_Residuo.IP_MODIFICA); 				vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpal_Contencion_Residuo.FEC_MODIFICA); 				vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpal_Contencion_Residuo.FLG_ESTADO); 				vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpal_Contencion_Residuo.USU_MODIFICA); 				vCmd.Parameters.Add("pDESCRIPCION", vT_Sgpal_Contencion_Residuo.DESCRIPCION); 				vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpal_Contencion_Residuo.USU_INGRESO); 				vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpal_Contencion_Residuo.FEC_INGRESO); 				vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpal_Contencion_Residuo.IP_INGRESO); 				vCmd.Parameters.Add("pID_CONTENCION_RESIDUO", vT_Sgpal_Contencion_Residuo.ID_CONTENCION_RESIDUO);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpal_Contencion_Residuo;
        }
        
        public T_Sgpal_Contencion_Residuo ActualizarT_Sgpal_Contencion_Residuo(T_Sgpal_Contencion_Residuo vT_Sgpal_Contencion_Residuo)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_CONTENCION_RESIDUO.USP_UPD_CONTENCION_RESIDUO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpal_Contencion_Residuo.IP_MODIFICA); 				vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpal_Contencion_Residuo.FEC_MODIFICA); 				vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpal_Contencion_Residuo.FLG_ESTADO); 				vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpal_Contencion_Residuo.USU_MODIFICA); 				vCmd.Parameters.Add("pDESCRIPCION", vT_Sgpal_Contencion_Residuo.DESCRIPCION); 				vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpal_Contencion_Residuo.USU_INGRESO); 				vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpal_Contencion_Residuo.FEC_INGRESO); 				vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpal_Contencion_Residuo.IP_INGRESO); 				vCmd.Parameters.Add("pID_CONTENCION_RESIDUO", vT_Sgpal_Contencion_Residuo.ID_CONTENCION_RESIDUO);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpal_Contencion_Residuo;
        }

        public int AnularT_Sgpal_Contencion_ResiduoPorCodigo(int vId_Contencion_Residuo)
        {
            int vResultado = 0;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_CONTENCION_RESIDUO.USP_DEL_CONTENCION_RESIDUO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_CONTENCION_RESIDUO", vId_Contencion_Residuo);
                    vCnn.Open();
                    vResultado = vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vResultado;
        }

        public IEnumerable<T_Sgpal_Contencion_Residuo> ListarPaginadoT_Sgpal_Contencion_Residuo(string vFiltro, int vNumPag, int vCantRegxPag)
        {
           List<T_Sgpal_Contencion_Residuo> vLista = new List<T_Sgpal_Contencion_Residuo>();
           T_Sgpal_Contencion_Residuo vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_CONTENCION_RESIDUO.USP_PAG_CONTENCION_RESIDUO", vCnn))
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
                        vEntidad = new T_Sgpal_Contencion_Residuo(vRdr);
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