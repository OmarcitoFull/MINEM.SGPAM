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
    /// Objetivo:	Clase que genera las operaciones para la tabla T_SGPAL_TIPO_ENCARGO
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	27/10/2021
    /// </summary>
    public partial class T_Sgpal_Tipo_EncargoAD : BaseAD, IT_Sgpal_Tipo_EncargoAD
    {
        public T_Sgpal_Tipo_EncargoAD(IConfiguration vConfiguration)
        {
            CnnString = vConfiguration.GetSection(Constantes.BD).Value;
        }

        public IEnumerable<T_Sgpal_Tipo_Encargo> ListarT_Sgpal_Tipo_Encargo()
        {
            List<T_Sgpal_Tipo_Encargo> vLista = new List<T_Sgpal_Tipo_Encargo>();
            T_Sgpal_Tipo_Encargo vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_TIPO_ENCARGO.USP_LIS_TIPO_ENCARGO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpal_Tipo_Encargo(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public T_Sgpal_Tipo_Encargo RecuperarT_Sgpal_Tipo_EncargoPorCodigo(int vId_Tipo_Encargo)
        {
            T_Sgpal_Tipo_Encargo vEntidad = null;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_TIPO_ENCARGO.USP_SEL_TIPO_ENCARGO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_TIPO_ENCARGO", vId_Tipo_Encargo);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpal_Tipo_Encargo(vRdr);
                    }
                }
                vCnn.Close();
            }
            return vEntidad;
        }

        public T_Sgpal_Tipo_Encargo InsertarT_Sgpal_Tipo_Encargo(T_Sgpal_Tipo_Encargo vT_Sgpal_Tipo_Encargo)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_TIPO_ENCARGO.USP_INS_TIPO_ENCARGO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_TIPO_ENCARGO", vT_Sgpal_Tipo_Encargo.ID_TIPO_ENCARGO);
                    vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpal_Tipo_Encargo.USU_MODIFICA);
                    vCmd.Parameters.Add("pDESCRIPCION", vT_Sgpal_Tipo_Encargo.DESCRIPCION);
                    vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpal_Tipo_Encargo.IP_INGRESO);
                    vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpal_Tipo_Encargo.FLG_ESTADO);
                    vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpal_Tipo_Encargo.USU_INGRESO);
                    vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpal_Tipo_Encargo.FEC_MODIFICA);
                    vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpal_Tipo_Encargo.IP_MODIFICA);
                    vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpal_Tipo_Encargo.FEC_INGRESO);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpal_Tipo_Encargo;
        }

        public T_Sgpal_Tipo_Encargo ActualizarT_Sgpal_Tipo_Encargo(T_Sgpal_Tipo_Encargo vT_Sgpal_Tipo_Encargo)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_TIPO_ENCARGO.USP_UPD_TIPO_ENCARGO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_TIPO_ENCARGO", vT_Sgpal_Tipo_Encargo.ID_TIPO_ENCARGO);
                    vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpal_Tipo_Encargo.USU_MODIFICA);
                    vCmd.Parameters.Add("pDESCRIPCION", vT_Sgpal_Tipo_Encargo.DESCRIPCION);
                    vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpal_Tipo_Encargo.IP_INGRESO);
                    vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpal_Tipo_Encargo.FLG_ESTADO);
                    vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpal_Tipo_Encargo.USU_INGRESO);
                    vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpal_Tipo_Encargo.FEC_MODIFICA);
                    vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpal_Tipo_Encargo.IP_MODIFICA);
                    vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpal_Tipo_Encargo.FEC_INGRESO);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpal_Tipo_Encargo;
        }

        public int AnularT_Sgpal_Tipo_EncargoPorCodigo(int vId_Tipo_Encargo)
        {
            int vResultado = 0;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_TIPO_ENCARGO.USP_DEL_TIPO_ENCARGO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_TIPO_ENCARGO", vId_Tipo_Encargo);
                    vCnn.Open();
                    vResultado = vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vResultado;
        }

        public IEnumerable<T_Sgpal_Tipo_Encargo> ListarPaginadoT_Sgpal_Tipo_Encargo(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            List<T_Sgpal_Tipo_Encargo> vLista = new List<T_Sgpal_Tipo_Encargo>();
            T_Sgpal_Tipo_Encargo vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_TIPO_ENCARGO.USP_PAG_TIPO_ENCARGO", vCnn))
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
                        vEntidad = new T_Sgpal_Tipo_Encargo(vRdr);
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