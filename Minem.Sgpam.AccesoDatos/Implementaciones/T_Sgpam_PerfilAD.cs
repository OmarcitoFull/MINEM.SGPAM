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
    /// Objetivo:	Clase que genera las operaciones para la tabla T_SGPAM_PERFIL
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	27/10/2021
    /// </summary>
    public partial class T_Sgpam_PerfilAD: BaseAD, IT_Sgpam_PerfilAD
    {   
        public IEnumerable<T_Sgpam_Perfil> ListarT_Sgpam_Perfil()
        {
           List<T_Sgpam_Perfil> vLista = new List<T_Sgpam_Perfil>();
           T_Sgpam_Perfil vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_PERFIL.USP_LIS_PERFIL", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpam_Perfil(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public T_Sgpam_Perfil RecuperarT_Sgpam_PerfilPorCodigo(int vId_Perfil)
        {
           T_Sgpam_Perfil vEntidad = null;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_PERFIL.USP_SEL_PERFIL", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_PERFIL", vId_Perfil);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpam_Perfil(vRdr);
                    }
                }
                vCnn.Close();
            }
            return vEntidad;
        }

        public T_Sgpam_Perfil InsertarT_Sgpam_Perfil(T_Sgpam_Perfil vT_Sgpam_Perfil)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_PERFIL.USP_INS_PERFIL", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpam_Perfil.FLG_ESTADO); 				vCmd.Parameters.Add("pID_PERFIL", vT_Sgpam_Perfil.ID_PERFIL); 				vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpam_Perfil.IP_INGRESO); 				vCmd.Parameters.Add("pDESCRIPCION", vT_Sgpam_Perfil.DESCRIPCION); 				vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpam_Perfil.FEC_MODIFICA); 				vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpam_Perfil.FEC_INGRESO); 				vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpam_Perfil.USU_MODIFICA); 				vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpam_Perfil.USU_INGRESO); 				vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpam_Perfil.IP_MODIFICA);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpam_Perfil;
        }
        
        public T_Sgpam_Perfil ActualizarT_Sgpam_Perfil(T_Sgpam_Perfil vT_Sgpam_Perfil)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_PERFIL.USP_UPD_PERFIL", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpam_Perfil.FLG_ESTADO); 				vCmd.Parameters.Add("pID_PERFIL", vT_Sgpam_Perfil.ID_PERFIL); 				vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpam_Perfil.IP_INGRESO); 				vCmd.Parameters.Add("pDESCRIPCION", vT_Sgpam_Perfil.DESCRIPCION); 				vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpam_Perfil.FEC_MODIFICA); 				vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpam_Perfil.FEC_INGRESO); 				vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpam_Perfil.USU_MODIFICA); 				vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpam_Perfil.USU_INGRESO); 				vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpam_Perfil.IP_MODIFICA);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpam_Perfil;
        }

        public int AnularT_Sgpam_PerfilPorCodigo(int vId_Perfil)
        {
            int vResultado = 0;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_PERFIL.USP_DEL_PERFIL", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_PERFIL", vId_Perfil);
                    vCnn.Open();
                    vResultado = vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vResultado;
        }

        public IEnumerable<T_Sgpam_Perfil> ListarPaginadoT_Sgpam_Perfil(string vFiltro, int vNumPag, int vCantRegxPag)
        {
           List<T_Sgpam_Perfil> vLista = new List<T_Sgpam_Perfil>();
           T_Sgpam_Perfil vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_PERFIL.USP_PAG_PERFIL", vCnn))
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
                        vEntidad = new T_Sgpam_Perfil(vRdr);
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