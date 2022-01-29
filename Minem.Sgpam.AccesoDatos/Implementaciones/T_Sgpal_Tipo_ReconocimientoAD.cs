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
    /// Objetivo:	Clase que genera las operaciones para la tabla T_SGPAL_TIPO_RECONOCIMIENTO
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	27/10/2021
    /// </summary>
    public partial class T_Sgpal_Tipo_ReconocimientoAD: BaseAD, IT_Sgpal_Tipo_ReconocimientoAD
    {   
        public IEnumerable<T_Sgpal_Tipo_Reconocimiento> ListarT_Sgpal_Tipo_Reconocimiento()
        {
           List<T_Sgpal_Tipo_Reconocimiento> vLista = new List<T_Sgpal_Tipo_Reconocimiento>();
           T_Sgpal_Tipo_Reconocimiento vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_TIPO_RECONOCIMIENTO.USP_LIS_TIPO_RECONOCIMIENTO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpal_Tipo_Reconocimiento(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public T_Sgpal_Tipo_Reconocimiento RecuperarT_Sgpal_Tipo_ReconocimientoPorCodigo(int vId_Tipo_Reconocimiento)
        {
           T_Sgpal_Tipo_Reconocimiento vEntidad = null;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_TIPO_RECONOCIMIENTO.USP_SEL_TIPO_RECONOCIMIENTO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_TIPO_RECONOCIMIENTO", vId_Tipo_Reconocimiento);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpal_Tipo_Reconocimiento(vRdr);
                    }
                }
                vCnn.Close();
            }
            return vEntidad;
        }

        public T_Sgpal_Tipo_Reconocimiento InsertarT_Sgpal_Tipo_Reconocimiento(T_Sgpal_Tipo_Reconocimiento vT_Sgpal_Tipo_Reconocimiento)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_TIPO_RECONOCIMIENTO.USP_INS_TIPO_RECONOCIMIENTO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpal_Tipo_Reconocimiento.USU_MODIFICA); 				vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpal_Tipo_Reconocimiento.IP_MODIFICA); 				vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpal_Tipo_Reconocimiento.FEC_MODIFICA); 				vCmd.Parameters.Add("pID_TIPO_RECONOCIMIENTO", vT_Sgpal_Tipo_Reconocimiento.ID_TIPO_RECONOCIMIENTO); 				vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpal_Tipo_Reconocimiento.USU_INGRESO); 				vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpal_Tipo_Reconocimiento.FEC_INGRESO); 				vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpal_Tipo_Reconocimiento.FLG_ESTADO); 				vCmd.Parameters.Add("pDESCRIPCION", vT_Sgpal_Tipo_Reconocimiento.DESCRIPCION); 				vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpal_Tipo_Reconocimiento.IP_INGRESO);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpal_Tipo_Reconocimiento;
        }
        
        public T_Sgpal_Tipo_Reconocimiento ActualizarT_Sgpal_Tipo_Reconocimiento(T_Sgpal_Tipo_Reconocimiento vT_Sgpal_Tipo_Reconocimiento)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_TIPO_RECONOCIMIENTO.USP_UPD_TIPO_RECONOCIMIENTO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpal_Tipo_Reconocimiento.USU_MODIFICA); 				vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpal_Tipo_Reconocimiento.IP_MODIFICA); 				vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpal_Tipo_Reconocimiento.FEC_MODIFICA); 				vCmd.Parameters.Add("pID_TIPO_RECONOCIMIENTO", vT_Sgpal_Tipo_Reconocimiento.ID_TIPO_RECONOCIMIENTO); 				vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpal_Tipo_Reconocimiento.USU_INGRESO); 				vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpal_Tipo_Reconocimiento.FEC_INGRESO); 				vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpal_Tipo_Reconocimiento.FLG_ESTADO); 				vCmd.Parameters.Add("pDESCRIPCION", vT_Sgpal_Tipo_Reconocimiento.DESCRIPCION); 				vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpal_Tipo_Reconocimiento.IP_INGRESO);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpal_Tipo_Reconocimiento;
        }

        public int AnularT_Sgpal_Tipo_ReconocimientoPorCodigo(int vId_Tipo_Reconocimiento)
        {
            int vResultado = 0;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_TIPO_RECONOCIMIENTO.USP_DEL_TIPO_RECONOCIMIENTO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_TIPO_RECONOCIMIENTO", vId_Tipo_Reconocimiento);
                    vCnn.Open();
                    vResultado = vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vResultado;
        }

        public IEnumerable<T_Sgpal_Tipo_Reconocimiento> ListarPaginadoT_Sgpal_Tipo_Reconocimiento(string vFiltro, int vNumPag, int vCantRegxPag)
        {
           List<T_Sgpal_Tipo_Reconocimiento> vLista = new List<T_Sgpal_Tipo_Reconocimiento>();
           T_Sgpal_Tipo_Reconocimiento vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_TIPO_RECONOCIMIENTO.USP_PAG_TIPO_RECONOCIMIENTO", vCnn))
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
                        vEntidad = new T_Sgpal_Tipo_Reconocimiento(vRdr);
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