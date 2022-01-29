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
    /// Objetivo:	Clase que genera las operaciones para la tabla T_SGPAL_TAMANO_PARTICULA
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	27/10/2021
    /// </summary>
    public partial class T_Sgpal_Tamano_ParticulaAD : BaseAD, IT_Sgpal_Tamano_ParticulaAD
    {
        public T_Sgpal_Tamano_ParticulaAD(IConfiguration vConfiguration)
        {
            CnnString = vConfiguration.GetSection(Constantes.BD).Value;
        }

        public IEnumerable<T_Sgpal_Tamano_Particula> ListarT_Sgpal_Tamano_Particula()
        {
            List<T_Sgpal_Tamano_Particula> vLista = new List<T_Sgpal_Tamano_Particula>();
            T_Sgpal_Tamano_Particula vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_TAMANO_PARTICULA.USP_LIS_TAMANO_PARTICULA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpal_Tamano_Particula(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public T_Sgpal_Tamano_Particula RecuperarT_Sgpal_Tamano_ParticulaPorCodigo(int vId_Tamano_Particula)
        {
            T_Sgpal_Tamano_Particula vEntidad = null;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_TAMANO_PARTICULA.USP_SEL_TAMANO_PARTICULA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_TAMANO_PARTICULA", vId_Tamano_Particula);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpal_Tamano_Particula(vRdr);
                    }
                }
                vCnn.Close();
            }
            return vEntidad;
        }

        public T_Sgpal_Tamano_Particula InsertarT_Sgpal_Tamano_Particula(T_Sgpal_Tamano_Particula vT_Sgpal_Tamano_Particula)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_TAMANO_PARTICULA.USP_INS_TAMANO_PARTICULA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpal_Tamano_Particula.FEC_INGRESO);
                    vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpal_Tamano_Particula.IP_INGRESO);
                    vCmd.Parameters.Add("pDESCRIPCION", vT_Sgpal_Tamano_Particula.DESCRIPCION);
                    vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpal_Tamano_Particula.USU_MODIFICA);
                    vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpal_Tamano_Particula.IP_MODIFICA);
                    vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpal_Tamano_Particula.USU_INGRESO);
                    vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpal_Tamano_Particula.FLG_ESTADO);
                    vCmd.Parameters.Add("pID_TAMANO_PARTICULA", vT_Sgpal_Tamano_Particula.ID_TAMANO_PARTICULA);
                    vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpal_Tamano_Particula.FEC_MODIFICA);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpal_Tamano_Particula;
        }

        public T_Sgpal_Tamano_Particula ActualizarT_Sgpal_Tamano_Particula(T_Sgpal_Tamano_Particula vT_Sgpal_Tamano_Particula)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_TAMANO_PARTICULA.USP_UPD_TAMANO_PARTICULA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpal_Tamano_Particula.FEC_INGRESO);
                    vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpal_Tamano_Particula.IP_INGRESO);
                    vCmd.Parameters.Add("pDESCRIPCION", vT_Sgpal_Tamano_Particula.DESCRIPCION);
                    vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpal_Tamano_Particula.USU_MODIFICA);
                    vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpal_Tamano_Particula.IP_MODIFICA);
                    vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpal_Tamano_Particula.USU_INGRESO);
                    vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpal_Tamano_Particula.FLG_ESTADO);
                    vCmd.Parameters.Add("pID_TAMANO_PARTICULA", vT_Sgpal_Tamano_Particula.ID_TAMANO_PARTICULA);
                    vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpal_Tamano_Particula.FEC_MODIFICA);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpal_Tamano_Particula;
        }

        public int AnularT_Sgpal_Tamano_ParticulaPorCodigo(int vId_Tamano_Particula)
        {
            int vResultado = 0;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_TAMANO_PARTICULA.USP_DEL_TAMANO_PARTICULA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_TAMANO_PARTICULA", vId_Tamano_Particula);
                    vCnn.Open();
                    vResultado = vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vResultado;
        }

        public IEnumerable<T_Sgpal_Tamano_Particula> ListarPaginadoT_Sgpal_Tamano_Particula(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            List<T_Sgpal_Tamano_Particula> vLista = new List<T_Sgpal_Tamano_Particula>();
            T_Sgpal_Tamano_Particula vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_TAMANO_PARTICULA.USP_PAG_TAMANO_PARTICULA", vCnn))
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
                        vEntidad = new T_Sgpal_Tamano_Particula(vRdr);
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