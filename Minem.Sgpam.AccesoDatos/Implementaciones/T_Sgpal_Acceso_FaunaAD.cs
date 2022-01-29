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
    /// Objetivo:	Clase que genera las operaciones para la tabla T_SGPAL_ACCESO_FAUNA
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	27/10/2021
    /// </summary>
    public partial class T_Sgpal_Acceso_FaunaAD : BaseAD, IT_Sgpal_Acceso_FaunaAD
    {
        public T_Sgpal_Acceso_FaunaAD(IConfiguration vConfiguration)
        {
            CnnString = vConfiguration.GetSection(Constantes.BD).Value;
        }

        public IEnumerable<T_Sgpal_Acceso_Fauna> ListarT_Sgpal_Acceso_Fauna()
        {
            List<T_Sgpal_Acceso_Fauna> vLista = new List<T_Sgpal_Acceso_Fauna>();
            T_Sgpal_Acceso_Fauna vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_ACCESO_FAUNA.USP_LIS_ACCESO_FAUNA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpal_Acceso_Fauna(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public T_Sgpal_Acceso_Fauna RecuperarT_Sgpal_Acceso_FaunaPorCodigo(int vId_Acceso_Fauna)
        {
            T_Sgpal_Acceso_Fauna vEntidad = null;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_ACCESO_FAUNA.USP_SEL_ACCESO_FAUNA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_ACCESO_FAUNA", vId_Acceso_Fauna);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpal_Acceso_Fauna(vRdr);
                    }
                }
                vCnn.Close();
            }
            return vEntidad;
        }

        public T_Sgpal_Acceso_Fauna InsertarT_Sgpal_Acceso_Fauna(T_Sgpal_Acceso_Fauna vT_Sgpal_Acceso_Fauna)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_ACCESO_FAUNA.USP_INS_ACCESO_FAUNA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pDESCRIPCION", vT_Sgpal_Acceso_Fauna.DESCRIPCION);
                    vCmd.Parameters.Add("pPESO_RM", vT_Sgpal_Acceso_Fauna.PESO_RM);
                    vCmd.Parameters.Add("pPESO_ORM", vT_Sgpal_Acceso_Fauna.PESO_ORM);
                    vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpal_Acceso_Fauna.USU_INGRESO);
                    vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpal_Acceso_Fauna.IP_INGRESO);
                    vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpal_Acceso_Fauna.FEC_INGRESO);
                    vCmd.Parameters.Add("pPESO_PQ", vT_Sgpal_Acceso_Fauna.PESO_PQ);
                    vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpal_Acceso_Fauna.USU_MODIFICA);
                    vCmd.Parameters.Add("pPESO_LB", vT_Sgpal_Acceso_Fauna.PESO_LB);
                    vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpal_Acceso_Fauna.FLG_ESTADO);
                    vCmd.Parameters.Add("pPESO_I", vT_Sgpal_Acceso_Fauna.PESO_I);
                    vCmd.Parameters.Add("pID_ACCESO_FAUNA", vT_Sgpal_Acceso_Fauna.ID_ACCESO_FAUNA);
                    vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpal_Acceso_Fauna.IP_MODIFICA);
                    vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpal_Acceso_Fauna.FEC_MODIFICA);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpal_Acceso_Fauna;
        }

        public T_Sgpal_Acceso_Fauna ActualizarT_Sgpal_Acceso_Fauna(T_Sgpal_Acceso_Fauna vT_Sgpal_Acceso_Fauna)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_ACCESO_FAUNA.USP_UPD_ACCESO_FAUNA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pDESCRIPCION", vT_Sgpal_Acceso_Fauna.DESCRIPCION);
                    vCmd.Parameters.Add("pPESO_RM", vT_Sgpal_Acceso_Fauna.PESO_RM);
                    vCmd.Parameters.Add("pPESO_ORM", vT_Sgpal_Acceso_Fauna.PESO_ORM);
                    vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpal_Acceso_Fauna.USU_INGRESO);
                    vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpal_Acceso_Fauna.IP_INGRESO);
                    vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpal_Acceso_Fauna.FEC_INGRESO);
                    vCmd.Parameters.Add("pPESO_PQ", vT_Sgpal_Acceso_Fauna.PESO_PQ);
                    vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpal_Acceso_Fauna.USU_MODIFICA);
                    vCmd.Parameters.Add("pPESO_LB", vT_Sgpal_Acceso_Fauna.PESO_LB);
                    vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpal_Acceso_Fauna.FLG_ESTADO);
                    vCmd.Parameters.Add("pPESO_I", vT_Sgpal_Acceso_Fauna.PESO_I);
                    vCmd.Parameters.Add("pID_ACCESO_FAUNA", vT_Sgpal_Acceso_Fauna.ID_ACCESO_FAUNA);
                    vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpal_Acceso_Fauna.IP_MODIFICA);
                    vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpal_Acceso_Fauna.FEC_MODIFICA);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpal_Acceso_Fauna;
        }

        public int AnularT_Sgpal_Acceso_FaunaPorCodigo(int vId_Acceso_Fauna)
        {
            int vResultado = 0;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_ACCESO_FAUNA.USP_DEL_ACCESO_FAUNA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_ACCESO_FAUNA", vId_Acceso_Fauna);
                    vCnn.Open();
                    vResultado = vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vResultado;
        }

        public IEnumerable<T_Sgpal_Acceso_Fauna> ListarPaginadoT_Sgpal_Acceso_Fauna(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            List<T_Sgpal_Acceso_Fauna> vLista = new List<T_Sgpal_Acceso_Fauna>();
            T_Sgpal_Acceso_Fauna vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_ACCESO_FAUNA.USP_PAG_ACCESO_FAUNA", vCnn))
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
                        vEntidad = new T_Sgpal_Acceso_Fauna(vRdr);
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