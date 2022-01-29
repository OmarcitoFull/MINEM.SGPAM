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
    /// Objetivo:	Clase que genera las operaciones para la tabla T_SGPAD_COMP_DM_SITUACION
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	27/10/2021
    /// </summary>
    public partial class T_Sgpad_Comp_Dm_SituacionAD: BaseAD, IT_Sgpad_Comp_Dm_SituacionAD
    {   
        public IEnumerable<T_Sgpad_Comp_Dm_Situacion> ListarT_Sgpad_Comp_Dm_Situacion()
        {
           List<T_Sgpad_Comp_Dm_Situacion> vLista = new List<T_Sgpad_Comp_Dm_Situacion>();
           T_Sgpad_Comp_Dm_Situacion vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_DM_SITUACION.USP_LIS_COMP_DM_SITUACION", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpad_Comp_Dm_Situacion(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public T_Sgpad_Comp_Dm_Situacion RecuperarT_Sgpad_Comp_Dm_SituacionPorCodigo(int vId_Comp_Dm_Situacion)
        {
           T_Sgpad_Comp_Dm_Situacion vEntidad = null;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_DM_SITUACION.USP_SEL_COMP_DM_SITUACION", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_COMP_DM_SITUACION", vId_Comp_Dm_Situacion);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpad_Comp_Dm_Situacion(vRdr);
                    }
                }
                vCnn.Close();
            }
            return vEntidad;
        }

        public T_Sgpad_Comp_Dm_Situacion InsertarT_Sgpad_Comp_Dm_Situacion(T_Sgpad_Comp_Dm_Situacion vT_Sgpad_Comp_Dm_Situacion)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_DM_SITUACION.USP_INS_COMP_DM_SITUACION", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_COMP_DM", vT_Sgpad_Comp_Dm_Situacion.ID_COMP_DM); 				vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpad_Comp_Dm_Situacion.IP_INGRESO); 				vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpad_Comp_Dm_Situacion.FLG_ESTADO); 				vCmd.Parameters.Add("pANIO", vT_Sgpad_Comp_Dm_Situacion.ANIO); 				vCmd.Parameters.Add("pID_TIPO_CONCENTRADO", vT_Sgpad_Comp_Dm_Situacion.ID_TIPO_CONCENTRADO); 				vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpad_Comp_Dm_Situacion.FEC_MODIFICA); 				vCmd.Parameters.Add("pID_COMP_DM_SITUACION", vT_Sgpad_Comp_Dm_Situacion.ID_COMP_DM_SITUACION); 				vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpad_Comp_Dm_Situacion.IP_MODIFICA); 				vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpad_Comp_Dm_Situacion.FEC_INGRESO); 				vCmd.Parameters.Add("pCANTIDAD", vT_Sgpad_Comp_Dm_Situacion.CANTIDAD); 				vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpad_Comp_Dm_Situacion.USU_MODIFICA); 				vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpad_Comp_Dm_Situacion.USU_INGRESO); 				vCmd.Parameters.Add("pID_SITUACION", vT_Sgpad_Comp_Dm_Situacion.ID_SITUACION);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpad_Comp_Dm_Situacion;
        }
        
        public T_Sgpad_Comp_Dm_Situacion ActualizarT_Sgpad_Comp_Dm_Situacion(T_Sgpad_Comp_Dm_Situacion vT_Sgpad_Comp_Dm_Situacion)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_DM_SITUACION.USP_UPD_COMP_DM_SITUACION", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_COMP_DM", vT_Sgpad_Comp_Dm_Situacion.ID_COMP_DM); 				vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpad_Comp_Dm_Situacion.IP_INGRESO); 				vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpad_Comp_Dm_Situacion.FLG_ESTADO); 				vCmd.Parameters.Add("pANIO", vT_Sgpad_Comp_Dm_Situacion.ANIO); 				vCmd.Parameters.Add("pID_TIPO_CONCENTRADO", vT_Sgpad_Comp_Dm_Situacion.ID_TIPO_CONCENTRADO); 				vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpad_Comp_Dm_Situacion.FEC_MODIFICA); 				vCmd.Parameters.Add("pID_COMP_DM_SITUACION", vT_Sgpad_Comp_Dm_Situacion.ID_COMP_DM_SITUACION); 				vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpad_Comp_Dm_Situacion.IP_MODIFICA); 				vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpad_Comp_Dm_Situacion.FEC_INGRESO); 				vCmd.Parameters.Add("pCANTIDAD", vT_Sgpad_Comp_Dm_Situacion.CANTIDAD); 				vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpad_Comp_Dm_Situacion.USU_MODIFICA); 				vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpad_Comp_Dm_Situacion.USU_INGRESO); 				vCmd.Parameters.Add("pID_SITUACION", vT_Sgpad_Comp_Dm_Situacion.ID_SITUACION);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpad_Comp_Dm_Situacion;
        }

        public int AnularT_Sgpad_Comp_Dm_SituacionPorCodigo(int vId_Comp_Dm_Situacion)
        {
            int vResultado = 0;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_DM_SITUACION.USP_DEL_COMP_DM_SITUACION", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_COMP_DM_SITUACION", vId_Comp_Dm_Situacion);
                    vCnn.Open();
                    vResultado = vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vResultado;
        }

        public IEnumerable<T_Sgpad_Comp_Dm_Situacion> ListarPaginadoT_Sgpad_Comp_Dm_Situacion(string vFiltro, int vNumPag, int vCantRegxPag)
        {
           List<T_Sgpad_Comp_Dm_Situacion> vLista = new List<T_Sgpad_Comp_Dm_Situacion>();
           T_Sgpad_Comp_Dm_Situacion vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_DM_SITUACION.USP_PAG_COMP_DM_SITUACION", vCnn))
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
                        vEntidad = new T_Sgpad_Comp_Dm_Situacion(vRdr);
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