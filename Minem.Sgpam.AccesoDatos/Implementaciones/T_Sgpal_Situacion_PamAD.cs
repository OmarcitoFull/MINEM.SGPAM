using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Extensions.Configuration;
using Minem.Sgpam.AccesoDatos.Base;
using Minem.Sgpam.AccesoDatos.Interfaces;
using Minem.Sgpam.Entidades;
using Oracle.ManagedDataAccess.Client;

namespace Minem.Sgpam.AccesoDatos.Implementaciones
{
    /// <summary>
    /// Objetivo:	Clase que genera las operaciones para la tabla T_SGPAL_SITUACION_PAM
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	27/10/2021
    /// </summary>
    public partial class T_Sgpal_Situacion_PamAD: BaseAD, IT_Sgpal_Situacion_PamAD
    {   
        public IEnumerable<T_Sgpal_Situacion_Pam> ListarT_Sgpal_Situacion_Pam()
        {
           List<T_Sgpal_Situacion_Pam> vLista = new List<T_Sgpal_Situacion_Pam>();
           T_Sgpal_Situacion_Pam vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_SITUACION_PAM.USP_LIS_SITUACION_PAM", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpal_Situacion_Pam(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public T_Sgpal_Situacion_Pam RecuperarT_Sgpal_Situacion_PamPorCodigo(int vId_Situacion_Pam)
        {
           T_Sgpal_Situacion_Pam vEntidad = null;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_SITUACION_PAM.USP_SEL_SITUACION_PAM", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_SITUACION_PAM", vId_Situacion_Pam);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpal_Situacion_Pam(vRdr);
                    }
                }
                vCnn.Close();
            }
            return vEntidad;
        }

        public T_Sgpal_Situacion_Pam InsertarT_Sgpal_Situacion_Pam(T_Sgpal_Situacion_Pam vT_Sgpal_Situacion_Pam)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_SITUACION_PAM.USP_INS_SITUACION_PAM", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_SITUACION_PAM", vT_Sgpal_Situacion_Pam.ID_SITUACION_PAM); 				vCmd.Parameters.Add("pDESCRIPCION", vT_Sgpal_Situacion_Pam.DESCRIPCION); 				vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpal_Situacion_Pam.IP_INGRESO); 				vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpal_Situacion_Pam.FEC_INGRESO); 				vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpal_Situacion_Pam.USU_INGRESO); 				vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpal_Situacion_Pam.FEC_MODIFICA); 				vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpal_Situacion_Pam.FLG_ESTADO); 				vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpal_Situacion_Pam.USU_MODIFICA); 				vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpal_Situacion_Pam.IP_MODIFICA);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpal_Situacion_Pam;
        }
        
        public T_Sgpal_Situacion_Pam ActualizarT_Sgpal_Situacion_Pam(T_Sgpal_Situacion_Pam vT_Sgpal_Situacion_Pam)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_SITUACION_PAM.USP_UPD_SITUACION_PAM", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_SITUACION_PAM", vT_Sgpal_Situacion_Pam.ID_SITUACION_PAM); 				vCmd.Parameters.Add("pDESCRIPCION", vT_Sgpal_Situacion_Pam.DESCRIPCION); 				vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpal_Situacion_Pam.IP_INGRESO); 				vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpal_Situacion_Pam.FEC_INGRESO); 				vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpal_Situacion_Pam.USU_INGRESO); 				vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpal_Situacion_Pam.FEC_MODIFICA); 				vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpal_Situacion_Pam.FLG_ESTADO); 				vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpal_Situacion_Pam.USU_MODIFICA); 				vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpal_Situacion_Pam.IP_MODIFICA);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpal_Situacion_Pam;
        }

        public int AnularT_Sgpal_Situacion_PamPorCodigo(int vId_Situacion_Pam)
        {
            int vResultado = 0;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_SITUACION_PAM.USP_DEL_SITUACION_PAM", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_SITUACION_PAM", vId_Situacion_Pam);
                    vCnn.Open();
                    vResultado = vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vResultado;
        }

        public IEnumerable<T_Sgpal_Situacion_Pam> ListarPaginadoT_Sgpal_Situacion_Pam(string vFiltro, int vNumPag, int vCantRegxPag)
        {
           List<T_Sgpal_Situacion_Pam> vLista = new List<T_Sgpal_Situacion_Pam>();
           T_Sgpal_Situacion_Pam vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_SITUACION_PAM.USP_PAG_SITUACION_PAM", vCnn))
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
                        vEntidad = new T_Sgpal_Situacion_Pam(vRdr);
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