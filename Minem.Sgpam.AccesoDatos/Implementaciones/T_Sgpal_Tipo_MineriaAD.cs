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
    /// Objetivo:	Clase que genera las operaciones para la tabla T_SGPAL_TIPO_MINERIA
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	27/10/2021
    /// </summary>
    public partial class T_Sgpal_Tipo_MineriaAD : BaseAD, IT_Sgpal_Tipo_MineriaAD
    {
        public T_Sgpal_Tipo_MineriaAD(IConfiguration vConfiguration)
        {
            CnnString = vConfiguration.GetSection(Constantes.BD).Value;
        }

        public IEnumerable<T_Sgpal_Tipo_Mineria> ListarT_Sgpal_Tipo_Mineria()
        {
            List<T_Sgpal_Tipo_Mineria> vLista = new List<T_Sgpal_Tipo_Mineria>();
            T_Sgpal_Tipo_Mineria vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_TIPO_MINERIA.USP_LIS_TIPO_MINERIA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpal_Tipo_Mineria(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public T_Sgpal_Tipo_Mineria RecuperarT_Sgpal_Tipo_MineriaPorCodigo(int vId_Tipo_Mineria)
        {
            T_Sgpal_Tipo_Mineria vEntidad = null;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_TIPO_MINERIA.USP_SEL_TIPO_MINERIA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_TIPO_MINERIA", vId_Tipo_Mineria);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpal_Tipo_Mineria(vRdr);
                    }
                }
                vCnn.Close();
            }
            return vEntidad;
        }

        public T_Sgpal_Tipo_Mineria InsertarT_Sgpal_Tipo_Mineria(T_Sgpal_Tipo_Mineria vT_Sgpal_Tipo_Mineria)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_TIPO_MINERIA.USP_INS_TIPO_MINERIA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_TIPO_MINERIA", vT_Sgpal_Tipo_Mineria.ID_TIPO_MINERIA);
                    vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpal_Tipo_Mineria.USU_MODIFICA);
                    vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpal_Tipo_Mineria.FEC_INGRESO);
                    vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpal_Tipo_Mineria.USU_INGRESO);
                    vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpal_Tipo_Mineria.IP_INGRESO);
                    vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpal_Tipo_Mineria.FLG_ESTADO);
                    vCmd.Parameters.Add("pDESCRIPCION", vT_Sgpal_Tipo_Mineria.DESCRIPCION);
                    vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpal_Tipo_Mineria.FEC_MODIFICA);
                    vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpal_Tipo_Mineria.IP_MODIFICA);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpal_Tipo_Mineria;
        }

        public T_Sgpal_Tipo_Mineria ActualizarT_Sgpal_Tipo_Mineria(T_Sgpal_Tipo_Mineria vT_Sgpal_Tipo_Mineria)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_TIPO_MINERIA.USP_UPD_TIPO_MINERIA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_TIPO_MINERIA", vT_Sgpal_Tipo_Mineria.ID_TIPO_MINERIA);
                    vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpal_Tipo_Mineria.USU_MODIFICA);
                    vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpal_Tipo_Mineria.FEC_INGRESO);
                    vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpal_Tipo_Mineria.USU_INGRESO);
                    vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpal_Tipo_Mineria.IP_INGRESO);
                    vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpal_Tipo_Mineria.FLG_ESTADO);
                    vCmd.Parameters.Add("pDESCRIPCION", vT_Sgpal_Tipo_Mineria.DESCRIPCION);
                    vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpal_Tipo_Mineria.FEC_MODIFICA);
                    vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpal_Tipo_Mineria.IP_MODIFICA);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpal_Tipo_Mineria;
        }

        public int AnularT_Sgpal_Tipo_MineriaPorCodigo(int vId_Tipo_Mineria)
        {
            int vResultado = 0;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_TIPO_MINERIA.USP_DEL_TIPO_MINERIA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_TIPO_MINERIA", vId_Tipo_Mineria);
                    vCnn.Open();
                    vResultado = vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vResultado;
        }

        public IEnumerable<T_Sgpal_Tipo_Mineria> ListarPaginadoT_Sgpal_Tipo_Mineria(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            List<T_Sgpal_Tipo_Mineria> vLista = new List<T_Sgpal_Tipo_Mineria>();
            T_Sgpal_Tipo_Mineria vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_TIPO_MINERIA.USP_PAG_TIPO_MINERIA", vCnn))
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
                        vEntidad = new T_Sgpal_Tipo_Mineria(vRdr);
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