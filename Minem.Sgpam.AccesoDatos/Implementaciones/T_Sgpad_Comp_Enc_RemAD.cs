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
    /// Objetivo:	Clase que genera las operaciones para la tabla T_SGPAD_COMP_ENC_REM
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	27/10/2021
    /// </summary>
    public partial class T_Sgpad_Comp_Enc_RemAD : BaseAD, IT_Sgpad_Comp_Enc_RemAD
    {
        public T_Sgpad_Comp_Enc_RemAD(IConfiguration vConfiguration)
        {
            CnnString = vConfiguration.GetSection(Constantes.BD).Value;
        }

        public IEnumerable<T_Sgpad_Comp_Enc_Rem> ListarT_Sgpad_Comp_Enc_Rem(int vIdComponente)
        {
            List<T_Sgpad_Comp_Enc_Rem> vLista = new List<T_Sgpad_Comp_Enc_Rem>();
            T_Sgpad_Comp_Enc_Rem vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_ENC_REM.USP_LIS_COMP_ENC_REM", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_COMPONENTE", vIdComponente);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpad_Comp_Enc_Rem(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public T_Sgpad_Comp_Enc_Rem RecuperarT_Sgpad_Comp_Enc_RemPorCodigo(int vId_Comp_Enc_Rem)
        {
            T_Sgpad_Comp_Enc_Rem vEntidad = null;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_ENC_REM.USP_SEL_COMP_ENC_REM", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_COMP_ENC_REM", vId_Comp_Enc_Rem);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpad_Comp_Enc_Rem(vRdr);
                    }
                }
                vCnn.Close();
            }
            return vEntidad;
        }

        public T_Sgpad_Comp_Enc_Rem InsertarT_Sgpad_Comp_Enc_Rem(T_Sgpad_Comp_Enc_Rem vT_Sgpad_Comp_Enc_Rem)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_ENC_REM.USP_INS_COMP_ENC_REM", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pNRO_REMEDIACION", vT_Sgpad_Comp_Enc_Rem.NRO_REMEDIACION);
                    vCmd.Parameters.Add("pRESOLUCION_EXC_ENC", vT_Sgpad_Comp_Enc_Rem.RESOLUCION_EXC_ENC);
                    vCmd.Parameters.Add("pANIO_RESOLUCION", vT_Sgpad_Comp_Enc_Rem.ANIO_RESOLUCION);
                    vCmd.Parameters.Add("pID_TIPO_ENCARGO", vT_Sgpad_Comp_Enc_Rem.ID_TIPO_ENCARGO);
                    vCmd.Parameters.Add("pID_TIPO_RESOLUCION", vT_Sgpad_Comp_Enc_Rem.ID_TIPO_RESOLUCION);
                    //vCmd.Parameters.Add("pID_COMP_ENC_REM", vT_Sgpad_Comp_Enc_Rem.ID_COMP_ENC_REM);
                    vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpad_Comp_Enc_Rem.FEC_MODIFICA);
                    vCmd.Parameters.Add("pID_COMPONENTE", vT_Sgpad_Comp_Enc_Rem.ID_COMPONENTE);
                    vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpad_Comp_Enc_Rem.IP_INGRESO);
                    vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpad_Comp_Enc_Rem.FEC_INGRESO);
                    vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpad_Comp_Enc_Rem.FLG_ESTADO);
                    vCmd.Parameters.Add("pRESPONSABLE_REMEDIACION", vT_Sgpad_Comp_Enc_Rem.RESPONSABLE_REMEDIACION);
                    vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpad_Comp_Enc_Rem.USU_MODIFICA);
                    vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpad_Comp_Enc_Rem.USU_INGRESO);
                    vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpad_Comp_Enc_Rem.IP_MODIFICA);
                    vCmd.Parameters.Add(":pID_COMP_ENC_REM", OracleDbType.Int64).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vT_Sgpad_Comp_Enc_Rem.ID_COMP_ENC_REM = Convert.ToInt32(vCmd.Parameters[":pID_COMP_ENC_REM"].Value.ToString());
                    vCnn.Close();
                }
            }
            return vT_Sgpad_Comp_Enc_Rem;
        }

        public T_Sgpad_Comp_Enc_Rem ActualizarT_Sgpad_Comp_Enc_Rem(T_Sgpad_Comp_Enc_Rem vT_Sgpad_Comp_Enc_Rem)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_ENC_REM.USP_UPD_COMP_ENC_REM", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pNRO_REMEDIACION", vT_Sgpad_Comp_Enc_Rem.NRO_REMEDIACION);
                    vCmd.Parameters.Add("pRESOLUCION_EXC_ENC", vT_Sgpad_Comp_Enc_Rem.RESOLUCION_EXC_ENC);
                    vCmd.Parameters.Add("pANIO_RESOLUCION", vT_Sgpad_Comp_Enc_Rem.ANIO_RESOLUCION);
                    vCmd.Parameters.Add("pID_TIPO_ENCARGO", vT_Sgpad_Comp_Enc_Rem.ID_TIPO_ENCARGO);
                    vCmd.Parameters.Add("pID_TIPO_RESOLUCION", vT_Sgpad_Comp_Enc_Rem.ID_TIPO_RESOLUCION);
                    vCmd.Parameters.Add("pID_COMP_ENC_REM", vT_Sgpad_Comp_Enc_Rem.ID_COMP_ENC_REM);
                    vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpad_Comp_Enc_Rem.FEC_MODIFICA);
                    vCmd.Parameters.Add("pID_COMPONENTE", vT_Sgpad_Comp_Enc_Rem.ID_COMPONENTE);
                    //vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpad_Comp_Enc_Rem.IP_INGRESO);
                    //vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpad_Comp_Enc_Rem.FEC_INGRESO);
                    vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpad_Comp_Enc_Rem.FLG_ESTADO);
                    vCmd.Parameters.Add("pRESPONSABLE_REMEDIACION", vT_Sgpad_Comp_Enc_Rem.RESPONSABLE_REMEDIACION);
                    vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpad_Comp_Enc_Rem.USU_MODIFICA);
                    //vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpad_Comp_Enc_Rem.USU_INGRESO);
                    vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpad_Comp_Enc_Rem.IP_MODIFICA);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpad_Comp_Enc_Rem;
        }

        public int AnularT_Sgpad_Comp_Enc_RemPorCodigo(int vId_Comp_Enc_Rem)
        {
            int vResultado = 0;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_ENC_REM.USP_DEL_COMP_ENC_REM", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_COMP_ENC_REM", vId_Comp_Enc_Rem);
                    vCnn.Open();
                    vResultado = vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vResultado;
        }

        public IEnumerable<T_Sgpad_Comp_Enc_Rem> ListarPaginadoT_Sgpad_Comp_Enc_Rem(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            List<T_Sgpad_Comp_Enc_Rem> vLista = new List<T_Sgpad_Comp_Enc_Rem>();
            T_Sgpad_Comp_Enc_Rem vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_ENC_REM.USP_PAG_COMP_ENC_REM", vCnn))
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
                        vEntidad = new T_Sgpad_Comp_Enc_Rem(vRdr);
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