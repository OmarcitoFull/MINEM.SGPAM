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
    /// Objetivo:	Clase que genera las operaciones para la tabla T_SGPAL_POT_DANO_ESCORIA
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	27/10/2021
    /// </summary>
    public partial class T_Sgpal_Pot_Dano_EscoriaAD: BaseAD, IT_Sgpal_Pot_Dano_EscoriaAD
    {   
        public IEnumerable<T_Sgpal_Pot_Dano_Escoria> ListarT_Sgpal_Pot_Dano_Escoria()
        {
           List<T_Sgpal_Pot_Dano_Escoria> vLista = new List<T_Sgpal_Pot_Dano_Escoria>();
           T_Sgpal_Pot_Dano_Escoria vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_POT_DANO_ESCORIA.USP_LIS_POT_DANO_ESCORIA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpal_Pot_Dano_Escoria(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public T_Sgpal_Pot_Dano_Escoria RecuperarT_Sgpal_Pot_Dano_EscoriaPorCodigo(int vId_Pot_Dano_Escoria)
        {
           T_Sgpal_Pot_Dano_Escoria vEntidad = null;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_POT_DANO_ESCORIA.USP_SEL_POT_DANO_ESCORIA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_POT_DANO_ESCORIA", vId_Pot_Dano_Escoria);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpal_Pot_Dano_Escoria(vRdr);
                    }
                }
                vCnn.Close();
            }
            return vEntidad;
        }

        public T_Sgpal_Pot_Dano_Escoria InsertarT_Sgpal_Pot_Dano_Escoria(T_Sgpal_Pot_Dano_Escoria vT_Sgpal_Pot_Dano_Escoria)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_POT_DANO_ESCORIA.USP_INS_POT_DANO_ESCORIA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpal_Pot_Dano_Escoria.FLG_ESTADO); 				vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpal_Pot_Dano_Escoria.USU_MODIFICA); 				vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpal_Pot_Dano_Escoria.IP_MODIFICA); 				vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpal_Pot_Dano_Escoria.FEC_MODIFICA); 				vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpal_Pot_Dano_Escoria.FEC_INGRESO); 				vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpal_Pot_Dano_Escoria.USU_INGRESO); 				vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpal_Pot_Dano_Escoria.IP_INGRESO); 				vCmd.Parameters.Add("pDESCRIPCION", vT_Sgpal_Pot_Dano_Escoria.DESCRIPCION); 				vCmd.Parameters.Add("pID_POT_DANO_ESCORIA", vT_Sgpal_Pot_Dano_Escoria.ID_POT_DANO_ESCORIA);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpal_Pot_Dano_Escoria;
        }
        
        public T_Sgpal_Pot_Dano_Escoria ActualizarT_Sgpal_Pot_Dano_Escoria(T_Sgpal_Pot_Dano_Escoria vT_Sgpal_Pot_Dano_Escoria)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_POT_DANO_ESCORIA.USP_UPD_POT_DANO_ESCORIA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpal_Pot_Dano_Escoria.FLG_ESTADO); 				vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpal_Pot_Dano_Escoria.USU_MODIFICA); 				vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpal_Pot_Dano_Escoria.IP_MODIFICA); 				vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpal_Pot_Dano_Escoria.FEC_MODIFICA); 				vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpal_Pot_Dano_Escoria.FEC_INGRESO); 				vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpal_Pot_Dano_Escoria.USU_INGRESO); 				vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpal_Pot_Dano_Escoria.IP_INGRESO); 				vCmd.Parameters.Add("pDESCRIPCION", vT_Sgpal_Pot_Dano_Escoria.DESCRIPCION); 				vCmd.Parameters.Add("pID_POT_DANO_ESCORIA", vT_Sgpal_Pot_Dano_Escoria.ID_POT_DANO_ESCORIA);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpal_Pot_Dano_Escoria;
        }

        public int AnularT_Sgpal_Pot_Dano_EscoriaPorCodigo(int vId_Pot_Dano_Escoria)
        {
            int vResultado = 0;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_POT_DANO_ESCORIA.USP_DEL_POT_DANO_ESCORIA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_POT_DANO_ESCORIA", vId_Pot_Dano_Escoria);
                    vCnn.Open();
                    vResultado = vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vResultado;
        }

        public IEnumerable<T_Sgpal_Pot_Dano_Escoria> ListarPaginadoT_Sgpal_Pot_Dano_Escoria(string vFiltro, int vNumPag, int vCantRegxPag)
        {
           List<T_Sgpal_Pot_Dano_Escoria> vLista = new List<T_Sgpal_Pot_Dano_Escoria>();
           T_Sgpal_Pot_Dano_Escoria vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_POT_DANO_ESCORIA.USP_PAG_POT_DANO_ESCORIA", vCnn))
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
                        vEntidad = new T_Sgpal_Pot_Dano_Escoria(vRdr);
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