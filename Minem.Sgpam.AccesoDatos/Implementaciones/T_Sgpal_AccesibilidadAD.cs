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
    /// Objetivo:	Clase que genera las operaciones para la tabla T_SGPAL_ACCESIBILIDAD
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	27/10/2021
    /// </summary>
    public partial class T_Sgpal_AccesibilidadAD : BaseAD, IT_Sgpal_AccesibilidadAD
    {
        public T_Sgpal_AccesibilidadAD(IConfiguration vConfiguration)
        {
            CnnString = vConfiguration.GetSection(Constantes.BD).Value;
        }

        public IEnumerable<T_Sgpal_Accesibilidad> ListarT_Sgpal_Accesibilidad()
        {
            List<T_Sgpal_Accesibilidad> vLista = new List<T_Sgpal_Accesibilidad>();
            T_Sgpal_Accesibilidad vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_ACCESIBILIDAD.USP_LIS_ACCESIBILIDAD", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpal_Accesibilidad(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public T_Sgpal_Accesibilidad RecuperarT_Sgpal_AccesibilidadPorCodigo(int vId_Accesibilidad)
        {
            T_Sgpal_Accesibilidad vEntidad = null;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_ACCESIBILIDAD.USP_SEL_ACCESIBILIDAD", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_ACCESIBILIDAD", vId_Accesibilidad);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpal_Accesibilidad(vRdr);
                    }
                }
                vCnn.Close();
            }
            return vEntidad;
        }

        public T_Sgpal_Accesibilidad InsertarT_Sgpal_Accesibilidad(T_Sgpal_Accesibilidad vT_Sgpal_Accesibilidad)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_ACCESIBILIDAD.USP_INS_ACCESIBILIDAD", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpal_Accesibilidad.FEC_MODIFICA);
                    vCmd.Parameters.Add("pPESO_ORM", vT_Sgpal_Accesibilidad.PESO_ORM);
                    vCmd.Parameters.Add("pID_ACCESIBILIDAD", vT_Sgpal_Accesibilidad.ID_ACCESIBILIDAD);
                    vCmd.Parameters.Add("pDESCRIPCION", vT_Sgpal_Accesibilidad.DESCRIPCION);
                    vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpal_Accesibilidad.IP_MODIFICA);
                    vCmd.Parameters.Add("pPESO_I", vT_Sgpal_Accesibilidad.PESO_I);
                    vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpal_Accesibilidad.USU_MODIFICA);
                    vCmd.Parameters.Add("pPESO_LB", vT_Sgpal_Accesibilidad.PESO_LB);
                    vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpal_Accesibilidad.FLG_ESTADO);
                    vCmd.Parameters.Add("pPESO_PQ", vT_Sgpal_Accesibilidad.PESO_PQ);
                    vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpal_Accesibilidad.USU_INGRESO);
                    vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpal_Accesibilidad.FEC_INGRESO);
                    vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpal_Accesibilidad.IP_INGRESO);
                    vCmd.Parameters.Add("pPESO_RM", vT_Sgpal_Accesibilidad.PESO_RM);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpal_Accesibilidad;
        }

        public T_Sgpal_Accesibilidad ActualizarT_Sgpal_Accesibilidad(T_Sgpal_Accesibilidad vT_Sgpal_Accesibilidad)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_ACCESIBILIDAD.USP_UPD_ACCESIBILIDAD", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpal_Accesibilidad.FEC_MODIFICA);
                    vCmd.Parameters.Add("pPESO_ORM", vT_Sgpal_Accesibilidad.PESO_ORM);
                    vCmd.Parameters.Add("pID_ACCESIBILIDAD", vT_Sgpal_Accesibilidad.ID_ACCESIBILIDAD);
                    vCmd.Parameters.Add("pDESCRIPCION", vT_Sgpal_Accesibilidad.DESCRIPCION);
                    vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpal_Accesibilidad.IP_MODIFICA);
                    vCmd.Parameters.Add("pPESO_I", vT_Sgpal_Accesibilidad.PESO_I);
                    vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpal_Accesibilidad.USU_MODIFICA);
                    vCmd.Parameters.Add("pPESO_LB", vT_Sgpal_Accesibilidad.PESO_LB);
                    vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpal_Accesibilidad.FLG_ESTADO);
                    vCmd.Parameters.Add("pPESO_PQ", vT_Sgpal_Accesibilidad.PESO_PQ);
                    vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpal_Accesibilidad.USU_INGRESO);
                    vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpal_Accesibilidad.FEC_INGRESO);
                    vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpal_Accesibilidad.IP_INGRESO);
                    vCmd.Parameters.Add("pPESO_RM", vT_Sgpal_Accesibilidad.PESO_RM);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpal_Accesibilidad;
        }

        public int AnularT_Sgpal_AccesibilidadPorCodigo(int vId_Accesibilidad)
        {
            int vResultado = 0;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_ACCESIBILIDAD.USP_DEL_ACCESIBILIDAD", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_ACCESIBILIDAD", vId_Accesibilidad);
                    vCnn.Open();
                    vResultado = vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vResultado;
        }

        public IEnumerable<T_Sgpal_Accesibilidad> ListarPaginadoT_Sgpal_Accesibilidad(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            List<T_Sgpal_Accesibilidad> vLista = new List<T_Sgpal_Accesibilidad>();
            T_Sgpal_Accesibilidad vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_ACCESIBILIDAD.USP_PAG_ACCESIBILIDAD", vCnn))
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
                        vEntidad = new T_Sgpal_Accesibilidad(vRdr);
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