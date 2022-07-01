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
    /// Objetivo:	Clase que genera las operaciones para la tabla T_SGPAD_EUM_INSPECCION
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	27/10/2021
    /// </summary>
    public partial class T_Sgpad_Eum_InspeccionAD : BaseAD, IT_Sgpad_Eum_InspeccionAD
    {
        public T_Sgpad_Eum_InspeccionAD(IConfiguration vConfiguration)
        {
            CnnString = vConfiguration.GetSection(Constantes.BD).Value;
        }

        public IEnumerable<T_Sgpad_Eum_Inspeccion> ListarT_Sgpad_Eum_Inspeccion()
        {
            List<T_Sgpad_Eum_Inspeccion> vLista = new List<T_Sgpad_Eum_Inspeccion>();
            T_Sgpad_Eum_Inspeccion vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_EUM_INSPECCION.USP_LIS_EUM_INSPECCION", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpad_Eum_Inspeccion(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public T_Sgpad_Eum_Inspeccion RecuperarT_Sgpad_Eum_InspeccionPorCodigo(int vId_Eum_Inspeccion)
        {
            T_Sgpad_Eum_Inspeccion vEntidad = null;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_EUM_INSPECCION.USP_SEL_EUM_INSPECCION", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_EUM_INSPECCION", vId_Eum_Inspeccion);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpad_Eum_Inspeccion(vRdr);
                    }
                }
                vCnn.Close();
            }
            return vEntidad;
        }

        public T_Sgpad_Eum_Inspeccion InsertarT_Sgpad_Eum_Inspeccion(T_Sgpad_Eum_Inspeccion vT_Sgpad_Eum_Inspeccion)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_EUM_INSPECCION.USP_INS_EUM_INSPECCION", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_EUM", vT_Sgpad_Eum_Inspeccion.ID_EUM);
                    vCmd.Parameters.Add("pID_INSPECTOR", vT_Sgpad_Eum_Inspeccion.ID_INSPECTOR);
                    vCmd.Parameters.Add("pFECHA_INSPECCION", vT_Sgpad_Eum_Inspeccion.FECHA_INSPECCION);
                    vCmd.Parameters.Add("pDESCRIPCION_CLIMA", vT_Sgpad_Eum_Inspeccion.DESCRIPCION_CLIMA);
                    //vCmd.Parameters.Add("pID_TIPO_CLIMA", vT_Sgpad_Eum_Inspeccion.ID_TIPO_CLIMA); 
                    vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpad_Eum_Inspeccion.USU_INGRESO);
                    vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpad_Eum_Inspeccion.FEC_INGRESO);
                    vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpad_Eum_Inspeccion.IP_INGRESO);
                    vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpad_Eum_Inspeccion.FLG_ESTADO);
                    vCmd.Parameters.Add(":pID_EUM_INSPECCION", OracleDbType.Int64).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vT_Sgpad_Eum_Inspeccion.ID_EUM_INSPECCION = Convert.ToInt32(vCmd.Parameters[":pID_EUM_INSPECCION"].Value.ToString());
                    vCnn.Close();
                }
            }
            return vT_Sgpad_Eum_Inspeccion;
        }

        public T_Sgpad_Eum_Inspeccion ActualizarT_Sgpad_Eum_Inspeccion(T_Sgpad_Eum_Inspeccion vT_Sgpad_Eum_Inspeccion)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_EUM_INSPECCION.USP_UPD_EUM_INSPECCION", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_EUM_INSPECCION", vT_Sgpad_Eum_Inspeccion.ID_EUM_INSPECCION);
                    vCmd.Parameters.Add("pID_INSPECTOR", vT_Sgpad_Eum_Inspeccion.ID_INSPECTOR);
                    vCmd.Parameters.Add("pFECHA_INSPECCION", vT_Sgpad_Eum_Inspeccion.FECHA_INSPECCION);
                    vCmd.Parameters.Add("pDESCRIPCION_CLIMA", vT_Sgpad_Eum_Inspeccion.DESCRIPCION_CLIMA);
                    //vCmd.Parameters.Add("pID_TIPO_CLIMA", vT_Sgpad_Eum_Inspeccion.ID_TIPO_CLIMA);
                    vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpad_Eum_Inspeccion.USU_MODIFICA);
                    vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpad_Eum_Inspeccion.FEC_MODIFICA);
                    vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpad_Eum_Inspeccion.IP_MODIFICA);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpad_Eum_Inspeccion;
        }

        public int AnularT_Sgpad_Eum_InspeccionPorCodigo(T_Sgpad_Eum_Inspeccion vT_Sgpad_Eum_Inspeccion)
        {
            int vResultado = 0;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_EUM_INSPECCION.USP_DEL_EUM_INSPECCION", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_EUM_INSPECCION", vT_Sgpad_Eum_Inspeccion.ID_EUM_INSPECCION);
                    vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpad_Eum_Inspeccion.USU_MODIFICA);
                    vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpad_Eum_Inspeccion.IP_MODIFICA);
                    vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpad_Eum_Inspeccion.FEC_MODIFICA);
                    vCnn.Open();
                    vResultado = vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vResultado;
        }

        public IEnumerable<T_Sgpad_Eum_Inspeccion> ListarPaginadoT_Sgpad_Eum_Inspeccion(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            List<T_Sgpad_Eum_Inspeccion> vLista = new List<T_Sgpad_Eum_Inspeccion>();
            T_Sgpad_Eum_Inspeccion vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_EUM_INSPECCION.USP_PAG_EUM_INSPECCION", vCnn))
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
                        vEntidad = new T_Sgpad_Eum_Inspeccion(vRdr);
                        //vEntidad.TotalVirtual = System.Convert.ToInt32(vRdr["TotalVirtual"]);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public IEnumerable<T_Sgpad_Eum_Inspeccion> ListarPorIdEumT_Sgpad_Eum_Inspeccion(int vId_Eum)
        {
            List<T_Sgpad_Eum_Inspeccion> vLista = new List<T_Sgpad_Eum_Inspeccion>();
            T_Sgpad_Eum_Inspeccion vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_EUM_INSPECCION.USP_LIS_POR_IDEUM_EUM_INSPECCION", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_EUM", vId_Eum);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();

                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpad_Eum_Inspeccion(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

    }
}