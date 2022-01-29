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
    /// Objetivo:	Clase que genera las operaciones para la tabla T_SGPAD_COMP_REINFO_DM
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	27/10/2021
    /// </summary>
    public partial class T_Sgpad_Comp_Reinfo_DmAD: BaseAD, IT_Sgpad_Comp_Reinfo_DmAD
    {   
        public IEnumerable<T_Sgpad_Comp_Reinfo_Dm> ListarT_Sgpad_Comp_Reinfo_Dm()
        {
           List<T_Sgpad_Comp_Reinfo_Dm> vLista = new List<T_Sgpad_Comp_Reinfo_Dm>();
           T_Sgpad_Comp_Reinfo_Dm vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_REINFO_DM.USP_LIS_COMP_REINFO_DM", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpad_Comp_Reinfo_Dm(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public T_Sgpad_Comp_Reinfo_Dm RecuperarT_Sgpad_Comp_Reinfo_DmPorCodigo(int vId_Comp_Reinfo_Dm)
        {
           T_Sgpad_Comp_Reinfo_Dm vEntidad = null;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_REINFO_DM.USP_SEL_COMP_REINFO_DM", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_COMP_REINFO_DM", vId_Comp_Reinfo_Dm);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpad_Comp_Reinfo_Dm(vRdr);
                    }
                }
                vCnn.Close();
            }
            return vEntidad;
        }

        public T_Sgpad_Comp_Reinfo_Dm InsertarT_Sgpad_Comp_Reinfo_Dm(T_Sgpad_Comp_Reinfo_Dm vT_Sgpad_Comp_Reinfo_Dm)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_REINFO_DM.USP_INS_COMP_REINFO_DM", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_COMP_REINFO_DM", vT_Sgpad_Comp_Reinfo_Dm.ID_COMP_REINFO_DM); 				vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpad_Comp_Reinfo_Dm.IP_MODIFICA); 				vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpad_Comp_Reinfo_Dm.FEC_INGRESO); 				vCmd.Parameters.Add("pID_COMPONENTE", vT_Sgpad_Comp_Reinfo_Dm.ID_COMPONENTE); 				vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpad_Comp_Reinfo_Dm.IP_INGRESO); 				vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpad_Comp_Reinfo_Dm.USU_MODIFICA); 				vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpad_Comp_Reinfo_Dm.FEC_MODIFICA); 				vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpad_Comp_Reinfo_Dm.USU_INGRESO); 				vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpad_Comp_Reinfo_Dm.FLG_ESTADO);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpad_Comp_Reinfo_Dm;
        }
        
        public T_Sgpad_Comp_Reinfo_Dm ActualizarT_Sgpad_Comp_Reinfo_Dm(T_Sgpad_Comp_Reinfo_Dm vT_Sgpad_Comp_Reinfo_Dm)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_REINFO_DM.USP_UPD_COMP_REINFO_DM", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_COMP_REINFO_DM", vT_Sgpad_Comp_Reinfo_Dm.ID_COMP_REINFO_DM); 				vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpad_Comp_Reinfo_Dm.IP_MODIFICA); 				vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpad_Comp_Reinfo_Dm.FEC_INGRESO); 				vCmd.Parameters.Add("pID_COMPONENTE", vT_Sgpad_Comp_Reinfo_Dm.ID_COMPONENTE); 				vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpad_Comp_Reinfo_Dm.IP_INGRESO); 				vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpad_Comp_Reinfo_Dm.USU_MODIFICA); 				vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpad_Comp_Reinfo_Dm.FEC_MODIFICA); 				vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpad_Comp_Reinfo_Dm.USU_INGRESO); 				vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpad_Comp_Reinfo_Dm.FLG_ESTADO);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpad_Comp_Reinfo_Dm;
        }

        public int AnularT_Sgpad_Comp_Reinfo_DmPorCodigo(int vId_Comp_Reinfo_Dm)
        {
            int vResultado = 0;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_REINFO_DM.USP_DEL_COMP_REINFO_DM", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_COMP_REINFO_DM", vId_Comp_Reinfo_Dm);
                    vCnn.Open();
                    vResultado = vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vResultado;
        }

        public IEnumerable<T_Sgpad_Comp_Reinfo_Dm> ListarPaginadoT_Sgpad_Comp_Reinfo_Dm(string vFiltro, int vNumPag, int vCantRegxPag)
        {
           List<T_Sgpad_Comp_Reinfo_Dm> vLista = new List<T_Sgpad_Comp_Reinfo_Dm>();
           T_Sgpad_Comp_Reinfo_Dm vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_REINFO_DM.USP_PAG_COMP_REINFO_DM", vCnn))
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
                        vEntidad = new T_Sgpad_Comp_Reinfo_Dm(vRdr);
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