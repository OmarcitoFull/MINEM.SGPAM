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
    /// Objetivo:	Clase que genera las operaciones para la tabla T_SGPAD_COMP_RIESGO_SAL_AMB
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	27/10/2021
    /// </summary>
    public partial class T_Sgpad_Comp_Riesgo_Sal_AmbAD : BaseAD, IT_Sgpad_Comp_Riesgo_Sal_AmbAD
    {
        public T_Sgpad_Comp_Riesgo_Sal_AmbAD(IConfiguration vConfiguration)
        {
            CnnString = vConfiguration.GetSection(Constantes.BD).Value;
        }

        public IEnumerable<V_Sgpad_Comp_Riesgo_Sal_Amb> ListarT_Sgpad_Comp_Riesgo_Sal_Amb(int vIdComponente)
        {
            List<V_Sgpad_Comp_Riesgo_Sal_Amb> vLista = new List<V_Sgpad_Comp_Riesgo_Sal_Amb>();
            V_Sgpad_Comp_Riesgo_Sal_Amb vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_RIESGO_SAL_AMB.USP_LIS_COMP_RIESGO_SAL_AMB", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_COMPONENTE", vIdComponente);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new V_Sgpad_Comp_Riesgo_Sal_Amb(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public T_Sgpad_Comp_Riesgo_Sal_Amb RecuperarT_Sgpad_Comp_Riesgo_Sal_AmbPorCodigo(int vId_Comp_Riesgo_Sal_Amb)
        {
            T_Sgpad_Comp_Riesgo_Sal_Amb vEntidad = null;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_RIESGO_SAL_AMB.USP_SEL_COMP_RIESGO_SAL_AMB", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_COMP_RIESGO_SAL_AMB", vId_Comp_Riesgo_Sal_Amb);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpad_Comp_Riesgo_Sal_Amb(vRdr);
                    }
                }
                vCnn.Close();
            }
            return vEntidad;
        }

        public T_Sgpad_Comp_Riesgo_Sal_Amb InsertarT_Sgpad_Comp_Riesgo_Sal_Amb(T_Sgpad_Comp_Riesgo_Sal_Amb vT_Sgpad_Comp_Riesgo_Sal_Amb)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_RIESGO_SAL_AMB.USP_INS_COMP_RIESGO_SAL_AMB", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpad_Comp_Riesgo_Sal_Amb.USU_MODIFICA);
                    vCmd.Parameters.Add("pID_COMPONENTE", vT_Sgpad_Comp_Riesgo_Sal_Amb.ID_COMPONENTE);
                    vCmd.Parameters.Add("pID_EVIDENCIA_INUNDACION", vT_Sgpad_Comp_Riesgo_Sal_Amb.ID_EVIDENCIA_INUNDACION);
                    vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpad_Comp_Riesgo_Sal_Amb.IP_INGRESO);
                    vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpad_Comp_Riesgo_Sal_Amb.FEC_INGRESO);
                    vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpad_Comp_Riesgo_Sal_Amb.FLG_ESTADO);
                    vCmd.Parameters.Add("pID_POTENCIAL_ARD", vT_Sgpad_Comp_Riesgo_Sal_Amb.ID_POTENCIAL_ARD);
                    vCmd.Parameters.Add("pID_EVIDENCIA_EROSION", vT_Sgpad_Comp_Riesgo_Sal_Amb.ID_EVIDENCIA_EROSION);
                    vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpad_Comp_Riesgo_Sal_Amb.IP_MODIFICA);
                    vCmd.Parameters.Add("pID_EVIDENCIA_SUS_TOXICA", vT_Sgpad_Comp_Riesgo_Sal_Amb.ID_EVIDENCIA_SUS_TOXICA);
                    vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpad_Comp_Riesgo_Sal_Amb.FEC_MODIFICA);
                    vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpad_Comp_Riesgo_Sal_Amb.USU_INGRESO);
                    //vCmd.Parameters.Add("pID_COMP_RIESGO_SAL_AMB", vT_Sgpad_Comp_Riesgo_Sal_Amb.ID_COMP_RIESGO_SAL_AMB);
                    vCmd.Parameters.Add(":pID_COMP_RIESGO_SAL_AMB", OracleDbType.Int64).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vT_Sgpad_Comp_Riesgo_Sal_Amb.ID_COMP_RIESGO_SAL_AMB = Convert.ToInt32(vCmd.Parameters[":pID_COMP_RIESGO_SAL_AMB"].Value.ToString());
                    vCnn.Close();
                }
            }
            return vT_Sgpad_Comp_Riesgo_Sal_Amb;
        }

        public T_Sgpad_Comp_Riesgo_Sal_Amb ActualizarT_Sgpad_Comp_Riesgo_Sal_Amb(T_Sgpad_Comp_Riesgo_Sal_Amb vT_Sgpad_Comp_Riesgo_Sal_Amb)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_RIESGO_SAL_AMB.USP_UPD_COMP_RIESGO_SAL_AMB", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpad_Comp_Riesgo_Sal_Amb.USU_MODIFICA);
                    vCmd.Parameters.Add("pID_COMPONENTE", vT_Sgpad_Comp_Riesgo_Sal_Amb.ID_COMPONENTE);
                    vCmd.Parameters.Add("pID_EVIDENCIA_INUNDACION", vT_Sgpad_Comp_Riesgo_Sal_Amb.ID_EVIDENCIA_INUNDACION);
                    //vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpad_Comp_Riesgo_Sal_Amb.IP_INGRESO);
                    //vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpad_Comp_Riesgo_Sal_Amb.FEC_INGRESO);
                    vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpad_Comp_Riesgo_Sal_Amb.FLG_ESTADO);
                    vCmd.Parameters.Add("pID_POTENCIAL_ARD", vT_Sgpad_Comp_Riesgo_Sal_Amb.ID_POTENCIAL_ARD);
                    vCmd.Parameters.Add("pID_EVIDENCIA_EROSION", vT_Sgpad_Comp_Riesgo_Sal_Amb.ID_EVIDENCIA_EROSION);
                    vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpad_Comp_Riesgo_Sal_Amb.IP_MODIFICA);
                    vCmd.Parameters.Add("pID_EVIDENCIA_SUS_TOXICA", vT_Sgpad_Comp_Riesgo_Sal_Amb.ID_EVIDENCIA_SUS_TOXICA);
                    vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpad_Comp_Riesgo_Sal_Amb.FEC_MODIFICA);
                    //vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpad_Comp_Riesgo_Sal_Amb.USU_INGRESO);
                    vCmd.Parameters.Add("pID_COMP_RIESGO_SAL_AMB", vT_Sgpad_Comp_Riesgo_Sal_Amb.ID_COMP_RIESGO_SAL_AMB);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpad_Comp_Riesgo_Sal_Amb;
        }

        public int AnularT_Sgpad_Comp_Riesgo_Sal_AmbPorCodigo(int vId_Comp_Riesgo_Sal_Amb)
        {
            int vResultado = 0;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_RIESGO_SAL_AMB.USP_DEL_COMP_RIESGO_SAL_AMB", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_COMP_RIESGO_SAL_AMB", vId_Comp_Riesgo_Sal_Amb);
                    vCnn.Open();
                    vResultado = vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vResultado;
        }

        public IEnumerable<T_Sgpad_Comp_Riesgo_Sal_Amb> ListarPaginadoT_Sgpad_Comp_Riesgo_Sal_Amb(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            List<T_Sgpad_Comp_Riesgo_Sal_Amb> vLista = new List<T_Sgpad_Comp_Riesgo_Sal_Amb>();
            T_Sgpad_Comp_Riesgo_Sal_Amb vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_RIESGO_SAL_AMB.USP_PAG_COMP_RIESGO_SAL_AMB", vCnn))
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
                        vEntidad = new T_Sgpad_Comp_Riesgo_Sal_Amb(vRdr);
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