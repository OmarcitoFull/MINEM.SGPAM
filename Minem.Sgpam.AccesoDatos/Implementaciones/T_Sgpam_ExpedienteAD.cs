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
    /// Objetivo:	Clase que genera las operaciones para la tabla T_SGPAM_EXPEDIENTE
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	27/10/2021
    /// </summary>
    public partial class T_Sgpam_ExpedienteAD: BaseAD, IT_Sgpam_ExpedienteAD
    {
        public T_Sgpam_ExpedienteAD(IConfiguration vConfiguration)
        {
            CnnString = vConfiguration.GetSection(Constantes.BD).Value;
        }

        public IEnumerable<T_Sgpam_Expediente> ListarT_Sgpam_Expediente()
        {
           List<T_Sgpam_Expediente> vLista = new List<T_Sgpam_Expediente>();
           T_Sgpam_Expediente vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_EXPEDIENTE.USP_LIS_EXPEDIENTE", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpam_Expediente(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public T_Sgpam_Expediente RecuperarT_Sgpam_ExpedientePorCodigo(int vId_Expediente)
        {
           T_Sgpam_Expediente vEntidad = null;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_EXPEDIENTE.USP_SEL_EXPEDIENTE", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_EXPEDIENTE", vId_Expediente);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpam_Expediente(vRdr);
                    }
                }
                vCnn.Close();
            }
            return vEntidad;
        }

        public T_Sgpam_Expediente InsertarT_Sgpam_Expediente(T_Sgpam_Expediente vT_Sgpam_Expediente)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_EXPEDIENTE.USP_INS_EXPEDIENTE", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpam_Expediente.IP_MODIFICA); 
				vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpam_Expediente.FLG_ESTADO); 
				vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpam_Expediente.USU_MODIFICA); 
				vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpam_Expediente.USU_INGRESO); 
				vCmd.Parameters.Add("pDECLARANTE", vT_Sgpam_Expediente.DECLARANTE); 
				vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpam_Expediente.FEC_INGRESO); 
				vCmd.Parameters.Add("pID_EXPEDIENTE", vT_Sgpam_Expediente.ID_EXPEDIENTE); 
				vCmd.Parameters.Add("pNRO_EXPEDIENTE", vT_Sgpam_Expediente.NRO_EXPEDIENTE); 
				vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpam_Expediente.IP_INGRESO); 
				vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpam_Expediente.FEC_MODIFICA); 
				vCmd.Parameters.Add("pZONA", vT_Sgpam_Expediente.ZONA);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpam_Expediente;
        }
        
        public T_Sgpam_Expediente ActualizarT_Sgpam_Expediente(T_Sgpam_Expediente vT_Sgpam_Expediente)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_EXPEDIENTE.USP_UPD_EXPEDIENTE", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpam_Expediente.IP_MODIFICA); 
				vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpam_Expediente.FLG_ESTADO); 
				vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpam_Expediente.USU_MODIFICA); 
				vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpam_Expediente.USU_INGRESO); 
				vCmd.Parameters.Add("pDECLARANTE", vT_Sgpam_Expediente.DECLARANTE); 
				vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpam_Expediente.FEC_INGRESO); 
				vCmd.Parameters.Add("pID_EXPEDIENTE", vT_Sgpam_Expediente.ID_EXPEDIENTE); 
				vCmd.Parameters.Add("pNRO_EXPEDIENTE", vT_Sgpam_Expediente.NRO_EXPEDIENTE); 
				vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpam_Expediente.IP_INGRESO); 
				vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpam_Expediente.FEC_MODIFICA); 
				vCmd.Parameters.Add("pZONA", vT_Sgpam_Expediente.ZONA);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpam_Expediente;
        }

        public int AnularT_Sgpam_ExpedientePorCodigo(int vId_Expediente)
        {
            int vResultado = 0;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_EXPEDIENTE.USP_DEL_EXPEDIENTE", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_EXPEDIENTE", vId_Expediente);
                    vCnn.Open();
                    vResultado = vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vResultado;
        }

        public IEnumerable<T_Sgpam_Expediente> ListarPaginadoT_Sgpam_Expediente(string vNroExp, string vFiltro, int vNumPag, int vCantRegxPag)
        {
           List<T_Sgpam_Expediente> vLista = new List<T_Sgpam_Expediente>();
           T_Sgpam_Expediente vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_EXPEDIENTE.USP_LIS_PAG_EXPEDIENTE", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pFiltro", vFiltro);
                    vCmd.Parameters.Add("pNroExp", vNroExp);
                    vCmd.Parameters.Add("pNumPag", vNumPag);
                    vCmd.Parameters.Add("pCantRegxPag", vCantRegxPag);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpam_Expediente(vRdr);
                        //vEntidad.TotalVirtual = System.Convert.ToInt32(vRdr["TotalVirtual"]);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }
    }
}