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
    /// Objetivo:	Clase que genera las operaciones para la tabla T_SGPAD_COMP_INFO_CAMPO
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	27/10/2021
    /// </summary>
    public partial class T_Sgpad_Comp_Info_CampoAD : BaseAD, IT_Sgpad_Comp_Info_CampoAD
    {
        public T_Sgpad_Comp_Info_CampoAD(IConfiguration vConfiguration)
        {
            CnnString = vConfiguration.GetSection(Constantes.BD).Value;
        }

        public IEnumerable<T_Sgpad_Comp_Info_Campo> ListarT_Sgpad_Comp_Info_Campo(int vIdComponente)
        {
            List<T_Sgpad_Comp_Info_Campo> vLista = new List<T_Sgpad_Comp_Info_Campo>();
            T_Sgpad_Comp_Info_Campo vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_INFO_CAMPO.USP_LIS_COMP_INFO_CAMPO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_COMPONENTE", vIdComponente);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpad_Comp_Info_Campo(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public T_Sgpad_Comp_Info_Campo RecuperarT_Sgpad_Comp_Info_CampoPorCodigo(int vId_Comp_Info_Campo)
        {
            T_Sgpad_Comp_Info_Campo vEntidad = null;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_INFO_CAMPO.USP_SEL_COMP_INFO_CAMPO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_COMP_INFO_CAMPO", vId_Comp_Info_Campo);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpad_Comp_Info_Campo(vRdr);
                    }
                }
                vCnn.Close();
            }
            return vEntidad;
        }

        public T_Sgpad_Comp_Info_Campo InsertarT_Sgpad_Comp_Info_Campo(T_Sgpad_Comp_Info_Campo vT_Sgpad_Comp_Info_Campo)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_INFO_CAMPO.USP_INS_COMP_INFO_CAMPO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pFECHA_INFORME", vT_Sgpad_Comp_Info_Campo.FECHA_INFORME);
                    vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpad_Comp_Info_Campo.IP_MODIFICA);
                    vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpad_Comp_Info_Campo.FEC_MODIFICA);
                    vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpad_Comp_Info_Campo.USU_INGRESO);
                    vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpad_Comp_Info_Campo.IP_INGRESO);
                    vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpad_Comp_Info_Campo.USU_MODIFICA);
                    vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpad_Comp_Info_Campo.FLG_ESTADO);
                    //vCmd.Parameters.Add("pID_COMP_INFO_CAMPO", vT_Sgpad_Comp_Info_Campo.ID_COMP_INFO_CAMPO);
                    vCmd.Parameters.Add("pID_COMPONENTE", vT_Sgpad_Comp_Info_Campo.ID_COMPONENTE);
                    vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpad_Comp_Info_Campo.FEC_INGRESO);
                    vCmd.Parameters.Add("pNRO_INFORME", vT_Sgpad_Comp_Info_Campo.NRO_INFORME);
                    vCmd.Parameters.Add(":pID_COMP_INFO_CAMPO", OracleDbType.Int64).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vT_Sgpad_Comp_Info_Campo.ID_COMP_INFO_CAMPO = Convert.ToInt32(vCmd.Parameters[":pID_COMP_INFO_CAMPO"].Value.ToString());
                    vCnn.Close();
                }
            }
            return vT_Sgpad_Comp_Info_Campo;
        }

        public T_Sgpad_Comp_Info_Campo ActualizarT_Sgpad_Comp_Info_Campo(T_Sgpad_Comp_Info_Campo vT_Sgpad_Comp_Info_Campo)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_INFO_CAMPO.USP_UPD_COMP_INFO_CAMPO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pFECHA_INFORME", vT_Sgpad_Comp_Info_Campo.FECHA_INFORME);
                    vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpad_Comp_Info_Campo.IP_MODIFICA);
                    vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpad_Comp_Info_Campo.FEC_MODIFICA);
                    //vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpad_Comp_Info_Campo.USU_INGRESO);
                    //vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpad_Comp_Info_Campo.IP_INGRESO);
                    vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpad_Comp_Info_Campo.USU_MODIFICA);
                    vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpad_Comp_Info_Campo.FLG_ESTADO);
                    vCmd.Parameters.Add("pID_COMP_INFO_CAMPO", vT_Sgpad_Comp_Info_Campo.ID_COMP_INFO_CAMPO);
                    vCmd.Parameters.Add("pID_COMPONENTE", vT_Sgpad_Comp_Info_Campo.ID_COMPONENTE);
                    //vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpad_Comp_Info_Campo.FEC_INGRESO);
                    vCmd.Parameters.Add("pNRO_INFORME", vT_Sgpad_Comp_Info_Campo.NRO_INFORME);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpad_Comp_Info_Campo;
        }

        public int AnularT_Sgpad_Comp_Info_CampoPorCodigo(int vId_Comp_Info_Campo)
        {
            int vResultado = 0;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_INFO_CAMPO.USP_DEL_COMP_INFO_CAMPO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_COMP_INFO_CAMPO", vId_Comp_Info_Campo);
                    vCnn.Open();
                    vResultado = vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vResultado;
        }

        public IEnumerable<T_Sgpad_Comp_Info_Campo> ListarPaginadoT_Sgpad_Comp_Info_Campo(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            List<T_Sgpad_Comp_Info_Campo> vLista = new List<T_Sgpad_Comp_Info_Campo>();
            T_Sgpad_Comp_Info_Campo vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_INFO_CAMPO.USP_PAG_COMP_INFO_CAMPO", vCnn))
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
                        vEntidad = new T_Sgpad_Comp_Info_Campo(vRdr);
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