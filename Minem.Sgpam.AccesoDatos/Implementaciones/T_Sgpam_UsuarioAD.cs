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
    /// Objetivo:	Clase que genera las operaciones para la tabla T_SGPAM_USUARIO
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	27/10/2021
    /// </summary>
    public partial class T_Sgpam_UsuarioAD: BaseAD, IT_Sgpam_UsuarioAD
    {   
        public IEnumerable<T_Sgpam_Usuario> ListarT_Sgpam_Usuario()
        {
           List<T_Sgpam_Usuario> vLista = new List<T_Sgpam_Usuario>();
           T_Sgpam_Usuario vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_USUARIO.USP_LIS_USUARIO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpam_Usuario(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public T_Sgpam_Usuario RecuperarT_Sgpam_UsuarioPorCodigo(int vId_Usuario)
        {
           T_Sgpam_Usuario vEntidad = null;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_USUARIO.USP_SEL_USUARIO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_USUARIO", vId_Usuario);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpam_Usuario(vRdr);
                    }
                }
                vCnn.Close();
            }
            return vEntidad;
        }

        public T_Sgpam_Usuario InsertarT_Sgpam_Usuario(T_Sgpam_Usuario vT_Sgpam_Usuario)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_USUARIO.USP_INS_USUARIO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_USUARIO", vT_Sgpam_Usuario.ID_USUARIO); 				vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpam_Usuario.FLG_ESTADO); 				vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpam_Usuario.FEC_INGRESO); 				vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpam_Usuario.FEC_MODIFICA); 				vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpam_Usuario.USU_INGRESO); 				vCmd.Parameters.Add("pNOMBRE_USUARIO", vT_Sgpam_Usuario.NOMBRE_USUARIO); 				vCmd.Parameters.Add("pCOD_USUARIO", vT_Sgpam_Usuario.COD_USUARIO); 				vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpam_Usuario.IP_MODIFICA); 				vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpam_Usuario.IP_INGRESO); 				vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpam_Usuario.USU_MODIFICA);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpam_Usuario;
        }
        
        public T_Sgpam_Usuario ActualizarT_Sgpam_Usuario(T_Sgpam_Usuario vT_Sgpam_Usuario)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_USUARIO.USP_UPD_USUARIO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_USUARIO", vT_Sgpam_Usuario.ID_USUARIO); 				vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpam_Usuario.FLG_ESTADO); 				vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpam_Usuario.FEC_INGRESO); 				vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpam_Usuario.FEC_MODIFICA); 				vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpam_Usuario.USU_INGRESO); 				vCmd.Parameters.Add("pNOMBRE_USUARIO", vT_Sgpam_Usuario.NOMBRE_USUARIO); 				vCmd.Parameters.Add("pCOD_USUARIO", vT_Sgpam_Usuario.COD_USUARIO); 				vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpam_Usuario.IP_MODIFICA); 				vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpam_Usuario.IP_INGRESO); 				vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpam_Usuario.USU_MODIFICA);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpam_Usuario;
        }

        public int AnularT_Sgpam_UsuarioPorCodigo(int vId_Usuario)
        {
            int vResultado = 0;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_USUARIO.USP_DEL_USUARIO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_USUARIO", vId_Usuario);
                    vCnn.Open();
                    vResultado = vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vResultado;
        }

        public IEnumerable<T_Sgpam_Usuario> ListarPaginadoT_Sgpam_Usuario(string vFiltro, int vNumPag, int vCantRegxPag)
        {
           List<T_Sgpam_Usuario> vLista = new List<T_Sgpam_Usuario>();
           T_Sgpam_Usuario vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_USUARIO.USP_PAG_USUARIO", vCnn))
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
                        vEntidad = new T_Sgpam_Usuario(vRdr);
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