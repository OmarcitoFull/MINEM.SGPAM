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
    /// Objetivo:	Clase que genera las operaciones para la tabla T_SGPAD_COMP_EST_GESTION
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	27/10/2021
    /// </summary>
    public partial class T_Sgpad_Comp_Est_GestionAD : BaseAD, IT_Sgpad_Comp_Est_GestionAD
    {
        public T_Sgpad_Comp_Est_GestionAD(IConfiguration vConfiguration)
        {
            CnnString = vConfiguration.GetSection(Constantes.BD).Value;
        }

        public IEnumerable<V_Sgpad_Comp_Est_Gestion> ListarT_Sgpad_Comp_Est_Gestion(int vIdComponente)
        {
            List<V_Sgpad_Comp_Est_Gestion> vLista = new List<V_Sgpad_Comp_Est_Gestion>();
            V_Sgpad_Comp_Est_Gestion vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_EST_GESTION.USP_LIS_COMP_EST_GESTION", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_COMPONENTE", vIdComponente);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new V_Sgpad_Comp_Est_Gestion(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public T_Sgpad_Comp_Est_Gestion RecuperarT_Sgpad_Comp_Est_GestionPorCodigo(int vId_Comp_Est_Gestion)
        {
            T_Sgpad_Comp_Est_Gestion vEntidad = null;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_EST_GESTION.USP_SEL_COMP_EST_GESTION", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_COMP_EST_GESTION", vId_Comp_Est_Gestion);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpad_Comp_Est_Gestion(vRdr);
                    }
                }
                vCnn.Close();
            }
            return vEntidad;
        }

        public T_Sgpad_Comp_Est_Gestion InsertarT_Sgpad_Comp_Est_Gestion(T_Sgpad_Comp_Est_Gestion vT_Sgpad_Comp_Est_Gestion)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_EST_GESTION.USP_INS_COMP_EST_GESTION", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    //vCmd.Parameters.Add("pID_COMP_EST_GESTION", vT_Sgpad_Comp_Est_Gestion.ID_COMP_EST_GESTION);
                    vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpad_Comp_Est_Gestion.USU_MODIFICA);
                    vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpad_Comp_Est_Gestion.USU_INGRESO);
                    vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpad_Comp_Est_Gestion.FEC_INGRESO);
                    vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpad_Comp_Est_Gestion.FEC_MODIFICA);
                    vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpad_Comp_Est_Gestion.IP_MODIFICA);
                    vCmd.Parameters.Add("pID_ESTADO_GESTION", vT_Sgpad_Comp_Est_Gestion.ID_ESTADO_GESTION);
                    vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpad_Comp_Est_Gestion.FLG_ESTADO);
                    vCmd.Parameters.Add("pFECHA", vT_Sgpad_Comp_Est_Gestion.FECHA);
                    vCmd.Parameters.Add("pSUSTENTO", vT_Sgpad_Comp_Est_Gestion.SUSTENTO);
                    vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpad_Comp_Est_Gestion.IP_INGRESO);
                    vCmd.Parameters.Add("pID_COMPONENTE", vT_Sgpad_Comp_Est_Gestion.ID_COMPONENTE);
                    vCmd.Parameters.Add(":pID_COMP_EST_GESTION", OracleDbType.Int64).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vT_Sgpad_Comp_Est_Gestion.ID_COMP_EST_GESTION = Convert.ToInt32(vCmd.Parameters[":pID_COMP_EST_GESTION"].Value.ToString());
                    vCnn.Close();
                }
            }
            return vT_Sgpad_Comp_Est_Gestion;
        }

        public T_Sgpad_Comp_Est_Gestion ActualizarT_Sgpad_Comp_Est_Gestion(T_Sgpad_Comp_Est_Gestion vT_Sgpad_Comp_Est_Gestion)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_EST_GESTION.USP_UPD_COMP_EST_GESTION", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_COMP_EST_GESTION", vT_Sgpad_Comp_Est_Gestion.ID_COMP_EST_GESTION);
                    vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpad_Comp_Est_Gestion.USU_MODIFICA);
                    //vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpad_Comp_Est_Gestion.USU_INGRESO);
                    //vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpad_Comp_Est_Gestion.FEC_INGRESO);
                    vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpad_Comp_Est_Gestion.FEC_MODIFICA);
                    vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpad_Comp_Est_Gestion.IP_MODIFICA);
                    vCmd.Parameters.Add("pID_ESTADO_GESTION", vT_Sgpad_Comp_Est_Gestion.ID_ESTADO_GESTION);
                    vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpad_Comp_Est_Gestion.FLG_ESTADO);
                    vCmd.Parameters.Add("pFECHA", vT_Sgpad_Comp_Est_Gestion.FECHA);
                    vCmd.Parameters.Add("pSUSTENTO", vT_Sgpad_Comp_Est_Gestion.SUSTENTO);
                    //vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpad_Comp_Est_Gestion.IP_INGRESO);
                    vCmd.Parameters.Add("pID_COMPONENTE", vT_Sgpad_Comp_Est_Gestion.ID_COMPONENTE);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpad_Comp_Est_Gestion;
        }

        public int AnularT_Sgpad_Comp_Est_GestionPorCodigo(int vId_Comp_Est_Gestion)
        {
            int vResultado = 0;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_EST_GESTION.USP_DEL_COMP_EST_GESTION", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_COMP_EST_GESTION", vId_Comp_Est_Gestion);
                    vCnn.Open();
                    vResultado = vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vResultado;
        }

        public IEnumerable<T_Sgpad_Comp_Est_Gestion> ListarPaginadoT_Sgpad_Comp_Est_Gestion(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            List<T_Sgpad_Comp_Est_Gestion> vLista = new List<T_Sgpad_Comp_Est_Gestion>();
            T_Sgpad_Comp_Est_Gestion vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_EST_GESTION.USP_PAG_COMP_EST_GESTION", vCnn))
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
                        vEntidad = new T_Sgpad_Comp_Est_Gestion(vRdr);
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