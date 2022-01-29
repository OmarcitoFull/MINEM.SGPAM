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
    /// Objetivo:	Clase que genera las operaciones para la tabla T_SGPAL_HUNDIMIENTO
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	27/10/2021
    /// </summary>
    public partial class T_Sgpal_HundimientoAD : BaseAD, IT_Sgpal_HundimientoAD
    {
        public T_Sgpal_HundimientoAD(IConfiguration vConfiguration)
        {
            CnnString = vConfiguration.GetSection(Constantes.BD).Value;
        }

        public IEnumerable<T_Sgpal_Hundimiento> ListarT_Sgpal_Hundimiento()
        {
            List<T_Sgpal_Hundimiento> vLista = new List<T_Sgpal_Hundimiento>();
            T_Sgpal_Hundimiento vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_HUNDIMIENTO.USP_LIS_HUNDIMIENTO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpal_Hundimiento(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public T_Sgpal_Hundimiento RecuperarT_Sgpal_HundimientoPorCodigo(int vId_Hundimiento)
        {
            T_Sgpal_Hundimiento vEntidad = null;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_HUNDIMIENTO.USP_SEL_HUNDIMIENTO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_HUNDIMIENTO", vId_Hundimiento);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpal_Hundimiento(vRdr);
                    }
                }
                vCnn.Close();
            }
            return vEntidad;
        }

        public T_Sgpal_Hundimiento InsertarT_Sgpal_Hundimiento(T_Sgpal_Hundimiento vT_Sgpal_Hundimiento)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_HUNDIMIENTO.USP_INS_HUNDIMIENTO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpal_Hundimiento.USU_INGRESO);
                    vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpal_Hundimiento.FLG_ESTADO);
                    vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpal_Hundimiento.FEC_MODIFICA);
                    vCmd.Parameters.Add("pPESO_RM", vT_Sgpal_Hundimiento.PESO_RM);
                    vCmd.Parameters.Add("pPESO_ORM", vT_Sgpal_Hundimiento.PESO_ORM);
                    vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpal_Hundimiento.FEC_INGRESO);
                    vCmd.Parameters.Add("pPESO_PQ", vT_Sgpal_Hundimiento.PESO_PQ);
                    vCmd.Parameters.Add("pPESO_LB", vT_Sgpal_Hundimiento.PESO_LB);
                    vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpal_Hundimiento.IP_MODIFICA);
                    vCmd.Parameters.Add("pDESCRIPCION", vT_Sgpal_Hundimiento.DESCRIPCION);
                    vCmd.Parameters.Add("pID_HUNDIMIENTO", vT_Sgpal_Hundimiento.ID_HUNDIMIENTO);
                    vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpal_Hundimiento.USU_MODIFICA);
                    vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpal_Hundimiento.IP_INGRESO);
                    vCmd.Parameters.Add("pPESO_I", vT_Sgpal_Hundimiento.PESO_I);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpal_Hundimiento;
        }

        public T_Sgpal_Hundimiento ActualizarT_Sgpal_Hundimiento(T_Sgpal_Hundimiento vT_Sgpal_Hundimiento)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_HUNDIMIENTO.USP_UPD_HUNDIMIENTO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpal_Hundimiento.USU_INGRESO);
                    vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpal_Hundimiento.FLG_ESTADO);
                    vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpal_Hundimiento.FEC_MODIFICA);
                    vCmd.Parameters.Add("pPESO_RM", vT_Sgpal_Hundimiento.PESO_RM);
                    vCmd.Parameters.Add("pPESO_ORM", vT_Sgpal_Hundimiento.PESO_ORM);
                    vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpal_Hundimiento.FEC_INGRESO);
                    vCmd.Parameters.Add("pPESO_PQ", vT_Sgpal_Hundimiento.PESO_PQ);
                    vCmd.Parameters.Add("pPESO_LB", vT_Sgpal_Hundimiento.PESO_LB);
                    vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpal_Hundimiento.IP_MODIFICA);
                    vCmd.Parameters.Add("pDESCRIPCION", vT_Sgpal_Hundimiento.DESCRIPCION);
                    vCmd.Parameters.Add("pID_HUNDIMIENTO", vT_Sgpal_Hundimiento.ID_HUNDIMIENTO);
                    vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpal_Hundimiento.USU_MODIFICA);
                    vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpal_Hundimiento.IP_INGRESO);
                    vCmd.Parameters.Add("pPESO_I", vT_Sgpal_Hundimiento.PESO_I);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpal_Hundimiento;
        }

        public int AnularT_Sgpal_HundimientoPorCodigo(int vId_Hundimiento)
        {
            int vResultado = 0;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_HUNDIMIENTO.USP_DEL_HUNDIMIENTO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_HUNDIMIENTO", vId_Hundimiento);
                    vCnn.Open();
                    vResultado = vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vResultado;
        }

        public IEnumerable<T_Sgpal_Hundimiento> ListarPaginadoT_Sgpal_Hundimiento(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            List<T_Sgpal_Hundimiento> vLista = new List<T_Sgpal_Hundimiento>();
            T_Sgpal_Hundimiento vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_HUNDIMIENTO.USP_PAG_HUNDIMIENTO", vCnn))
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
                        vEntidad = new T_Sgpal_Hundimiento(vRdr);
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