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
    /// Objetivo:	Clase que genera las operaciones para la tabla T_SGPAL_CERCA_AREA_PROTEGIDA
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	27/10/2021
    /// </summary>
    public partial class T_Sgpal_Cerca_Area_ProtegidaAD : BaseAD, IT_Sgpal_Cerca_Area_ProtegidaAD
    {
        public T_Sgpal_Cerca_Area_ProtegidaAD(IConfiguration vConfiguration)
        {
            CnnString = vConfiguration.GetSection(Constantes.BD).Value;
        }

        public IEnumerable<T_Sgpal_Cerca_Area_Protegida> ListarT_Sgpal_Cerca_Area_Protegida()
        {
            List<T_Sgpal_Cerca_Area_Protegida> vLista = new List<T_Sgpal_Cerca_Area_Protegida>();
            T_Sgpal_Cerca_Area_Protegida vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_CERCA_AREA_PROTEGIDA.USP_LIS_CERCA_AREA_PROTEGIDA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpal_Cerca_Area_Protegida(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public T_Sgpal_Cerca_Area_Protegida RecuperarT_Sgpal_Cerca_Area_ProtegidaPorCodigo(int vId_Cerca_Area_Protegida)
        {
            T_Sgpal_Cerca_Area_Protegida vEntidad = null;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_CERCA_AREA_PROTEGIDA.USP_SEL_CERCA_AREA_PROTEGIDA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_CERCA_AREA_PROTEGIDA", vId_Cerca_Area_Protegida);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpal_Cerca_Area_Protegida(vRdr);
                    }
                }
                vCnn.Close();
            }
            return vEntidad;
        }

        public T_Sgpal_Cerca_Area_Protegida InsertarT_Sgpal_Cerca_Area_Protegida(T_Sgpal_Cerca_Area_Protegida vT_Sgpal_Cerca_Area_Protegida)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_CERCA_AREA_PROTEGIDA.USP_INS_CERCA_AREA_PROTEGIDA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pPESO_RM", vT_Sgpal_Cerca_Area_Protegida.PESO_RM);
                    vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpal_Cerca_Area_Protegida.IP_INGRESO);
                    vCmd.Parameters.Add("pID_CERCA_AREA_PROTEGIDA", vT_Sgpal_Cerca_Area_Protegida.ID_CERCA_AREA_PROTEGIDA);
                    vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpal_Cerca_Area_Protegida.FEC_INGRESO);
                    vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpal_Cerca_Area_Protegida.FEC_MODIFICA);
                    vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpal_Cerca_Area_Protegida.USU_MODIFICA);
                    vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpal_Cerca_Area_Protegida.IP_MODIFICA);
                    vCmd.Parameters.Add("pPESO_PQ", vT_Sgpal_Cerca_Area_Protegida.PESO_PQ);
                    vCmd.Parameters.Add("pPESO_ORM", vT_Sgpal_Cerca_Area_Protegida.PESO_ORM);
                    vCmd.Parameters.Add("pPESO_I", vT_Sgpal_Cerca_Area_Protegida.PESO_I);
                    vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpal_Cerca_Area_Protegida.FLG_ESTADO);
                    vCmd.Parameters.Add("pDESCRIPCION", vT_Sgpal_Cerca_Area_Protegida.DESCRIPCION);
                    vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpal_Cerca_Area_Protegida.USU_INGRESO);
                    vCmd.Parameters.Add("pPESO_LB", vT_Sgpal_Cerca_Area_Protegida.PESO_LB);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpal_Cerca_Area_Protegida;
        }

        public T_Sgpal_Cerca_Area_Protegida ActualizarT_Sgpal_Cerca_Area_Protegida(T_Sgpal_Cerca_Area_Protegida vT_Sgpal_Cerca_Area_Protegida)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_CERCA_AREA_PROTEGIDA.USP_UPD_CERCA_AREA_PROTEGIDA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pPESO_RM", vT_Sgpal_Cerca_Area_Protegida.PESO_RM);
                    vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpal_Cerca_Area_Protegida.IP_INGRESO);
                    vCmd.Parameters.Add("pID_CERCA_AREA_PROTEGIDA", vT_Sgpal_Cerca_Area_Protegida.ID_CERCA_AREA_PROTEGIDA);
                    vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpal_Cerca_Area_Protegida.FEC_INGRESO);
                    vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpal_Cerca_Area_Protegida.FEC_MODIFICA);
                    vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpal_Cerca_Area_Protegida.USU_MODIFICA);
                    vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpal_Cerca_Area_Protegida.IP_MODIFICA);
                    vCmd.Parameters.Add("pPESO_PQ", vT_Sgpal_Cerca_Area_Protegida.PESO_PQ);
                    vCmd.Parameters.Add("pPESO_ORM", vT_Sgpal_Cerca_Area_Protegida.PESO_ORM);
                    vCmd.Parameters.Add("pPESO_I", vT_Sgpal_Cerca_Area_Protegida.PESO_I);
                    vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpal_Cerca_Area_Protegida.FLG_ESTADO);
                    vCmd.Parameters.Add("pDESCRIPCION", vT_Sgpal_Cerca_Area_Protegida.DESCRIPCION);
                    vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpal_Cerca_Area_Protegida.USU_INGRESO);
                    vCmd.Parameters.Add("pPESO_LB", vT_Sgpal_Cerca_Area_Protegida.PESO_LB);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpal_Cerca_Area_Protegida;
        }

        public int AnularT_Sgpal_Cerca_Area_ProtegidaPorCodigo(int vId_Cerca_Area_Protegida)
        {
            int vResultado = 0;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_CERCA_AREA_PROTEGIDA.USP_DEL_CERCA_AREA_PROTEGIDA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_CERCA_AREA_PROTEGIDA", vId_Cerca_Area_Protegida);
                    vCnn.Open();
                    vResultado = vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vResultado;
        }

        public IEnumerable<T_Sgpal_Cerca_Area_Protegida> ListarPaginadoT_Sgpal_Cerca_Area_Protegida(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            List<T_Sgpal_Cerca_Area_Protegida> vLista = new List<T_Sgpal_Cerca_Area_Protegida>();
            T_Sgpal_Cerca_Area_Protegida vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_CERCA_AREA_PROTEGIDA.USP_PAG_CERCA_AREA_PROTEGIDA", vCnn))
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
                        vEntidad = new T_Sgpal_Cerca_Area_Protegida(vRdr);
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