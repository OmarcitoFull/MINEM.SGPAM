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
    /// Objetivo:	Clase que genera las operaciones para la tabla T_SGPAL_POT_COLAPSO
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	27/10/2021
    /// </summary>
    public partial class T_Sgpal_Pot_ColapsoAD : BaseAD, IT_Sgpal_Pot_ColapsoAD
    {
        public T_Sgpal_Pot_ColapsoAD(IConfiguration vConfiguration)
        {
            CnnString = vConfiguration.GetSection(Constantes.BD).Value;
        }

        public IEnumerable<T_Sgpal_Pot_Colapso> ListarT_Sgpal_Pot_Colapso()
        {
            List<T_Sgpal_Pot_Colapso> vLista = new List<T_Sgpal_Pot_Colapso>();
            T_Sgpal_Pot_Colapso vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_POT_COLAPSO.USP_LIS_POT_COLAPSO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpal_Pot_Colapso(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public T_Sgpal_Pot_Colapso RecuperarT_Sgpal_Pot_ColapsoPorCodigo(int vId_Pot_Colapso)
        {
            T_Sgpal_Pot_Colapso vEntidad = null;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_POT_COLAPSO.USP_SEL_POT_COLAPSO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_POT_COLAPSO", vId_Pot_Colapso);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpal_Pot_Colapso(vRdr);
                    }
                }
                vCnn.Close();
            }
            return vEntidad;
        }

        public T_Sgpal_Pot_Colapso InsertarT_Sgpal_Pot_Colapso(T_Sgpal_Pot_Colapso vT_Sgpal_Pot_Colapso)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_POT_COLAPSO.USP_INS_POT_COLAPSO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pDESCRIPCION", vT_Sgpal_Pot_Colapso.DESCRIPCION);
                    vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpal_Pot_Colapso.FLG_ESTADO);
                    vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpal_Pot_Colapso.FEC_MODIFICA);
                    vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpal_Pot_Colapso.IP_MODIFICA);
                    vCmd.Parameters.Add("pPESO_LB", vT_Sgpal_Pot_Colapso.PESO_LB);
                    vCmd.Parameters.Add("pPESO_RM", vT_Sgpal_Pot_Colapso.PESO_RM);
                    vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpal_Pot_Colapso.IP_INGRESO);
                    vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpal_Pot_Colapso.FEC_INGRESO);
                    vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpal_Pot_Colapso.USU_MODIFICA);
                    vCmd.Parameters.Add("pPESO_PQ", vT_Sgpal_Pot_Colapso.PESO_PQ);
                    vCmd.Parameters.Add("pPESO_I", vT_Sgpal_Pot_Colapso.PESO_I);
                    vCmd.Parameters.Add("pPESO_ORM", vT_Sgpal_Pot_Colapso.PESO_ORM);
                    vCmd.Parameters.Add("pID_POT_COLAPSO", vT_Sgpal_Pot_Colapso.ID_POT_COLAPSO);
                    vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpal_Pot_Colapso.USU_INGRESO);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpal_Pot_Colapso;
        }

        public T_Sgpal_Pot_Colapso ActualizarT_Sgpal_Pot_Colapso(T_Sgpal_Pot_Colapso vT_Sgpal_Pot_Colapso)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_POT_COLAPSO.USP_UPD_POT_COLAPSO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pDESCRIPCION", vT_Sgpal_Pot_Colapso.DESCRIPCION);
                    vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpal_Pot_Colapso.FLG_ESTADO);
                    vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpal_Pot_Colapso.FEC_MODIFICA);
                    vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpal_Pot_Colapso.IP_MODIFICA);
                    vCmd.Parameters.Add("pPESO_LB", vT_Sgpal_Pot_Colapso.PESO_LB);
                    vCmd.Parameters.Add("pPESO_RM", vT_Sgpal_Pot_Colapso.PESO_RM);
                    vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpal_Pot_Colapso.IP_INGRESO);
                    vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpal_Pot_Colapso.FEC_INGRESO);
                    vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpal_Pot_Colapso.USU_MODIFICA);
                    vCmd.Parameters.Add("pPESO_PQ", vT_Sgpal_Pot_Colapso.PESO_PQ);
                    vCmd.Parameters.Add("pPESO_I", vT_Sgpal_Pot_Colapso.PESO_I);
                    vCmd.Parameters.Add("pPESO_ORM", vT_Sgpal_Pot_Colapso.PESO_ORM);
                    vCmd.Parameters.Add("pID_POT_COLAPSO", vT_Sgpal_Pot_Colapso.ID_POT_COLAPSO);
                    vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpal_Pot_Colapso.USU_INGRESO);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpal_Pot_Colapso;
        }

        public int AnularT_Sgpal_Pot_ColapsoPorCodigo(int vId_Pot_Colapso)
        {
            int vResultado = 0;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_POT_COLAPSO.USP_DEL_POT_COLAPSO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_POT_COLAPSO", vId_Pot_Colapso);
                    vCnn.Open();
                    vResultado = vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vResultado;
        }

        public IEnumerable<T_Sgpal_Pot_Colapso> ListarPaginadoT_Sgpal_Pot_Colapso(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            List<T_Sgpal_Pot_Colapso> vLista = new List<T_Sgpal_Pot_Colapso>();
            T_Sgpal_Pot_Colapso vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_POT_COLAPSO.USP_PAG_POT_COLAPSO", vCnn))
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
                        vEntidad = new T_Sgpal_Pot_Colapso(vRdr);
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