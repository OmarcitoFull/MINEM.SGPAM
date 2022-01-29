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
    /// Objetivo:	Clase que genera las operaciones para la tabla T_SGPAL_POTENCIAL_ARD
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	27/10/2021
    /// </summary>
    public partial class T_Sgpal_Potencial_ArdAD : BaseAD, IT_Sgpal_Potencial_ArdAD
    {
        public T_Sgpal_Potencial_ArdAD(IConfiguration vConfiguration)
        {
            CnnString = vConfiguration.GetSection(Constantes.BD).Value;
        }

        public IEnumerable<T_Sgpal_Potencial_Ard> ListarT_Sgpal_Potencial_Ard()
        {
            List<T_Sgpal_Potencial_Ard> vLista = new List<T_Sgpal_Potencial_Ard>();
            T_Sgpal_Potencial_Ard vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_POTENCIAL_ARD.USP_LIS_POTENCIAL_ARD", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpal_Potencial_Ard(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public T_Sgpal_Potencial_Ard RecuperarT_Sgpal_Potencial_ArdPorCodigo(int vId_Potencial_Ard)
        {
            T_Sgpal_Potencial_Ard vEntidad = null;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_POTENCIAL_ARD.USP_SEL_POTENCIAL_ARD", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_POTENCIAL_ARD", vId_Potencial_Ard);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpal_Potencial_Ard(vRdr);
                    }
                }
                vCnn.Close();
            }
            return vEntidad;
        }

        public T_Sgpal_Potencial_Ard InsertarT_Sgpal_Potencial_Ard(T_Sgpal_Potencial_Ard vT_Sgpal_Potencial_Ard)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_POTENCIAL_ARD.USP_INS_POTENCIAL_ARD", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pPESO_PQ", vT_Sgpal_Potencial_Ard.PESO_PQ);
                    vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpal_Potencial_Ard.USU_MODIFICA);
                    vCmd.Parameters.Add("pID_POTENCIAL_ARD", vT_Sgpal_Potencial_Ard.ID_POTENCIAL_ARD);
                    vCmd.Parameters.Add("pDESCRIPCION", vT_Sgpal_Potencial_Ard.DESCRIPCION);
                    vCmd.Parameters.Add("pPESO_RM", vT_Sgpal_Potencial_Ard.PESO_RM);
                    vCmd.Parameters.Add("pPESO_LB", vT_Sgpal_Potencial_Ard.PESO_LB);
                    vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpal_Potencial_Ard.FLG_ESTADO);
                    vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpal_Potencial_Ard.USU_INGRESO);
                    vCmd.Parameters.Add("pPESO_ORM", vT_Sgpal_Potencial_Ard.PESO_ORM);
                    vCmd.Parameters.Add("pPESO_I", vT_Sgpal_Potencial_Ard.PESO_I);
                    vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpal_Potencial_Ard.IP_MODIFICA);
                    vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpal_Potencial_Ard.IP_INGRESO);
                    vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpal_Potencial_Ard.FEC_INGRESO);
                    vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpal_Potencial_Ard.FEC_MODIFICA);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpal_Potencial_Ard;
        }

        public T_Sgpal_Potencial_Ard ActualizarT_Sgpal_Potencial_Ard(T_Sgpal_Potencial_Ard vT_Sgpal_Potencial_Ard)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_POTENCIAL_ARD.USP_UPD_POTENCIAL_ARD", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pPESO_PQ", vT_Sgpal_Potencial_Ard.PESO_PQ);
                    vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpal_Potencial_Ard.USU_MODIFICA);
                    vCmd.Parameters.Add("pID_POTENCIAL_ARD", vT_Sgpal_Potencial_Ard.ID_POTENCIAL_ARD);
                    vCmd.Parameters.Add("pDESCRIPCION", vT_Sgpal_Potencial_Ard.DESCRIPCION);
                    vCmd.Parameters.Add("pPESO_RM", vT_Sgpal_Potencial_Ard.PESO_RM);
                    vCmd.Parameters.Add("pPESO_LB", vT_Sgpal_Potencial_Ard.PESO_LB);
                    vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpal_Potencial_Ard.FLG_ESTADO);
                    vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpal_Potencial_Ard.USU_INGRESO);
                    vCmd.Parameters.Add("pPESO_ORM", vT_Sgpal_Potencial_Ard.PESO_ORM);
                    vCmd.Parameters.Add("pPESO_I", vT_Sgpal_Potencial_Ard.PESO_I);
                    vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpal_Potencial_Ard.IP_MODIFICA);
                    vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpal_Potencial_Ard.IP_INGRESO);
                    vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpal_Potencial_Ard.FEC_INGRESO);
                    vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpal_Potencial_Ard.FEC_MODIFICA);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpal_Potencial_Ard;
        }

        public int AnularT_Sgpal_Potencial_ArdPorCodigo(int vId_Potencial_Ard)
        {
            int vResultado = 0;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_POTENCIAL_ARD.USP_DEL_POTENCIAL_ARD", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_POTENCIAL_ARD", vId_Potencial_Ard);
                    vCnn.Open();
                    vResultado = vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vResultado;
        }

        public IEnumerable<T_Sgpal_Potencial_Ard> ListarPaginadoT_Sgpal_Potencial_Ard(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            List<T_Sgpal_Potencial_Ard> vLista = new List<T_Sgpal_Potencial_Ard>();
            T_Sgpal_Potencial_Ard vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_POTENCIAL_ARD.USP_PAG_POTENCIAL_ARD", vCnn))
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
                        vEntidad = new T_Sgpal_Potencial_Ard(vRdr);
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