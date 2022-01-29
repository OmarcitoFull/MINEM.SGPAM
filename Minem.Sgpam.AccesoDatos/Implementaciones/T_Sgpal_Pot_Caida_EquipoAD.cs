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
    /// Objetivo:	Clase que genera las operaciones para la tabla T_SGPAL_POT_CAIDA_EQUIPO
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	27/10/2021
    /// </summary>
    public partial class T_Sgpal_Pot_Caida_EquipoAD: BaseAD, IT_Sgpal_Pot_Caida_EquipoAD
    {   
        public IEnumerable<T_Sgpal_Pot_Caida_Equipo> ListarT_Sgpal_Pot_Caida_Equipo()
        {
           List<T_Sgpal_Pot_Caida_Equipo> vLista = new List<T_Sgpal_Pot_Caida_Equipo>();
           T_Sgpal_Pot_Caida_Equipo vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_POT_CAIDA_EQUIPO.USP_LIS_POT_CAIDA_EQUIPO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpal_Pot_Caida_Equipo(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public T_Sgpal_Pot_Caida_Equipo RecuperarT_Sgpal_Pot_Caida_EquipoPorCodigo(int vId_Pot_Caida_Equipo)
        {
           T_Sgpal_Pot_Caida_Equipo vEntidad = null;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_POT_CAIDA_EQUIPO.USP_SEL_POT_CAIDA_EQUIPO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_POT_CAIDA_EQUIPO", vId_Pot_Caida_Equipo);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpal_Pot_Caida_Equipo(vRdr);
                    }
                }
                vCnn.Close();
            }
            return vEntidad;
        }

        public T_Sgpal_Pot_Caida_Equipo InsertarT_Sgpal_Pot_Caida_Equipo(T_Sgpal_Pot_Caida_Equipo vT_Sgpal_Pot_Caida_Equipo)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_POT_CAIDA_EQUIPO.USP_INS_POT_CAIDA_EQUIPO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpal_Pot_Caida_Equipo.FLG_ESTADO); 				vCmd.Parameters.Add("pDESCRIPCION", vT_Sgpal_Pot_Caida_Equipo.DESCRIPCION); 				vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpal_Pot_Caida_Equipo.IP_INGRESO); 				vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpal_Pot_Caida_Equipo.IP_MODIFICA); 				vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpal_Pot_Caida_Equipo.FEC_INGRESO); 				vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpal_Pot_Caida_Equipo.USU_MODIFICA); 				vCmd.Parameters.Add("pID_POT_CAIDA_EQUIPO", vT_Sgpal_Pot_Caida_Equipo.ID_POT_CAIDA_EQUIPO); 				vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpal_Pot_Caida_Equipo.FEC_MODIFICA); 				vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpal_Pot_Caida_Equipo.USU_INGRESO);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpal_Pot_Caida_Equipo;
        }
        
        public T_Sgpal_Pot_Caida_Equipo ActualizarT_Sgpal_Pot_Caida_Equipo(T_Sgpal_Pot_Caida_Equipo vT_Sgpal_Pot_Caida_Equipo)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_POT_CAIDA_EQUIPO.USP_UPD_POT_CAIDA_EQUIPO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpal_Pot_Caida_Equipo.FLG_ESTADO); 				vCmd.Parameters.Add("pDESCRIPCION", vT_Sgpal_Pot_Caida_Equipo.DESCRIPCION); 				vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpal_Pot_Caida_Equipo.IP_INGRESO); 				vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpal_Pot_Caida_Equipo.IP_MODIFICA); 				vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpal_Pot_Caida_Equipo.FEC_INGRESO); 				vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpal_Pot_Caida_Equipo.USU_MODIFICA); 				vCmd.Parameters.Add("pID_POT_CAIDA_EQUIPO", vT_Sgpal_Pot_Caida_Equipo.ID_POT_CAIDA_EQUIPO); 				vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpal_Pot_Caida_Equipo.FEC_MODIFICA); 				vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpal_Pot_Caida_Equipo.USU_INGRESO);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpal_Pot_Caida_Equipo;
        }

        public int AnularT_Sgpal_Pot_Caida_EquipoPorCodigo(int vId_Pot_Caida_Equipo)
        {
            int vResultado = 0;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_POT_CAIDA_EQUIPO.USP_DEL_POT_CAIDA_EQUIPO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_POT_CAIDA_EQUIPO", vId_Pot_Caida_Equipo);
                    vCnn.Open();
                    vResultado = vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vResultado;
        }

        public IEnumerable<T_Sgpal_Pot_Caida_Equipo> ListarPaginadoT_Sgpal_Pot_Caida_Equipo(string vFiltro, int vNumPag, int vCantRegxPag)
        {
           List<T_Sgpal_Pot_Caida_Equipo> vLista = new List<T_Sgpal_Pot_Caida_Equipo>();
           T_Sgpal_Pot_Caida_Equipo vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_POT_CAIDA_EQUIPO.USP_PAG_POT_CAIDA_EQUIPO", vCnn))
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
                        vEntidad = new T_Sgpal_Pot_Caida_Equipo(vRdr);
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