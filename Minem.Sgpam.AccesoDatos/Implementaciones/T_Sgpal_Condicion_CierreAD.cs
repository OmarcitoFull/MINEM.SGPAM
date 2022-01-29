using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Extensions.Configuration;
using Minem.Sgpam.AccesoDatos.Base;
using Minem.Sgpam.AccesoDatos.Interfaces;
using Minem.Sgpam.Entidades;
using Minem.Sgpam.InfraEstructura;
using Oracle.ManagedDataAccess.Client;

namespace Minem.Sgpam.AccesoDatos.Implementaciones
{
    /// <summary>
    /// Objetivo:	Clase que genera las operaciones para la tabla T_SGPAL_CONDICION_CIERRE
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	27/10/2021
    /// </summary>
    public partial class T_Sgpal_Condicion_CierreAD : BaseAD, IT_Sgpal_Condicion_CierreAD
    {
        public T_Sgpal_Condicion_CierreAD(IConfiguration vConfiguration)
        {
            CnnString = vConfiguration.GetSection(Constantes.BD).Value;
        }

        public IEnumerable<T_Sgpal_Condicion_Cierre> ListarT_Sgpal_Condicion_Cierre()
        {
            List<T_Sgpal_Condicion_Cierre> vLista = new List<T_Sgpal_Condicion_Cierre>();
            T_Sgpal_Condicion_Cierre vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_CONDICION_CIERRE.USP_LIS_CONDICION_CIERRE", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpal_Condicion_Cierre(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public T_Sgpal_Condicion_Cierre RecuperarT_Sgpal_Condicion_CierrePorCodigo(int vId_Condicion_Cierre)
        {
            T_Sgpal_Condicion_Cierre vEntidad = null;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_CONDICION_CIERRE.USP_SEL_CONDICION_CIERRE", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_CONDICION_CIERRE", vId_Condicion_Cierre);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpal_Condicion_Cierre(vRdr);
                    }
                }
                vCnn.Close();
            }
            return vEntidad;
        }

        public T_Sgpal_Condicion_Cierre InsertarT_Sgpal_Condicion_Cierre(T_Sgpal_Condicion_Cierre vT_Sgpal_Condicion_Cierre)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_CONDICION_CIERRE.USP_INS_CONDICION_CIERRE", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpal_Condicion_Cierre.USU_INGRESO);
                    vCmd.Parameters.Add("pPESO_I", vT_Sgpal_Condicion_Cierre.PESO_I);
                    vCmd.Parameters.Add("pPESO_RM", vT_Sgpal_Condicion_Cierre.PESO_RM);
                    vCmd.Parameters.Add("pPESO_PQ", vT_Sgpal_Condicion_Cierre.PESO_PQ);
                    vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpal_Condicion_Cierre.IP_INGRESO);
                    vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpal_Condicion_Cierre.USU_MODIFICA);
                    vCmd.Parameters.Add("pID_CONDICION_CIERRE", vT_Sgpal_Condicion_Cierre.ID_CONDICION_CIERRE);
                    vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpal_Condicion_Cierre.FLG_ESTADO);
                    vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpal_Condicion_Cierre.IP_MODIFICA);
                    vCmd.Parameters.Add("pPESO_LB", vT_Sgpal_Condicion_Cierre.PESO_LB);
                    vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpal_Condicion_Cierre.FEC_MODIFICA);
                    vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpal_Condicion_Cierre.FEC_INGRESO);
                    vCmd.Parameters.Add("pPESO_ORM", vT_Sgpal_Condicion_Cierre.PESO_ORM);
                    vCmd.Parameters.Add("pDESCRIPCION", vT_Sgpal_Condicion_Cierre.DESCRIPCION);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpal_Condicion_Cierre;
        }

        public T_Sgpal_Condicion_Cierre ActualizarT_Sgpal_Condicion_Cierre(T_Sgpal_Condicion_Cierre vT_Sgpal_Condicion_Cierre)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_CONDICION_CIERRE.USP_UPD_CONDICION_CIERRE", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpal_Condicion_Cierre.USU_INGRESO);
                    vCmd.Parameters.Add("pPESO_I", vT_Sgpal_Condicion_Cierre.PESO_I);
                    vCmd.Parameters.Add("pPESO_RM", vT_Sgpal_Condicion_Cierre.PESO_RM);
                    vCmd.Parameters.Add("pPESO_PQ", vT_Sgpal_Condicion_Cierre.PESO_PQ);
                    vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpal_Condicion_Cierre.IP_INGRESO);
                    vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpal_Condicion_Cierre.USU_MODIFICA);
                    vCmd.Parameters.Add("pID_CONDICION_CIERRE", vT_Sgpal_Condicion_Cierre.ID_CONDICION_CIERRE);
                    vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpal_Condicion_Cierre.FLG_ESTADO);
                    vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpal_Condicion_Cierre.IP_MODIFICA);
                    vCmd.Parameters.Add("pPESO_LB", vT_Sgpal_Condicion_Cierre.PESO_LB);
                    vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpal_Condicion_Cierre.FEC_MODIFICA);
                    vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpal_Condicion_Cierre.FEC_INGRESO);
                    vCmd.Parameters.Add("pPESO_ORM", vT_Sgpal_Condicion_Cierre.PESO_ORM);
                    vCmd.Parameters.Add("pDESCRIPCION", vT_Sgpal_Condicion_Cierre.DESCRIPCION);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpal_Condicion_Cierre;
        }

        public int AnularT_Sgpal_Condicion_CierrePorCodigo(int vId_Condicion_Cierre)
        {
            int vResultado = 0;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_CONDICION_CIERRE.USP_DEL_CONDICION_CIERRE", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_CONDICION_CIERRE", vId_Condicion_Cierre);
                    vCnn.Open();
                    vResultado = vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vResultado;
        }

        public IEnumerable<T_Sgpal_Condicion_Cierre> ListarPaginadoT_Sgpal_Condicion_Cierre(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            List<T_Sgpal_Condicion_Cierre> vLista = new List<T_Sgpal_Condicion_Cierre>();
            T_Sgpal_Condicion_Cierre vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_CONDICION_CIERRE.USP_PAG_CONDICION_CIERRE", vCnn))
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
                        vEntidad = new T_Sgpal_Condicion_Cierre(vRdr);
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