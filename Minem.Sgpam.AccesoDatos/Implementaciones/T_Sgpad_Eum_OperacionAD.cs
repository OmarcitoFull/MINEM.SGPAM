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
    public partial class T_Sgpad_Eum_OperacionAD : BaseAD, IT_Sgpad_Eum_OperacionAD
    {
        public T_Sgpad_Eum_OperacionAD(IConfiguration vConfiguration)
        {
            CnnString = vConfiguration.GetSection(Constantes.BD).Value;
        }

        public IEnumerable<T_Sgpad_Eum_Operacion> ListarT_Sgpad_Eum_Operacion()
        {
            List<T_Sgpad_Eum_Operacion> vLista = new List<T_Sgpad_Eum_Operacion>();
            T_Sgpad_Eum_Operacion vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_EUM_OPERACION.USP_LIS_EUM_OPERACION", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpad_Eum_Operacion(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public T_Sgpad_Eum_Operacion RecuperarT_Sgpad_Eum_OperacionPorCodigo(int vId_Eum_Operacion)
        {
            T_Sgpad_Eum_Operacion vEntidad = null;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_EUM_OPERACION.USP_SEL_EUM_OPERACION", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_EUM_OPERACION", vId_Eum_Operacion);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpad_Eum_Operacion(vRdr);
                    }
                }
                vCnn.Close();
            }
            return vEntidad;
        }

        public T_Sgpad_Eum_Operacion InsertarT_Sgpad_Eum_Operacion(T_Sgpad_Eum_Operacion vT_Sgpad_Eum_Operacion)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_EUM_OPERACION.USP_INS_EUM_OPERACION", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    //vCmd.Parameters.Add("pID_EUM_OPERACION", vT_Sgpad_Eum_Operacion.ID_EUM_OPERACION); 
                    vCmd.Parameters.Add("pID_EUM", vT_Sgpad_Eum_Operacion.ID_EUM);
                    vCmd.Parameters.Add("pID_TIPO_OPERACION", vT_Sgpad_Eum_Operacion.ID_TIPO_OPERACION);
                    vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpad_Eum_Operacion.USU_INGRESO);
                    //vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpad_Eum_Operacion.FEC_INGRESO);
                    vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpad_Eum_Operacion.IP_INGRESO);
                    vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpad_Eum_Operacion.FLG_ESTADO);
                    vCmd.Parameters.Add(":pID_EUM_OPERACION", OracleDbType.Int64).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vT_Sgpad_Eum_Operacion.ID_EUM_OPERACION = Convert.ToInt32(vCmd.Parameters[":pID_EUM_OPERACION"].Value.ToString());
                    vCnn.Close();
                }
            }
            return vT_Sgpad_Eum_Operacion;
        }

        public T_Sgpad_Eum_Operacion ActualizarT_Sgpad_Eum_Operacion(T_Sgpad_Eum_Operacion vT_Sgpad_Eum_Operacion)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_EUM_OPERACION.USP_UPD_EUM_OPERACION", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_EUM_OPERACION", vT_Sgpad_Eum_Operacion.ID_EUM_OPERACION); 
                    vCmd.Parameters.Add("pID_TIPO_OPERACION", vT_Sgpad_Eum_Operacion.ID_TIPO_OPERACION);
                    vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpad_Eum_Operacion.USU_MODIFICA);
                    //vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpad_Eum_Operacion.FEC_MODIFICA);
                    vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpad_Eum_Operacion.IP_MODIFICA);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpad_Eum_Operacion;
        }

        public int AnularT_Sgpad_Eum_OperacionPorCodigo(int vId_Eum_Operacion)
        {
            int vResultado = 0;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_EUM_OPERACION.USP_DEL_EUM_OPERACION", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_EUM_OPERACION", vId_Eum_Operacion);
                    vCnn.Open();
                    vResultado = vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vResultado;
        }

        public IEnumerable<T_Sgpad_Eum_Operacion> ListarPaginadoT_Sgpad_Eum_Operacion(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            List<T_Sgpad_Eum_Operacion> vLista = new List<T_Sgpad_Eum_Operacion>();
            T_Sgpad_Eum_Operacion vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_EUM_OPERACION.USP_PAG_EUM_OPERACION", vCnn))
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
                        vEntidad = new T_Sgpad_Eum_Operacion(vRdr);
                        //vEntidad.TotalVirtual = System.Convert.ToInt32(vRdr["TotalVirtual"]);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public IEnumerable<T_Sgpad_Eum_Operacion> ListarPorIdEumT_Sgpad_Eum_Operacion(int vId_Eum)
        {
            List<T_Sgpad_Eum_Operacion> vLista = new List<T_Sgpad_Eum_Operacion>();
            T_Sgpad_Eum_Operacion vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_EUM_OPERACION.USP_LIS_POR_IDEUM_EUM_OPERACION", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_EUM", vId_Eum);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();

                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpad_Eum_Operacion(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

    }
}
