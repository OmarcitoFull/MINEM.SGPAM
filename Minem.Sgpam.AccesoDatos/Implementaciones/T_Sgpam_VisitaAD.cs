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
    /// Objetivo:	Clase que genera las operaciones para la tabla T_SGPAM_VISITA
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	27/10/2021
    /// </summary>
    public partial class T_Sgpam_VisitaAD: BaseAD, IT_Sgpam_VisitaAD
    {
        public T_Sgpam_VisitaAD(IConfiguration vConfiguration)
        {
            CnnString = vConfiguration.GetSection(Constantes.BD).Value;
        }

        public IEnumerable<T_Sgpam_Visita> ListarT_Sgpam_Visita()
        {
           List<T_Sgpam_Visita> vLista = new List<T_Sgpam_Visita>();
           T_Sgpam_Visita vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_VISITA.USP_LIS_VISITA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpam_Visita(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public T_Sgpam_Visita RecuperarT_Sgpam_VisitaPorCodigo(int vId_Visita)
        {
           T_Sgpam_Visita vEntidad = null;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_VISITA.USP_SEL_VISITA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_VISITA", vId_Visita);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpam_Visita(vRdr);
                    }
                }
                vCnn.Close();
            }
            return vEntidad;
        }

        public T_Sgpam_Visita InsertarT_Sgpam_Visita(T_Sgpam_Visita vT_Sgpam_Visita)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_VISITA.USP_INS_VISITA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    //vCmd.Parameters.Add("pID_VISITA", vT_Sgpam_Visita.ID_VISITA);
                    vCmd.Parameters.Add("pUBIGEO", vT_Sgpam_Visita.UBIGEO);
                    vCmd.Parameters.Add("pFECHA_SALIDA", vT_Sgpam_Visita.FECHA_SALIDA);
                    vCmd.Parameters.Add("pFECHA_REGRESO", vT_Sgpam_Visita.FECHA_REGRESO);
                    vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpam_Visita.USU_INGRESO);
                    vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpam_Visita.FEC_INGRESO);
                    vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpam_Visita.IP_INGRESO);
				    vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpam_Visita.FLG_ESTADO);
                    vCmd.Parameters.Add(":pID_VISITA", OracleDbType.Int64).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vT_Sgpam_Visita.ID_VISITA = Convert.ToInt32(vCmd.Parameters[":pID_VISITA"].Value.ToString());
                    vCnn.Close();
                }
            }
            return vT_Sgpam_Visita;
        }
        
        public T_Sgpam_Visita ActualizarT_Sgpam_Visita(T_Sgpam_Visita vT_Sgpam_Visita)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_VISITA.USP_UPD_VISITA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_VISITA", vT_Sgpam_Visita.ID_VISITA);
                    vCmd.Parameters.Add("pUBIGEO", vT_Sgpam_Visita.UBIGEO);
                    vCmd.Parameters.Add("pFECHA_SALIDA", vT_Sgpam_Visita.FECHA_SALIDA);
                    vCmd.Parameters.Add("pFECHA_REGRESO", vT_Sgpam_Visita.FECHA_REGRESO);
                    vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpam_Visita.USU_MODIFICA);
                    vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpam_Visita.FEC_MODIFICA);
                    vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpam_Visita.IP_MODIFICA);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpam_Visita;
        }

        public int AnularT_Sgpam_VisitaPorCodigo(int vId_Visita)
        {
            int vResultado = 0;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_VISITA.USP_DEL_VISITA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_VISITA", vId_Visita);
                    vCnn.Open();
                    vResultado = vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vResultado;
        }

        public IEnumerable<T_Sgpam_Visita> ListarPaginadoT_Sgpam_Visita(string vFiltro, string vNroExpediente, int vTipo, int vCantAnios, int vNumPag, int vCantRegxPag)
        {
           List<T_Sgpam_Visita> vLista = new List<T_Sgpam_Visita>();
           T_Sgpam_Visita vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_VISITA.USP_LIS_PAG_VISITA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pFILTRO", vFiltro);
                    vCmd.Parameters.Add("pNRO_EXPEDIENTE", vNroExpediente);
                    vCmd.Parameters.Add("pTIPO", vTipo);
                    vCmd.Parameters.Add("pCANT_ANIOS", vCantAnios);
                    vCmd.Parameters.Add("pNumPag", vNumPag);
                    vCmd.Parameters.Add("pCantRegxPag", vCantRegxPag);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpam_Visita(vRdr);
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