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
    /// Objetivo:	Clase que genera las operaciones para la tabla T_SGPAL_EVIDENCIA_EROSION
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	27/10/2021
    /// </summary>
    public partial class T_Sgpal_Evidencia_ErosionAD : BaseAD, IT_Sgpal_Evidencia_ErosionAD
    {
        public T_Sgpal_Evidencia_ErosionAD(IConfiguration vConfiguration)
        {
            CnnString = vConfiguration.GetSection(Constantes.BD).Value;
        }

        public IEnumerable<T_Sgpal_Evidencia_Erosion> ListarT_Sgpal_Evidencia_Erosion()
        {
            List<T_Sgpal_Evidencia_Erosion> vLista = new List<T_Sgpal_Evidencia_Erosion>();
            T_Sgpal_Evidencia_Erosion vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_EVIDENCIA_EROSION.USP_LIS_EVIDENCIA_EROSION", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpal_Evidencia_Erosion(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public T_Sgpal_Evidencia_Erosion RecuperarT_Sgpal_Evidencia_ErosionPorCodigo(int vId_Evidencia_Erosion)
        {
            T_Sgpal_Evidencia_Erosion vEntidad = null;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_EVIDENCIA_EROSION.USP_SEL_EVIDENCIA_EROSION", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_EVIDENCIA_EROSION", vId_Evidencia_Erosion);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpal_Evidencia_Erosion(vRdr);
                    }
                }
                vCnn.Close();
            }
            return vEntidad;
        }

        public T_Sgpal_Evidencia_Erosion InsertarT_Sgpal_Evidencia_Erosion(T_Sgpal_Evidencia_Erosion vT_Sgpal_Evidencia_Erosion)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_EVIDENCIA_EROSION.USP_INS_EVIDENCIA_EROSION", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpal_Evidencia_Erosion.USU_MODIFICA);
                    vCmd.Parameters.Add("pPESO_ORM", vT_Sgpal_Evidencia_Erosion.PESO_ORM);
                    vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpal_Evidencia_Erosion.IP_INGRESO);
                    vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpal_Evidencia_Erosion.FLG_ESTADO);
                    vCmd.Parameters.Add("pPESO_I", vT_Sgpal_Evidencia_Erosion.PESO_I);
                    vCmd.Parameters.Add("pPESO_PQ", vT_Sgpal_Evidencia_Erosion.PESO_PQ);
                    vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpal_Evidencia_Erosion.IP_MODIFICA);
                    vCmd.Parameters.Add("pPESO_RM", vT_Sgpal_Evidencia_Erosion.PESO_RM);
                    vCmd.Parameters.Add("pID_EVIDENCIA_EROSION", vT_Sgpal_Evidencia_Erosion.ID_EVIDENCIA_EROSION);
                    vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpal_Evidencia_Erosion.FEC_MODIFICA);
                    vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpal_Evidencia_Erosion.FEC_INGRESO);
                    vCmd.Parameters.Add("pDESCRIPCION", vT_Sgpal_Evidencia_Erosion.DESCRIPCION);
                    vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpal_Evidencia_Erosion.USU_INGRESO);
                    vCmd.Parameters.Add("pPESO_LB", vT_Sgpal_Evidencia_Erosion.PESO_LB);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpal_Evidencia_Erosion;
        }

        public T_Sgpal_Evidencia_Erosion ActualizarT_Sgpal_Evidencia_Erosion(T_Sgpal_Evidencia_Erosion vT_Sgpal_Evidencia_Erosion)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_EVIDENCIA_EROSION.USP_UPD_EVIDENCIA_EROSION", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpal_Evidencia_Erosion.USU_MODIFICA);
                    vCmd.Parameters.Add("pPESO_ORM", vT_Sgpal_Evidencia_Erosion.PESO_ORM);
                    vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpal_Evidencia_Erosion.IP_INGRESO);
                    vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpal_Evidencia_Erosion.FLG_ESTADO);
                    vCmd.Parameters.Add("pPESO_I", vT_Sgpal_Evidencia_Erosion.PESO_I);
                    vCmd.Parameters.Add("pPESO_PQ", vT_Sgpal_Evidencia_Erosion.PESO_PQ);
                    vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpal_Evidencia_Erosion.IP_MODIFICA);
                    vCmd.Parameters.Add("pPESO_RM", vT_Sgpal_Evidencia_Erosion.PESO_RM);
                    vCmd.Parameters.Add("pID_EVIDENCIA_EROSION", vT_Sgpal_Evidencia_Erosion.ID_EVIDENCIA_EROSION);
                    vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpal_Evidencia_Erosion.FEC_MODIFICA);
                    vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpal_Evidencia_Erosion.FEC_INGRESO);
                    vCmd.Parameters.Add("pDESCRIPCION", vT_Sgpal_Evidencia_Erosion.DESCRIPCION);
                    vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpal_Evidencia_Erosion.USU_INGRESO);
                    vCmd.Parameters.Add("pPESO_LB", vT_Sgpal_Evidencia_Erosion.PESO_LB);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpal_Evidencia_Erosion;
        }

        public int AnularT_Sgpal_Evidencia_ErosionPorCodigo(int vId_Evidencia_Erosion)
        {
            int vResultado = 0;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_EVIDENCIA_EROSION.USP_DEL_EVIDENCIA_EROSION", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_EVIDENCIA_EROSION", vId_Evidencia_Erosion);
                    vCnn.Open();
                    vResultado = vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vResultado;
        }

        public IEnumerable<T_Sgpal_Evidencia_Erosion> ListarPaginadoT_Sgpal_Evidencia_Erosion(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            List<T_Sgpal_Evidencia_Erosion> vLista = new List<T_Sgpal_Evidencia_Erosion>();
            T_Sgpal_Evidencia_Erosion vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_EVIDENCIA_EROSION.USP_PAG_EVIDENCIA_EROSION", vCnn))
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
                        vEntidad = new T_Sgpal_Evidencia_Erosion(vRdr);
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