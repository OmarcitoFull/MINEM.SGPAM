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
    /// Objetivo:	Clase que genera las operaciones para la tabla T_SGPAL_COBERTURA
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	27/10/2021
    /// </summary>
    public partial class T_Sgpal_CargoAD : BaseAD, IT_Sgpal_CargoAD
    {
        public T_Sgpal_CargoAD(IConfiguration vConfiguration)
        {
            CnnString = vConfiguration.GetSection(Constantes.BD).Value;
        }

        public IEnumerable<T_Sgpal_Cargo> ListarT_Sgpal_Cargo()
        {
            List<T_Sgpal_Cargo> vLista = new List<T_Sgpal_Cargo>();
            T_Sgpal_Cargo vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_CARGO.USP_LIS_CARGO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpal_Cargo(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public T_Sgpal_Cargo RecuperarT_Sgpal_CargoPorCodigo(int vId_Cargo)
        {
            T_Sgpal_Cargo vEntidad = null;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_CARGO.USP_SEL_CARGO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_CARGO", vId_Cargo);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpal_Cargo(vRdr);
                    }
                }
                vCnn.Close();
            }
            return vEntidad;
        }

        public T_Sgpal_Cargo InsertarT_Sgpal_Cargo(T_Sgpal_Cargo vT_Sgpal_Cargo)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_CARGO.USP_INS_CARGO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pDESCRIPCION", vT_Sgpal_Cargo.DESCRIPCION);
                    vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpal_Cargo.USU_INGRESO);
                    vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpal_Cargo.FEC_INGRESO);
                    vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpal_Cargo.IP_INGRESO);
                    vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpal_Cargo.FLG_ESTADO);
                    vCmd.Parameters.Add(":pID_CARGO", OracleDbType.Int64).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vT_Sgpal_Cargo.ID_CARGO = Convert.ToInt32(vCmd.Parameters[":pID_CARGO"].Value.ToString());
                    vCnn.Close();
                }
            }
            return vT_Sgpal_Cargo;
        }

        public T_Sgpal_Cargo ActualizarT_Sgpal_Cargo(T_Sgpal_Cargo vT_Sgpal_Cargo)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_CARGO.USP_UPD_CARGO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_CARGO", vT_Sgpal_Cargo.ID_CARGO);
                    vCmd.Parameters.Add("pDESCRIPCION", vT_Sgpal_Cargo.DESCRIPCION);
                    vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpal_Cargo.USU_MODIFICA);
                    vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpal_Cargo.FEC_MODIFICA);
                    vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpal_Cargo.IP_MODIFICA);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpal_Cargo;
        }

        public int AnularT_Sgpal_CargoPorCodigo(int vId_Cargo)
        {
            int vResultado = 0;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_CARGO.USP_DEL_CARGO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_CARGO", vId_Cargo);
                    vCnn.Open();
                    vResultado = vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vResultado;
        }

        public IEnumerable<T_Sgpal_Cargo> ListarPaginadoT_Sgpal_Cargo(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            List<T_Sgpal_Cargo> vLista = new List<T_Sgpal_Cargo>();
            T_Sgpal_Cargo vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_CARGO.USP_PAG_CARGO", vCnn))
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
                        vEntidad = new T_Sgpal_Cargo(vRdr);
                        //vEntidad.TotalVirtual = System.Convert.ToInt32(vRdr["TotalVirtual"]);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

    }
}
