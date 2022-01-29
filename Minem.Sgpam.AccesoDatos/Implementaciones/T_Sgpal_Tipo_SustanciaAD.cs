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
    /// Objetivo:	Clase que genera las operaciones para la tabla T_SGPAL_TIPO_SUSTANCIA
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	27/10/2021
    /// </summary>
    public partial class T_Sgpal_Tipo_SustanciaAD: BaseAD, IT_Sgpal_Tipo_SustanciaAD
    {
        public T_Sgpal_Tipo_SustanciaAD(IConfiguration vConfiguration)
        {
            CnnString = vConfiguration.GetSection(Constantes.BD).Value;
        }

        public IEnumerable<T_Sgpal_Tipo_Sustancia> ListarT_Sgpal_Tipo_Sustancia()
        {
           List<T_Sgpal_Tipo_Sustancia> vLista = new List<T_Sgpal_Tipo_Sustancia>();
           T_Sgpal_Tipo_Sustancia vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_TIPO_SUSTANCIA.USP_LIS_TIPO_SUSTANCIA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpal_Tipo_Sustancia(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public T_Sgpal_Tipo_Sustancia RecuperarT_Sgpal_Tipo_SustanciaPorCodigo(int vId_Tipo_Sustancia)
        {
           T_Sgpal_Tipo_Sustancia vEntidad = null;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_TIPO_SUSTANCIA.USP_SEL_TIPO_SUSTANCIA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_TIPO_SUSTANCIA", vId_Tipo_Sustancia);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpal_Tipo_Sustancia(vRdr);
                    }
                }
                vCnn.Close();
            }
            return vEntidad;
        }

        public T_Sgpal_Tipo_Sustancia InsertarT_Sgpal_Tipo_Sustancia(T_Sgpal_Tipo_Sustancia vT_Sgpal_Tipo_Sustancia)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_TIPO_SUSTANCIA.USP_INS_TIPO_SUSTANCIA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpal_Tipo_Sustancia.FLG_ESTADO); 
				vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpal_Tipo_Sustancia.USU_INGRESO); 
				vCmd.Parameters.Add("pDESCRIPCION", vT_Sgpal_Tipo_Sustancia.DESCRIPCION); 
				vCmd.Parameters.Add("pID_TIPO_SUSTANCIA", vT_Sgpal_Tipo_Sustancia.ID_TIPO_SUSTANCIA); 
				vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpal_Tipo_Sustancia.USU_MODIFICA); 
				vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpal_Tipo_Sustancia.IP_INGRESO); 
				vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpal_Tipo_Sustancia.IP_MODIFICA); 
				vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpal_Tipo_Sustancia.FEC_INGRESO); 
				vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpal_Tipo_Sustancia.FEC_MODIFICA);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpal_Tipo_Sustancia;
        }
        
        public T_Sgpal_Tipo_Sustancia ActualizarT_Sgpal_Tipo_Sustancia(T_Sgpal_Tipo_Sustancia vT_Sgpal_Tipo_Sustancia)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_TIPO_SUSTANCIA.USP_UPD_TIPO_SUSTANCIA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpal_Tipo_Sustancia.FLG_ESTADO); 
				vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpal_Tipo_Sustancia.USU_INGRESO); 
				vCmd.Parameters.Add("pDESCRIPCION", vT_Sgpal_Tipo_Sustancia.DESCRIPCION); 
				vCmd.Parameters.Add("pID_TIPO_SUSTANCIA", vT_Sgpal_Tipo_Sustancia.ID_TIPO_SUSTANCIA); 
				vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpal_Tipo_Sustancia.USU_MODIFICA); 
				vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpal_Tipo_Sustancia.IP_INGRESO); 
				vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpal_Tipo_Sustancia.IP_MODIFICA); 
				vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpal_Tipo_Sustancia.FEC_INGRESO); 
				vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpal_Tipo_Sustancia.FEC_MODIFICA);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpal_Tipo_Sustancia;
        }

        public int AnularT_Sgpal_Tipo_SustanciaPorCodigo(int vId_Tipo_Sustancia)
        {
            int vResultado = 0;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_TIPO_SUSTANCIA.USP_DEL_TIPO_SUSTANCIA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_TIPO_SUSTANCIA", vId_Tipo_Sustancia);
                    vCnn.Open();
                    vResultado = vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vResultado;
        }

        public IEnumerable<T_Sgpal_Tipo_Sustancia> ListarPaginadoT_Sgpal_Tipo_Sustancia(string vFiltro, int vNumPag, int vCantRegxPag)
        {
           List<T_Sgpal_Tipo_Sustancia> vLista = new List<T_Sgpal_Tipo_Sustancia>();
           T_Sgpal_Tipo_Sustancia vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_TIPO_SUSTANCIA.USP_PAG_TIPO_SUSTANCIA", vCnn))
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
                        vEntidad = new T_Sgpal_Tipo_Sustancia(vRdr);
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