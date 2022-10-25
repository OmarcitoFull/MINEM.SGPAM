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
    /// Objetivo:	Clase que genera las operaciones para la tabla T_SGPAM_MAESTRA
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	27/10/2021
    /// </summary>
    public partial class T_Sgpam_MaestraAD : BaseAD, IT_Sgpam_MaestraAD
    {
        public T_Sgpam_MaestraAD(IConfiguration vConfiguration)
        {
            CnnString = vConfiguration.GetSection(Constantes.BD).Value;
        }

        public IEnumerable<T_Sgpam_Maestra> ListarT_Sgpam_Maestra()
        {
            List<T_Sgpam_Maestra> vLista = new List<T_Sgpam_Maestra>();
            T_Sgpam_Maestra vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_MAESTRA.USP_LIS_MAESTRA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpam_Maestra(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public T_Sgpam_Maestra RecuperarT_Sgpam_MaestraPorCodigo(int vId_Eum)
        {
            T_Sgpam_Maestra vEntidad = null;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_MAESTRA.USP_SEL_MAESTRA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_EUM", vId_Eum);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpam_Maestra(vRdr);
                    }
                }
                vCnn.Close();
            }
            return vEntidad;
        }

        public T_Sgpam_Maestra InsertarT_Sgpam_Maestra(T_Sgpam_Maestra vT_Sgpam_Maestra)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_MAESTRA.USP_INS_MAESTRA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pDESCRIPCION_EUM", vT_Sgpam_Maestra.DESCRIPCION_EUM);
                    vCmd.Parameters.Add("pACCESO_EUM", vT_Sgpam_Maestra.ACCESO_EUM);
                    vCmd.Parameters.Add("pHISTORIA_EUM", vT_Sgpam_Maestra.HISTORIA_EUM);
                    vCmd.Parameters.Add("pEVIDENCIA_ACT_REC", vT_Sgpam_Maestra.EVIDENCIA_ACT_REC);
                    vCmd.Parameters.Add("pID_TIPO_OPERACION", vT_Sgpam_Maestra.ID_TIPO_OPERACION);
                    vCmd.Parameters.Add("pID_TIPO_SUSTANCIA", vT_Sgpam_Maestra.ID_TIPO_SUSTANCIA);
                    vCmd.Parameters.Add("pRELIEVE", vT_Sgpam_Maestra.RELIEVE);
                    vCmd.Parameters.Add("pCUERPOS_AGUA", vT_Sgpam_Maestra.CUERPOS_AGUA);
                    vCmd.Parameters.Add("pFLORA_TERRESTRE", vT_Sgpam_Maestra.FLORA_TERRESTRE);
                    vCmd.Parameters.Add("pFAUNA_TERRESTE", vT_Sgpam_Maestra.FAUNA_TERRESTE);
                    vCmd.Parameters.Add("pFLORA_FAUNA_ACUATICA", vT_Sgpam_Maestra.FLORA_FAUNA_ACUATICA);
                    vCmd.Parameters.Add("pINFRA_URBANA", vT_Sgpam_Maestra.INFRA_URBANA);
                    vCmd.Parameters.Add("pUSO_SUELO", vT_Sgpam_Maestra.USO_SUELO);
                    vCmd.Parameters.Add("pUSO_AGUA", vT_Sgpam_Maestra.USO_AGUA);
                    vCmd.Parameters.Add("pAREA_CONSERVACION", vT_Sgpam_Maestra.AREA_CONSERVACION);
                    vCmd.Parameters.Add("pSITIO_ARQUE_TURISTICO", vT_Sgpam_Maestra.SITIO_ARQUE_TURISTICO);
                    vCmd.Parameters.Add("pID_CONFLICTO_SOCIAL", vT_Sgpam_Maestra.ID_CONFLICTO_SOCIAL);
                    vCmd.Parameters.Add("pCONFLICTO_SOCIAL", vT_Sgpam_Maestra.CONFLICTO_SOCIAL);
                    vCmd.Parameters.Add("pEUM_DESCRIPCION", vT_Sgpam_Maestra.EUM_DESCRIPCION);
                    vCmd.Parameters.Add("pCOMENTARIO_ADI", vT_Sgpam_Maestra.COMENTARIO_ADI);
                    vCmd.Parameters.Add("pNUM_EUM", vT_Sgpam_Maestra.NUM_EUM);
                    vCmd.Parameters.Add("pID_ESTADO_REGISTRO", vT_Sgpam_Maestra.ID_ESTADO_REGISTRO);
                    vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpam_Maestra.USU_INGRESO);
                    vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpam_Maestra.FEC_INGRESO);
                    vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpam_Maestra.IP_INGRESO);
                    vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpam_Maestra.FLG_ESTADO);
                    vCmd.Parameters.Add(":pID_EUM", OracleDbType.Int64).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vT_Sgpam_Maestra.ID_EUM = Convert.ToInt32(vCmd.Parameters[":pID_EUM"].Value.ToString());
                    vCnn.Close();
                }
            }
            return vT_Sgpam_Maestra;
        }

        public T_Sgpam_Maestra ActualizarT_Sgpam_Maestra(T_Sgpam_Maestra vT_Sgpam_Maestra)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_MAESTRA.USP_UPD_MAESTRA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_EUM", vT_Sgpam_Maestra.ID_EUM);
                    vCmd.Parameters.Add("pDESCRIPCION_EUM", vT_Sgpam_Maestra.DESCRIPCION_EUM);
                    vCmd.Parameters.Add("pACCESO_EUM", vT_Sgpam_Maestra.ACCESO_EUM);
                    vCmd.Parameters.Add("pHISTORIA_EUM", vT_Sgpam_Maestra.HISTORIA_EUM);
                    vCmd.Parameters.Add("pEVIDENCIA_ACT_REC", vT_Sgpam_Maestra.EVIDENCIA_ACT_REC);
                    vCmd.Parameters.Add("pID_TIPO_OPERACION", vT_Sgpam_Maestra.ID_TIPO_OPERACION);
                    vCmd.Parameters.Add("pID_TIPO_SUSTANCIA", vT_Sgpam_Maestra.ID_TIPO_SUSTANCIA);
                    vCmd.Parameters.Add("pRELIEVE", vT_Sgpam_Maestra.RELIEVE);
                    vCmd.Parameters.Add("pCUERPOS_AGUA", vT_Sgpam_Maestra.CUERPOS_AGUA);
                    vCmd.Parameters.Add("pFLORA_TERRESTRE", vT_Sgpam_Maestra.FLORA_TERRESTRE);
                    vCmd.Parameters.Add("pFAUNA_TERRESTE", vT_Sgpam_Maestra.FAUNA_TERRESTE);
                    vCmd.Parameters.Add("pFLORA_FAUNA_ACUATICA", vT_Sgpam_Maestra.FLORA_FAUNA_ACUATICA);
                    vCmd.Parameters.Add("pINFRA_URBANA", vT_Sgpam_Maestra.INFRA_URBANA);
                    vCmd.Parameters.Add("pUSO_SUELO", vT_Sgpam_Maestra.USO_SUELO);
                    vCmd.Parameters.Add("pUSO_AGUA", vT_Sgpam_Maestra.USO_AGUA);
                    vCmd.Parameters.Add("pAREA_CONSERVACION", vT_Sgpam_Maestra.AREA_CONSERVACION);
                    vCmd.Parameters.Add("pSITIO_ARQUE_TURISTICO", vT_Sgpam_Maestra.SITIO_ARQUE_TURISTICO);
                    vCmd.Parameters.Add("pID_CONFLICTO_SOCIAL", vT_Sgpam_Maestra.ID_CONFLICTO_SOCIAL);
                    vCmd.Parameters.Add("pCONFLICTO_SOCIAL", vT_Sgpam_Maestra.CONFLICTO_SOCIAL);
                    vCmd.Parameters.Add("pEUM_DESCRIPCION", vT_Sgpam_Maestra.EUM_DESCRIPCION);
                    vCmd.Parameters.Add("pCOMENTARIO_ADI", vT_Sgpam_Maestra.COMENTARIO_ADI);
                    vCmd.Parameters.Add("pNUM_EUM", vT_Sgpam_Maestra.NUM_EUM);
                    vCmd.Parameters.Add("pID_ESTADO_REGISTRO", vT_Sgpam_Maestra.ID_ESTADO_REGISTRO);
                    vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpam_Maestra.USU_MODIFICA);
                    vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpam_Maestra.FEC_MODIFICA);
                    vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpam_Maestra.IP_MODIFICA);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpam_Maestra;
        }

        public int AnularT_Sgpam_MaestraPorCodigo(T_Sgpam_Maestra vT_Sgpam_Maestra)
        {
            int vResultado = 0;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_MAESTRA.USP_DEL_MAESTRA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_EUM", vT_Sgpam_Maestra.ID_EUM);
                    vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpam_Maestra.USU_MODIFICA);
                    vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpam_Maestra.FEC_MODIFICA);
                    vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpam_Maestra.IP_MODIFICA);
                    vCnn.Open();
                    vResultado = vCmd.ExecuteNonQuery();
                    vCnn.Close();
                    vResultado = (vResultado == -1) ? vResultado * -1 : vResultado;
                }
            }
            return vResultado;
        }

        public IEnumerable<T_Sgpam_Maestra> ListarPaginadoT_Sgpam_Maestra(string vFiltro, string vUbigeo, int vNumPag, int vCantRegxPag)
        {
            List<T_Sgpam_Maestra> vLista = new List<T_Sgpam_Maestra>();
            T_Sgpam_Maestra vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_MAESTRA.USP_LIS_PAG_MAESTRA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pFILTRO", vFiltro);
                    vCmd.Parameters.Add("pUBIGEO", vUbigeo);
                    vCmd.Parameters.Add("pNumPag", vNumPag);
                    vCmd.Parameters.Add("pCantRegxPag", vCantRegxPag);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpam_Maestra(vRdr);
                        //vEntidad.TotalVirtual = System.Convert.ToInt32(vRdr["TotalVirtual"]);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public IEnumerable<T_Sgpam_Maestra> ListarAutocompletarT_Sgpam_Maestra(string vFiltro)
        {
            List<T_Sgpam_Maestra> vLista = new List<T_Sgpam_Maestra>();
            T_Sgpam_Maestra vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_MAESTRA.USP_LIS_AUT_MAESTRA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pFILTRO", vFiltro);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpam_Maestra() {
                            ID_EUM = Convert.ToInt32(vRdr["ID_EUM"]),
                            EUM_DESCRIPCION = Convert.ToString(vRdr["EUM_DESCRIPCION"])
                        };
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

    }
}