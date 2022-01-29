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
    /// Objetivo:	Clase que genera las operaciones para la tabla T_SGPAL_PRESENCIA_ELEMENTO
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	27/10/2021
    /// </summary>
    public partial class T_Sgpal_Presencia_ElementoAD : BaseAD, IT_Sgpal_Presencia_ElementoAD
    {
        public T_Sgpal_Presencia_ElementoAD(IConfiguration vConfiguration)
        {
            CnnString = vConfiguration.GetSection(Constantes.BD).Value;
        }

        public IEnumerable<T_Sgpal_Presencia_Elemento> ListarT_Sgpal_Presencia_Elemento()
        {
            List<T_Sgpal_Presencia_Elemento> vLista = new List<T_Sgpal_Presencia_Elemento>();
            T_Sgpal_Presencia_Elemento vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_PRESENCIA_ELEMENTO.USP_LIS_PRESENCIA_ELEMENTO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpal_Presencia_Elemento(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public T_Sgpal_Presencia_Elemento RecuperarT_Sgpal_Presencia_ElementoPorCodigo(int vId_Presencia_Elemento)
        {
            T_Sgpal_Presencia_Elemento vEntidad = null;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_PRESENCIA_ELEMENTO.USP_SEL_PRESENCIA_ELEMENTO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_PRESENCIA_ELEMENTO", vId_Presencia_Elemento);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpal_Presencia_Elemento(vRdr);
                    }
                }
                vCnn.Close();
            }
            return vEntidad;
        }

        public T_Sgpal_Presencia_Elemento InsertarT_Sgpal_Presencia_Elemento(T_Sgpal_Presencia_Elemento vT_Sgpal_Presencia_Elemento)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_PRESENCIA_ELEMENTO.USP_INS_PRESENCIA_ELEMENTO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpal_Presencia_Elemento.FEC_MODIFICA);
                    vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpal_Presencia_Elemento.USU_INGRESO);
                    vCmd.Parameters.Add("pPESO_RM", vT_Sgpal_Presencia_Elemento.PESO_RM);
                    vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpal_Presencia_Elemento.FLG_ESTADO);
                    vCmd.Parameters.Add("pID_PRESENCIA_ELEMENTO", vT_Sgpal_Presencia_Elemento.ID_PRESENCIA_ELEMENTO);
                    vCmd.Parameters.Add("pPESO_PQ", vT_Sgpal_Presencia_Elemento.PESO_PQ);
                    vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpal_Presencia_Elemento.FEC_INGRESO);
                    vCmd.Parameters.Add("pDESCRIPCION", vT_Sgpal_Presencia_Elemento.DESCRIPCION);
                    vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpal_Presencia_Elemento.IP_INGRESO);
                    vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpal_Presencia_Elemento.IP_MODIFICA);
                    vCmd.Parameters.Add("pPESO_ORM", vT_Sgpal_Presencia_Elemento.PESO_ORM);
                    vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpal_Presencia_Elemento.USU_MODIFICA);
                    vCmd.Parameters.Add("pPESO_LB", vT_Sgpal_Presencia_Elemento.PESO_LB);
                    vCmd.Parameters.Add("pPESO_I", vT_Sgpal_Presencia_Elemento.PESO_I);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpal_Presencia_Elemento;
        }

        public T_Sgpal_Presencia_Elemento ActualizarT_Sgpal_Presencia_Elemento(T_Sgpal_Presencia_Elemento vT_Sgpal_Presencia_Elemento)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_PRESENCIA_ELEMENTO.USP_UPD_PRESENCIA_ELEMENTO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpal_Presencia_Elemento.FEC_MODIFICA);
                    vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpal_Presencia_Elemento.USU_INGRESO);
                    vCmd.Parameters.Add("pPESO_RM", vT_Sgpal_Presencia_Elemento.PESO_RM);
                    vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpal_Presencia_Elemento.FLG_ESTADO);
                    vCmd.Parameters.Add("pID_PRESENCIA_ELEMENTO", vT_Sgpal_Presencia_Elemento.ID_PRESENCIA_ELEMENTO);
                    vCmd.Parameters.Add("pPESO_PQ", vT_Sgpal_Presencia_Elemento.PESO_PQ);
                    vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpal_Presencia_Elemento.FEC_INGRESO);
                    vCmd.Parameters.Add("pDESCRIPCION", vT_Sgpal_Presencia_Elemento.DESCRIPCION);
                    vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpal_Presencia_Elemento.IP_INGRESO);
                    vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpal_Presencia_Elemento.IP_MODIFICA);
                    vCmd.Parameters.Add("pPESO_ORM", vT_Sgpal_Presencia_Elemento.PESO_ORM);
                    vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpal_Presencia_Elemento.USU_MODIFICA);
                    vCmd.Parameters.Add("pPESO_LB", vT_Sgpal_Presencia_Elemento.PESO_LB);
                    vCmd.Parameters.Add("pPESO_I", vT_Sgpal_Presencia_Elemento.PESO_I);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpal_Presencia_Elemento;
        }

        public int AnularT_Sgpal_Presencia_ElementoPorCodigo(int vId_Presencia_Elemento)
        {
            int vResultado = 0;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_PRESENCIA_ELEMENTO.USP_DEL_PRESENCIA_ELEMENTO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_PRESENCIA_ELEMENTO", vId_Presencia_Elemento);
                    vCnn.Open();
                    vResultado = vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vResultado;
        }

        public IEnumerable<T_Sgpal_Presencia_Elemento> ListarPaginadoT_Sgpal_Presencia_Elemento(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            List<T_Sgpal_Presencia_Elemento> vLista = new List<T_Sgpal_Presencia_Elemento>();
            T_Sgpal_Presencia_Elemento vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_PRESENCIA_ELEMENTO.USP_PAG_PRESENCIA_ELEMENTO", vCnn))
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
                        vEntidad = new T_Sgpal_Presencia_Elemento(vRdr);
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