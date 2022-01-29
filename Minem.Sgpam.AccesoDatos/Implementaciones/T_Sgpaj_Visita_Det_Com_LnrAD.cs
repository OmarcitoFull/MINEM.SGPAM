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
    /// Objetivo:	Clase que genera las operaciones para la tabla T_SGPAJ_VISITA_DET_COM_LNR
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	27/10/2021
    /// </summary>
    public partial class T_Sgpaj_Visita_Det_Com_LnrAD: BaseAD, IT_Sgpaj_Visita_Det_Com_LnrAD
    {   
        public IEnumerable<T_Sgpaj_Visita_Det_Com_Lnr> ListarT_Sgpaj_Visita_Det_Com_Lnr()
        {
           List<T_Sgpaj_Visita_Det_Com_Lnr> vLista = new List<T_Sgpaj_Visita_Det_Com_Lnr>();
           T_Sgpaj_Visita_Det_Com_Lnr vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_VISITA_DET_COM_LNR.USP_LIS_VISITA_DET_COM_LNR", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpaj_Visita_Det_Com_Lnr(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public T_Sgpaj_Visita_Det_Com_Lnr RecuperarT_Sgpaj_Visita_Det_Com_LnrPorCodigo(int vId_Visita_Det_Com_Lnr)
        {
           T_Sgpaj_Visita_Det_Com_Lnr vEntidad = null;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_VISITA_DET_COM_LNR.USP_SEL_VISITA_DET_COM_LNR", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_VISITA_DET_COM_LNR", vId_Visita_Det_Com_Lnr);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpaj_Visita_Det_Com_Lnr(vRdr);
                    }
                }
                vCnn.Close();
            }
            return vEntidad;
        }

        public T_Sgpaj_Visita_Det_Com_Lnr InsertarT_Sgpaj_Visita_Det_Com_Lnr(T_Sgpaj_Visita_Det_Com_Lnr vT_Sgpaj_Visita_Det_Com_Lnr)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_VISITA_DET_COM_LNR.USP_INS_VISITA_DET_COM_LNR", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_COMPONENTE", vT_Sgpaj_Visita_Det_Com_Lnr.ID_COMPONENTE); 				vCmd.Parameters.Add("pID_LNR", vT_Sgpaj_Visita_Det_Com_Lnr.ID_LNR); 				vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpaj_Visita_Det_Com_Lnr.FLG_ESTADO); 				vCmd.Parameters.Add("pID_VISITA_DET_COM_LNR", vT_Sgpaj_Visita_Det_Com_Lnr.ID_VISITA_DET_COM_LNR); 				vCmd.Parameters.Add("pPUNTAJE", vT_Sgpaj_Visita_Det_Com_Lnr.PUNTAJE); 				vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpaj_Visita_Det_Com_Lnr.IP_MODIFICA); 				vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpaj_Visita_Det_Com_Lnr.FEC_INGRESO); 				vCmd.Parameters.Add("pID_VISITA_DET", vT_Sgpaj_Visita_Det_Com_Lnr.ID_VISITA_DET); 				vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpaj_Visita_Det_Com_Lnr.FEC_MODIFICA); 				vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpaj_Visita_Det_Com_Lnr.IP_INGRESO); 				vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpaj_Visita_Det_Com_Lnr.USU_MODIFICA); 				vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpaj_Visita_Det_Com_Lnr.USU_INGRESO);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpaj_Visita_Det_Com_Lnr;
        }
        
        public T_Sgpaj_Visita_Det_Com_Lnr ActualizarT_Sgpaj_Visita_Det_Com_Lnr(T_Sgpaj_Visita_Det_Com_Lnr vT_Sgpaj_Visita_Det_Com_Lnr)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_VISITA_DET_COM_LNR.USP_UPD_VISITA_DET_COM_LNR", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_COMPONENTE", vT_Sgpaj_Visita_Det_Com_Lnr.ID_COMPONENTE); 				vCmd.Parameters.Add("pID_LNR", vT_Sgpaj_Visita_Det_Com_Lnr.ID_LNR); 				vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpaj_Visita_Det_Com_Lnr.FLG_ESTADO); 				vCmd.Parameters.Add("pID_VISITA_DET_COM_LNR", vT_Sgpaj_Visita_Det_Com_Lnr.ID_VISITA_DET_COM_LNR); 				vCmd.Parameters.Add("pPUNTAJE", vT_Sgpaj_Visita_Det_Com_Lnr.PUNTAJE); 				vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpaj_Visita_Det_Com_Lnr.IP_MODIFICA); 				vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpaj_Visita_Det_Com_Lnr.FEC_INGRESO); 				vCmd.Parameters.Add("pID_VISITA_DET", vT_Sgpaj_Visita_Det_Com_Lnr.ID_VISITA_DET); 				vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpaj_Visita_Det_Com_Lnr.FEC_MODIFICA); 				vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpaj_Visita_Det_Com_Lnr.IP_INGRESO); 				vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpaj_Visita_Det_Com_Lnr.USU_MODIFICA); 				vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpaj_Visita_Det_Com_Lnr.USU_INGRESO);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpaj_Visita_Det_Com_Lnr;
        }

        public int AnularT_Sgpaj_Visita_Det_Com_LnrPorCodigo(int vId_Visita_Det_Com_Lnr)
        {
            int vResultado = 0;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_VISITA_DET_COM_LNR.USP_DEL_VISITA_DET_COM_LNR", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_VISITA_DET_COM_LNR", vId_Visita_Det_Com_Lnr);
                    vCnn.Open();
                    vResultado = vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vResultado;
        }

        public IEnumerable<T_Sgpaj_Visita_Det_Com_Lnr> ListarPaginadoT_Sgpaj_Visita_Det_Com_Lnr(string vFiltro, int vNumPag, int vCantRegxPag)
        {
           List<T_Sgpaj_Visita_Det_Com_Lnr> vLista = new List<T_Sgpaj_Visita_Det_Com_Lnr>();
           T_Sgpaj_Visita_Det_Com_Lnr vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_VISITA_DET_COM_LNR.USP_PAG_VISITA_DET_COM_LNR", vCnn))
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
                        vEntidad = new T_Sgpaj_Visita_Det_Com_Lnr(vRdr);
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