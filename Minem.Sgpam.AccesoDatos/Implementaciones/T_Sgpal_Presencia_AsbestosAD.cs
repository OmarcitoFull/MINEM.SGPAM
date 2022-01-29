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
    /// Objetivo:	Clase que genera las operaciones para la tabla T_SGPAL_PRESENCIA_ASBESTOS
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	27/10/2021
    /// </summary>
    public partial class T_Sgpal_Presencia_AsbestosAD: BaseAD, IT_Sgpal_Presencia_AsbestosAD
    {   
        public IEnumerable<T_Sgpal_Presencia_Asbestos> ListarT_Sgpal_Presencia_Asbestos()
        {
           List<T_Sgpal_Presencia_Asbestos> vLista = new List<T_Sgpal_Presencia_Asbestos>();
           T_Sgpal_Presencia_Asbestos vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_PRESENCIA_ASBESTOS.USP_LIS_PRESENCIA_ASBESTOS", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpal_Presencia_Asbestos(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public T_Sgpal_Presencia_Asbestos RecuperarT_Sgpal_Presencia_AsbestosPorCodigo(int vId_Presencia_Asbestos)
        {
           T_Sgpal_Presencia_Asbestos vEntidad = null;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_PRESENCIA_ASBESTOS.USP_SEL_PRESENCIA_ASBESTOS", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_PRESENCIA_ASBESTOS", vId_Presencia_Asbestos);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpal_Presencia_Asbestos(vRdr);
                    }
                }
                vCnn.Close();
            }
            return vEntidad;
        }

        public T_Sgpal_Presencia_Asbestos InsertarT_Sgpal_Presencia_Asbestos(T_Sgpal_Presencia_Asbestos vT_Sgpal_Presencia_Asbestos)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_PRESENCIA_ASBESTOS.USP_INS_PRESENCIA_ASBESTOS", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpal_Presencia_Asbestos.FEC_MODIFICA); 				vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpal_Presencia_Asbestos.IP_MODIFICA); 				vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpal_Presencia_Asbestos.FLG_ESTADO); 				vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpal_Presencia_Asbestos.USU_MODIFICA); 				vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpal_Presencia_Asbestos.USU_INGRESO); 				vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpal_Presencia_Asbestos.IP_INGRESO); 				vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpal_Presencia_Asbestos.FEC_INGRESO); 				vCmd.Parameters.Add("pDESCRIPCION", vT_Sgpal_Presencia_Asbestos.DESCRIPCION); 				vCmd.Parameters.Add("pID_PRESENCIA_ASBESTOS", vT_Sgpal_Presencia_Asbestos.ID_PRESENCIA_ASBESTOS);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpal_Presencia_Asbestos;
        }
        
        public T_Sgpal_Presencia_Asbestos ActualizarT_Sgpal_Presencia_Asbestos(T_Sgpal_Presencia_Asbestos vT_Sgpal_Presencia_Asbestos)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_PRESENCIA_ASBESTOS.USP_UPD_PRESENCIA_ASBESTOS", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpal_Presencia_Asbestos.FEC_MODIFICA); 				vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpal_Presencia_Asbestos.IP_MODIFICA); 				vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpal_Presencia_Asbestos.FLG_ESTADO); 				vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpal_Presencia_Asbestos.USU_MODIFICA); 				vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpal_Presencia_Asbestos.USU_INGRESO); 				vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpal_Presencia_Asbestos.IP_INGRESO); 				vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpal_Presencia_Asbestos.FEC_INGRESO); 				vCmd.Parameters.Add("pDESCRIPCION", vT_Sgpal_Presencia_Asbestos.DESCRIPCION); 				vCmd.Parameters.Add("pID_PRESENCIA_ASBESTOS", vT_Sgpal_Presencia_Asbestos.ID_PRESENCIA_ASBESTOS);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpal_Presencia_Asbestos;
        }

        public int AnularT_Sgpal_Presencia_AsbestosPorCodigo(int vId_Presencia_Asbestos)
        {
            int vResultado = 0;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_PRESENCIA_ASBESTOS.USP_DEL_PRESENCIA_ASBESTOS", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_PRESENCIA_ASBESTOS", vId_Presencia_Asbestos);
                    vCnn.Open();
                    vResultado = vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vResultado;
        }

        public IEnumerable<T_Sgpal_Presencia_Asbestos> ListarPaginadoT_Sgpal_Presencia_Asbestos(string vFiltro, int vNumPag, int vCantRegxPag)
        {
           List<T_Sgpal_Presencia_Asbestos> vLista = new List<T_Sgpal_Presencia_Asbestos>();
           T_Sgpal_Presencia_Asbestos vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_PRESENCIA_ASBESTOS.USP_PAG_PRESENCIA_ASBESTOS", vCnn))
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
                        vEntidad = new T_Sgpal_Presencia_Asbestos(vRdr);
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