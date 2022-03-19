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
    /// Objetivo:	Clase que genera las operaciones para la tabla T_SGPAH_EUM_MOD
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	27/10/2021
    /// </summary>
    public partial class T_Sgpah_Eum_ModAD: BaseAD, IT_Sgpah_Eum_ModAD
    {
        public T_Sgpah_Eum_ModAD(IConfiguration vConfiguration)
        {
            CnnString = vConfiguration.GetSection(Constantes.BD).Value;
        }

        public IEnumerable<T_Sgpah_Eum_Mod> ListarT_Sgpah_Eum_Mod()
        {
           List<T_Sgpah_Eum_Mod> vLista = new List<T_Sgpah_Eum_Mod>();
           T_Sgpah_Eum_Mod vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_EUM_MOD.USP_LIS_EUM_MOD", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpah_Eum_Mod(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public T_Sgpah_Eum_Mod RecuperarT_Sgpah_Eum_ModPorCodigo(int vId_Eum_Mod)
        {
           T_Sgpah_Eum_Mod vEntidad = null;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_EUM_MOD.USP_SEL_EUM_MOD", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_EUM_MOD", vId_Eum_Mod);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpah_Eum_Mod(vRdr);
                    }
                }
                vCnn.Close();
            }
            return vEntidad;
        }

        public T_Sgpah_Eum_Mod InsertarT_Sgpah_Eum_Mod(T_Sgpah_Eum_Mod vT_Sgpah_Eum_Mod)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_EUM_MOD.USP_INS_EUM_MOD", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    //vCmd.Parameters.Add("pID_EUM_MOD", vT_Sgpah_Eum_Mod.ID_EUM_MOD); 
                    vCmd.Parameters.Add("pID_EUM", vT_Sgpah_Eum_Mod.ID_EUM);
                    vCmd.Parameters.Add("pCARGO", vT_Sgpah_Eum_Mod.CARGO);
                    vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpah_Eum_Mod.USU_INGRESO);
                    vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpah_Eum_Mod.FEC_INGRESO);
                    vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpah_Eum_Mod.IP_INGRESO);
                    vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpah_Eum_Mod.FLG_ESTADO);
                    vCmd.Parameters.Add(":pID_EUM_MOD", OracleDbType.Int64).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vT_Sgpah_Eum_Mod.ID_EUM_MOD = Convert.ToInt32(vCmd.Parameters[":pID_EUM_MOD"].Value.ToString());
                    vCnn.Close();
                }
            }
            return vT_Sgpah_Eum_Mod;
        }
        
        public T_Sgpah_Eum_Mod ActualizarT_Sgpah_Eum_Mod(T_Sgpah_Eum_Mod vT_Sgpah_Eum_Mod)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_EUM_MOD.USP_UPD_EUM_MOD", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_EUM_MOD", vT_Sgpah_Eum_Mod.ID_EUM_MOD);
                    vCmd.Parameters.Add("pCARGO", vT_Sgpah_Eum_Mod.CARGO);
                    vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpah_Eum_Mod.USU_INGRESO);
                    vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpah_Eum_Mod.FEC_INGRESO);
                    vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpah_Eum_Mod.IP_INGRESO);
                    vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpah_Eum_Mod.FLG_ESTADO);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpah_Eum_Mod;
        }

        public int AnularT_Sgpah_Eum_ModPorCodigo(int vId_Eum_Mod)
        {
            int vResultado = 0;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_EUM_MOD.USP_DEL_EUM_MOD", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_EUM_MOD", vId_Eum_Mod);
                    vCnn.Open();
                    vResultado = vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vResultado;
        }

        public IEnumerable<T_Sgpah_Eum_Mod> ListarPaginadoT_Sgpah_Eum_Mod(string vFiltro, int vNumPag, int vCantRegxPag)
        {
           List<T_Sgpah_Eum_Mod> vLista = new List<T_Sgpah_Eum_Mod>();
           T_Sgpah_Eum_Mod vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_EUM_MOD.USP_PAG_EUM_MOD", vCnn))
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
                        vEntidad = new T_Sgpah_Eum_Mod(vRdr);
                        vEntidad.TotalVirtual = System.Convert.ToInt32(vRdr["TotalVirtual"]);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public IEnumerable<T_Sgpah_Eum_Mod> ListarPorIdEumT_Sgpah_Eum_Mod(int vId_Eum)
        {
            List<T_Sgpah_Eum_Mod> vLista = new List<T_Sgpah_Eum_Mod>();
            T_Sgpah_Eum_Mod vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_EUM_MOD.USP_LIS_POR_IDEUM_EUM_MOD", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_EUM", vId_Eum);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();

                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpah_Eum_Mod(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }
    }
}