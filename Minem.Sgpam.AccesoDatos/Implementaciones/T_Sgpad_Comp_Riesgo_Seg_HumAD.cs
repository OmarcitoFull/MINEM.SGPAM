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
    /// Objetivo:	Clase que genera las operaciones para la tabla T_SGPAD_COMP_RIESGO_SEG_HUM
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	27/10/2021
    /// </summary>
    public partial class T_Sgpad_Comp_Riesgo_Seg_HumAD : BaseAD, IT_Sgpad_Comp_Riesgo_Seg_HumAD
    {
        public T_Sgpad_Comp_Riesgo_Seg_HumAD(IConfiguration vConfiguration)
        {
            CnnString = vConfiguration.GetSection(Constantes.BD).Value;
        }

        public IEnumerable<V_Sgpad_Comp_Riesgo_Seg_Hum> ListarT_Sgpad_Comp_Riesgo_Seg_Hum(int vIdComponente)
        {
            List<V_Sgpad_Comp_Riesgo_Seg_Hum> vLista = new List<V_Sgpad_Comp_Riesgo_Seg_Hum>();
            V_Sgpad_Comp_Riesgo_Seg_Hum vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_RIESGO_SEG_HUM.USP_LIS_COMP_RIESGO_SEG_HUM", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_COMPONENTE", vIdComponente);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new V_Sgpad_Comp_Riesgo_Seg_Hum(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public T_Sgpad_Comp_Riesgo_Seg_Hum RecuperarT_Sgpad_Comp_Riesgo_Seg_HumPorCodigo(int vId_Comp_Riesgo_Seg_Hum)
        {
            T_Sgpad_Comp_Riesgo_Seg_Hum vEntidad = null;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_RIESGO_SEG_HUM.USP_SEL_COMP_RIESGO_SEG_HUM", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_COMP_RIESGO_SEG_HUM", vId_Comp_Riesgo_Seg_Hum);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpad_Comp_Riesgo_Seg_Hum(vRdr);
                    }
                }
                vCnn.Close();
            }
            return vEntidad;
        }

        public T_Sgpad_Comp_Riesgo_Seg_Hum InsertarT_Sgpad_Comp_Riesgo_Seg_Hum(T_Sgpad_Comp_Riesgo_Seg_Hum vT_Sgpad_Comp_Riesgo_Seg_Hum)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_RIESGO_SEG_HUM.USP_INS_COMP_RIESGO_SEG_HUM", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    //vCmd.Parameters.Add("pID_COMP_RIESGO_SEG_HUM", vT_Sgpad_Comp_Riesgo_Seg_Hum.ID_COMP_RIESGO_SEG_HUM);
                    vCmd.Parameters.Add("pID_POT_COLAPSO", vT_Sgpad_Comp_Riesgo_Seg_Hum.ID_POT_COLAPSO);
                    vCmd.Parameters.Add("pID_HUNDIMIENTO", vT_Sgpad_Comp_Riesgo_Seg_Hum.ID_HUNDIMIENTO);
                    vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpad_Comp_Riesgo_Seg_Hum.FEC_INGRESO);
                    vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpad_Comp_Riesgo_Seg_Hum.FLG_ESTADO);
                    vCmd.Parameters.Add("pID_PRESENCIA_ADVERTENCIA", vT_Sgpad_Comp_Riesgo_Seg_Hum.ID_PRESENCIA_ADVERTENCIA);
                    vCmd.Parameters.Add("pID_POT_CAIDA_PERSONA", vT_Sgpad_Comp_Riesgo_Seg_Hum.ID_POT_CAIDA_PERSONA);
                    vCmd.Parameters.Add("pID_COMPONENTE", vT_Sgpad_Comp_Riesgo_Seg_Hum.ID_COMPONENTE);
                    vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpad_Comp_Riesgo_Seg_Hum.IP_MODIFICA);
                    vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpad_Comp_Riesgo_Seg_Hum.IP_INGRESO);
                    vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpad_Comp_Riesgo_Seg_Hum.USU_MODIFICA);
                    vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpad_Comp_Riesgo_Seg_Hum.USU_INGRESO);
                    vCmd.Parameters.Add("pID_PRESENCIA_ELEMENTO", vT_Sgpad_Comp_Riesgo_Seg_Hum.ID_PRESENCIA_ELEMENTO);
                    vCmd.Parameters.Add("pID_ACCESIBILIDAD", vT_Sgpad_Comp_Riesgo_Seg_Hum.ID_ACCESIBILIDAD);
                    vCmd.Parameters.Add("pID_CONDICION_CIERRE", vT_Sgpad_Comp_Riesgo_Seg_Hum.ID_CONDICION_CIERRE);
                    vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpad_Comp_Riesgo_Seg_Hum.FEC_MODIFICA);
                    vCmd.Parameters.Add(":pID_COMP_RIESGO_SEG_HUM", OracleDbType.Int64).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vT_Sgpad_Comp_Riesgo_Seg_Hum.ID_COMP_RIESGO_SEG_HUM = Convert.ToInt32(vCmd.Parameters[":pID_COMP_RIESGO_SEG_HUM"].Value.ToString());
                    vCnn.Close();
                }
            }
            return vT_Sgpad_Comp_Riesgo_Seg_Hum;
        }

        public T_Sgpad_Comp_Riesgo_Seg_Hum ActualizarT_Sgpad_Comp_Riesgo_Seg_Hum(T_Sgpad_Comp_Riesgo_Seg_Hum vT_Sgpad_Comp_Riesgo_Seg_Hum)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_RIESGO_SEG_HUM.USP_UPD_COMP_RIESGO_SEG_HUM", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_COMP_RIESGO_SEG_HUM", vT_Sgpad_Comp_Riesgo_Seg_Hum.ID_COMP_RIESGO_SEG_HUM);
                    //vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpad_Comp_Riesgo_Seg_Hum.FEC_INGRESO);
                    vCmd.Parameters.Add("pID_PRESENCIA_ADVERTENCIA", vT_Sgpad_Comp_Riesgo_Seg_Hum.ID_PRESENCIA_ADVERTENCIA);
                    vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpad_Comp_Riesgo_Seg_Hum.FLG_ESTADO);
                    vCmd.Parameters.Add("pID_COMPONENTE", vT_Sgpad_Comp_Riesgo_Seg_Hum.ID_COMPONENTE);
                    vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpad_Comp_Riesgo_Seg_Hum.IP_MODIFICA);
                    //vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpad_Comp_Riesgo_Seg_Hum.IP_INGRESO);
                    vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpad_Comp_Riesgo_Seg_Hum.USU_MODIFICA);
                    vCmd.Parameters.Add("pID_HUNDIMIENTO", vT_Sgpad_Comp_Riesgo_Seg_Hum.ID_HUNDIMIENTO);
                    //vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpad_Comp_Riesgo_Seg_Hum.USU_INGRESO);
                    vCmd.Parameters.Add("pID_POT_COLAPSO", vT_Sgpad_Comp_Riesgo_Seg_Hum.ID_POT_COLAPSO);
                    vCmd.Parameters.Add("pID_POT_CAIDA_PERSONA", vT_Sgpad_Comp_Riesgo_Seg_Hum.ID_POT_CAIDA_PERSONA);
                    vCmd.Parameters.Add("pID_CONDICION_CIERRE", vT_Sgpad_Comp_Riesgo_Seg_Hum.ID_CONDICION_CIERRE);
                    vCmd.Parameters.Add("pID_PRESENCIA_ELEMENTO", vT_Sgpad_Comp_Riesgo_Seg_Hum.ID_PRESENCIA_ELEMENTO);
                    vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpad_Comp_Riesgo_Seg_Hum.FEC_MODIFICA);
                    vCmd.Parameters.Add("pID_ACCESIBILIDAD", vT_Sgpad_Comp_Riesgo_Seg_Hum.ID_ACCESIBILIDAD);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpad_Comp_Riesgo_Seg_Hum;
        }

        public int AnularT_Sgpad_Comp_Riesgo_Seg_HumPorCodigo(int vId_Comp_Riesgo_Seg_Hum)
        {
            int vResultado = 0;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_RIESGO_SEG_HUM.USP_DEL_COMP_RIESGO_SEG_HUM", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_COMP_RIESGO_SEG_HUM", vId_Comp_Riesgo_Seg_Hum);
                    vCnn.Open();
                    vResultado = vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vResultado;
        }

        public IEnumerable<T_Sgpad_Comp_Riesgo_Seg_Hum> ListarPaginadoT_Sgpad_Comp_Riesgo_Seg_Hum(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            List<T_Sgpad_Comp_Riesgo_Seg_Hum> vLista = new List<T_Sgpad_Comp_Riesgo_Seg_Hum>();
            T_Sgpad_Comp_Riesgo_Seg_Hum vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_RIESGO_SEG_HUM.USP_PAG_COMP_RIESGO_SEG_HUM", vCnn))
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
                        vEntidad = new T_Sgpad_Comp_Riesgo_Seg_Hum(vRdr);
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