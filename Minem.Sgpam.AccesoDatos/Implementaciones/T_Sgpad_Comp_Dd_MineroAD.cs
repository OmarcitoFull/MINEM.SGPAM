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
    /// Objetivo:	Clase que genera las operaciones para la tabla T_SGPAD_COMP_DD_MINERO
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	27/10/2021
    /// </summary>
    public partial class T_Sgpad_Comp_Dd_MineroAD: BaseAD, IT_Sgpad_Comp_Dd_MineroAD
    {
        public T_Sgpad_Comp_Dd_MineroAD(IConfiguration vConfiguration)
        {
            CnnString = vConfiguration.GetSection(Constantes.BD).Value;
        }

        public IEnumerable<T_Sgpad_Comp_Dd_Minero> ListarT_Sgpad_Comp_Dd_Minero()
        {
           List<T_Sgpad_Comp_Dd_Minero> vLista = new List<T_Sgpad_Comp_Dd_Minero>();
           T_Sgpad_Comp_Dd_Minero vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_DD_MINERO.USP_LIS_COMP_DD_MINERO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpad_Comp_Dd_Minero(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public T_Sgpad_Comp_Dd_Minero RecuperarT_Sgpad_Comp_Dd_MineroPorCodigo(int vId_Comp_Dm)
        {
           T_Sgpad_Comp_Dd_Minero vEntidad = null;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_DD_MINERO.USP_SEL_COMP_DD_MINERO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_COMP_DM", vId_Comp_Dm);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpad_Comp_Dd_Minero(vRdr);
                    }
                }
                vCnn.Close();
            }
            return vEntidad;
        }

        public T_Sgpad_Comp_Dd_Minero InsertarT_Sgpad_Comp_Dd_Minero(T_Sgpad_Comp_Dd_Minero vT_Sgpad_Comp_Dd_Minero)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_DD_MINERO.USP_INS_COMP_DD_MINERO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pCODIGO_DM", vT_Sgpad_Comp_Dd_Minero.CODIGO_DM); 				vCmd.Parameters.Add("pID_COMPONENTE", vT_Sgpad_Comp_Dd_Minero.ID_COMPONENTE); 				vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpad_Comp_Dd_Minero.IP_INGRESO); 				vCmd.Parameters.Add("pID_ESTADO", vT_Sgpad_Comp_Dd_Minero.ID_ESTADO); 				vCmd.Parameters.Add("pID_SUSTANCIA", vT_Sgpad_Comp_Dd_Minero.ID_SUSTANCIA); 				vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpad_Comp_Dd_Minero.USU_MODIFICA); 				vCmd.Parameters.Add("pDESCRIPCION_DM", vT_Sgpad_Comp_Dd_Minero.DESCRIPCION_DM); 				vCmd.Parameters.Add("pID_SITUACION", vT_Sgpad_Comp_Dd_Minero.ID_SITUACION); 				vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpad_Comp_Dd_Minero.FLG_ESTADO); 				vCmd.Parameters.Add("pID_COMP_DM", vT_Sgpad_Comp_Dd_Minero.ID_COMP_DM); 				vCmd.Parameters.Add("pID_TIPO_DM", vT_Sgpad_Comp_Dd_Minero.ID_TIPO_DM); 				vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpad_Comp_Dd_Minero.FEC_MODIFICA); 				vCmd.Parameters.Add("pUEA", vT_Sgpad_Comp_Dd_Minero.UEA); 				vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpad_Comp_Dd_Minero.USU_INGRESO); 				vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpad_Comp_Dd_Minero.IP_MODIFICA); 				vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpad_Comp_Dd_Minero.FEC_INGRESO);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpad_Comp_Dd_Minero;
        }
        
        public T_Sgpad_Comp_Dd_Minero ActualizarT_Sgpad_Comp_Dd_Minero(T_Sgpad_Comp_Dd_Minero vT_Sgpad_Comp_Dd_Minero)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_DD_MINERO.USP_UPD_COMP_DD_MINERO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pCODIGO_DM", vT_Sgpad_Comp_Dd_Minero.CODIGO_DM); 				vCmd.Parameters.Add("pID_COMPONENTE", vT_Sgpad_Comp_Dd_Minero.ID_COMPONENTE); 				vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpad_Comp_Dd_Minero.IP_INGRESO); 				vCmd.Parameters.Add("pID_ESTADO", vT_Sgpad_Comp_Dd_Minero.ID_ESTADO); 				vCmd.Parameters.Add("pID_SUSTANCIA", vT_Sgpad_Comp_Dd_Minero.ID_SUSTANCIA); 				vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpad_Comp_Dd_Minero.USU_MODIFICA); 				vCmd.Parameters.Add("pDESCRIPCION_DM", vT_Sgpad_Comp_Dd_Minero.DESCRIPCION_DM); 				vCmd.Parameters.Add("pID_SITUACION", vT_Sgpad_Comp_Dd_Minero.ID_SITUACION); 				vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpad_Comp_Dd_Minero.FLG_ESTADO); 				vCmd.Parameters.Add("pID_COMP_DM", vT_Sgpad_Comp_Dd_Minero.ID_COMP_DM); 				vCmd.Parameters.Add("pID_TIPO_DM", vT_Sgpad_Comp_Dd_Minero.ID_TIPO_DM); 				vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpad_Comp_Dd_Minero.FEC_MODIFICA); 				vCmd.Parameters.Add("pUEA", vT_Sgpad_Comp_Dd_Minero.UEA); 				vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpad_Comp_Dd_Minero.USU_INGRESO); 				vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpad_Comp_Dd_Minero.IP_MODIFICA); 				vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpad_Comp_Dd_Minero.FEC_INGRESO);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpad_Comp_Dd_Minero;
        }

        public int AnularT_Sgpad_Comp_Dd_MineroPorCodigo(int vId_Comp_Dm)
        {
            int vResultado = 0;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_DD_MINERO.USP_DEL_COMP_DD_MINERO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_COMP_DM", vId_Comp_Dm);
                    vCnn.Open();
                    vResultado = vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vResultado;
        }

        public IEnumerable<T_Sgpad_Comp_Dd_Minero> ListarPaginadoT_Sgpad_Comp_Dd_Minero(string vFiltro, int vNumPag, int vCantRegxPag)
        {
           List<T_Sgpad_Comp_Dd_Minero> vLista = new List<T_Sgpad_Comp_Dd_Minero>();
           T_Sgpad_Comp_Dd_Minero vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_DD_MINERO.USP_PAG_COMP_DD_MINERO", vCnn))
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
                        vEntidad = new T_Sgpad_Comp_Dd_Minero(vRdr);
                        vEntidad.TotalVirtual = System.Convert.ToInt32(vRdr["TotalVirtual"]);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public IEnumerable<T_Sgpad_Comp_Dd_Minero> ListarPorIdEumT_Sgpad_Comp_Dd_Minero(int vId_Eum)
        {
            List<T_Sgpad_Comp_Dd_Minero> vLista = new List<T_Sgpad_Comp_Dd_Minero>();
            T_Sgpad_Comp_Dd_Minero vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_DD_MINERO.USP_LIS_POR_IDEUM_COMP_DD_MINERO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_EUM", vId_Eum);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpad_Comp_Dd_Minero(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }
    }
}