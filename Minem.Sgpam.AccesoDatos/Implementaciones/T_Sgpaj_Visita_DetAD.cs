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
    /// Objetivo:	Clase que genera las operaciones para la tabla T_SGPAJ_VISITA_DET
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	27/10/2021
    /// </summary>
    public partial class T_Sgpaj_Visita_DetAD: BaseAD, IT_Sgpaj_Visita_DetAD
    {   
        public IEnumerable<T_Sgpaj_Visita_Det> ListarT_Sgpaj_Visita_Det()
        {
           List<T_Sgpaj_Visita_Det> vLista = new List<T_Sgpaj_Visita_Det>();
           T_Sgpaj_Visita_Det vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_VISITA_DET.USP_LIS_VISITA_DET", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpaj_Visita_Det(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public T_Sgpaj_Visita_Det RecuperarT_Sgpaj_Visita_DetPorCodigo(int vId_Visita_Det)
        {
           T_Sgpaj_Visita_Det vEntidad = null;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_VISITA_DET.USP_SEL_VISITA_DET", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_VISITA_DET", vId_Visita_Det);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpaj_Visita_Det(vRdr);
                    }
                }
                vCnn.Close();
            }
            return vEntidad;
        }

        public T_Sgpaj_Visita_Det InsertarT_Sgpaj_Visita_Det(T_Sgpaj_Visita_Det vT_Sgpaj_Visita_Det)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_VISITA_DET.USP_INS_VISITA_DET", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_VISITA_DET", vT_Sgpaj_Visita_Det.ID_VISITA_DET); 				vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpaj_Visita_Det.USU_MODIFICA); 				vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpaj_Visita_Det.FEC_INGRESO); 				vCmd.Parameters.Add("pMOTIVO", vT_Sgpaj_Visita_Det.MOTIVO); 				vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpaj_Visita_Det.IP_INGRESO); 				vCmd.Parameters.Add("pOBSERVACION", vT_Sgpaj_Visita_Det.OBSERVACION); 				vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpaj_Visita_Det.IP_MODIFICA); 				vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpaj_Visita_Det.USU_INGRESO); 				vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpaj_Visita_Det.FLG_ESTADO); 				vCmd.Parameters.Add("pID_VISITA", vT_Sgpaj_Visita_Det.ID_VISITA); 				vCmd.Parameters.Add("pID_EXPEDIENTE", vT_Sgpaj_Visita_Det.ID_EXPEDIENTE); 				vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpaj_Visita_Det.FEC_MODIFICA); 				vCmd.Parameters.Add("pID_EUM", vT_Sgpaj_Visita_Det.ID_EUM);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpaj_Visita_Det;
        }
        
        public T_Sgpaj_Visita_Det ActualizarT_Sgpaj_Visita_Det(T_Sgpaj_Visita_Det vT_Sgpaj_Visita_Det)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_VISITA_DET.USP_UPD_VISITA_DET", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_VISITA_DET", vT_Sgpaj_Visita_Det.ID_VISITA_DET); 				vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpaj_Visita_Det.USU_MODIFICA); 				vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpaj_Visita_Det.FEC_INGRESO); 				vCmd.Parameters.Add("pMOTIVO", vT_Sgpaj_Visita_Det.MOTIVO); 				vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpaj_Visita_Det.IP_INGRESO); 				vCmd.Parameters.Add("pOBSERVACION", vT_Sgpaj_Visita_Det.OBSERVACION); 				vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpaj_Visita_Det.IP_MODIFICA); 				vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpaj_Visita_Det.USU_INGRESO); 				vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpaj_Visita_Det.FLG_ESTADO); 				vCmd.Parameters.Add("pID_VISITA", vT_Sgpaj_Visita_Det.ID_VISITA); 				vCmd.Parameters.Add("pID_EXPEDIENTE", vT_Sgpaj_Visita_Det.ID_EXPEDIENTE); 				vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpaj_Visita_Det.FEC_MODIFICA); 				vCmd.Parameters.Add("pID_EUM", vT_Sgpaj_Visita_Det.ID_EUM);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpaj_Visita_Det;
        }

        public int AnularT_Sgpaj_Visita_DetPorCodigo(int vId_Visita_Det)
        {
            int vResultado = 0;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_VISITA_DET.USP_DEL_VISITA_DET", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_VISITA_DET", vId_Visita_Det);
                    vCnn.Open();
                    vResultado = vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vResultado;
        }

        public IEnumerable<T_Sgpaj_Visita_Det> ListarPaginadoT_Sgpaj_Visita_Det(string vFiltro, int vNumPag, int vCantRegxPag)
        {
           List<T_Sgpaj_Visita_Det> vLista = new List<T_Sgpaj_Visita_Det>();
           T_Sgpaj_Visita_Det vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_VISITA_DET.USP_PAG_VISITA_DET", vCnn))
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
                        vEntidad = new T_Sgpaj_Visita_Det(vRdr);
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