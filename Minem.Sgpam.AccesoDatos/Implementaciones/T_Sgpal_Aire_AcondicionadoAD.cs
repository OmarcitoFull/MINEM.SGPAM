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
    /// Objetivo:	Clase que genera las operaciones para la tabla T_SGPAL_AIRE_ACONDICIONADO
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	27/10/2021
    /// </summary>
    public partial class T_Sgpal_Aire_AcondicionadoAD: BaseAD, IT_Sgpal_Aire_AcondicionadoAD
    {   
        public IEnumerable<T_Sgpal_Aire_Acondicionado> ListarT_Sgpal_Aire_Acondicionado()
        {
           List<T_Sgpal_Aire_Acondicionado> vLista = new List<T_Sgpal_Aire_Acondicionado>();
           T_Sgpal_Aire_Acondicionado vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_AIRE_ACONDICIONADO.USP_LIS_AIRE_ACONDICIONADO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpal_Aire_Acondicionado(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public T_Sgpal_Aire_Acondicionado RecuperarT_Sgpal_Aire_AcondicionadoPorCodigo(int vId_Aire_Acondicionado)
        {
           T_Sgpal_Aire_Acondicionado vEntidad = null;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_AIRE_ACONDICIONADO.USP_SEL_AIRE_ACONDICIONADO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_AIRE_ACONDICIONADO", vId_Aire_Acondicionado);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpal_Aire_Acondicionado(vRdr);
                    }
                }
                vCnn.Close();
            }
            return vEntidad;
        }

        public T_Sgpal_Aire_Acondicionado InsertarT_Sgpal_Aire_Acondicionado(T_Sgpal_Aire_Acondicionado vT_Sgpal_Aire_Acondicionado)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_AIRE_ACONDICIONADO.USP_INS_AIRE_ACONDICIONADO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpal_Aire_Acondicionado.USU_INGRESO); 				vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpal_Aire_Acondicionado.IP_MODIFICA); 				vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpal_Aire_Acondicionado.FEC_MODIFICA); 				vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpal_Aire_Acondicionado.FLG_ESTADO); 				vCmd.Parameters.Add("pID_AIRE_ACONDICIONADO", vT_Sgpal_Aire_Acondicionado.ID_AIRE_ACONDICIONADO); 				vCmd.Parameters.Add("pDESCRIPCION", vT_Sgpal_Aire_Acondicionado.DESCRIPCION); 				vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpal_Aire_Acondicionado.USU_MODIFICA); 				vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpal_Aire_Acondicionado.FEC_INGRESO); 				vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpal_Aire_Acondicionado.IP_INGRESO);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpal_Aire_Acondicionado;
        }
        
        public T_Sgpal_Aire_Acondicionado ActualizarT_Sgpal_Aire_Acondicionado(T_Sgpal_Aire_Acondicionado vT_Sgpal_Aire_Acondicionado)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_AIRE_ACONDICIONADO.USP_UPD_AIRE_ACONDICIONADO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpal_Aire_Acondicionado.USU_INGRESO); 				vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpal_Aire_Acondicionado.IP_MODIFICA); 				vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpal_Aire_Acondicionado.FEC_MODIFICA); 				vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpal_Aire_Acondicionado.FLG_ESTADO); 				vCmd.Parameters.Add("pID_AIRE_ACONDICIONADO", vT_Sgpal_Aire_Acondicionado.ID_AIRE_ACONDICIONADO); 				vCmd.Parameters.Add("pDESCRIPCION", vT_Sgpal_Aire_Acondicionado.DESCRIPCION); 				vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpal_Aire_Acondicionado.USU_MODIFICA); 				vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpal_Aire_Acondicionado.FEC_INGRESO); 				vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpal_Aire_Acondicionado.IP_INGRESO);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpal_Aire_Acondicionado;
        }

        public int AnularT_Sgpal_Aire_AcondicionadoPorCodigo(int vId_Aire_Acondicionado)
        {
            int vResultado = 0;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_AIRE_ACONDICIONADO.USP_DEL_AIRE_ACONDICIONADO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_AIRE_ACONDICIONADO", vId_Aire_Acondicionado);
                    vCnn.Open();
                    vResultado = vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vResultado;
        }

        public IEnumerable<T_Sgpal_Aire_Acondicionado> ListarPaginadoT_Sgpal_Aire_Acondicionado(string vFiltro, int vNumPag, int vCantRegxPag)
        {
           List<T_Sgpal_Aire_Acondicionado> vLista = new List<T_Sgpal_Aire_Acondicionado>();
           T_Sgpal_Aire_Acondicionado vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_AIRE_ACONDICIONADO.USP_PAG_AIRE_ACONDICIONADO", vCnn))
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
                        vEntidad = new T_Sgpal_Aire_Acondicionado(vRdr);
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