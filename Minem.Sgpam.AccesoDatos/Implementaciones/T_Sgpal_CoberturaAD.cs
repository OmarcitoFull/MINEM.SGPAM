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
    /// Objetivo:	Clase que genera las operaciones para la tabla T_SGPAL_COBERTURA
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	27/10/2021
    /// </summary>
    public partial class T_Sgpal_CoberturaAD: BaseAD, IT_Sgpal_CoberturaAD
    {
        public T_Sgpal_CoberturaAD(IConfiguration vConfiguration)
        {
            CnnString = vConfiguration.GetSection(Constantes.BD).Value;
        }

        public IEnumerable<T_Sgpal_Cobertura> ListarT_Sgpal_Cobertura()
        {
           List<T_Sgpal_Cobertura> vLista = new List<T_Sgpal_Cobertura>();
           T_Sgpal_Cobertura vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COBERTURA.USP_LIS_COBERTURA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpal_Cobertura(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public T_Sgpal_Cobertura RecuperarT_Sgpal_CoberturaPorCodigo(int vId_Cobertura)
        {
           T_Sgpal_Cobertura vEntidad = null;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COBERTURA.USP_SEL_COBERTURA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_COBERTURA", vId_Cobertura);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpal_Cobertura(vRdr);
                    }
                }
                vCnn.Close();
            }
            return vEntidad;
        }

        public T_Sgpal_Cobertura InsertarT_Sgpal_Cobertura(T_Sgpal_Cobertura vT_Sgpal_Cobertura)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COBERTURA.USP_INS_COBERTURA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpal_Cobertura.IP_MODIFICA); 				vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpal_Cobertura.FLG_ESTADO); 				vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpal_Cobertura.USU_INGRESO); 				vCmd.Parameters.Add("pID_COBERTURA", vT_Sgpal_Cobertura.ID_COBERTURA); 				vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpal_Cobertura.FEC_MODIFICA); 				vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpal_Cobertura.IP_INGRESO); 				vCmd.Parameters.Add("pDESCRIPCION", vT_Sgpal_Cobertura.DESCRIPCION); 				vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpal_Cobertura.USU_MODIFICA); 				vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpal_Cobertura.FEC_INGRESO);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpal_Cobertura;
        }
        
        public T_Sgpal_Cobertura ActualizarT_Sgpal_Cobertura(T_Sgpal_Cobertura vT_Sgpal_Cobertura)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COBERTURA.USP_UPD_COBERTURA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpal_Cobertura.IP_MODIFICA); 				vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpal_Cobertura.FLG_ESTADO); 				vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpal_Cobertura.USU_INGRESO); 				vCmd.Parameters.Add("pID_COBERTURA", vT_Sgpal_Cobertura.ID_COBERTURA); 				vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpal_Cobertura.FEC_MODIFICA); 				vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpal_Cobertura.IP_INGRESO); 				vCmd.Parameters.Add("pDESCRIPCION", vT_Sgpal_Cobertura.DESCRIPCION); 				vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpal_Cobertura.USU_MODIFICA); 				vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpal_Cobertura.FEC_INGRESO);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpal_Cobertura;
        }

        public int AnularT_Sgpal_CoberturaPorCodigo(int vId_Cobertura)
        {
            int vResultado = 0;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COBERTURA.USP_DEL_COBERTURA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_COBERTURA", vId_Cobertura);
                    vCnn.Open();
                    vResultado = vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vResultado;
        }

        public IEnumerable<T_Sgpal_Cobertura> ListarPaginadoT_Sgpal_Cobertura(string vFiltro, int vNumPag, int vCantRegxPag)
        {
           List<T_Sgpal_Cobertura> vLista = new List<T_Sgpal_Cobertura>();
           T_Sgpal_Cobertura vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COBERTURA.USP_PAG_COBERTURA", vCnn))
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
                        vEntidad = new T_Sgpal_Cobertura(vRdr);
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