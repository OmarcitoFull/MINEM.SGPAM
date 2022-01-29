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
    /// Objetivo:	Clase que genera las operaciones para la tabla T_SGPAL_TIPO_RESOLUCION
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	27/10/2021
    /// </summary>
    public partial class T_Sgpal_Tipo_ResolucionAD: BaseAD, IT_Sgpal_Tipo_ResolucionAD
    {
        public T_Sgpal_Tipo_ResolucionAD(IConfiguration vConfiguration)
        {
            CnnString = vConfiguration.GetSection(Constantes.BD).Value;
        }

        public IEnumerable<T_Sgpal_Tipo_Resolucion> ListarT_Sgpal_Tipo_Resolucion()
        {
           List<T_Sgpal_Tipo_Resolucion> vLista = new List<T_Sgpal_Tipo_Resolucion>();
           T_Sgpal_Tipo_Resolucion vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_TIPO_RESOLUCION.USP_LIS_TIPO_RESOLUCION", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpal_Tipo_Resolucion(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public T_Sgpal_Tipo_Resolucion RecuperarT_Sgpal_Tipo_ResolucionPorCodigo(int vId_Tipo_Resolucion)
        {
           T_Sgpal_Tipo_Resolucion vEntidad = null;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_TIPO_RESOLUCION.USP_SEL_TIPO_RESOLUCION", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_TIPO_RESOLUCION", vId_Tipo_Resolucion);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpal_Tipo_Resolucion(vRdr);
                    }
                }
                vCnn.Close();
            }
            return vEntidad;
        }

        public T_Sgpal_Tipo_Resolucion InsertarT_Sgpal_Tipo_Resolucion(T_Sgpal_Tipo_Resolucion vT_Sgpal_Tipo_Resolucion)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_TIPO_RESOLUCION.USP_INS_TIPO_RESOLUCION", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpal_Tipo_Resolucion.USU_INGRESO); 				vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpal_Tipo_Resolucion.USU_MODIFICA); 				vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpal_Tipo_Resolucion.IP_MODIFICA); 				vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpal_Tipo_Resolucion.FLG_ESTADO); 				vCmd.Parameters.Add("pDESCRIPCION", vT_Sgpal_Tipo_Resolucion.DESCRIPCION); 				vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpal_Tipo_Resolucion.IP_INGRESO); 				vCmd.Parameters.Add("pID_TIPO_RESOLUCION", vT_Sgpal_Tipo_Resolucion.ID_TIPO_RESOLUCION); 				vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpal_Tipo_Resolucion.FEC_MODIFICA); 				vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpal_Tipo_Resolucion.FEC_INGRESO);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpal_Tipo_Resolucion;
        }
        
        public T_Sgpal_Tipo_Resolucion ActualizarT_Sgpal_Tipo_Resolucion(T_Sgpal_Tipo_Resolucion vT_Sgpal_Tipo_Resolucion)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_TIPO_RESOLUCION.USP_UPD_TIPO_RESOLUCION", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpal_Tipo_Resolucion.USU_INGRESO); 				vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpal_Tipo_Resolucion.USU_MODIFICA); 				vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpal_Tipo_Resolucion.IP_MODIFICA); 				vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpal_Tipo_Resolucion.FLG_ESTADO); 				vCmd.Parameters.Add("pDESCRIPCION", vT_Sgpal_Tipo_Resolucion.DESCRIPCION); 				vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpal_Tipo_Resolucion.IP_INGRESO); 				vCmd.Parameters.Add("pID_TIPO_RESOLUCION", vT_Sgpal_Tipo_Resolucion.ID_TIPO_RESOLUCION); 				vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpal_Tipo_Resolucion.FEC_MODIFICA); 				vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpal_Tipo_Resolucion.FEC_INGRESO);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpal_Tipo_Resolucion;
        }

        public int AnularT_Sgpal_Tipo_ResolucionPorCodigo(int vId_Tipo_Resolucion)
        {
            int vResultado = 0;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_TIPO_RESOLUCION.USP_DEL_TIPO_RESOLUCION", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_TIPO_RESOLUCION", vId_Tipo_Resolucion);
                    vCnn.Open();
                    vResultado = vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vResultado;
        }

        public IEnumerable<T_Sgpal_Tipo_Resolucion> ListarPaginadoT_Sgpal_Tipo_Resolucion(string vFiltro, int vNumPag, int vCantRegxPag)
        {
           List<T_Sgpal_Tipo_Resolucion> vLista = new List<T_Sgpal_Tipo_Resolucion>();
           T_Sgpal_Tipo_Resolucion vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_TIPO_RESOLUCION.USP_PAG_TIPO_RESOLUCION", vCnn))
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
                        vEntidad = new T_Sgpal_Tipo_Resolucion(vRdr);
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