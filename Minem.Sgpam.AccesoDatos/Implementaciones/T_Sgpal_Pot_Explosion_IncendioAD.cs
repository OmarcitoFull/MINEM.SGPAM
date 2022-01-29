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
    /// Objetivo:	Clase que genera las operaciones para la tabla T_SGPAL_POT_EXPLOSION_INCENDIO
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	27/10/2021
    /// </summary>
    public partial class T_Sgpal_Pot_Explosion_IncendioAD: BaseAD, IT_Sgpal_Pot_Explosion_IncendioAD
    {   
        public IEnumerable<T_Sgpal_Pot_Explosion_Incendio> ListarT_Sgpal_Pot_Explosion_Incendio()
        {
           List<T_Sgpal_Pot_Explosion_Incendio> vLista = new List<T_Sgpal_Pot_Explosion_Incendio>();
           T_Sgpal_Pot_Explosion_Incendio vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_POT_EXPLOSION_INCENDIO.USP_LIS_POT_EXPLOSION_INCENDIO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpal_Pot_Explosion_Incendio(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public T_Sgpal_Pot_Explosion_Incendio RecuperarT_Sgpal_Pot_Explosion_IncendioPorCodigo()
        {
           T_Sgpal_Pot_Explosion_Incendio vEntidad = null;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_POT_EXPLOSION_INCENDIO.USP_SEL_POT_EXPLOSION_INCENDIO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpal_Pot_Explosion_Incendio(vRdr);
                    }
                }
                vCnn.Close();
            }
            return vEntidad;
        }

        public T_Sgpal_Pot_Explosion_Incendio InsertarT_Sgpal_Pot_Explosion_Incendio(T_Sgpal_Pot_Explosion_Incendio vT_Sgpal_Pot_Explosion_Incendio)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_POT_EXPLOSION_INCENDIO.USP_INS_POT_EXPLOSION_INCENDIO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpal_Pot_Explosion_Incendio.USU_INGRESO); 				vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpal_Pot_Explosion_Incendio.FEC_INGRESO); 				vCmd.Parameters.Add("pDESCRIPCION", vT_Sgpal_Pot_Explosion_Incendio.DESCRIPCION); 				vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpal_Pot_Explosion_Incendio.IP_INGRESO); 				vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpal_Pot_Explosion_Incendio.USU_MODIFICA); 				vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpal_Pot_Explosion_Incendio.IP_MODIFICA); 				vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpal_Pot_Explosion_Incendio.FEC_MODIFICA); 				vCmd.Parameters.Add("pID_POT_EXPLOSION_INCENDIO", vT_Sgpal_Pot_Explosion_Incendio.ID_POT_EXPLOSION_INCENDIO); 				vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpal_Pot_Explosion_Incendio.FLG_ESTADO);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpal_Pot_Explosion_Incendio;
        }
        
        public T_Sgpal_Pot_Explosion_Incendio ActualizarT_Sgpal_Pot_Explosion_Incendio(T_Sgpal_Pot_Explosion_Incendio vT_Sgpal_Pot_Explosion_Incendio)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_POT_EXPLOSION_INCENDIO.USP_UPD_POT_EXPLOSION_INCENDIO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpal_Pot_Explosion_Incendio.USU_INGRESO); 				vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpal_Pot_Explosion_Incendio.FEC_INGRESO); 				vCmd.Parameters.Add("pDESCRIPCION", vT_Sgpal_Pot_Explosion_Incendio.DESCRIPCION); 				vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpal_Pot_Explosion_Incendio.IP_INGRESO); 				vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpal_Pot_Explosion_Incendio.USU_MODIFICA); 				vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpal_Pot_Explosion_Incendio.IP_MODIFICA); 				vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpal_Pot_Explosion_Incendio.FEC_MODIFICA); 				vCmd.Parameters.Add("pID_POT_EXPLOSION_INCENDIO", vT_Sgpal_Pot_Explosion_Incendio.ID_POT_EXPLOSION_INCENDIO); 				vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpal_Pot_Explosion_Incendio.FLG_ESTADO);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpal_Pot_Explosion_Incendio;
        }

        public int AnularT_Sgpal_Pot_Explosion_IncendioPorCodigo()
        {
            int vResultado = 0;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_POT_EXPLOSION_INCENDIO.USP_DEL_POT_EXPLOSION_INCENDIO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    
                    vCnn.Open();
                    vResultado = vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vResultado;
        }

        public IEnumerable<T_Sgpal_Pot_Explosion_Incendio> ListarPaginadoT_Sgpal_Pot_Explosion_Incendio(string vFiltro, int vNumPag, int vCantRegxPag)
        {
           List<T_Sgpal_Pot_Explosion_Incendio> vLista = new List<T_Sgpal_Pot_Explosion_Incendio>();
           T_Sgpal_Pot_Explosion_Incendio vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_POT_EXPLOSION_INCENDIO.USP_PAG_POT_EXPLOSION_INCENDIO", vCnn))
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
                        vEntidad = new T_Sgpal_Pot_Explosion_Incendio(vRdr);
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