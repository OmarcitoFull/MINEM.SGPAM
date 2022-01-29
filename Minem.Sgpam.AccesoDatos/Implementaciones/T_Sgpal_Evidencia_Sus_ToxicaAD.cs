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
    /// Objetivo:	Clase que genera las operaciones para la tabla T_SGPAL_EVIDENCIA_SUS_TOXICA
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	27/10/2021
    /// </summary>
    public partial class T_Sgpal_Evidencia_Sus_ToxicaAD : BaseAD, IT_Sgpal_Evidencia_Sus_ToxicaAD
    {
        public T_Sgpal_Evidencia_Sus_ToxicaAD(IConfiguration vConfiguration)
        {
            CnnString = vConfiguration.GetSection(Constantes.BD).Value;
        }

        public IEnumerable<T_Sgpal_Evidencia_Sus_Toxica> ListarT_Sgpal_Evidencia_Sus_Toxica()
        {
            List<T_Sgpal_Evidencia_Sus_Toxica> vLista = new List<T_Sgpal_Evidencia_Sus_Toxica>();
            T_Sgpal_Evidencia_Sus_Toxica vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_EVIDENCIA_SUS_TOXICA.USP_LIS_EVIDENCIA_SUS_TOXICA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpal_Evidencia_Sus_Toxica(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public T_Sgpal_Evidencia_Sus_Toxica RecuperarT_Sgpal_Evidencia_Sus_ToxicaPorCodigo(int vId_Evidencia_Sus_Toxica)
        {
            T_Sgpal_Evidencia_Sus_Toxica vEntidad = null;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_EVIDENCIA_SUS_TOXICA.USP_SEL_EVIDENCIA_SUS_TOXICA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_EVIDENCIA_SUS_TOXICA", vId_Evidencia_Sus_Toxica);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpal_Evidencia_Sus_Toxica(vRdr);
                    }
                }
                vCnn.Close();
            }
            return vEntidad;
        }

        public T_Sgpal_Evidencia_Sus_Toxica InsertarT_Sgpal_Evidencia_Sus_Toxica(T_Sgpal_Evidencia_Sus_Toxica vT_Sgpal_Evidencia_Sus_Toxica)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_EVIDENCIA_SUS_TOXICA.USP_INS_EVIDENCIA_SUS_TOXICA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pPESO_PQ", vT_Sgpal_Evidencia_Sus_Toxica.PESO_PQ);
                    vCmd.Parameters.Add("pPESO_LB", vT_Sgpal_Evidencia_Sus_Toxica.PESO_LB);
                    vCmd.Parameters.Add("pDESCRIPCION", vT_Sgpal_Evidencia_Sus_Toxica.DESCRIPCION);
                    vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpal_Evidencia_Sus_Toxica.USU_INGRESO);
                    vCmd.Parameters.Add("pPESO_ORM", vT_Sgpal_Evidencia_Sus_Toxica.PESO_ORM);
                    vCmd.Parameters.Add("pID_EVIDENCIA_SUS_TOXICA", vT_Sgpal_Evidencia_Sus_Toxica.ID_EVIDENCIA_SUS_TOXICA);
                    vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpal_Evidencia_Sus_Toxica.FEC_MODIFICA);
                    vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpal_Evidencia_Sus_Toxica.USU_MODIFICA);
                    vCmd.Parameters.Add("pPESO_RM", vT_Sgpal_Evidencia_Sus_Toxica.PESO_RM);
                    vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpal_Evidencia_Sus_Toxica.IP_INGRESO);
                    vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpal_Evidencia_Sus_Toxica.FLG_ESTADO);
                    vCmd.Parameters.Add("pPESO_I", vT_Sgpal_Evidencia_Sus_Toxica.PESO_I);
                    vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpal_Evidencia_Sus_Toxica.FEC_INGRESO);
                    vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpal_Evidencia_Sus_Toxica.IP_MODIFICA);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpal_Evidencia_Sus_Toxica;
        }

        public T_Sgpal_Evidencia_Sus_Toxica ActualizarT_Sgpal_Evidencia_Sus_Toxica(T_Sgpal_Evidencia_Sus_Toxica vT_Sgpal_Evidencia_Sus_Toxica)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_EVIDENCIA_SUS_TOXICA.USP_UPD_EVIDENCIA_SUS_TOXICA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pPESO_PQ", vT_Sgpal_Evidencia_Sus_Toxica.PESO_PQ);
                    vCmd.Parameters.Add("pPESO_LB", vT_Sgpal_Evidencia_Sus_Toxica.PESO_LB);
                    vCmd.Parameters.Add("pDESCRIPCION", vT_Sgpal_Evidencia_Sus_Toxica.DESCRIPCION);
                    vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpal_Evidencia_Sus_Toxica.USU_INGRESO);
                    vCmd.Parameters.Add("pPESO_ORM", vT_Sgpal_Evidencia_Sus_Toxica.PESO_ORM);
                    vCmd.Parameters.Add("pID_EVIDENCIA_SUS_TOXICA", vT_Sgpal_Evidencia_Sus_Toxica.ID_EVIDENCIA_SUS_TOXICA);
                    vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpal_Evidencia_Sus_Toxica.FEC_MODIFICA);
                    vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpal_Evidencia_Sus_Toxica.USU_MODIFICA);
                    vCmd.Parameters.Add("pPESO_RM", vT_Sgpal_Evidencia_Sus_Toxica.PESO_RM);
                    vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpal_Evidencia_Sus_Toxica.IP_INGRESO);
                    vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpal_Evidencia_Sus_Toxica.FLG_ESTADO);
                    vCmd.Parameters.Add("pPESO_I", vT_Sgpal_Evidencia_Sus_Toxica.PESO_I);
                    vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpal_Evidencia_Sus_Toxica.FEC_INGRESO);
                    vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpal_Evidencia_Sus_Toxica.IP_MODIFICA);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpal_Evidencia_Sus_Toxica;
        }

        public int AnularT_Sgpal_Evidencia_Sus_ToxicaPorCodigo(int vId_Evidencia_Sus_Toxica)
        {
            int vResultado = 0;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_EVIDENCIA_SUS_TOXICA.USP_DEL_EVIDENCIA_SUS_TOXICA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_EVIDENCIA_SUS_TOXICA", vId_Evidencia_Sus_Toxica);
                    vCnn.Open();
                    vResultado = vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vResultado;
        }

        public IEnumerable<T_Sgpal_Evidencia_Sus_Toxica> ListarPaginadoT_Sgpal_Evidencia_Sus_Toxica(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            List<T_Sgpal_Evidencia_Sus_Toxica> vLista = new List<T_Sgpal_Evidencia_Sus_Toxica>();
            T_Sgpal_Evidencia_Sus_Toxica vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_EVIDENCIA_SUS_TOXICA.USP_PAG_EVIDENCIA_SUS_TOXICA", vCnn))
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
                        vEntidad = new T_Sgpal_Evidencia_Sus_Toxica(vRdr);
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