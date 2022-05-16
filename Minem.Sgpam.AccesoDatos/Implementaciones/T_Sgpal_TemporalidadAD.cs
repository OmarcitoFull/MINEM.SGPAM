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
    /// Objetivo:	Clase que genera las operaciones para la tabla T_SGPAL_TEMPORALIDAD
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	27/10/2021
    /// </summary>
    public partial class T_Sgpal_TemporalidadAD: BaseAD, IT_Sgpal_TemporalidadAD
    {
        public T_Sgpal_TemporalidadAD(IConfiguration vConfiguration)
        {
            CnnString = vConfiguration.GetSection(Constantes.BD).Value;
        }

        public IEnumerable<T_Sgpal_Temporalidad> ListarT_Sgpal_Temporalidad()
        {
           List<T_Sgpal_Temporalidad> vLista = new List<T_Sgpal_Temporalidad>();
           T_Sgpal_Temporalidad vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_TEMPORALIDAD.USP_LIS_TEMPORALIDAD", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpal_Temporalidad(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public T_Sgpal_Temporalidad RecuperarT_Sgpal_TemporalidadPorCodigo(int vId_Temporalidad)
        {
           T_Sgpal_Temporalidad vEntidad = null;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_TEMPORALIDAD.USP_SEL_TEMPORALIDAD", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_TEMPORALIDAD", vId_Temporalidad);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpal_Temporalidad(vRdr);
                    }
                }
                vCnn.Close();
            }
            return vEntidad;
        }

        public T_Sgpal_Temporalidad InsertarT_Sgpal_Temporalidad(T_Sgpal_Temporalidad vT_Sgpal_Temporalidad)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_TEMPORALIDAD.USP_INS_TEMPORALIDAD", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpal_Temporalidad.USU_INGRESO); 				vCmd.Parameters.Add("pDESCRIPCION", vT_Sgpal_Temporalidad.DESCRIPCION); 				vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpal_Temporalidad.USU_MODIFICA); 				vCmd.Parameters.Add("pID_TEMPORALIDAD", vT_Sgpal_Temporalidad.ID_TEMPORALIDAD); 				vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpal_Temporalidad.FEC_INGRESO); 				vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpal_Temporalidad.FEC_MODIFICA); 				vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpal_Temporalidad.FLG_ESTADO); 				vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpal_Temporalidad.IP_INGRESO); 				vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpal_Temporalidad.IP_MODIFICA);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpal_Temporalidad;
        }
        
        public T_Sgpal_Temporalidad ActualizarT_Sgpal_Temporalidad(T_Sgpal_Temporalidad vT_Sgpal_Temporalidad)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_TEMPORALIDAD.USP_UPD_TEMPORALIDAD", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpal_Temporalidad.USU_INGRESO); 				vCmd.Parameters.Add("pDESCRIPCION", vT_Sgpal_Temporalidad.DESCRIPCION); 				vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpal_Temporalidad.USU_MODIFICA); 				vCmd.Parameters.Add("pID_TEMPORALIDAD", vT_Sgpal_Temporalidad.ID_TEMPORALIDAD); 				vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpal_Temporalidad.FEC_INGRESO); 				vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpal_Temporalidad.FEC_MODIFICA); 				vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpal_Temporalidad.FLG_ESTADO); 				vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpal_Temporalidad.IP_INGRESO); 				vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpal_Temporalidad.IP_MODIFICA);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpal_Temporalidad;
        }

        public int AnularT_Sgpal_TemporalidadPorCodigo(int vId_Temporalidad)
        {
            int vResultado = 0;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_TEMPORALIDAD.USP_DEL_TEMPORALIDAD", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_TEMPORALIDAD", vId_Temporalidad);
                    vCnn.Open();
                    vResultado = vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vResultado;
        }

        public IEnumerable<T_Sgpal_Temporalidad> ListarPaginadoT_Sgpal_Temporalidad(string vFiltro, int vNumPag, int vCantRegxPag)
        {
           List<T_Sgpal_Temporalidad> vLista = new List<T_Sgpal_Temporalidad>();
           T_Sgpal_Temporalidad vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_TEMPORALIDAD.USP_PAG_TEMPORALIDAD", vCnn))
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
                        vEntidad = new T_Sgpal_Temporalidad(vRdr);
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