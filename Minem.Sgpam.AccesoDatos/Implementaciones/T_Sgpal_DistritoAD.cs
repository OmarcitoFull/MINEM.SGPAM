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
    /// Objetivo:	Clase que genera las operaciones para la tabla T_SGPAL_DISTRITO
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	27/10/2021
    /// </summary>
    public partial class T_Sgpal_DistritoAD : BaseAD, IT_Sgpal_DistritoAD
    {
        public T_Sgpal_DistritoAD(IConfiguration vConfiguration)
        {
            CnnString = vConfiguration.GetSection(Constantes.BD).Value;
        }

        public IEnumerable<T_Sgpal_Distrito> ListarT_Sgpal_Distrito()
        {
            List<T_Sgpal_Distrito> vLista = new List<T_Sgpal_Distrito>();
            T_Sgpal_Distrito vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_DISTRITO.USP_LIS_DISTRITO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpal_Distrito(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public T_Sgpal_Distrito RecuperarT_Sgpal_DistritoPorCodigo(int vId_Distrito)
        {
            T_Sgpal_Distrito vEntidad = null;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_DISTRITO.USP_SEL_DISTRITO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_DISTRITO", vId_Distrito);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpal_Distrito(vRdr);
                    }
                }
                vCnn.Close();
            }
            return vEntidad;
        }

        public T_Sgpal_Distrito InsertarT_Sgpal_Distrito(T_Sgpal_Distrito vT_Sgpal_Distrito)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_DISTRITO.USP_INS_DISTRITO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_DISTRITO", vT_Sgpal_Distrito.ID_DISTRITO);
                    vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpal_Distrito.IP_MODIFICA);
                    vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpal_Distrito.FEC_MODIFICA);
                    vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpal_Distrito.USU_MODIFICA);
                    vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpal_Distrito.USU_INGRESO);
                    vCmd.Parameters.Add("pCOD_REFERENCIAL", vT_Sgpal_Distrito.COD_REFERENCIAL);
                    vCmd.Parameters.Add("pDESCRIPCION", vT_Sgpal_Distrito.DESCRIPCION);
                    vCmd.Parameters.Add("pID_PROVINCIA", vT_Sgpal_Distrito.ID_PROVINCIA);
                    vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpal_Distrito.IP_INGRESO);
                    vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpal_Distrito.FEC_INGRESO);
                    vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpal_Distrito.FLG_ESTADO);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpal_Distrito;
        }

        public T_Sgpal_Distrito ActualizarT_Sgpal_Distrito(T_Sgpal_Distrito vT_Sgpal_Distrito)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_DISTRITO.USP_UPD_DISTRITO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_DISTRITO", vT_Sgpal_Distrito.ID_DISTRITO);
                    vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpal_Distrito.IP_MODIFICA);
                    vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpal_Distrito.FEC_MODIFICA);
                    vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpal_Distrito.USU_MODIFICA);
                    vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpal_Distrito.USU_INGRESO);
                    vCmd.Parameters.Add("pCOD_REFERENCIAL", vT_Sgpal_Distrito.COD_REFERENCIAL);
                    vCmd.Parameters.Add("pDESCRIPCION", vT_Sgpal_Distrito.DESCRIPCION);
                    vCmd.Parameters.Add("pID_PROVINCIA", vT_Sgpal_Distrito.ID_PROVINCIA);
                    vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpal_Distrito.IP_INGRESO);
                    vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpal_Distrito.FEC_INGRESO);
                    vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpal_Distrito.FLG_ESTADO);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpal_Distrito;
        }

        public int AnularT_Sgpal_DistritoPorCodigo(int vId_Distrito)
        {
            int vResultado = 0;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_DISTRITO.USP_DEL_DISTRITO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_DISTRITO", vId_Distrito);
                    vCnn.Open();
                    vResultado = vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vResultado;
        }

        public IEnumerable<T_Sgpal_Distrito> ListarPaginadoT_Sgpal_Distrito(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            List<T_Sgpal_Distrito> vLista = new List<T_Sgpal_Distrito>();
            T_Sgpal_Distrito vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_DISTRITO.USP_PAG_DISTRITO", vCnn))
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
                        vEntidad = new T_Sgpal_Distrito(vRdr);
                        vEntidad.TotalVirtual = System.Convert.ToInt32(vRdr["TotalVirtual"]);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public IEnumerable<Ubigeo> ListarT_Ubigeo()
        {
            List<Ubigeo> vLista = new List<Ubigeo>();
            Ubigeo vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_DISTRITO.USP_LIS_UBIGEO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new Ubigeo(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }
    }
}