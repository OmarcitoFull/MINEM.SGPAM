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
    /// Objetivo:	Clase que genera las operaciones para la tabla T_SGPAL_CONFLICTO_SOCIAL
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	27/10/2021
    /// </summary>
    public partial class T_Sgpal_Conflicto_SocialAD: BaseAD, IT_Sgpal_Conflicto_SocialAD
    {
        public T_Sgpal_Conflicto_SocialAD(IConfiguration vConfiguration)
        {
            CnnString = vConfiguration.GetSection(Constantes.BD).Value;
        }

        public IEnumerable<T_Sgpal_Conflicto_Social> ListarT_Sgpal_Conflicto_Social()
        {
           List<T_Sgpal_Conflicto_Social> vLista = new List<T_Sgpal_Conflicto_Social>();
           T_Sgpal_Conflicto_Social vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_CONFLICTO_SOCIAL.USP_LIS_CONFLICTO_SOCIAL", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpal_Conflicto_Social(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public T_Sgpal_Conflicto_Social RecuperarT_Sgpal_Conflicto_SocialPorCodigo(int vId_Conflicto_Social)
        {
           T_Sgpal_Conflicto_Social vEntidad = null;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_CONFLICTO_SOCIAL.USP_SEL_CONFLICTO_SOCIAL", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_CONFLICTO_SOCIAL", vId_Conflicto_Social);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpal_Conflicto_Social(vRdr);
                    }
                }
                vCnn.Close();
            }
            return vEntidad;
        }

        public T_Sgpal_Conflicto_Social InsertarT_Sgpal_Conflicto_Social(T_Sgpal_Conflicto_Social vT_Sgpal_Conflicto_Social)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_CONFLICTO_SOCIAL.USP_INS_CONFLICTO_SOCIAL", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpal_Conflicto_Social.FEC_MODIFICA); 
				vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpal_Conflicto_Social.FLG_ESTADO); 
				vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpal_Conflicto_Social.IP_MODIFICA); 
				vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpal_Conflicto_Social.FEC_INGRESO); 
				vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpal_Conflicto_Social.IP_INGRESO); 
				vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpal_Conflicto_Social.USU_INGRESO); 
				vCmd.Parameters.Add("pDESCRIPCION", vT_Sgpal_Conflicto_Social.DESCRIPCION); 
				vCmd.Parameters.Add("pID_CONFLICTO_SOCIAL", vT_Sgpal_Conflicto_Social.ID_CONFLICTO_SOCIAL); 
				vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpal_Conflicto_Social.USU_MODIFICA);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpal_Conflicto_Social;
        }
        
        public T_Sgpal_Conflicto_Social ActualizarT_Sgpal_Conflicto_Social(T_Sgpal_Conflicto_Social vT_Sgpal_Conflicto_Social)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_CONFLICTO_SOCIAL.USP_UPD_CONFLICTO_SOCIAL", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpal_Conflicto_Social.FEC_MODIFICA); 
				vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpal_Conflicto_Social.FLG_ESTADO); 
				vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpal_Conflicto_Social.IP_MODIFICA); 
				vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpal_Conflicto_Social.FEC_INGRESO); 
				vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpal_Conflicto_Social.IP_INGRESO); 
				vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpal_Conflicto_Social.USU_INGRESO); 
				vCmd.Parameters.Add("pDESCRIPCION", vT_Sgpal_Conflicto_Social.DESCRIPCION); 
				vCmd.Parameters.Add("pID_CONFLICTO_SOCIAL", vT_Sgpal_Conflicto_Social.ID_CONFLICTO_SOCIAL); 
				vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpal_Conflicto_Social.USU_MODIFICA);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpal_Conflicto_Social;
        }

        public int AnularT_Sgpal_Conflicto_SocialPorCodigo(int vId_Conflicto_Social)
        {
            int vResultado = 0;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_CONFLICTO_SOCIAL.USP_DEL_CONFLICTO_SOCIAL", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_CONFLICTO_SOCIAL", vId_Conflicto_Social);
                    vCnn.Open();
                    vResultado = vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vResultado;
        }

        public IEnumerable<T_Sgpal_Conflicto_Social> ListarPaginadoT_Sgpal_Conflicto_Social(string vFiltro, int vNumPag, int vCantRegxPag)
        {
           List<T_Sgpal_Conflicto_Social> vLista = new List<T_Sgpal_Conflicto_Social>();
           T_Sgpal_Conflicto_Social vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_CONFLICTO_SOCIAL.USP_PAG_CONFLICTO_SOCIAL", vCnn))
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
                        vEntidad = new T_Sgpal_Conflicto_Social(vRdr);
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