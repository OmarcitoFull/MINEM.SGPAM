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
    /// Objetivo:	Clase que genera las operaciones para la tabla T_SGPAL_AGUA_CONTAMINADA
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	27/10/2021
    /// </summary>
    public partial class T_Sgpal_Agua_ContaminadaAD : BaseAD, IT_Sgpal_Agua_ContaminadaAD
    {
        public T_Sgpal_Agua_ContaminadaAD(IConfiguration vConfiguration)
        {
            CnnString = vConfiguration.GetSection(Constantes.BD).Value;
        }

        public IEnumerable<T_Sgpal_Agua_Contaminada> ListarT_Sgpal_Agua_Contaminada()
        {
            List<T_Sgpal_Agua_Contaminada> vLista = new List<T_Sgpal_Agua_Contaminada>();
            T_Sgpal_Agua_Contaminada vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_AGUA_CONTAMINADA.USP_LIS_AGUA_CONTAMINADA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpal_Agua_Contaminada(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public T_Sgpal_Agua_Contaminada RecuperarT_Sgpal_Agua_ContaminadaPorCodigo(int vId_Agua_Contaminada)
        {
            T_Sgpal_Agua_Contaminada vEntidad = null;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_AGUA_CONTAMINADA.USP_SEL_AGUA_CONTAMINADA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_AGUA_CONTAMINADA", vId_Agua_Contaminada);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpal_Agua_Contaminada(vRdr);
                    }
                }
                vCnn.Close();
            }
            return vEntidad;
        }

        public T_Sgpal_Agua_Contaminada InsertarT_Sgpal_Agua_Contaminada(T_Sgpal_Agua_Contaminada vT_Sgpal_Agua_Contaminada)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_AGUA_CONTAMINADA.USP_INS_AGUA_CONTAMINADA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpal_Agua_Contaminada.IP_MODIFICA);
                    vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpal_Agua_Contaminada.FEC_MODIFICA);
                    vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpal_Agua_Contaminada.IP_INGRESO);
                    vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpal_Agua_Contaminada.FEC_INGRESO);
                    vCmd.Parameters.Add("pPESO_LB", vT_Sgpal_Agua_Contaminada.PESO_LB);
                    vCmd.Parameters.Add("pPESO_I", vT_Sgpal_Agua_Contaminada.PESO_I);
                    vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpal_Agua_Contaminada.USU_MODIFICA);
                    vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpal_Agua_Contaminada.USU_INGRESO);
                    vCmd.Parameters.Add("pPESO_ORM", vT_Sgpal_Agua_Contaminada.PESO_ORM);
                    vCmd.Parameters.Add("pPESO_RM", vT_Sgpal_Agua_Contaminada.PESO_RM);
                    vCmd.Parameters.Add("pDESCRIPCION", vT_Sgpal_Agua_Contaminada.DESCRIPCION);
                    vCmd.Parameters.Add("pID_AGUA_CONTAMINADA", vT_Sgpal_Agua_Contaminada.ID_AGUA_CONTAMINADA);
                    vCmd.Parameters.Add("pPESO_PQ", vT_Sgpal_Agua_Contaminada.PESO_PQ);
                    vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpal_Agua_Contaminada.FLG_ESTADO);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpal_Agua_Contaminada;
        }

        public T_Sgpal_Agua_Contaminada ActualizarT_Sgpal_Agua_Contaminada(T_Sgpal_Agua_Contaminada vT_Sgpal_Agua_Contaminada)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_AGUA_CONTAMINADA.USP_UPD_AGUA_CONTAMINADA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpal_Agua_Contaminada.IP_MODIFICA);
                    vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpal_Agua_Contaminada.FEC_MODIFICA);
                    vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpal_Agua_Contaminada.IP_INGRESO);
                    vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpal_Agua_Contaminada.FEC_INGRESO);
                    vCmd.Parameters.Add("pPESO_LB", vT_Sgpal_Agua_Contaminada.PESO_LB);
                    vCmd.Parameters.Add("pPESO_I", vT_Sgpal_Agua_Contaminada.PESO_I);
                    vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpal_Agua_Contaminada.USU_MODIFICA);
                    vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpal_Agua_Contaminada.USU_INGRESO);
                    vCmd.Parameters.Add("pPESO_ORM", vT_Sgpal_Agua_Contaminada.PESO_ORM);
                    vCmd.Parameters.Add("pPESO_RM", vT_Sgpal_Agua_Contaminada.PESO_RM);
                    vCmd.Parameters.Add("pDESCRIPCION", vT_Sgpal_Agua_Contaminada.DESCRIPCION);
                    vCmd.Parameters.Add("pID_AGUA_CONTAMINADA", vT_Sgpal_Agua_Contaminada.ID_AGUA_CONTAMINADA);
                    vCmd.Parameters.Add("pPESO_PQ", vT_Sgpal_Agua_Contaminada.PESO_PQ);
                    vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpal_Agua_Contaminada.FLG_ESTADO);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpal_Agua_Contaminada;
        }

        public int AnularT_Sgpal_Agua_ContaminadaPorCodigo(int vId_Agua_Contaminada)
        {
            int vResultado = 0;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_AGUA_CONTAMINADA.USP_DEL_AGUA_CONTAMINADA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_AGUA_CONTAMINADA", vId_Agua_Contaminada);
                    vCnn.Open();
                    vResultado = vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vResultado;
        }

        public IEnumerable<T_Sgpal_Agua_Contaminada> ListarPaginadoT_Sgpal_Agua_Contaminada(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            List<T_Sgpal_Agua_Contaminada> vLista = new List<T_Sgpal_Agua_Contaminada>();
            T_Sgpal_Agua_Contaminada vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_AGUA_CONTAMINADA.USP_PAG_AGUA_CONTAMINADA", vCnn))
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
                        vEntidad = new T_Sgpal_Agua_Contaminada(vRdr);
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