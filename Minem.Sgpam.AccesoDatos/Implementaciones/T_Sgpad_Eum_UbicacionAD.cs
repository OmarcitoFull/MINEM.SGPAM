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
    /// Objetivo:	Clase que genera las operaciones para la tabla T_SGPAD_EUM_UBICACION
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	27/10/2021
    /// </summary>
    public partial class T_Sgpad_Eum_UbicacionAD: BaseAD, IT_Sgpad_Eum_UbicacionAD
    {   
        public IEnumerable<T_Sgpad_Eum_Ubicacion> ListarT_Sgpad_Eum_Ubicacion()
        {
           List<T_Sgpad_Eum_Ubicacion> vLista = new List<T_Sgpad_Eum_Ubicacion>();
           T_Sgpad_Eum_Ubicacion vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_EUM_UBICACION.USP_LIS_EUM_UBICACION", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpad_Eum_Ubicacion(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public T_Sgpad_Eum_Ubicacion RecuperarT_Sgpad_Eum_UbicacionPorCodigo(int vId_Eum_Ubicacion)
        {
           T_Sgpad_Eum_Ubicacion vEntidad = null;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_EUM_UBICACION.USP_SEL_EUM_UBICACION", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_EUM_UBICACION", vId_Eum_Ubicacion);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpad_Eum_Ubicacion(vRdr);
                    }
                }
                vCnn.Close();
            }
            return vEntidad;
        }

        public T_Sgpad_Eum_Ubicacion InsertarT_Sgpad_Eum_Ubicacion(T_Sgpad_Eum_Ubicacion vT_Sgpad_Eum_Ubicacion)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_EUM_UBICACION.USP_INS_EUM_UBICACION", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpad_Eum_Ubicacion.FEC_INGRESO); 				vCmd.Parameters.Add("pPARAJE", vT_Sgpad_Eum_Ubicacion.PARAJE); 				vCmd.Parameters.Add("pID_CUENCA_PRINCIPAL", vT_Sgpad_Eum_Ubicacion.ID_CUENCA_PRINCIPAL); 				vCmd.Parameters.Add("pID_CUENCA_SECUNDARIA", vT_Sgpad_Eum_Ubicacion.ID_CUENCA_SECUNDARIA); 				vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpad_Eum_Ubicacion.FEC_MODIFICA); 				vCmd.Parameters.Add("pID_EUM_UBICACION", vT_Sgpad_Eum_Ubicacion.ID_EUM_UBICACION); 				vCmd.Parameters.Add("pREFERENCIA", vT_Sgpad_Eum_Ubicacion.REFERENCIA); 				vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpad_Eum_Ubicacion.IP_MODIFICA); 				vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpad_Eum_Ubicacion.IP_INGRESO); 				vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpad_Eum_Ubicacion.USU_MODIFICA); 				vCmd.Parameters.Add("pID_EUM", vT_Sgpad_Eum_Ubicacion.ID_EUM); 				vCmd.Parameters.Add("pUBIGEO", vT_Sgpad_Eum_Ubicacion.UBIGEO); 				vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpad_Eum_Ubicacion.USU_INGRESO); 				vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpad_Eum_Ubicacion.FLG_ESTADO);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpad_Eum_Ubicacion;
        }
        
        public T_Sgpad_Eum_Ubicacion ActualizarT_Sgpad_Eum_Ubicacion(T_Sgpad_Eum_Ubicacion vT_Sgpad_Eum_Ubicacion)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_EUM_UBICACION.USP_UPD_EUM_UBICACION", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpad_Eum_Ubicacion.FEC_INGRESO); 				vCmd.Parameters.Add("pPARAJE", vT_Sgpad_Eum_Ubicacion.PARAJE); 				vCmd.Parameters.Add("pID_CUENCA_PRINCIPAL", vT_Sgpad_Eum_Ubicacion.ID_CUENCA_PRINCIPAL); 				vCmd.Parameters.Add("pID_CUENCA_SECUNDARIA", vT_Sgpad_Eum_Ubicacion.ID_CUENCA_SECUNDARIA); 				vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpad_Eum_Ubicacion.FEC_MODIFICA); 				vCmd.Parameters.Add("pID_EUM_UBICACION", vT_Sgpad_Eum_Ubicacion.ID_EUM_UBICACION); 				vCmd.Parameters.Add("pREFERENCIA", vT_Sgpad_Eum_Ubicacion.REFERENCIA); 				vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpad_Eum_Ubicacion.IP_MODIFICA); 				vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpad_Eum_Ubicacion.IP_INGRESO); 				vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpad_Eum_Ubicacion.USU_MODIFICA); 				vCmd.Parameters.Add("pID_EUM", vT_Sgpad_Eum_Ubicacion.ID_EUM); 				vCmd.Parameters.Add("pUBIGEO", vT_Sgpad_Eum_Ubicacion.UBIGEO); 				vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpad_Eum_Ubicacion.USU_INGRESO); 				vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpad_Eum_Ubicacion.FLG_ESTADO);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpad_Eum_Ubicacion;
        }

        public int AnularT_Sgpad_Eum_UbicacionPorCodigo(int vId_Eum_Ubicacion)
        {
            int vResultado = 0;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_EUM_UBICACION.USP_DEL_EUM_UBICACION", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_EUM_UBICACION", vId_Eum_Ubicacion);
                    vCnn.Open();
                    vResultado = vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vResultado;
        }

        public IEnumerable<T_Sgpad_Eum_Ubicacion> ListarPaginadoT_Sgpad_Eum_Ubicacion(string vFiltro, int vNumPag, int vCantRegxPag)
        {
           List<T_Sgpad_Eum_Ubicacion> vLista = new List<T_Sgpad_Eum_Ubicacion>();
           T_Sgpad_Eum_Ubicacion vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_EUM_UBICACION.USP_PAG_EUM_UBICACION", vCnn))
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
                        vEntidad = new T_Sgpad_Eum_Ubicacion(vRdr);
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