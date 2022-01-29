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
    /// Objetivo:	Clase que genera las operaciones para la tabla T_SGPAD_EUM_INFORME
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	27/10/2021
    /// </summary>
    public partial class T_Sgpad_Eum_InformeAD: BaseAD, IT_Sgpad_Eum_InformeAD
    {   
        public IEnumerable<T_Sgpad_Eum_Informe> ListarT_Sgpad_Eum_Informe()
        {
           List<T_Sgpad_Eum_Informe> vLista = new List<T_Sgpad_Eum_Informe>();
           T_Sgpad_Eum_Informe vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_EUM_INFORME.USP_LIS_EUM_INFORME", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpad_Eum_Informe(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public T_Sgpad_Eum_Informe RecuperarT_Sgpad_Eum_InformePorCodigo(int vId_Eum_Informe)
        {
           T_Sgpad_Eum_Informe vEntidad = null;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_EUM_INFORME.USP_SEL_EUM_INFORME", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_EUM_INFORME", vId_Eum_Informe);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpad_Eum_Informe(vRdr);
                    }
                }
                vCnn.Close();
            }
            return vEntidad;
        }

        public T_Sgpad_Eum_Informe InsertarT_Sgpad_Eum_Informe(T_Sgpad_Eum_Informe vT_Sgpad_Eum_Informe)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_EUM_INFORME.USP_INS_EUM_INFORME", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pNRO_EXPEDIENTE", vT_Sgpad_Eum_Informe.NRO_EXPEDIENTE); 
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpad_Eum_Informe;
        }
        
        public T_Sgpad_Eum_Informe ActualizarT_Sgpad_Eum_Informe(T_Sgpad_Eum_Informe vT_Sgpad_Eum_Informe)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_EUM_INFORME.USP_UPD_EUM_INFORME", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pNRO_EXPEDIENTE", vT_Sgpad_Eum_Informe.NRO_EXPEDIENTE); 
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpad_Eum_Informe;
        }

        public int AnularT_Sgpad_Eum_InformePorCodigo(int vId_Eum_Informe)
        {
            int vResultado = 0;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_EUM_INFORME.USP_DEL_EUM_INFORME", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_EUM_INFORME", vId_Eum_Informe);
                    vCnn.Open();
                    vResultado = vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vResultado;
        }

        public IEnumerable<T_Sgpad_Eum_Informe> ListarPaginadoT_Sgpad_Eum_Informe(string vFiltro, int vNumPag, int vCantRegxPag)
        {
           List<T_Sgpad_Eum_Informe> vLista = new List<T_Sgpad_Eum_Informe>();
           T_Sgpad_Eum_Informe vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_EUM_INFORME.USP_PAG_EUM_INFORME", vCnn))
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
                        vEntidad = new T_Sgpad_Eum_Informe(vRdr);
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