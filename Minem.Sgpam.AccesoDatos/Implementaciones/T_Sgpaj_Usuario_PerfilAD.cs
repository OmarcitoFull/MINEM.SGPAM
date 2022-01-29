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
    /// Objetivo:	Clase que genera las operaciones para la tabla T_SGPAJ_USUARIO_PERFIL
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	27/10/2021
    /// </summary>
    public partial class T_Sgpaj_Usuario_PerfilAD: BaseAD, IT_Sgpaj_Usuario_PerfilAD
    {   
        public IEnumerable<T_Sgpaj_Usuario_Perfil> ListarT_Sgpaj_Usuario_Perfil()
        {
           List<T_Sgpaj_Usuario_Perfil> vLista = new List<T_Sgpaj_Usuario_Perfil>();
           T_Sgpaj_Usuario_Perfil vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_USUARIO_PERFIL.USP_LIS_USUARIO_PERFIL", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpaj_Usuario_Perfil(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public T_Sgpaj_Usuario_Perfil RecuperarT_Sgpaj_Usuario_PerfilPorCodigo(int vId_Usuario_Perfil)
        {
           T_Sgpaj_Usuario_Perfil vEntidad = null;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_USUARIO_PERFIL.USP_SEL_USUARIO_PERFIL", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_USUARIO_PERFIL", vId_Usuario_Perfil);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpaj_Usuario_Perfil(vRdr);
                    }
                }
                vCnn.Close();
            }
            return vEntidad;
        }

        public T_Sgpaj_Usuario_Perfil InsertarT_Sgpaj_Usuario_Perfil(T_Sgpaj_Usuario_Perfil vT_Sgpaj_Usuario_Perfil)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_USUARIO_PERFIL.USP_INS_USUARIO_PERFIL", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpaj_Usuario_Perfil.FEC_MODIFICA); 				vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpaj_Usuario_Perfil.USU_INGRESO); 				vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpaj_Usuario_Perfil.IP_INGRESO); 				vCmd.Parameters.Add("pID_USUARIO_PERFIL", vT_Sgpaj_Usuario_Perfil.ID_USUARIO_PERFIL); 				vCmd.Parameters.Add("pID_PERFIL", vT_Sgpaj_Usuario_Perfil.ID_PERFIL); 				vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpaj_Usuario_Perfil.FLG_ESTADO); 				vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpaj_Usuario_Perfil.IP_MODIFICA); 				vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpaj_Usuario_Perfil.USU_MODIFICA); 				vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpaj_Usuario_Perfil.FEC_INGRESO); 				vCmd.Parameters.Add("pID_USUARIO", vT_Sgpaj_Usuario_Perfil.ID_USUARIO);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpaj_Usuario_Perfil;
        }
        
        public T_Sgpaj_Usuario_Perfil ActualizarT_Sgpaj_Usuario_Perfil(T_Sgpaj_Usuario_Perfil vT_Sgpaj_Usuario_Perfil)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_USUARIO_PERFIL.USP_UPD_USUARIO_PERFIL", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpaj_Usuario_Perfil.FEC_MODIFICA); 				vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpaj_Usuario_Perfil.USU_INGRESO); 				vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpaj_Usuario_Perfil.IP_INGRESO); 				vCmd.Parameters.Add("pID_USUARIO_PERFIL", vT_Sgpaj_Usuario_Perfil.ID_USUARIO_PERFIL); 				vCmd.Parameters.Add("pID_PERFIL", vT_Sgpaj_Usuario_Perfil.ID_PERFIL); 				vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpaj_Usuario_Perfil.FLG_ESTADO); 				vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpaj_Usuario_Perfil.IP_MODIFICA); 				vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpaj_Usuario_Perfil.USU_MODIFICA); 				vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpaj_Usuario_Perfil.FEC_INGRESO); 				vCmd.Parameters.Add("pID_USUARIO", vT_Sgpaj_Usuario_Perfil.ID_USUARIO);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpaj_Usuario_Perfil;
        }

        public int AnularT_Sgpaj_Usuario_PerfilPorCodigo(int vId_Usuario_Perfil)
        {
            int vResultado = 0;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_USUARIO_PERFIL.USP_DEL_USUARIO_PERFIL", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_USUARIO_PERFIL", vId_Usuario_Perfil);
                    vCnn.Open();
                    vResultado = vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vResultado;
        }

        public IEnumerable<T_Sgpaj_Usuario_Perfil> ListarPaginadoT_Sgpaj_Usuario_Perfil(string vFiltro, int vNumPag, int vCantRegxPag)
        {
           List<T_Sgpaj_Usuario_Perfil> vLista = new List<T_Sgpaj_Usuario_Perfil>();
           T_Sgpaj_Usuario_Perfil vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_USUARIO_PERFIL.USP_PAG_USUARIO_PERFIL", vCnn))
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
                        vEntidad = new T_Sgpaj_Usuario_Perfil(vRdr);
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