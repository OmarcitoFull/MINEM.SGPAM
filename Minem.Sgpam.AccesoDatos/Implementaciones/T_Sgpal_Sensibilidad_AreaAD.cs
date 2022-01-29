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
    /// Objetivo:	Clase que genera las operaciones para la tabla T_SGPAL_SENSIBILIDAD_AREA
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	27/10/2021
    /// </summary>
    public partial class T_Sgpal_Sensibilidad_AreaAD : BaseAD, IT_Sgpal_Sensibilidad_AreaAD
    {
        public T_Sgpal_Sensibilidad_AreaAD(IConfiguration vConfiguration)
        {
            CnnString = vConfiguration.GetSection(Constantes.BD).Value;
        }

        public IEnumerable<T_Sgpal_Sensibilidad_Area> ListarT_Sgpal_Sensibilidad_Area()
        {
            List<T_Sgpal_Sensibilidad_Area> vLista = new List<T_Sgpal_Sensibilidad_Area>();
            T_Sgpal_Sensibilidad_Area vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_SENSIBILIDAD_AREA.USP_LIS_SENSIBILIDAD_AREA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpal_Sensibilidad_Area(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public T_Sgpal_Sensibilidad_Area RecuperarT_Sgpal_Sensibilidad_AreaPorCodigo(int vId_Sensibilidad_Area)
        {
            T_Sgpal_Sensibilidad_Area vEntidad = null;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_SENSIBILIDAD_AREA.USP_SEL_SENSIBILIDAD_AREA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_SENSIBILIDAD_AREA", vId_Sensibilidad_Area);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpal_Sensibilidad_Area(vRdr);
                    }
                }
                vCnn.Close();
            }
            return vEntidad;
        }

        public T_Sgpal_Sensibilidad_Area InsertarT_Sgpal_Sensibilidad_Area(T_Sgpal_Sensibilidad_Area vT_Sgpal_Sensibilidad_Area)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_SENSIBILIDAD_AREA.USP_INS_SENSIBILIDAD_AREA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpal_Sensibilidad_Area.FEC_MODIFICA);
                    vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpal_Sensibilidad_Area.IP_INGRESO);
                    vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpal_Sensibilidad_Area.USU_MODIFICA);
                    vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpal_Sensibilidad_Area.FEC_INGRESO);
                    vCmd.Parameters.Add("pPESO_ORM", vT_Sgpal_Sensibilidad_Area.PESO_ORM);
                    vCmd.Parameters.Add("pPESO_I", vT_Sgpal_Sensibilidad_Area.PESO_I);
                    vCmd.Parameters.Add("pPESO_PQ", vT_Sgpal_Sensibilidad_Area.PESO_PQ);
                    vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpal_Sensibilidad_Area.IP_MODIFICA);
                    vCmd.Parameters.Add("pDESCRIPCION", vT_Sgpal_Sensibilidad_Area.DESCRIPCION);
                    vCmd.Parameters.Add("pPESO_LB", vT_Sgpal_Sensibilidad_Area.PESO_LB);
                    vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpal_Sensibilidad_Area.USU_INGRESO);
                    vCmd.Parameters.Add("pPESO_RM", vT_Sgpal_Sensibilidad_Area.PESO_RM);
                    vCmd.Parameters.Add("pID_SENSIBILIDAD_AREA", vT_Sgpal_Sensibilidad_Area.ID_SENSIBILIDAD_AREA);
                    vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpal_Sensibilidad_Area.FLG_ESTADO);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpal_Sensibilidad_Area;
        }

        public T_Sgpal_Sensibilidad_Area ActualizarT_Sgpal_Sensibilidad_Area(T_Sgpal_Sensibilidad_Area vT_Sgpal_Sensibilidad_Area)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_SENSIBILIDAD_AREA.USP_UPD_SENSIBILIDAD_AREA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpal_Sensibilidad_Area.FEC_MODIFICA);
                    vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpal_Sensibilidad_Area.IP_INGRESO);
                    vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpal_Sensibilidad_Area.USU_MODIFICA);
                    vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpal_Sensibilidad_Area.FEC_INGRESO);
                    vCmd.Parameters.Add("pPESO_ORM", vT_Sgpal_Sensibilidad_Area.PESO_ORM);
                    vCmd.Parameters.Add("pPESO_I", vT_Sgpal_Sensibilidad_Area.PESO_I);
                    vCmd.Parameters.Add("pPESO_PQ", vT_Sgpal_Sensibilidad_Area.PESO_PQ);
                    vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpal_Sensibilidad_Area.IP_MODIFICA);
                    vCmd.Parameters.Add("pDESCRIPCION", vT_Sgpal_Sensibilidad_Area.DESCRIPCION);
                    vCmd.Parameters.Add("pPESO_LB", vT_Sgpal_Sensibilidad_Area.PESO_LB);
                    vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpal_Sensibilidad_Area.USU_INGRESO);
                    vCmd.Parameters.Add("pPESO_RM", vT_Sgpal_Sensibilidad_Area.PESO_RM);
                    vCmd.Parameters.Add("pID_SENSIBILIDAD_AREA", vT_Sgpal_Sensibilidad_Area.ID_SENSIBILIDAD_AREA);
                    vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpal_Sensibilidad_Area.FLG_ESTADO);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpal_Sensibilidad_Area;
        }

        public int AnularT_Sgpal_Sensibilidad_AreaPorCodigo(int vId_Sensibilidad_Area)
        {
            int vResultado = 0;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_SENSIBILIDAD_AREA.USP_DEL_SENSIBILIDAD_AREA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_SENSIBILIDAD_AREA", vId_Sensibilidad_Area);
                    vCnn.Open();
                    vResultado = vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vResultado;
        }

        public IEnumerable<T_Sgpal_Sensibilidad_Area> ListarPaginadoT_Sgpal_Sensibilidad_Area(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            List<T_Sgpal_Sensibilidad_Area> vLista = new List<T_Sgpal_Sensibilidad_Area>();
            T_Sgpal_Sensibilidad_Area vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_SENSIBILIDAD_AREA.USP_PAG_SENSIBILIDAD_AREA", vCnn))
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
                        vEntidad = new T_Sgpal_Sensibilidad_Area(vRdr);
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