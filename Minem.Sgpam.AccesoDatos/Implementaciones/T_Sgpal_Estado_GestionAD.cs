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
    /// Objetivo:	Clase que genera las operaciones para la tabla T_SGPAL_ESTADO_GESTION
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	27/10/2021
    /// </summary>
    public partial class T_Sgpal_Estado_GestionAD : BaseAD, IT_Sgpal_Estado_GestionAD
    {
        public T_Sgpal_Estado_GestionAD(IConfiguration vConfiguration)
        {
            CnnString = vConfiguration.GetSection(Constantes.BD).Value;
        }

        public IEnumerable<T_Sgpal_Estado_Gestion> ListarT_Sgpal_Estado_Gestion()
        {
            List<T_Sgpal_Estado_Gestion> vLista = new List<T_Sgpal_Estado_Gestion>();
            T_Sgpal_Estado_Gestion vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_ESTADO_GESTION.USP_LIS_ESTADO_GESTION", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpal_Estado_Gestion(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public T_Sgpal_Estado_Gestion RecuperarT_Sgpal_Estado_GestionPorCodigo(int vId_Estado_Gestion)
        {
            T_Sgpal_Estado_Gestion vEntidad = null;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_ESTADO_GESTION.USP_SEL_ESTADO_GESTION", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_ESTADO_GESTION", vId_Estado_Gestion);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpal_Estado_Gestion(vRdr);
                    }
                }
                vCnn.Close();
            }
            return vEntidad;
        }

        public T_Sgpal_Estado_Gestion InsertarT_Sgpal_Estado_Gestion(T_Sgpal_Estado_Gestion vT_Sgpal_Estado_Gestion)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_ESTADO_GESTION.USP_INS_ESTADO_GESTION", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpal_Estado_Gestion.IP_MODIFICA);
                    vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpal_Estado_Gestion.IP_INGRESO);
                    vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpal_Estado_Gestion.FLG_ESTADO);
                    vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpal_Estado_Gestion.USU_INGRESO);
                    vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpal_Estado_Gestion.FEC_MODIFICA);
                    vCmd.Parameters.Add("pDESCRIPCION", vT_Sgpal_Estado_Gestion.DESCRIPCION);
                    vCmd.Parameters.Add("pID_ESTADO_GESTION", vT_Sgpal_Estado_Gestion.ID_ESTADO_GESTION);
                    vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpal_Estado_Gestion.USU_MODIFICA);
                    vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpal_Estado_Gestion.FEC_INGRESO);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpal_Estado_Gestion;
        }

        public T_Sgpal_Estado_Gestion ActualizarT_Sgpal_Estado_Gestion(T_Sgpal_Estado_Gestion vT_Sgpal_Estado_Gestion)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_ESTADO_GESTION.USP_UPD_ESTADO_GESTION", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpal_Estado_Gestion.IP_MODIFICA);
                    vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpal_Estado_Gestion.IP_INGRESO);
                    vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpal_Estado_Gestion.FLG_ESTADO);
                    vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpal_Estado_Gestion.USU_INGRESO);
                    vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpal_Estado_Gestion.FEC_MODIFICA);
                    vCmd.Parameters.Add("pDESCRIPCION", vT_Sgpal_Estado_Gestion.DESCRIPCION);
                    vCmd.Parameters.Add("pID_ESTADO_GESTION", vT_Sgpal_Estado_Gestion.ID_ESTADO_GESTION);
                    vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpal_Estado_Gestion.USU_MODIFICA);
                    vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpal_Estado_Gestion.FEC_INGRESO);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpal_Estado_Gestion;
        }

        public int AnularT_Sgpal_Estado_GestionPorCodigo(int vId_Estado_Gestion)
        {
            int vResultado = 0;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_ESTADO_GESTION.USP_DEL_ESTADO_GESTION", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_ESTADO_GESTION", vId_Estado_Gestion);
                    vCnn.Open();
                    vResultado = vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vResultado;
        }

        public IEnumerable<T_Sgpal_Estado_Gestion> ListarPaginadoT_Sgpal_Estado_Gestion(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            List<T_Sgpal_Estado_Gestion> vLista = new List<T_Sgpal_Estado_Gestion>();
            T_Sgpal_Estado_Gestion vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_ESTADO_GESTION.USP_PAG_ESTADO_GESTION", vCnn))
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
                        vEntidad = new T_Sgpal_Estado_Gestion(vRdr);
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