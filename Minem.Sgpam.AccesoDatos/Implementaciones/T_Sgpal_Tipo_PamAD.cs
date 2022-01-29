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
    /// Objetivo:	Clase que genera las operaciones para la tabla T_SGPAL_TIPO_PAM
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	27/10/2021
    /// </summary>
    public partial class T_Sgpal_Tipo_PamAD : BaseAD, IT_Sgpal_Tipo_PamAD
    {
        public T_Sgpal_Tipo_PamAD(IConfiguration vConfiguration)
        {
            CnnString = vConfiguration.GetSection(Constantes.BD).Value;
        }

        public IEnumerable<T_Sgpal_Tipo_Pam> ListarT_Sgpal_Tipo_Pam()
        {
            List<T_Sgpal_Tipo_Pam> vLista = new List<T_Sgpal_Tipo_Pam>();
            T_Sgpal_Tipo_Pam vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_TIPO_PAM.USP_LIS_TIPO_PAM", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpal_Tipo_Pam(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public T_Sgpal_Tipo_Pam RecuperarT_Sgpal_Tipo_PamPorCodigo(int vId_Tipo_Pam)
        {
            T_Sgpal_Tipo_Pam vEntidad = null;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_TIPO_PAM.USP_SEL_TIPO_PAM", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_TIPO_PAM", vId_Tipo_Pam);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpal_Tipo_Pam(vRdr);
                    }
                }
                vCnn.Close();
            }
            return vEntidad;
        }

        public T_Sgpal_Tipo_Pam InsertarT_Sgpal_Tipo_Pam(T_Sgpal_Tipo_Pam vT_Sgpal_Tipo_Pam)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_TIPO_PAM.USP_INS_TIPO_PAM", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_TIPO_PAM", vT_Sgpal_Tipo_Pam.ID_TIPO_PAM);
                    vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpal_Tipo_Pam.USU_MODIFICA);
                    vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpal_Tipo_Pam.FLG_ESTADO);
                    vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpal_Tipo_Pam.USU_INGRESO);
                    vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpal_Tipo_Pam.FEC_INGRESO);
                    vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpal_Tipo_Pam.FEC_MODIFICA);
                    vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpal_Tipo_Pam.IP_INGRESO);
                    vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpal_Tipo_Pam.IP_MODIFICA);
                    vCmd.Parameters.Add("pDESCRIPCION", vT_Sgpal_Tipo_Pam.DESCRIPCION);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpal_Tipo_Pam;
        }

        public T_Sgpal_Tipo_Pam ActualizarT_Sgpal_Tipo_Pam(T_Sgpal_Tipo_Pam vT_Sgpal_Tipo_Pam)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_TIPO_PAM.USP_UPD_TIPO_PAM", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_TIPO_PAM", vT_Sgpal_Tipo_Pam.ID_TIPO_PAM);
                    vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpal_Tipo_Pam.USU_MODIFICA);
                    vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpal_Tipo_Pam.FLG_ESTADO);
                    vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpal_Tipo_Pam.USU_INGRESO);
                    vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpal_Tipo_Pam.FEC_INGRESO);
                    vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpal_Tipo_Pam.FEC_MODIFICA);
                    vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpal_Tipo_Pam.IP_INGRESO);
                    vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpal_Tipo_Pam.IP_MODIFICA);
                    vCmd.Parameters.Add("pDESCRIPCION", vT_Sgpal_Tipo_Pam.DESCRIPCION);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpal_Tipo_Pam;
        }

        public int AnularT_Sgpal_Tipo_PamPorCodigo(int vId_Tipo_Pam)
        {
            int vResultado = 0;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_TIPO_PAM.USP_DEL_TIPO_PAM", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_TIPO_PAM", vId_Tipo_Pam);
                    vCnn.Open();
                    vResultado = vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vResultado;
        }

        public IEnumerable<T_Sgpal_Tipo_Pam> ListarPaginadoT_Sgpal_Tipo_Pam(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            List<T_Sgpal_Tipo_Pam> vLista = new List<T_Sgpal_Tipo_Pam>();
            T_Sgpal_Tipo_Pam vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_TIPO_PAM.USP_PAG_TIPO_PAM", vCnn))
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
                        vEntidad = new T_Sgpal_Tipo_Pam(vRdr);
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