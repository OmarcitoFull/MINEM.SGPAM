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
    /// Objetivo:	Clase que genera las operaciones para la tabla T_SGPAL_TIPO_OPERACION
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	27/10/2021
    /// </summary>
    public partial class T_Sgpal_Tipo_OperacionAD : BaseAD, IT_Sgpal_Tipo_OperacionAD
    {
        public T_Sgpal_Tipo_OperacionAD(IConfiguration vConfiguration)
        {
            CnnString = vConfiguration.GetSection(Constantes.BD).Value;
        }

        public IEnumerable<T_Sgpal_Tipo_Operacion> ListarT_Sgpal_Tipo_Operacion()
        {
            List<T_Sgpal_Tipo_Operacion> vLista = new List<T_Sgpal_Tipo_Operacion>();
            T_Sgpal_Tipo_Operacion vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_TIPO_OPERACION.USP_LIS_TIPO_OPERACION", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpal_Tipo_Operacion(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public T_Sgpal_Tipo_Operacion RecuperarT_Sgpal_Tipo_OperacionPorCodigo(int vId_Tipo_Operacion)
        {
            T_Sgpal_Tipo_Operacion vEntidad = null;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_TIPO_OPERACION.USP_SEL_TIPO_OPERACION", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_TIPO_OPERACION", vId_Tipo_Operacion);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpal_Tipo_Operacion(vRdr);
                    }
                }
                vCnn.Close();
            }
            return vEntidad;
        }

        public T_Sgpal_Tipo_Operacion InsertarT_Sgpal_Tipo_Operacion(T_Sgpal_Tipo_Operacion vT_Sgpal_Tipo_Operacion)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_TIPO_OPERACION.USP_INS_TIPO_OPERACION", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpal_Tipo_Operacion.IP_INGRESO);
                    vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpal_Tipo_Operacion.USU_MODIFICA);
                    vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpal_Tipo_Operacion.FEC_INGRESO);
                    vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpal_Tipo_Operacion.FEC_MODIFICA);
                    vCmd.Parameters.Add("pDESCRIPCION", vT_Sgpal_Tipo_Operacion.DESCRIPCION);
                    vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpal_Tipo_Operacion.FLG_ESTADO);
                    vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpal_Tipo_Operacion.USU_INGRESO);
                    vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpal_Tipo_Operacion.IP_MODIFICA);
                    vCmd.Parameters.Add(":pID_TIPO_OPERACION", OracleDbType.Int64).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vT_Sgpal_Tipo_Operacion.ID_TIPO_OPERACION = Convert.ToInt32(vCmd.Parameters[":pID_TIPO_OPERACION"].Value.ToString());
                    vCnn.Close();
                }
            }
            return vT_Sgpal_Tipo_Operacion;
        }

        public T_Sgpal_Tipo_Operacion ActualizarT_Sgpal_Tipo_Operacion(T_Sgpal_Tipo_Operacion vT_Sgpal_Tipo_Operacion)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_TIPO_OPERACION.USP_UPD_TIPO_OPERACION", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpal_Tipo_Operacion.USU_MODIFICA);
                    vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpal_Tipo_Operacion.FEC_MODIFICA);
                    vCmd.Parameters.Add("pID_TIPO_OPERACION", vT_Sgpal_Tipo_Operacion.ID_TIPO_OPERACION);
                    vCmd.Parameters.Add("pDESCRIPCION", vT_Sgpal_Tipo_Operacion.DESCRIPCION);
                    vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpal_Tipo_Operacion.FLG_ESTADO);
                    vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpal_Tipo_Operacion.IP_MODIFICA);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpal_Tipo_Operacion;
        }

        public int AnularT_Sgpal_Tipo_OperacionPorCodigo(T_Sgpal_Tipo_Operacion vT_Sgpal_Tipo_Operacion)
        {
            int vResultado = 0;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_TIPO_OPERACION.USP_DEL_TIPO_OPERACION", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_TIPO_OPERACION", vT_Sgpal_Tipo_Operacion.ID_TIPO_OPERACION);
                    vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpal_Tipo_Operacion.USU_MODIFICA);
                    vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpal_Tipo_Operacion.FEC_MODIFICA);
                    vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpal_Tipo_Operacion.IP_MODIFICA);
                    vCnn.Open();
                    vResultado = vCmd.ExecuteNonQuery();
                    vCnn.Close();
                    vResultado = (vResultado == -1) ? vResultado * -1 : vResultado;
                }
            }
            return vResultado;
        }

        public IEnumerable<T_Sgpal_Tipo_Operacion> ListarPaginadoT_Sgpal_Tipo_Operacion(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            List<T_Sgpal_Tipo_Operacion> vLista = new List<T_Sgpal_Tipo_Operacion>();
            T_Sgpal_Tipo_Operacion vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_TIPO_OPERACION.USP_PAG_TIPO_OPERACION", vCnn))
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
                        vEntidad = new T_Sgpal_Tipo_Operacion(vRdr);
                        vEntidad.TotalVirtual = System.Convert.ToInt32(vRdr["TotalVirtual"]);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public IEnumerable<T_Sgpal_Tipo_Operacion> ListarSinIdEumT_Sgpal_Tipo_Operacion(int vIdEum)
        {
            List<T_Sgpal_Tipo_Operacion> vLista = new List<T_Sgpal_Tipo_Operacion>();
            T_Sgpal_Tipo_Operacion vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_TIPO_OPERACION.USP_LIS_SIN_IDEUM_TIPO_OPERACION", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_EUM", vIdEum);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpal_Tipo_Operacion(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }
    }
}