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
    /// Objetivo:	Clase que genera las operaciones para la tabla T_SGPAL_PRESENCIA_LIQUIDO
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	27/10/2021
    /// </summary>
    public partial class T_Sgpal_Presencia_LiquidoAD: BaseAD, IT_Sgpal_Presencia_LiquidoAD
    {   
        public IEnumerable<T_Sgpal_Presencia_Liquido> ListarT_Sgpal_Presencia_Liquido()
        {
           List<T_Sgpal_Presencia_Liquido> vLista = new List<T_Sgpal_Presencia_Liquido>();
           T_Sgpal_Presencia_Liquido vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_PRESENCIA_LIQUIDO.USP_LIS_PRESENCIA_LIQUIDO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpal_Presencia_Liquido(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public T_Sgpal_Presencia_Liquido RecuperarT_Sgpal_Presencia_LiquidoPorCodigo(int vId_Presencia_Liquido)
        {
           T_Sgpal_Presencia_Liquido vEntidad = null;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_PRESENCIA_LIQUIDO.USP_SEL_PRESENCIA_LIQUIDO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_PRESENCIA_LIQUIDO", vId_Presencia_Liquido);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpal_Presencia_Liquido(vRdr);
                    }
                }
                vCnn.Close();
            }
            return vEntidad;
        }

        public T_Sgpal_Presencia_Liquido InsertarT_Sgpal_Presencia_Liquido(T_Sgpal_Presencia_Liquido vT_Sgpal_Presencia_Liquido)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_PRESENCIA_LIQUIDO.USP_INS_PRESENCIA_LIQUIDO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_PRESENCIA_LIQUIDO", vT_Sgpal_Presencia_Liquido.ID_PRESENCIA_LIQUIDO); 
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpal_Presencia_Liquido;
        }
        
        public T_Sgpal_Presencia_Liquido ActualizarT_Sgpal_Presencia_Liquido(T_Sgpal_Presencia_Liquido vT_Sgpal_Presencia_Liquido)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_PRESENCIA_LIQUIDO.USP_UPD_PRESENCIA_LIQUIDO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_PRESENCIA_LIQUIDO", vT_Sgpal_Presencia_Liquido.ID_PRESENCIA_LIQUIDO); 
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpal_Presencia_Liquido;
        }

        public int AnularT_Sgpal_Presencia_LiquidoPorCodigo(int vId_Presencia_Liquido)
        {
            int vResultado = 0;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_PRESENCIA_LIQUIDO.USP_DEL_PRESENCIA_LIQUIDO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_PRESENCIA_LIQUIDO", vId_Presencia_Liquido);
                    vCnn.Open();
                    vResultado = vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vResultado;
        }

        public IEnumerable<T_Sgpal_Presencia_Liquido> ListarPaginadoT_Sgpal_Presencia_Liquido(string vFiltro, int vNumPag, int vCantRegxPag)
        {
           List<T_Sgpal_Presencia_Liquido> vLista = new List<T_Sgpal_Presencia_Liquido>();
           T_Sgpal_Presencia_Liquido vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_PRESENCIA_LIQUIDO.USP_PAG_PRESENCIA_LIQUIDO", vCnn))
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
                        vEntidad = new T_Sgpal_Presencia_Liquido(vRdr);
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