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
    /// Objetivo:	Clase que genera las operaciones para la tabla T_SGPAD_COMP_RIESGO_FAU_CON
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	27/10/2021
    /// </summary>
    public partial class T_Sgpad_Comp_Riesgo_Fau_ConAD : BaseAD, IT_Sgpad_Comp_Riesgo_Fau_ConAD
    {
        public T_Sgpad_Comp_Riesgo_Fau_ConAD(IConfiguration vConfiguration)
        {
            CnnString = vConfiguration.GetSection(Constantes.BD).Value;
        }

        public IEnumerable<V_Sgpad_Comp_Riesgo_Fau_Con> ListarT_Sgpad_Comp_Riesgo_Fau_Con(int vIdComponente)
        {
            List<V_Sgpad_Comp_Riesgo_Fau_Con> vLista = new List<V_Sgpad_Comp_Riesgo_Fau_Con>();
            V_Sgpad_Comp_Riesgo_Fau_Con vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_RIESGO_FAU_CON.USP_LIS_COMP_RIESGO_FAU_CON", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_COMPONENTE", vIdComponente);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new V_Sgpad_Comp_Riesgo_Fau_Con(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public T_Sgpad_Comp_Riesgo_Fau_Con RecuperarT_Sgpad_Comp_Riesgo_Fau_ConPorCodigo(int vId_Comp_Riesgo_Fau_Con)
        {
            T_Sgpad_Comp_Riesgo_Fau_Con vEntidad = null;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_RIESGO_FAU_CON.USP_SEL_COMP_RIESGO_FAU_CON", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_COMP_RIESGO_FAU_CON", vId_Comp_Riesgo_Fau_Con);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpad_Comp_Riesgo_Fau_Con(vRdr);
                    }
                }
                vCnn.Close();
            }
            return vEntidad;
        }

        public T_Sgpad_Comp_Riesgo_Fau_Con InsertarT_Sgpad_Comp_Riesgo_Fau_Con(T_Sgpad_Comp_Riesgo_Fau_Con vT_Sgpad_Comp_Riesgo_Fau_Con)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_RIESGO_FAU_CON.USP_INS_COMP_RIESGO_FAU_CON", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpad_Comp_Riesgo_Fau_Con.FEC_MODIFICA);
                    vCmd.Parameters.Add("pID_SENSIBILIDAD_AREA", vT_Sgpad_Comp_Riesgo_Fau_Con.ID_SENSIBILIDAD_AREA);
                    //vCmd.Parameters.Add("pID_COMP_RIESGO_FAU_CON", vT_Sgpad_Comp_Riesgo_Fau_Con.ID_COMP_RIESGO_FAU_CON);
                    vCmd.Parameters.Add("pID_ACCESO_FAUNA", vT_Sgpad_Comp_Riesgo_Fau_Con.ID_ACCESO_FAUNA);
                    vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpad_Comp_Riesgo_Fau_Con.IP_MODIFICA);
                    vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpad_Comp_Riesgo_Fau_Con.FEC_INGRESO);
                    vCmd.Parameters.Add("pID_VEGETACION_INVASIVA", vT_Sgpad_Comp_Riesgo_Fau_Con.ID_VEGETACION_INVASIVA);
                    vCmd.Parameters.Add("pID_ATRACCION_FAUNA", vT_Sgpad_Comp_Riesgo_Fau_Con.ID_ATRACCION_FAUNA);
                    vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpad_Comp_Riesgo_Fau_Con.USU_MODIFICA);
                    vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpad_Comp_Riesgo_Fau_Con.USU_INGRESO);
                    vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpad_Comp_Riesgo_Fau_Con.FLG_ESTADO);
                    vCmd.Parameters.Add("pID_CERCA_AREA_PROTEGIDA", vT_Sgpad_Comp_Riesgo_Fau_Con.ID_CERCA_AREA_PROTEGIDA);
                    vCmd.Parameters.Add("pID_AGUA_CONTAMINADA", vT_Sgpad_Comp_Riesgo_Fau_Con.ID_AGUA_CONTAMINADA);
                    vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpad_Comp_Riesgo_Fau_Con.IP_INGRESO);
                    vCmd.Parameters.Add("pID_COMPONENTE", vT_Sgpad_Comp_Riesgo_Fau_Con.ID_COMPONENTE);
                    vCmd.Parameters.Add(":pID_COMP_RIESGO_FAU_CON", OracleDbType.Int64).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vT_Sgpad_Comp_Riesgo_Fau_Con.ID_COMP_RIESGO_FAU_CON = Convert.ToInt32(vCmd.Parameters[":pID_COMP_RIESGO_FAU_CON"].Value.ToString());
                    vCnn.Close();
                }
            }
            return vT_Sgpad_Comp_Riesgo_Fau_Con;
        }

        public T_Sgpad_Comp_Riesgo_Fau_Con ActualizarT_Sgpad_Comp_Riesgo_Fau_Con(T_Sgpad_Comp_Riesgo_Fau_Con vT_Sgpad_Comp_Riesgo_Fau_Con)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_RIESGO_FAU_CON.USP_UPD_COMP_RIESGO_FAU_CON", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpad_Comp_Riesgo_Fau_Con.FEC_MODIFICA);
                    vCmd.Parameters.Add("pID_SENSIBILIDAD_AREA", vT_Sgpad_Comp_Riesgo_Fau_Con.ID_SENSIBILIDAD_AREA);
                    vCmd.Parameters.Add("pID_COMP_RIESGO_FAU_CON", vT_Sgpad_Comp_Riesgo_Fau_Con.ID_COMP_RIESGO_FAU_CON);
                    vCmd.Parameters.Add("pID_ACCESO_FAUNA", vT_Sgpad_Comp_Riesgo_Fau_Con.ID_ACCESO_FAUNA);
                    vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpad_Comp_Riesgo_Fau_Con.IP_MODIFICA);
                    //vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpad_Comp_Riesgo_Fau_Con.FEC_INGRESO);
                    vCmd.Parameters.Add("pID_VEGETACION_INVASIVA", vT_Sgpad_Comp_Riesgo_Fau_Con.ID_VEGETACION_INVASIVA);
                    vCmd.Parameters.Add("pID_ATRACCION_FAUNA", vT_Sgpad_Comp_Riesgo_Fau_Con.ID_ATRACCION_FAUNA);
                    vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpad_Comp_Riesgo_Fau_Con.USU_MODIFICA);
                    //vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpad_Comp_Riesgo_Fau_Con.USU_INGRESO);
                    vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpad_Comp_Riesgo_Fau_Con.FLG_ESTADO);
                    vCmd.Parameters.Add("pID_CERCA_AREA_PROTEGIDA", vT_Sgpad_Comp_Riesgo_Fau_Con.ID_CERCA_AREA_PROTEGIDA);
                    vCmd.Parameters.Add("pID_AGUA_CONTAMINADA", vT_Sgpad_Comp_Riesgo_Fau_Con.ID_AGUA_CONTAMINADA);
                    //vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpad_Comp_Riesgo_Fau_Con.IP_INGRESO);
                    vCmd.Parameters.Add("pID_COMPONENTE", vT_Sgpad_Comp_Riesgo_Fau_Con.ID_COMPONENTE);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpad_Comp_Riesgo_Fau_Con;
        }

        public int AnularT_Sgpad_Comp_Riesgo_Fau_ConPorCodigo(int vId_Comp_Riesgo_Fau_Con)
        {
            int vResultado = 0;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_RIESGO_FAU_CON.USP_DEL_COMP_RIESGO_FAU_CON", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_COMP_RIESGO_FAU_CON", vId_Comp_Riesgo_Fau_Con);
                    vCnn.Open();
                    vResultado = vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vResultado;
        }

        public IEnumerable<T_Sgpad_Comp_Riesgo_Fau_Con> ListarPaginadoT_Sgpad_Comp_Riesgo_Fau_Con(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            List<T_Sgpad_Comp_Riesgo_Fau_Con> vLista = new List<T_Sgpad_Comp_Riesgo_Fau_Con>();
            T_Sgpad_Comp_Riesgo_Fau_Con vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_RIESGO_FAU_CON.USP_PAG_COMP_RIESGO_FAU_CON", vCnn))
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
                        vEntidad = new T_Sgpad_Comp_Riesgo_Fau_Con(vRdr);
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