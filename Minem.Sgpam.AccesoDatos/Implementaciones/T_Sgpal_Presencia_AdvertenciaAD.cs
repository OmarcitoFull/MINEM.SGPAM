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
    /// Objetivo:	Clase que genera las operaciones para la tabla T_SGPAL_PRESENCIA_ADVERTENCIA
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	27/10/2021
    /// </summary>
    public partial class T_Sgpal_Presencia_AdvertenciaAD : BaseAD, IT_Sgpal_Presencia_AdvertenciaAD
    {
        public T_Sgpal_Presencia_AdvertenciaAD(IConfiguration vConfiguration)
        {
            CnnString = vConfiguration.GetSection(Constantes.BD).Value;
        }

        public IEnumerable<T_Sgpal_Presencia_Advertencia> ListarT_Sgpal_Presencia_Advertencia()
        {
            List<T_Sgpal_Presencia_Advertencia> vLista = new List<T_Sgpal_Presencia_Advertencia>();
            T_Sgpal_Presencia_Advertencia vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_PRESENCIA_ADVERTENCIA.USP_LIS_PRESENCIA_ADVERTENCIA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpal_Presencia_Advertencia(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public T_Sgpal_Presencia_Advertencia RecuperarT_Sgpal_Presencia_AdvertenciaPorCodigo(int vId_Presencia_Advertencia)
        {
            T_Sgpal_Presencia_Advertencia vEntidad = null;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_PRESENCIA_ADVERTENCIA.USP_SEL_PRESENCIA_ADVERTENCIA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_PRESENCIA_ADVERTENCIA", vId_Presencia_Advertencia);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpal_Presencia_Advertencia(vRdr);
                    }
                }
                vCnn.Close();
            }
            return vEntidad;
        }

        public T_Sgpal_Presencia_Advertencia InsertarT_Sgpal_Presencia_Advertencia(T_Sgpal_Presencia_Advertencia vT_Sgpal_Presencia_Advertencia)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_PRESENCIA_ADVERTENCIA.USP_INS_PRESENCIA_ADVERTENCIA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_PRESENCIA_ADVERTENCIA", vT_Sgpal_Presencia_Advertencia.ID_PRESENCIA_ADVERTENCIA);
                    vCmd.Parameters.Add("pPESO_ORM", vT_Sgpal_Presencia_Advertencia.PESO_ORM);
                    vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpal_Presencia_Advertencia.USU_INGRESO);
                    vCmd.Parameters.Add("pPESO_RM", vT_Sgpal_Presencia_Advertencia.PESO_RM);
                    vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpal_Presencia_Advertencia.FEC_MODIFICA);
                    vCmd.Parameters.Add("pDESCRIPCION", vT_Sgpal_Presencia_Advertencia.DESCRIPCION);
                    vCmd.Parameters.Add("pPESO_LB", vT_Sgpal_Presencia_Advertencia.PESO_LB);
                    vCmd.Parameters.Add("pPESO_I", vT_Sgpal_Presencia_Advertencia.PESO_I);
                    vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpal_Presencia_Advertencia.USU_MODIFICA);
                    vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpal_Presencia_Advertencia.FLG_ESTADO);
                    vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpal_Presencia_Advertencia.IP_INGRESO);
                    vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpal_Presencia_Advertencia.FEC_INGRESO);
                    vCmd.Parameters.Add("pPESO_PQ", vT_Sgpal_Presencia_Advertencia.PESO_PQ);
                    vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpal_Presencia_Advertencia.IP_MODIFICA);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpal_Presencia_Advertencia;
        }

        public T_Sgpal_Presencia_Advertencia ActualizarT_Sgpal_Presencia_Advertencia(T_Sgpal_Presencia_Advertencia vT_Sgpal_Presencia_Advertencia)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_PRESENCIA_ADVERTENCIA.USP_UPD_PRESENCIA_ADVERTENCIA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_PRESENCIA_ADVERTENCIA", vT_Sgpal_Presencia_Advertencia.ID_PRESENCIA_ADVERTENCIA);
                    vCmd.Parameters.Add("pPESO_ORM", vT_Sgpal_Presencia_Advertencia.PESO_ORM);
                    vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpal_Presencia_Advertencia.USU_INGRESO);
                    vCmd.Parameters.Add("pPESO_RM", vT_Sgpal_Presencia_Advertencia.PESO_RM);
                    vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpal_Presencia_Advertencia.FEC_MODIFICA);
                    vCmd.Parameters.Add("pDESCRIPCION", vT_Sgpal_Presencia_Advertencia.DESCRIPCION);
                    vCmd.Parameters.Add("pPESO_LB", vT_Sgpal_Presencia_Advertencia.PESO_LB);
                    vCmd.Parameters.Add("pPESO_I", vT_Sgpal_Presencia_Advertencia.PESO_I);
                    vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpal_Presencia_Advertencia.USU_MODIFICA);
                    vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpal_Presencia_Advertencia.FLG_ESTADO);
                    vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpal_Presencia_Advertencia.IP_INGRESO);
                    vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpal_Presencia_Advertencia.FEC_INGRESO);
                    vCmd.Parameters.Add("pPESO_PQ", vT_Sgpal_Presencia_Advertencia.PESO_PQ);
                    vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpal_Presencia_Advertencia.IP_MODIFICA);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpal_Presencia_Advertencia;
        }

        public int AnularT_Sgpal_Presencia_AdvertenciaPorCodigo(int vId_Presencia_Advertencia)
        {
            int vResultado = 0;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_PRESENCIA_ADVERTENCIA.USP_DEL_PRESENCIA_ADVERTENCIA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_PRESENCIA_ADVERTENCIA", vId_Presencia_Advertencia);
                    vCnn.Open();
                    vResultado = vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vResultado;
        }

        public IEnumerable<T_Sgpal_Presencia_Advertencia> ListarPaginadoT_Sgpal_Presencia_Advertencia(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            List<T_Sgpal_Presencia_Advertencia> vLista = new List<T_Sgpal_Presencia_Advertencia>();
            T_Sgpal_Presencia_Advertencia vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_PRESENCIA_ADVERTENCIA.USP_PAG_PRESENCIA_ADVERTENCIA", vCnn))
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
                        vEntidad = new T_Sgpal_Presencia_Advertencia(vRdr);
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