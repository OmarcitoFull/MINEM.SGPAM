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
    /// Objetivo:	Clase que genera las operaciones para la tabla T_SGPAL_POT_ELECTRICO
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	27/10/2021
    /// </summary>
    public partial class T_Sgpal_Pot_ElectricoAD: BaseAD, IT_Sgpal_Pot_ElectricoAD
    {   
        public IEnumerable<T_Sgpal_Pot_Electrico> ListarT_Sgpal_Pot_Electrico()
        {
           List<T_Sgpal_Pot_Electrico> vLista = new List<T_Sgpal_Pot_Electrico>();
           T_Sgpal_Pot_Electrico vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_POT_ELECTRICO.USP_LIS_POT_ELECTRICO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpal_Pot_Electrico(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public T_Sgpal_Pot_Electrico RecuperarT_Sgpal_Pot_ElectricoPorCodigo(int vId_Pot_Electrico)
        {
           T_Sgpal_Pot_Electrico vEntidad = null;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_POT_ELECTRICO.USP_SEL_POT_ELECTRICO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_POT_ELECTRICO", vId_Pot_Electrico);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpal_Pot_Electrico(vRdr);
                    }
                }
                vCnn.Close();
            }
            return vEntidad;
        }

        public T_Sgpal_Pot_Electrico InsertarT_Sgpal_Pot_Electrico(T_Sgpal_Pot_Electrico vT_Sgpal_Pot_Electrico)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_POT_ELECTRICO.USP_INS_POT_ELECTRICO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpal_Pot_Electrico.IP_MODIFICA); 				vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpal_Pot_Electrico.FEC_INGRESO); 				vCmd.Parameters.Add("pID_POT_ELECTRICO", vT_Sgpal_Pot_Electrico.ID_POT_ELECTRICO); 				vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpal_Pot_Electrico.USU_INGRESO); 				vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpal_Pot_Electrico.IP_INGRESO); 				vCmd.Parameters.Add("pDESCRIPCION", vT_Sgpal_Pot_Electrico.DESCRIPCION); 				vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpal_Pot_Electrico.USU_MODIFICA); 				vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpal_Pot_Electrico.FEC_MODIFICA); 				vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpal_Pot_Electrico.FLG_ESTADO);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpal_Pot_Electrico;
        }
        
        public T_Sgpal_Pot_Electrico ActualizarT_Sgpal_Pot_Electrico(T_Sgpal_Pot_Electrico vT_Sgpal_Pot_Electrico)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_POT_ELECTRICO.USP_UPD_POT_ELECTRICO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpal_Pot_Electrico.IP_MODIFICA); 				vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpal_Pot_Electrico.FEC_INGRESO); 				vCmd.Parameters.Add("pID_POT_ELECTRICO", vT_Sgpal_Pot_Electrico.ID_POT_ELECTRICO); 				vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpal_Pot_Electrico.USU_INGRESO); 				vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpal_Pot_Electrico.IP_INGRESO); 				vCmd.Parameters.Add("pDESCRIPCION", vT_Sgpal_Pot_Electrico.DESCRIPCION); 				vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpal_Pot_Electrico.USU_MODIFICA); 				vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpal_Pot_Electrico.FEC_MODIFICA); 				vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpal_Pot_Electrico.FLG_ESTADO);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpal_Pot_Electrico;
        }

        public int AnularT_Sgpal_Pot_ElectricoPorCodigo(int vId_Pot_Electrico)
        {
            int vResultado = 0;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_POT_ELECTRICO.USP_DEL_POT_ELECTRICO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_POT_ELECTRICO", vId_Pot_Electrico);
                    vCnn.Open();
                    vResultado = vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vResultado;
        }

        public IEnumerable<T_Sgpal_Pot_Electrico> ListarPaginadoT_Sgpal_Pot_Electrico(string vFiltro, int vNumPag, int vCantRegxPag)
        {
           List<T_Sgpal_Pot_Electrico> vLista = new List<T_Sgpal_Pot_Electrico>();
           T_Sgpal_Pot_Electrico vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_POT_ELECTRICO.USP_PAG_POT_ELECTRICO", vCnn))
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
                        vEntidad = new T_Sgpal_Pot_Electrico(vRdr);
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