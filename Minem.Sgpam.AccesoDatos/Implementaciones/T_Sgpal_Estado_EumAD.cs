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
    /// Objetivo:	Clase que genera las operaciones para la tabla T_SGPAL_ESTADO_EUM
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	27/10/2021
    /// </summary>
    public partial class T_Sgpal_Estado_EumAD: BaseAD, IT_Sgpal_Estado_EumAD
    {   
        public IEnumerable<T_Sgpal_Estado_Eum> ListarT_Sgpal_Estado_Eum()
        {
           List<T_Sgpal_Estado_Eum> vLista = new List<T_Sgpal_Estado_Eum>();
           T_Sgpal_Estado_Eum vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_ESTADO_EUM.USP_LIS_ESTADO_EUM", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpal_Estado_Eum(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public T_Sgpal_Estado_Eum RecuperarT_Sgpal_Estado_EumPorCodigo(int vId_Estado_Eum)
        {
           T_Sgpal_Estado_Eum vEntidad = null;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_ESTADO_EUM.USP_SEL_ESTADO_EUM", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_ESTADO_EUM", vId_Estado_Eum);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpal_Estado_Eum(vRdr);
                    }
                }
                vCnn.Close();
            }
            return vEntidad;
        }

        public T_Sgpal_Estado_Eum InsertarT_Sgpal_Estado_Eum(T_Sgpal_Estado_Eum vT_Sgpal_Estado_Eum)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_ESTADO_EUM.USP_INS_ESTADO_EUM", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpal_Estado_Eum.USU_INGRESO); 				vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpal_Estado_Eum.FEC_INGRESO); 				vCmd.Parameters.Add("pID_ESTADO_EUM", vT_Sgpal_Estado_Eum.ID_ESTADO_EUM); 				vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpal_Estado_Eum.USU_MODIFICA); 				vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpal_Estado_Eum.FEC_MODIFICA); 				vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpal_Estado_Eum.IP_INGRESO); 				vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpal_Estado_Eum.IP_MODIFICA); 				vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpal_Estado_Eum.FLG_ESTADO); 				vCmd.Parameters.Add("pDESCRIPCION", vT_Sgpal_Estado_Eum.DESCRIPCION);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpal_Estado_Eum;
        }
        
        public T_Sgpal_Estado_Eum ActualizarT_Sgpal_Estado_Eum(T_Sgpal_Estado_Eum vT_Sgpal_Estado_Eum)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_ESTADO_EUM.USP_UPD_ESTADO_EUM", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpal_Estado_Eum.USU_INGRESO); 				vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpal_Estado_Eum.FEC_INGRESO); 				vCmd.Parameters.Add("pID_ESTADO_EUM", vT_Sgpal_Estado_Eum.ID_ESTADO_EUM); 				vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpal_Estado_Eum.USU_MODIFICA); 				vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpal_Estado_Eum.FEC_MODIFICA); 				vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpal_Estado_Eum.IP_INGRESO); 				vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpal_Estado_Eum.IP_MODIFICA); 				vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpal_Estado_Eum.FLG_ESTADO); 				vCmd.Parameters.Add("pDESCRIPCION", vT_Sgpal_Estado_Eum.DESCRIPCION);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpal_Estado_Eum;
        }

        public int AnularT_Sgpal_Estado_EumPorCodigo(int vId_Estado_Eum)
        {
            int vResultado = 0;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_ESTADO_EUM.USP_DEL_ESTADO_EUM", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_ESTADO_EUM", vId_Estado_Eum);
                    vCnn.Open();
                    vResultado = vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vResultado;
        }

        public IEnumerable<T_Sgpal_Estado_Eum> ListarPaginadoT_Sgpal_Estado_Eum(string vFiltro, int vNumPag, int vCantRegxPag)
        {
           List<T_Sgpal_Estado_Eum> vLista = new List<T_Sgpal_Estado_Eum>();
           T_Sgpal_Estado_Eum vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_ESTADO_EUM.USP_PAG_ESTADO_EUM", vCnn))
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
                        vEntidad = new T_Sgpal_Estado_Eum(vRdr);
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