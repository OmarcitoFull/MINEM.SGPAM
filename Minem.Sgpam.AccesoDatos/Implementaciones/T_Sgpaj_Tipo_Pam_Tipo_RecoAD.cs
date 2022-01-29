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
    /// Objetivo:	Clase que genera las operaciones para la tabla T_SGPAJ_TIPO_PAM_TIPO_RECO
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	27/10/2021
    /// </summary>
    public partial class T_Sgpaj_Tipo_Pam_Tipo_RecoAD: BaseAD, IT_Sgpaj_Tipo_Pam_Tipo_RecoAD
    {   
        public IEnumerable<T_Sgpaj_Tipo_Pam_Tipo_Reco> ListarT_Sgpaj_Tipo_Pam_Tipo_Reco()
        {
           List<T_Sgpaj_Tipo_Pam_Tipo_Reco> vLista = new List<T_Sgpaj_Tipo_Pam_Tipo_Reco>();
           T_Sgpaj_Tipo_Pam_Tipo_Reco vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_TIPO_PAM_TIPO_RECO.USP_LIS_TIPO_PAM_TIPO_RECO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpaj_Tipo_Pam_Tipo_Reco(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public T_Sgpaj_Tipo_Pam_Tipo_Reco RecuperarT_Sgpaj_Tipo_Pam_Tipo_RecoPorCodigo(int vId_Tipo_Pam_Tipo_Reco)
        {
           T_Sgpaj_Tipo_Pam_Tipo_Reco vEntidad = null;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_TIPO_PAM_TIPO_RECO.USP_SEL_TIPO_PAM_TIPO_RECO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_TIPO_PAM_TIPO_RECO", vId_Tipo_Pam_Tipo_Reco);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpaj_Tipo_Pam_Tipo_Reco(vRdr);
                    }
                }
                vCnn.Close();
            }
            return vEntidad;
        }

        public T_Sgpaj_Tipo_Pam_Tipo_Reco InsertarT_Sgpaj_Tipo_Pam_Tipo_Reco(T_Sgpaj_Tipo_Pam_Tipo_Reco vT_Sgpaj_Tipo_Pam_Tipo_Reco)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_TIPO_PAM_TIPO_RECO.USP_INS_TIPO_PAM_TIPO_RECO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_TIPO_PAM_TIPO_RECO", vT_Sgpaj_Tipo_Pam_Tipo_Reco.ID_TIPO_PAM_TIPO_RECO); 
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpaj_Tipo_Pam_Tipo_Reco;
        }
        
        public T_Sgpaj_Tipo_Pam_Tipo_Reco ActualizarT_Sgpaj_Tipo_Pam_Tipo_Reco(T_Sgpaj_Tipo_Pam_Tipo_Reco vT_Sgpaj_Tipo_Pam_Tipo_Reco)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_TIPO_PAM_TIPO_RECO.USP_UPD_TIPO_PAM_TIPO_RECO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_TIPO_PAM_TIPO_RECO", vT_Sgpaj_Tipo_Pam_Tipo_Reco.ID_TIPO_PAM_TIPO_RECO); 
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpaj_Tipo_Pam_Tipo_Reco;
        }

        public int AnularT_Sgpaj_Tipo_Pam_Tipo_RecoPorCodigo(int vId_Tipo_Pam_Tipo_Reco)
        {
            int vResultado = 0;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_TIPO_PAM_TIPO_RECO.USP_DEL_TIPO_PAM_TIPO_RECO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_TIPO_PAM_TIPO_RECO", vId_Tipo_Pam_Tipo_Reco);
                    vCnn.Open();
                    vResultado = vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vResultado;
        }

        public IEnumerable<T_Sgpaj_Tipo_Pam_Tipo_Reco> ListarPaginadoT_Sgpaj_Tipo_Pam_Tipo_Reco(string vFiltro, int vNumPag, int vCantRegxPag)
        {
           List<T_Sgpaj_Tipo_Pam_Tipo_Reco> vLista = new List<T_Sgpaj_Tipo_Pam_Tipo_Reco>();
           T_Sgpaj_Tipo_Pam_Tipo_Reco vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_TIPO_PAM_TIPO_RECO.USP_PAG_TIPO_PAM_TIPO_RECO", vCnn))
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
                        vEntidad = new T_Sgpaj_Tipo_Pam_Tipo_Reco(vRdr);
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