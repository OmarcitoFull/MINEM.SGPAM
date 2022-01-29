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
    /// Objetivo:	Clase que genera las operaciones para la tabla T_SGPAL_TIPO_DM
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	27/10/2021
    /// </summary>
    public partial class T_Sgpal_Tipo_DmAD: BaseAD, IT_Sgpal_Tipo_DmAD
    {   
        public IEnumerable<T_Sgpal_Tipo_Dm> ListarT_Sgpal_Tipo_Dm()
        {
           List<T_Sgpal_Tipo_Dm> vLista = new List<T_Sgpal_Tipo_Dm>();
           T_Sgpal_Tipo_Dm vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_TIPO_DM.USP_LIS_TIPO_DM", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpal_Tipo_Dm(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public T_Sgpal_Tipo_Dm RecuperarT_Sgpal_Tipo_DmPorCodigo(int vId_Tipo_Dm)
        {
           T_Sgpal_Tipo_Dm vEntidad = null;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_TIPO_DM.USP_SEL_TIPO_DM", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_TIPO_DM", vId_Tipo_Dm);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpal_Tipo_Dm(vRdr);
                    }
                }
                vCnn.Close();
            }
            return vEntidad;
        }

        public T_Sgpal_Tipo_Dm InsertarT_Sgpal_Tipo_Dm(T_Sgpal_Tipo_Dm vT_Sgpal_Tipo_Dm)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_TIPO_DM.USP_INS_TIPO_DM", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_TIPO_DM", vT_Sgpal_Tipo_Dm.ID_TIPO_DM); 				vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpal_Tipo_Dm.USU_MODIFICA); 				vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpal_Tipo_Dm.FLG_ESTADO); 				vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpal_Tipo_Dm.FEC_MODIFICA); 				vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpal_Tipo_Dm.FEC_INGRESO); 				vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpal_Tipo_Dm.USU_INGRESO); 				vCmd.Parameters.Add("pDESCRIPCION", vT_Sgpal_Tipo_Dm.DESCRIPCION); 				vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpal_Tipo_Dm.IP_INGRESO); 				vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpal_Tipo_Dm.IP_MODIFICA);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpal_Tipo_Dm;
        }
        
        public T_Sgpal_Tipo_Dm ActualizarT_Sgpal_Tipo_Dm(T_Sgpal_Tipo_Dm vT_Sgpal_Tipo_Dm)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_TIPO_DM.USP_UPD_TIPO_DM", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_TIPO_DM", vT_Sgpal_Tipo_Dm.ID_TIPO_DM); 				vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpal_Tipo_Dm.USU_MODIFICA); 				vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpal_Tipo_Dm.FLG_ESTADO); 				vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpal_Tipo_Dm.FEC_MODIFICA); 				vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpal_Tipo_Dm.FEC_INGRESO); 				vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpal_Tipo_Dm.USU_INGRESO); 				vCmd.Parameters.Add("pDESCRIPCION", vT_Sgpal_Tipo_Dm.DESCRIPCION); 				vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpal_Tipo_Dm.IP_INGRESO); 				vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpal_Tipo_Dm.IP_MODIFICA);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpal_Tipo_Dm;
        }

        public int AnularT_Sgpal_Tipo_DmPorCodigo(int vId_Tipo_Dm)
        {
            int vResultado = 0;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_TIPO_DM.USP_DEL_TIPO_DM", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_TIPO_DM", vId_Tipo_Dm);
                    vCnn.Open();
                    vResultado = vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vResultado;
        }

        public IEnumerable<T_Sgpal_Tipo_Dm> ListarPaginadoT_Sgpal_Tipo_Dm(string vFiltro, int vNumPag, int vCantRegxPag)
        {
           List<T_Sgpal_Tipo_Dm> vLista = new List<T_Sgpal_Tipo_Dm>();
           T_Sgpal_Tipo_Dm vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_TIPO_DM.USP_PAG_TIPO_DM", vCnn))
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
                        vEntidad = new T_Sgpal_Tipo_Dm(vRdr);
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