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
    /// Objetivo:	Clase que genera las operaciones para la tabla T_SGPAL_VEGETACION_INVASIVA
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	27/10/2021
    /// </summary>
    public partial class T_Sgpal_Vegetacion_InvasivaAD : BaseAD, IT_Sgpal_Vegetacion_InvasivaAD
    {
        public T_Sgpal_Vegetacion_InvasivaAD(IConfiguration vConfiguration)
        {
            CnnString = vConfiguration.GetSection(Constantes.BD).Value;
        }

        public IEnumerable<T_Sgpal_Vegetacion_Invasiva> ListarT_Sgpal_Vegetacion_Invasiva()
        {
            List<T_Sgpal_Vegetacion_Invasiva> vLista = new List<T_Sgpal_Vegetacion_Invasiva>();
            T_Sgpal_Vegetacion_Invasiva vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_VEGETACION_INVASIVA.USP_LIS_VEGETACION_INVASIVA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpal_Vegetacion_Invasiva(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public T_Sgpal_Vegetacion_Invasiva RecuperarT_Sgpal_Vegetacion_InvasivaPorCodigo(int vId_Vegetacion_Invasiva)
        {
            T_Sgpal_Vegetacion_Invasiva vEntidad = null;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_VEGETACION_INVASIVA.USP_SEL_VEGETACION_INVASIVA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_VEGETACION_INVASIVA", vId_Vegetacion_Invasiva);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpal_Vegetacion_Invasiva(vRdr);
                    }
                }
                vCnn.Close();
            }
            return vEntidad;
        }

        public T_Sgpal_Vegetacion_Invasiva InsertarT_Sgpal_Vegetacion_Invasiva(T_Sgpal_Vegetacion_Invasiva vT_Sgpal_Vegetacion_Invasiva)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_VEGETACION_INVASIVA.USP_INS_VEGETACION_INVASIVA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pDESCRIPCION", vT_Sgpal_Vegetacion_Invasiva.DESCRIPCION);
                    vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpal_Vegetacion_Invasiva.FEC_INGRESO);
                    vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpal_Vegetacion_Invasiva.IP_INGRESO);
                    vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpal_Vegetacion_Invasiva.USU_MODIFICA);
                    vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpal_Vegetacion_Invasiva.USU_INGRESO);
                    vCmd.Parameters.Add("pPESO_ORM", vT_Sgpal_Vegetacion_Invasiva.PESO_ORM);
                    vCmd.Parameters.Add("pID_VEGETACION_INVASIVA", vT_Sgpal_Vegetacion_Invasiva.ID_VEGETACION_INVASIVA);
                    vCmd.Parameters.Add("pPESO_LB", vT_Sgpal_Vegetacion_Invasiva.PESO_LB);
                    vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpal_Vegetacion_Invasiva.FEC_MODIFICA);
                    vCmd.Parameters.Add("pPESO_PQ", vT_Sgpal_Vegetacion_Invasiva.PESO_PQ);
                    vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpal_Vegetacion_Invasiva.IP_MODIFICA);
                    vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpal_Vegetacion_Invasiva.FLG_ESTADO);
                    vCmd.Parameters.Add("pPESO_I", vT_Sgpal_Vegetacion_Invasiva.PESO_I);
                    vCmd.Parameters.Add("pPESO_RM", vT_Sgpal_Vegetacion_Invasiva.PESO_RM);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpal_Vegetacion_Invasiva;
        }

        public T_Sgpal_Vegetacion_Invasiva ActualizarT_Sgpal_Vegetacion_Invasiva(T_Sgpal_Vegetacion_Invasiva vT_Sgpal_Vegetacion_Invasiva)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_VEGETACION_INVASIVA.USP_UPD_VEGETACION_INVASIVA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pDESCRIPCION", vT_Sgpal_Vegetacion_Invasiva.DESCRIPCION);
                    vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpal_Vegetacion_Invasiva.FEC_INGRESO);
                    vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpal_Vegetacion_Invasiva.IP_INGRESO);
                    vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpal_Vegetacion_Invasiva.USU_MODIFICA);
                    vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpal_Vegetacion_Invasiva.USU_INGRESO);
                    vCmd.Parameters.Add("pPESO_ORM", vT_Sgpal_Vegetacion_Invasiva.PESO_ORM);
                    vCmd.Parameters.Add("pID_VEGETACION_INVASIVA", vT_Sgpal_Vegetacion_Invasiva.ID_VEGETACION_INVASIVA);
                    vCmd.Parameters.Add("pPESO_LB", vT_Sgpal_Vegetacion_Invasiva.PESO_LB);
                    vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpal_Vegetacion_Invasiva.FEC_MODIFICA);
                    vCmd.Parameters.Add("pPESO_PQ", vT_Sgpal_Vegetacion_Invasiva.PESO_PQ);
                    vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpal_Vegetacion_Invasiva.IP_MODIFICA);
                    vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpal_Vegetacion_Invasiva.FLG_ESTADO);
                    vCmd.Parameters.Add("pPESO_I", vT_Sgpal_Vegetacion_Invasiva.PESO_I);
                    vCmd.Parameters.Add("pPESO_RM", vT_Sgpal_Vegetacion_Invasiva.PESO_RM);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpal_Vegetacion_Invasiva;
        }

        public int AnularT_Sgpal_Vegetacion_InvasivaPorCodigo(int vId_Vegetacion_Invasiva)
        {
            int vResultado = 0;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_VEGETACION_INVASIVA.USP_DEL_VEGETACION_INVASIVA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_VEGETACION_INVASIVA", vId_Vegetacion_Invasiva);
                    vCnn.Open();
                    vResultado = vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vResultado;
        }

        public IEnumerable<T_Sgpal_Vegetacion_Invasiva> ListarPaginadoT_Sgpal_Vegetacion_Invasiva(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            List<T_Sgpal_Vegetacion_Invasiva> vLista = new List<T_Sgpal_Vegetacion_Invasiva>();
            T_Sgpal_Vegetacion_Invasiva vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_VEGETACION_INVASIVA.USP_PAG_VEGETACION_INVASIVA", vCnn))
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
                        vEntidad = new T_Sgpal_Vegetacion_Invasiva(vRdr);
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