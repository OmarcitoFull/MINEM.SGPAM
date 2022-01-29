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
    /// Objetivo:	Clase que genera las operaciones para la tabla T_SGPAL_CUENCA_HIDROGRAFICA
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	27/10/2021
    /// </summary>
    public partial class T_Sgpal_Cuenca_HidrograficaAD: BaseAD, IT_Sgpal_Cuenca_HidrograficaAD
    {   
        public IEnumerable<T_Sgpal_Cuenca_Hidrografica> ListarT_Sgpal_Cuenca_Hidrografica()
        {
           List<T_Sgpal_Cuenca_Hidrografica> vLista = new List<T_Sgpal_Cuenca_Hidrografica>();
           T_Sgpal_Cuenca_Hidrografica vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_CUENCA_HIDROGRAFICA.USP_LIS_CUENCA_HIDROGRAFICA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpal_Cuenca_Hidrografica(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public T_Sgpal_Cuenca_Hidrografica RecuperarT_Sgpal_Cuenca_HidrograficaPorCodigo(int vId_Cuenca_Hidro)
        {
           T_Sgpal_Cuenca_Hidrografica vEntidad = null;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_CUENCA_HIDROGRAFICA.USP_SEL_CUENCA_HIDROGRAFICA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_CUENCA_HIDRO", vId_Cuenca_Hidro);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpal_Cuenca_Hidrografica(vRdr);
                    }
                }
                vCnn.Close();
            }
            return vEntidad;
        }

        public T_Sgpal_Cuenca_Hidrografica InsertarT_Sgpal_Cuenca_Hidrografica(T_Sgpal_Cuenca_Hidrografica vT_Sgpal_Cuenca_Hidrografica)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_CUENCA_HIDROGRAFICA.USP_INS_CUENCA_HIDROGRAFICA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpal_Cuenca_Hidrografica.FEC_MODIFICA); 				vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpal_Cuenca_Hidrografica.USU_INGRESO); 				vCmd.Parameters.Add("pDESCRIPCION", vT_Sgpal_Cuenca_Hidrografica.DESCRIPCION); 				vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpal_Cuenca_Hidrografica.FLG_ESTADO); 				vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpal_Cuenca_Hidrografica.IP_MODIFICA); 				vCmd.Parameters.Add("pID_CUENCA_HIDRO", vT_Sgpal_Cuenca_Hidrografica.ID_CUENCA_HIDRO); 				vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpal_Cuenca_Hidrografica.USU_MODIFICA); 				vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpal_Cuenca_Hidrografica.IP_INGRESO); 				vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpal_Cuenca_Hidrografica.FEC_INGRESO);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpal_Cuenca_Hidrografica;
        }
        
        public T_Sgpal_Cuenca_Hidrografica ActualizarT_Sgpal_Cuenca_Hidrografica(T_Sgpal_Cuenca_Hidrografica vT_Sgpal_Cuenca_Hidrografica)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_CUENCA_HIDROGRAFICA.USP_UPD_CUENCA_HIDROGRAFICA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpal_Cuenca_Hidrografica.FEC_MODIFICA); 				vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpal_Cuenca_Hidrografica.USU_INGRESO); 				vCmd.Parameters.Add("pDESCRIPCION", vT_Sgpal_Cuenca_Hidrografica.DESCRIPCION); 				vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpal_Cuenca_Hidrografica.FLG_ESTADO); 				vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpal_Cuenca_Hidrografica.IP_MODIFICA); 				vCmd.Parameters.Add("pID_CUENCA_HIDRO", vT_Sgpal_Cuenca_Hidrografica.ID_CUENCA_HIDRO); 				vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpal_Cuenca_Hidrografica.USU_MODIFICA); 				vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpal_Cuenca_Hidrografica.IP_INGRESO); 				vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpal_Cuenca_Hidrografica.FEC_INGRESO);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpal_Cuenca_Hidrografica;
        }

        public int AnularT_Sgpal_Cuenca_HidrograficaPorCodigo(int vId_Cuenca_Hidro)
        {
            int vResultado = 0;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_CUENCA_HIDROGRAFICA.USP_DEL_CUENCA_HIDROGRAFICA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_CUENCA_HIDRO", vId_Cuenca_Hidro);
                    vCnn.Open();
                    vResultado = vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vResultado;
        }

        public IEnumerable<T_Sgpal_Cuenca_Hidrografica> ListarPaginadoT_Sgpal_Cuenca_Hidrografica(string vFiltro, int vNumPag, int vCantRegxPag)
        {
           List<T_Sgpal_Cuenca_Hidrografica> vLista = new List<T_Sgpal_Cuenca_Hidrografica>();
           T_Sgpal_Cuenca_Hidrografica vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_CUENCA_HIDROGRAFICA.USP_PAG_CUENCA_HIDROGRAFICA", vCnn))
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
                        vEntidad = new T_Sgpal_Cuenca_Hidrografica(vRdr);
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