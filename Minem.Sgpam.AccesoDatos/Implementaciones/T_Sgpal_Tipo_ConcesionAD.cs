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
    /// Objetivo:	Clase que genera las operaciones para la tabla T_SGPAL_TIPO_CONCESION
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	27/10/2021
    /// </summary>
    public partial class T_Sgpal_Tipo_ConcesionAD : BaseAD, IT_Sgpal_Tipo_ConcesionAD
    {
        public T_Sgpal_Tipo_ConcesionAD(IConfiguration vConfiguration)
        {
            CnnString = vConfiguration.GetSection(Constantes.BD).Value;
        }

        public IEnumerable<T_Sgpal_Tipo_Concesion> ListarT_Sgpal_Tipo_Concesion()
        {
            List<T_Sgpal_Tipo_Concesion> vLista = new List<T_Sgpal_Tipo_Concesion>();
            T_Sgpal_Tipo_Concesion vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_TIPO_CONCESION.USP_LIS_TIPO_CONCESION", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpal_Tipo_Concesion(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public T_Sgpal_Tipo_Concesion RecuperarT_Sgpal_Tipo_ConcesionPorCodigo(int vId_Tipo_Concesion)
        {
            T_Sgpal_Tipo_Concesion vEntidad = null;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_TIPO_CONCESION.USP_SEL_TIPO_CONCESION", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_TIPO_CONCESION", vId_Tipo_Concesion);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpal_Tipo_Concesion(vRdr);
                    }
                }
                vCnn.Close();
            }
            return vEntidad;
        }

        public T_Sgpal_Tipo_Concesion InsertarT_Sgpal_Tipo_Concesion(T_Sgpal_Tipo_Concesion vT_Sgpal_Tipo_Concesion)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_TIPO_CONCESION.USP_INS_TIPO_CONCESION", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_TIPO_CONCESION", vT_Sgpal_Tipo_Concesion.ID_TIPO_CONCESION);
                    vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpal_Tipo_Concesion.IP_MODIFICA);
                    vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpal_Tipo_Concesion.FLG_ESTADO);
                    vCmd.Parameters.Add("pDESCRIPCION", vT_Sgpal_Tipo_Concesion.DESCRIPCION);
                    vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpal_Tipo_Concesion.USU_MODIFICA);
                    vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpal_Tipo_Concesion.USU_INGRESO);
                    vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpal_Tipo_Concesion.FEC_INGRESO);
                    vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpal_Tipo_Concesion.FEC_MODIFICA);
                    vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpal_Tipo_Concesion.IP_INGRESO);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpal_Tipo_Concesion;
        }

        public T_Sgpal_Tipo_Concesion ActualizarT_Sgpal_Tipo_Concesion(T_Sgpal_Tipo_Concesion vT_Sgpal_Tipo_Concesion)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_TIPO_CONCESION.USP_UPD_TIPO_CONCESION", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_TIPO_CONCESION", vT_Sgpal_Tipo_Concesion.ID_TIPO_CONCESION);
                    vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpal_Tipo_Concesion.IP_MODIFICA);
                    vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpal_Tipo_Concesion.FLG_ESTADO);
                    vCmd.Parameters.Add("pDESCRIPCION", vT_Sgpal_Tipo_Concesion.DESCRIPCION);
                    vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpal_Tipo_Concesion.USU_MODIFICA);
                    vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpal_Tipo_Concesion.USU_INGRESO);
                    vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpal_Tipo_Concesion.FEC_INGRESO);
                    vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpal_Tipo_Concesion.FEC_MODIFICA);
                    vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpal_Tipo_Concesion.IP_INGRESO);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpal_Tipo_Concesion;
        }

        public int AnularT_Sgpal_Tipo_ConcesionPorCodigo(int vId_Tipo_Concesion)
        {
            int vResultado = 0;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_TIPO_CONCESION.USP_DEL_TIPO_CONCESION", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_TIPO_CONCESION", vId_Tipo_Concesion);
                    vCnn.Open();
                    vResultado = vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vResultado;
        }

        public IEnumerable<T_Sgpal_Tipo_Concesion> ListarPaginadoT_Sgpal_Tipo_Concesion(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            List<T_Sgpal_Tipo_Concesion> vLista = new List<T_Sgpal_Tipo_Concesion>();
            T_Sgpal_Tipo_Concesion vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_TIPO_CONCESION.USP_PAG_TIPO_CONCESION", vCnn))
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
                        vEntidad = new T_Sgpal_Tipo_Concesion(vRdr);
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