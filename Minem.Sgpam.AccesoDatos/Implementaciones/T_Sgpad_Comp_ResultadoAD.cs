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
    /// Objetivo:	Clase que genera las operaciones para la tabla T_SGPAD_COMP_RESULTADO
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	27/10/2021
    /// </summary>
    public partial class T_Sgpad_Comp_ResultadoAD : BaseAD, IT_Sgpad_Comp_ResultadoAD
    {
        public T_Sgpad_Comp_ResultadoAD(IConfiguration vConfiguration)
        {
            CnnString = vConfiguration.GetSection(Constantes.BD).Value;
        }

        public IEnumerable<T_Sgpad_Comp_Resultado> ListarT_Sgpad_Comp_Resultado(int vIdComponente)
        {
            List<T_Sgpad_Comp_Resultado> vLista = new List<T_Sgpad_Comp_Resultado>();
            T_Sgpad_Comp_Resultado vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_RESULTADO.USP_LIS_COMP_RESULTADO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_COMPONENTE", vIdComponente);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpad_Comp_Resultado(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public T_Sgpad_Comp_Resultado RecuperarT_Sgpad_Comp_ResultadoPorCodigo(int vId_Comp_Resultado)
        {
            T_Sgpad_Comp_Resultado vEntidad = null;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_RESULTADO.USP_SEL_COMP_RESULTADO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_COMP_RESULTADO", vId_Comp_Resultado);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpad_Comp_Resultado(vRdr);
                    }
                }
                vCnn.Close();
            }
            return vEntidad;
        }

        public T_Sgpad_Comp_Resultado InsertarT_Sgpad_Comp_Resultado(T_Sgpad_Comp_Resultado vT_Sgpad_Comp_Resultado)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_RESULTADO.USP_INS_COMP_RESULTADO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pACT_SGP_DESCRIPCION", vT_Sgpad_Comp_Resultado.ACT_SGP_DESCRIPCION);
                    vCmd.Parameters.Add("pACT_INV_REGION", vT_Sgpad_Comp_Resultado.ACT_INV_REGION);
                    vCmd.Parameters.Add("pACT_INV_SUB_TIPO", vT_Sgpad_Comp_Resultado.ACT_INV_SUB_TIPO);
                    vCmd.Parameters.Add("pEXC_OTROS", vT_Sgpad_Comp_Resultado.EXC_OTROS);
                    vCmd.Parameters.Add("pID_COMPONENTE", vT_Sgpad_Comp_Resultado.ID_COMPONENTE);
                    vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpad_Comp_Resultado.FLG_ESTADO);
                    vCmd.Parameters.Add("pACT_SGP_PH", vT_Sgpad_Comp_Resultado.ACT_SGP_PH);
                    vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpad_Comp_Resultado.USU_INGRESO);
                    vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpad_Comp_Resultado.IP_MODIFICA);
                    vCmd.Parameters.Add("pACT_INV_GENERADOR", vT_Sgpad_Comp_Resultado.ACT_INV_GENERADOR);
                    vCmd.Parameters.Add("pACT_INV_EUM", vT_Sgpad_Comp_Resultado.ACT_INV_EUM);
                    vCmd.Parameters.Add("pEXC_NO_SIG_RIE", vT_Sgpad_Comp_Resultado.EXC_NO_SIG_RIE);
                    vCmd.Parameters.Add("pACT_INV_RES_REMEDIA", vT_Sgpad_Comp_Resultado.ACT_INV_RES_REMEDIA);
                    vCmd.Parameters.Add("pINC_INVENTARIO", vT_Sgpad_Comp_Resultado.INC_INVENTARIO);
                    vCmd.Parameters.Add("pACT_INV_COORDENADAS", vT_Sgpad_Comp_Resultado.ACT_INV_COORDENADAS);
                    vCmd.Parameters.Add("pACT_SGP_CONDICIONES", vT_Sgpad_Comp_Resultado.ACT_SGP_CONDICIONES);
                    vCmd.Parameters.Add("pACT_INV_PROVINCIA", vT_Sgpad_Comp_Resultado.ACT_INV_PROVINCIA);
                    vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpad_Comp_Resultado.FEC_MODIFICA);
                    vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpad_Comp_Resultado.IP_INGRESO);
                    vCmd.Parameters.Add("pACT_INV_DISTRITO", vT_Sgpad_Comp_Resultado.ACT_INV_DISTRITO);
                    vCmd.Parameters.Add("pEXC_NO_EXI_PAM", vT_Sgpad_Comp_Resultado.EXC_NO_EXI_PAM);
                    //vCmd.Parameters.Add("pID_COMP_RESULTADO", vT_Sgpad_Comp_Resultado.ID_COMP_RESULTADO);
                    vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpad_Comp_Resultado.FEC_INGRESO);
                    vCmd.Parameters.Add("pACT_SGP_Q", vT_Sgpad_Comp_Resultado.ACT_SGP_Q);
                    vCmd.Parameters.Add("pACT_INV_CUENCA", vT_Sgpad_Comp_Resultado.ACT_INV_CUENCA);
                    vCmd.Parameters.Add("pACT_SGP_AREAS", vT_Sgpad_Comp_Resultado.ACT_SGP_AREAS);
                    vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpad_Comp_Resultado.USU_MODIFICA);
                    vCmd.Parameters.Add("pEXC_PAM_INF_DUP", vT_Sgpad_Comp_Resultado.EXC_PAM_INF_DUP);
                    vCmd.Parameters.Add("pEXC_AGR_PAM_ID", vT_Sgpad_Comp_Resultado.EXC_AGR_PAM_ID);
                    vCmd.Parameters.Add(":pID_COMP_RESULTADO", OracleDbType.Int64).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vT_Sgpad_Comp_Resultado.ID_COMP_RESULTADO = Convert.ToInt32(vCmd.Parameters[":pID_COMP_RESULTADO"].Value.ToString());
                    vCnn.Close();
                }
            }
            return vT_Sgpad_Comp_Resultado;
        }

        public T_Sgpad_Comp_Resultado ActualizarT_Sgpad_Comp_Resultado(T_Sgpad_Comp_Resultado vT_Sgpad_Comp_Resultado)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_RESULTADO.USP_UPD_COMP_RESULTADO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pACT_SGP_DESCRIPCION", vT_Sgpad_Comp_Resultado.ACT_SGP_DESCRIPCION);
                    vCmd.Parameters.Add("pACT_INV_REGION", vT_Sgpad_Comp_Resultado.ACT_INV_REGION);
                    vCmd.Parameters.Add("pACT_INV_SUB_TIPO", vT_Sgpad_Comp_Resultado.ACT_INV_SUB_TIPO);
                    vCmd.Parameters.Add("pEXC_OTROS", vT_Sgpad_Comp_Resultado.EXC_OTROS);
                    vCmd.Parameters.Add("pID_COMPONENTE", vT_Sgpad_Comp_Resultado.ID_COMPONENTE);
                    vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpad_Comp_Resultado.FLG_ESTADO);
                    vCmd.Parameters.Add("pACT_SGP_PH", vT_Sgpad_Comp_Resultado.ACT_SGP_PH);
                    vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpad_Comp_Resultado.USU_INGRESO);
                    vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpad_Comp_Resultado.IP_MODIFICA);
                    vCmd.Parameters.Add("pACT_INV_GENERADOR", vT_Sgpad_Comp_Resultado.ACT_INV_GENERADOR);
                    vCmd.Parameters.Add("pACT_INV_EUM", vT_Sgpad_Comp_Resultado.ACT_INV_EUM);
                    vCmd.Parameters.Add("pEXC_NO_SIG_RIE", vT_Sgpad_Comp_Resultado.EXC_NO_SIG_RIE);
                    vCmd.Parameters.Add("pACT_INV_RES_REMEDIA", vT_Sgpad_Comp_Resultado.ACT_INV_RES_REMEDIA);
                    vCmd.Parameters.Add("pINC_INVENTARIO", vT_Sgpad_Comp_Resultado.INC_INVENTARIO);
                    vCmd.Parameters.Add("pACT_INV_COORDENADAS", vT_Sgpad_Comp_Resultado.ACT_INV_COORDENADAS);
                    vCmd.Parameters.Add("pACT_SGP_CONDICIONES", vT_Sgpad_Comp_Resultado.ACT_SGP_CONDICIONES);
                    vCmd.Parameters.Add("pACT_INV_PROVINCIA", vT_Sgpad_Comp_Resultado.ACT_INV_PROVINCIA);
                    vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpad_Comp_Resultado.FEC_MODIFICA);
                    vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpad_Comp_Resultado.IP_INGRESO);
                    vCmd.Parameters.Add("pACT_INV_DISTRITO", vT_Sgpad_Comp_Resultado.ACT_INV_DISTRITO);
                    vCmd.Parameters.Add("pEXC_NO_EXI_PAM", vT_Sgpad_Comp_Resultado.EXC_NO_EXI_PAM);
                    vCmd.Parameters.Add("pID_COMP_RESULTADO", vT_Sgpad_Comp_Resultado.ID_COMP_RESULTADO);
                    vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpad_Comp_Resultado.FEC_INGRESO);
                    vCmd.Parameters.Add("pACT_SGP_Q", vT_Sgpad_Comp_Resultado.ACT_SGP_Q);
                    vCmd.Parameters.Add("pACT_INV_CUENCA", vT_Sgpad_Comp_Resultado.ACT_INV_CUENCA);
                    vCmd.Parameters.Add("pACT_SGP_AREAS", vT_Sgpad_Comp_Resultado.ACT_SGP_AREAS);
                    vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpad_Comp_Resultado.USU_MODIFICA);
                    vCmd.Parameters.Add("pEXC_PAM_INF_DUP", vT_Sgpad_Comp_Resultado.EXC_PAM_INF_DUP);
                    vCmd.Parameters.Add("pEXC_AGR_PAM_ID", vT_Sgpad_Comp_Resultado.EXC_AGR_PAM_ID);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpad_Comp_Resultado;
        }

        public int AnularT_Sgpad_Comp_ResultadoPorCodigo(int vId_Comp_Resultado)
        {
            int vResultado = 0;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_RESULTADO.USP_DEL_COMP_RESULTADO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_COMP_RESULTADO", vId_Comp_Resultado);
                    vCnn.Open();
                    vResultado = vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vResultado;
        }

        public IEnumerable<T_Sgpad_Comp_Resultado> ListarPaginadoT_Sgpad_Comp_Resultado(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            List<T_Sgpad_Comp_Resultado> vLista = new List<T_Sgpad_Comp_Resultado>();
            T_Sgpad_Comp_Resultado vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_RESULTADO.USP_PAG_COMP_RESULTADO", vCnn))
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
                        vEntidad = new T_Sgpad_Comp_Resultado(vRdr);
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