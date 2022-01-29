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
    /// Objetivo:	Clase que genera las operaciones para la tabla T_SGPAL_HUMEDAD
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	27/10/2021
    /// </summary>
    public partial class T_Sgpal_HumedadAD : BaseAD, IT_Sgpal_HumedadAD
    {
        public T_Sgpal_HumedadAD(IConfiguration vConfiguration)
        {
            CnnString = vConfiguration.GetSection(Constantes.BD).Value;
        }

        public IEnumerable<T_Sgpal_Humedad> ListarT_Sgpal_Humedad()
        {
            List<T_Sgpal_Humedad> vLista = new List<T_Sgpal_Humedad>();
            T_Sgpal_Humedad vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_HUMEDAD.USP_LIS_HUMEDAD", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpal_Humedad(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public T_Sgpal_Humedad RecuperarT_Sgpal_HumedadPorCodigo(int vId_Humedad)
        {
            T_Sgpal_Humedad vEntidad = null;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_HUMEDAD.USP_SEL_HUMEDAD", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_HUMEDAD", vId_Humedad);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpal_Humedad(vRdr);
                    }
                }
                vCnn.Close();
            }
            return vEntidad;
        }

        public T_Sgpal_Humedad InsertarT_Sgpal_Humedad(T_Sgpal_Humedad vT_Sgpal_Humedad)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_HUMEDAD.USP_INS_HUMEDAD", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpal_Humedad.FEC_MODIFICA);
                    vCmd.Parameters.Add("pDESCRIPCION", vT_Sgpal_Humedad.DESCRIPCION);
                    vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpal_Humedad.USU_INGRESO);
                    vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpal_Humedad.FEC_INGRESO);
                    vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpal_Humedad.IP_INGRESO);
                    vCmd.Parameters.Add("pID_HUMEDAD", vT_Sgpal_Humedad.ID_HUMEDAD);
                    vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpal_Humedad.IP_MODIFICA);
                    vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpal_Humedad.FLG_ESTADO);
                    vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpal_Humedad.USU_MODIFICA);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpal_Humedad;
        }

        public T_Sgpal_Humedad ActualizarT_Sgpal_Humedad(T_Sgpal_Humedad vT_Sgpal_Humedad)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_HUMEDAD.USP_UPD_HUMEDAD", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpal_Humedad.FEC_MODIFICA);
                    vCmd.Parameters.Add("pDESCRIPCION", vT_Sgpal_Humedad.DESCRIPCION);
                    vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpal_Humedad.USU_INGRESO);
                    vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpal_Humedad.FEC_INGRESO);
                    vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpal_Humedad.IP_INGRESO);
                    vCmd.Parameters.Add("pID_HUMEDAD", vT_Sgpal_Humedad.ID_HUMEDAD);
                    vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpal_Humedad.IP_MODIFICA);
                    vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpal_Humedad.FLG_ESTADO);
                    vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpal_Humedad.USU_MODIFICA);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpal_Humedad;
        }

        public int AnularT_Sgpal_HumedadPorCodigo(int vId_Humedad)
        {
            int vResultado = 0;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_HUMEDAD.USP_DEL_HUMEDAD", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_HUMEDAD", vId_Humedad);
                    vCnn.Open();
                    vResultado = vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vResultado;
        }

        public IEnumerable<T_Sgpal_Humedad> ListarPaginadoT_Sgpal_Humedad(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            List<T_Sgpal_Humedad> vLista = new List<T_Sgpal_Humedad>();
            T_Sgpal_Humedad vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_HUMEDAD.USP_PAG_HUMEDAD", vCnn))
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
                        vEntidad = new T_Sgpal_Humedad(vRdr);
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