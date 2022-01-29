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
    /// Objetivo:	Clase que genera las operaciones para la tabla T_SGPAH_COMPONENTE_MOD
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	27/10/2021
    /// </summary>
    public partial class T_Sgpah_Componente_ModAD : BaseAD, IT_Sgpah_Componente_ModAD
    {
        public T_Sgpah_Componente_ModAD(IConfiguration vConfiguration)
        {
            CnnString = vConfiguration.GetSection(Constantes.BD).Value;
        }

        public IEnumerable<T_Sgpah_Componente_Mod> ListarT_Sgpah_Componente_Mod(int vIdComponente)
        {
            List<T_Sgpah_Componente_Mod> vLista = new List<T_Sgpah_Componente_Mod>();
            T_Sgpah_Componente_Mod vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMPONENTE_MOD.USP_LIS_COMPONENTE_MOD", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_COMPONENTE", vIdComponente);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpah_Componente_Mod(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public T_Sgpah_Componente_Mod RecuperarT_Sgpah_Componente_ModPorCodigo(int vId_Componente_Mod)
        {
            T_Sgpah_Componente_Mod vEntidad = null;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMPONENTE_MOD.USP_SEL_COMPONENTE_MOD", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_COMPONENTE_MOD", vId_Componente_Mod);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpah_Componente_Mod(vRdr);
                    }
                }
                vCnn.Close();
            }
            return vEntidad;
        }

        public T_Sgpah_Componente_Mod InsertarT_Sgpah_Componente_Mod(T_Sgpah_Componente_Mod vT_Sgpah_Componente_Mod)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMPONENTE_MOD.USP_INS_COMPONENTE_MOD", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpah_Componente_Mod.FEC_INGRESO);
                    vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpah_Componente_Mod.IP_INGRESO);
                    vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpah_Componente_Mod.USU_INGRESO);
                    vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpah_Componente_Mod.FLG_ESTADO);
                    //vCmd.Parameters.Add("pID_COMPONENTE_MOD", vT_Sgpah_Componente_Mod.ID_COMPONENTE_MOD);
                    vCmd.Parameters.Add("pID_COMPONENTE", vT_Sgpah_Componente_Mod.ID_COMPONENTE);
                    vCmd.Parameters.Add("pCARGO", vT_Sgpah_Componente_Mod.CARGO);
                    vCmd.Parameters.Add(":pID_COMPONENTE_MOD", OracleDbType.Int64).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vT_Sgpah_Componente_Mod.ID_COMPONENTE_MOD = Convert.ToInt32(vCmd.Parameters[":pID_COMPONENTE_MOD"].Value.ToString());
                    vCnn.Close();
                }
            }
            return vT_Sgpah_Componente_Mod;
        }

        public T_Sgpah_Componente_Mod ActualizarT_Sgpah_Componente_Mod(T_Sgpah_Componente_Mod vT_Sgpah_Componente_Mod)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMPONENTE_MOD.USP_UPD_COMPONENTE_MOD", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpah_Componente_Mod.FEC_INGRESO);
                    vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpah_Componente_Mod.IP_INGRESO);
                    vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpah_Componente_Mod.USU_INGRESO);
                    vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpah_Componente_Mod.FLG_ESTADO);
                    vCmd.Parameters.Add("pID_COMPONENTE_MOD", vT_Sgpah_Componente_Mod.ID_COMPONENTE_MOD);
                    vCmd.Parameters.Add("pID_COMPONENTE", vT_Sgpah_Componente_Mod.ID_COMPONENTE);
                    vCmd.Parameters.Add("pCARGO", vT_Sgpah_Componente_Mod.CARGO);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpah_Componente_Mod;
        }

        public int AnularT_Sgpah_Componente_ModPorCodigo(int vId_Componente_Mod)
        {
            int vResultado = 0;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMPONENTE_MOD.USP_DEL_COMPONENTE_MOD", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_COMPONENTE_MOD", vId_Componente_Mod);
                    vCnn.Open();
                    vResultado = vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vResultado;
        }

        public IEnumerable<T_Sgpah_Componente_Mod> ListarPaginadoT_Sgpah_Componente_Mod(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            List<T_Sgpah_Componente_Mod> vLista = new List<T_Sgpah_Componente_Mod>();
            T_Sgpah_Componente_Mod vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMPONENTE_MOD.USP_PAG_COMPONENTE_MOD", vCnn))
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
                        vEntidad = new T_Sgpah_Componente_Mod(vRdr);
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