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
    /// Objetivo:	Clase que genera las operaciones para la tabla T_SGPAL_TIPO_CLIMA
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	27/10/2021
    /// </summary>
    public partial class T_Sgpal_Tipo_ClimaAD: BaseAD, IT_Sgpal_Tipo_ClimaAD
    {   
        public IEnumerable<T_Sgpal_Tipo_Clima> ListarT_Sgpal_Tipo_Clima()
        {
           List<T_Sgpal_Tipo_Clima> vLista = new List<T_Sgpal_Tipo_Clima>();
           T_Sgpal_Tipo_Clima vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_TIPO_CLIMA.USP_LIS_TIPO_CLIMA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpal_Tipo_Clima(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public T_Sgpal_Tipo_Clima RecuperarT_Sgpal_Tipo_ClimaPorCodigo(int vId_Tipo_Clima)
        {
           T_Sgpal_Tipo_Clima vEntidad = null;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_TIPO_CLIMA.USP_SEL_TIPO_CLIMA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_TIPO_CLIMA", vId_Tipo_Clima);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpal_Tipo_Clima(vRdr);
                    }
                }
                vCnn.Close();
            }
            return vEntidad;
        }

        public T_Sgpal_Tipo_Clima InsertarT_Sgpal_Tipo_Clima(T_Sgpal_Tipo_Clima vT_Sgpal_Tipo_Clima)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_TIPO_CLIMA.USP_INS_TIPO_CLIMA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpal_Tipo_Clima.USU_MODIFICA); 				vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpal_Tipo_Clima.IP_INGRESO); 				vCmd.Parameters.Add("pDESCRIPCION", vT_Sgpal_Tipo_Clima.DESCRIPCION); 				vCmd.Parameters.Add("pID_TIPO_CLIMA", vT_Sgpal_Tipo_Clima.ID_TIPO_CLIMA); 				vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpal_Tipo_Clima.USU_INGRESO); 				vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpal_Tipo_Clima.IP_MODIFICA); 				vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpal_Tipo_Clima.FEC_INGRESO); 				vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpal_Tipo_Clima.FEC_MODIFICA); 				vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpal_Tipo_Clima.FLG_ESTADO);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpal_Tipo_Clima;
        }
        
        public T_Sgpal_Tipo_Clima ActualizarT_Sgpal_Tipo_Clima(T_Sgpal_Tipo_Clima vT_Sgpal_Tipo_Clima)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_TIPO_CLIMA.USP_UPD_TIPO_CLIMA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpal_Tipo_Clima.USU_MODIFICA); 				vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpal_Tipo_Clima.IP_INGRESO); 				vCmd.Parameters.Add("pDESCRIPCION", vT_Sgpal_Tipo_Clima.DESCRIPCION); 				vCmd.Parameters.Add("pID_TIPO_CLIMA", vT_Sgpal_Tipo_Clima.ID_TIPO_CLIMA); 				vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpal_Tipo_Clima.USU_INGRESO); 				vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpal_Tipo_Clima.IP_MODIFICA); 				vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpal_Tipo_Clima.FEC_INGRESO); 				vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpal_Tipo_Clima.FEC_MODIFICA); 				vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpal_Tipo_Clima.FLG_ESTADO);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpal_Tipo_Clima;
        }

        public int AnularT_Sgpal_Tipo_ClimaPorCodigo(int vId_Tipo_Clima)
        {
            int vResultado = 0;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_TIPO_CLIMA.USP_DEL_TIPO_CLIMA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_TIPO_CLIMA", vId_Tipo_Clima);
                    vCnn.Open();
                    vResultado = vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vResultado;
        }

        public IEnumerable<T_Sgpal_Tipo_Clima> ListarPaginadoT_Sgpal_Tipo_Clima(string vFiltro, int vNumPag, int vCantRegxPag)
        {
           List<T_Sgpal_Tipo_Clima> vLista = new List<T_Sgpal_Tipo_Clima>();
           T_Sgpal_Tipo_Clima vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_TIPO_CLIMA.USP_PAG_TIPO_CLIMA", vCnn))
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
                        vEntidad = new T_Sgpal_Tipo_Clima(vRdr);
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