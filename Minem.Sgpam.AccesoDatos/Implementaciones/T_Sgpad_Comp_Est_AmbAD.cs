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
    /// Objetivo:	Clase que genera las operaciones para la tabla T_SGPAD_COMP_EST_AMB
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	27/10/2021
    /// </summary>
    public partial class T_Sgpad_Comp_Est_AmbAD : BaseAD, IT_Sgpad_Comp_Est_AmbAD
    {
        public T_Sgpad_Comp_Est_AmbAD(IConfiguration vConfiguration)
        {
            CnnString = vConfiguration.GetSection(Constantes.BD).Value;
        }

        public IEnumerable<T_Sgpad_Comp_Est_Amb> ListarT_Sgpad_Comp_Est_Amb(int vIdComponente)
        {
            List<T_Sgpad_Comp_Est_Amb> vLista = new List<T_Sgpad_Comp_Est_Amb>();
            T_Sgpad_Comp_Est_Amb vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_EST_AMB.USP_LIS_COMP_EST_AMB", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_COMPONENTE", vIdComponente);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpad_Comp_Est_Amb(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public T_Sgpad_Comp_Est_Amb RecuperarT_Sgpad_Comp_Est_AmbPorCodigo(int vId_Comp_Est_Amb)
        {
            T_Sgpad_Comp_Est_Amb vEntidad = null;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_EST_AMB.USP_SEL_COMP_EST_AMB", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_COMP_EST_AMB", vId_Comp_Est_Amb);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpad_Comp_Est_Amb(vRdr);
                    }
                }
                vCnn.Close();
            }
            return vEntidad;
        }

        public T_Sgpad_Comp_Est_Amb InsertarT_Sgpad_Comp_Est_Amb(T_Sgpad_Comp_Est_Amb vT_Sgpad_Comp_Est_Amb)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_EST_AMB.USP_INS_COMP_EST_AMB", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpad_Comp_Est_Amb.FEC_MODIFICA);
                    vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpad_Comp_Est_Amb.USU_MODIFICA);
                    vCmd.Parameters.Add("pTIPO_ESTUDIO", vT_Sgpad_Comp_Est_Amb.TIPO_ESTUDIO);
                    vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpad_Comp_Est_Amb.USU_INGRESO);
                    vCmd.Parameters.Add("pFEC_RESOLUCION", vT_Sgpad_Comp_Est_Amb.FEC_RESOLUCION);
                    vCmd.Parameters.Add("pNRO_EXPEDIENTE", vT_Sgpad_Comp_Est_Amb.NRO_EXPEDIENTE);
                    vCmd.Parameters.Add("pDES_NOM_TITULAR", vT_Sgpad_Comp_Est_Amb.DES_NOM_TITULAR);
                    vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpad_Comp_Est_Amb.IP_MODIFICA);
                    vCmd.Parameters.Add("pDES_NOM_PROYECTO", vT_Sgpad_Comp_Est_Amb.DES_NOM_PROYECTO);
                    vCmd.Parameters.Add("pDES_UND_AMBIENTAL", vT_Sgpad_Comp_Est_Amb.DES_UND_AMBIENTAL);
                    vCmd.Parameters.Add("pFEC_EXPEDIENTE", vT_Sgpad_Comp_Est_Amb.FEC_EXPEDIENTE);
                    vCmd.Parameters.Add("pDES_SITUACION", vT_Sgpad_Comp_Est_Amb.DES_SITUACION);
                    vCmd.Parameters.Add("pID_COMPONENTE", vT_Sgpad_Comp_Est_Amb.ID_COMPONENTE);
                    vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpad_Comp_Est_Amb.FEC_INGRESO);
                    vCmd.Parameters.Add("pRES_APROBACION", vT_Sgpad_Comp_Est_Amb.RES_APROBACION);
                    vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpad_Comp_Est_Amb.FLG_ESTADO);
                    vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpad_Comp_Est_Amb.IP_INGRESO);
                    vCmd.Parameters.Add(":pID_COMP_EST_AMB", OracleDbType.Int64).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vT_Sgpad_Comp_Est_Amb.ID_COMP_EST_AMB = Convert.ToInt32(vCmd.Parameters[":pID_COMP_EST_AMB"].Value.ToString());
                    vCnn.Close();
                }
            }
            return vT_Sgpad_Comp_Est_Amb;
        }

        public T_Sgpad_Comp_Est_Amb ActualizarT_Sgpad_Comp_Est_Amb(T_Sgpad_Comp_Est_Amb vT_Sgpad_Comp_Est_Amb)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_EST_AMB.USP_UPD_COMP_EST_AMB", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpad_Comp_Est_Amb.FEC_MODIFICA);
                    vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpad_Comp_Est_Amb.USU_MODIFICA);
                    vCmd.Parameters.Add("pTIPO_ESTUDIO", vT_Sgpad_Comp_Est_Amb.TIPO_ESTUDIO);
                    //vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpad_Comp_Est_Amb.USU_INGRESO);
                    vCmd.Parameters.Add("pFEC_RESOLUCION", vT_Sgpad_Comp_Est_Amb.FEC_RESOLUCION);
                    vCmd.Parameters.Add("pNRO_EXPEDIENTE", vT_Sgpad_Comp_Est_Amb.NRO_EXPEDIENTE);
                    vCmd.Parameters.Add("pDES_NOM_TITULAR", vT_Sgpad_Comp_Est_Amb.DES_NOM_TITULAR);
                    vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpad_Comp_Est_Amb.IP_MODIFICA);
                    vCmd.Parameters.Add("pDES_NOM_PROYECTO", vT_Sgpad_Comp_Est_Amb.DES_NOM_PROYECTO);
                    vCmd.Parameters.Add("pDES_UND_AMBIENTAL", vT_Sgpad_Comp_Est_Amb.DES_UND_AMBIENTAL);
                    vCmd.Parameters.Add("pFEC_EXPEDIENTE", vT_Sgpad_Comp_Est_Amb.FEC_EXPEDIENTE);
                    vCmd.Parameters.Add("pDES_SITUACION", vT_Sgpad_Comp_Est_Amb.DES_SITUACION);
                    vCmd.Parameters.Add("pID_COMPONENTE", vT_Sgpad_Comp_Est_Amb.ID_COMPONENTE);
                    //vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpad_Comp_Est_Amb.FEC_INGRESO);
                    vCmd.Parameters.Add("pRES_APROBACION", vT_Sgpad_Comp_Est_Amb.RES_APROBACION);
                    vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpad_Comp_Est_Amb.FLG_ESTADO);
                    //vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpad_Comp_Est_Amb.IP_INGRESO);
                    vCmd.Parameters.Add("pID_COMP_EST_AMB", vT_Sgpad_Comp_Est_Amb.ID_COMP_EST_AMB);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpad_Comp_Est_Amb;
        }

        public int AnularT_Sgpad_Comp_Est_AmbPorCodigo(int vId_Comp_Est_Amb)
        {
            int vResultado = 0;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_EST_AMB.USP_DEL_COMP_EST_AMB", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_COMP_EST_AMB", vId_Comp_Est_Amb);
                    vCnn.Open();
                    vResultado = vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vResultado;
        }

        public IEnumerable<T_Sgpad_Comp_Est_Amb> ListarPaginadoT_Sgpad_Comp_Est_Amb(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            List<T_Sgpad_Comp_Est_Amb> vLista = new List<T_Sgpad_Comp_Est_Amb>();
            T_Sgpad_Comp_Est_Amb vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_EST_AMB.USP_PAG_COMP_EST_AMB", vCnn))
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
                        vEntidad = new T_Sgpad_Comp_Est_Amb(vRdr);
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