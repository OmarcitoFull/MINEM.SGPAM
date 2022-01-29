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
    /// Objetivo:	Clase que genera las operaciones para la tabla T_SGPAL_FUENTE_PASIVO
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	27/10/2021
    /// </summary>
    public partial class T_Sgpal_Fuente_PasivoAD: BaseAD, IT_Sgpal_Fuente_PasivoAD
    {   
        public IEnumerable<T_Sgpal_Fuente_Pasivo> ListarT_Sgpal_Fuente_Pasivo()
        {
           List<T_Sgpal_Fuente_Pasivo> vLista = new List<T_Sgpal_Fuente_Pasivo>();
           T_Sgpal_Fuente_Pasivo vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_FUENTE_PASIVO.USP_LIS_FUENTE_PASIVO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpal_Fuente_Pasivo(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public T_Sgpal_Fuente_Pasivo RecuperarT_Sgpal_Fuente_PasivoPorCodigo(int vId_Fuente_Pasivo)
        {
           T_Sgpal_Fuente_Pasivo vEntidad = null;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_FUENTE_PASIVO.USP_SEL_FUENTE_PASIVO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_FUENTE_PASIVO", vId_Fuente_Pasivo);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpal_Fuente_Pasivo(vRdr);
                    }
                }
                vCnn.Close();
            }
            return vEntidad;
        }

        public T_Sgpal_Fuente_Pasivo InsertarT_Sgpal_Fuente_Pasivo(T_Sgpal_Fuente_Pasivo vT_Sgpal_Fuente_Pasivo)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_FUENTE_PASIVO.USP_INS_FUENTE_PASIVO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpal_Fuente_Pasivo.FEC_MODIFICA); 				vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpal_Fuente_Pasivo.USU_MODIFICA); 				vCmd.Parameters.Add("pDESCRIPCION", vT_Sgpal_Fuente_Pasivo.DESCRIPCION); 				vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpal_Fuente_Pasivo.FEC_INGRESO); 				vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpal_Fuente_Pasivo.IP_INGRESO); 				vCmd.Parameters.Add("pID_FUENTE_PASIVO", vT_Sgpal_Fuente_Pasivo.ID_FUENTE_PASIVO); 				vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpal_Fuente_Pasivo.IP_MODIFICA); 				vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpal_Fuente_Pasivo.USU_INGRESO); 				vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpal_Fuente_Pasivo.FLG_ESTADO);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpal_Fuente_Pasivo;
        }
        
        public T_Sgpal_Fuente_Pasivo ActualizarT_Sgpal_Fuente_Pasivo(T_Sgpal_Fuente_Pasivo vT_Sgpal_Fuente_Pasivo)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_FUENTE_PASIVO.USP_UPD_FUENTE_PASIVO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpal_Fuente_Pasivo.FEC_MODIFICA); 				vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpal_Fuente_Pasivo.USU_MODIFICA); 				vCmd.Parameters.Add("pDESCRIPCION", vT_Sgpal_Fuente_Pasivo.DESCRIPCION); 				vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpal_Fuente_Pasivo.FEC_INGRESO); 				vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpal_Fuente_Pasivo.IP_INGRESO); 				vCmd.Parameters.Add("pID_FUENTE_PASIVO", vT_Sgpal_Fuente_Pasivo.ID_FUENTE_PASIVO); 				vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpal_Fuente_Pasivo.IP_MODIFICA); 				vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpal_Fuente_Pasivo.USU_INGRESO); 				vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpal_Fuente_Pasivo.FLG_ESTADO);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpal_Fuente_Pasivo;
        }

        public int AnularT_Sgpal_Fuente_PasivoPorCodigo(int vId_Fuente_Pasivo)
        {
            int vResultado = 0;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_FUENTE_PASIVO.USP_DEL_FUENTE_PASIVO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_FUENTE_PASIVO", vId_Fuente_Pasivo);
                    vCnn.Open();
                    vResultado = vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vResultado;
        }

        public IEnumerable<T_Sgpal_Fuente_Pasivo> ListarPaginadoT_Sgpal_Fuente_Pasivo(string vFiltro, int vNumPag, int vCantRegxPag)
        {
           List<T_Sgpal_Fuente_Pasivo> vLista = new List<T_Sgpal_Fuente_Pasivo>();
           T_Sgpal_Fuente_Pasivo vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_FUENTE_PASIVO.USP_PAG_FUENTE_PASIVO", vCnn))
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
                        vEntidad = new T_Sgpal_Fuente_Pasivo(vRdr);
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