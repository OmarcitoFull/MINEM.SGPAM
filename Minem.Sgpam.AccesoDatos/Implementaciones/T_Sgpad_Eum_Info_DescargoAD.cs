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
    /// Objetivo:	Clase que genera las operaciones para la tabla T_SGPAD_EUM_INFO_DESCARGO
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	27/10/2021
    /// </summary>
    public partial class T_Sgpad_Eum_Info_DescargoAD: BaseAD, IT_Sgpad_Eum_Info_DescargoAD
    {
        public T_Sgpad_Eum_Info_DescargoAD(IConfiguration vConfiguration)
        {
            CnnString = vConfiguration.GetSection(Constantes.BD).Value;
        }

        public IEnumerable<T_Sgpad_Eum_Info_Descargo> ListarT_Sgpad_Eum_Info_Descargo()
        {
           List<T_Sgpad_Eum_Info_Descargo> vLista = new List<T_Sgpad_Eum_Info_Descargo>();
           T_Sgpad_Eum_Info_Descargo vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_EUM_INFO_DESCARGO.USP_LIS_EUM_INFO_DESCARGO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpad_Eum_Info_Descargo(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public T_Sgpad_Eum_Info_Descargo RecuperarT_Sgpad_Eum_Info_DescargoPorCodigo(int vId_Eum_Info_Descargo)
        {
           T_Sgpad_Eum_Info_Descargo vEntidad = null;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_EUM_INFO_DESCARGO.USP_SEL_EUM_INFO_DESCARGO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_EUM_INFO_DESCARGO", vId_Eum_Info_Descargo);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpad_Eum_Info_Descargo(vRdr);
                    }
                }
                vCnn.Close();
            }
            return vEntidad;
        }

        public T_Sgpad_Eum_Info_Descargo InsertarT_Sgpad_Eum_Info_Descargo(T_Sgpad_Eum_Info_Descargo vT_Sgpad_Eum_Info_Descargo)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_EUM_INFO_DESCARGO.USP_INS_EUM_INFO_DESCARGO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    //vCmd.Parameters.Add("pID_EUM_INFO_DESCARGO", vT_Sgpad_Eum_Info_Descargo.ID_EUM_INFO_DESCARGO);
                    vCmd.Parameters.Add("pID_EUM", vT_Sgpad_Eum_Info_Descargo.ID_EUM);
                    vCmd.Parameters.Add("pFECHA_DESCARGO", vT_Sgpad_Eum_Info_Descargo.FECHA_DESCARGO);
                    vCmd.Parameters.Add("pTITULAR", vT_Sgpad_Eum_Info_Descargo.TITULAR); 
				    vCmd.Parameters.Add("pDECLARACION", vT_Sgpad_Eum_Info_Descargo.DECLARACION);
                    vCmd.Parameters.Add("pASUNTO", vT_Sgpad_Eum_Info_Descargo.ASUNTO);
                    vCmd.Parameters.Add("pNOMBRE_DOCUMENTO", vT_Sgpad_Eum_Info_Descargo.NOMBRE_DOCUMENTO);
                    vCmd.Parameters.Add("pRUTA_DOCUMENTO", vT_Sgpad_Eum_Info_Descargo.RUTA_DOCUMENTO);
                    vCmd.Parameters.Add("pEXTENCION", vT_Sgpad_Eum_Info_Descargo.EXTENCION); 
				    vCmd.Parameters.Add("pTAMANO", vT_Sgpad_Eum_Info_Descargo.TAMANO); 
                    vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpad_Eum_Info_Descargo.USU_INGRESO);
                    vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpad_Eum_Info_Descargo.FEC_INGRESO);
                    vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpad_Eum_Info_Descargo.IP_INGRESO);
                    vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpad_Eum_Info_Descargo.FLG_ESTADO);
                    vCmd.Parameters.Add(":pID_EUM_INFO_DESCARGO", OracleDbType.Int64).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vT_Sgpad_Eum_Info_Descargo.ID_EUM_INFO_DESCARGO = Convert.ToInt32(vCmd.Parameters[":pID_EUM_INFO_DESCARGO"].Value.ToString());
                    vCnn.Close();
                }
            }
            return vT_Sgpad_Eum_Info_Descargo;
        }
        
        public T_Sgpad_Eum_Info_Descargo ActualizarT_Sgpad_Eum_Info_Descargo(T_Sgpad_Eum_Info_Descargo vT_Sgpad_Eum_Info_Descargo)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_EUM_INFO_DESCARGO.USP_UPD_EUM_INFO_DESCARGO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_EUM_INFO_DESCARGO", vT_Sgpad_Eum_Info_Descargo.ID_EUM_INFO_DESCARGO);
                    vCmd.Parameters.Add("pFECHA_DESCARGO", vT_Sgpad_Eum_Info_Descargo.FECHA_DESCARGO);
                    vCmd.Parameters.Add("pTITULAR", vT_Sgpad_Eum_Info_Descargo.TITULAR);
                    vCmd.Parameters.Add("pDECLARACION", vT_Sgpad_Eum_Info_Descargo.DECLARACION);
                    vCmd.Parameters.Add("pASUNTO", vT_Sgpad_Eum_Info_Descargo.ASUNTO);
                    vCmd.Parameters.Add("pNOMBRE_DOCUMENTO", vT_Sgpad_Eum_Info_Descargo.NOMBRE_DOCUMENTO);
                    vCmd.Parameters.Add("pRUTA_DOCUMENTO", vT_Sgpad_Eum_Info_Descargo.RUTA_DOCUMENTO);
                    vCmd.Parameters.Add("pEXTENCION", vT_Sgpad_Eum_Info_Descargo.EXTENCION);
                    vCmd.Parameters.Add("pTAMANO", vT_Sgpad_Eum_Info_Descargo.TAMANO);
                    vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpad_Eum_Info_Descargo.USU_MODIFICA);
                    vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpad_Eum_Info_Descargo.FEC_MODIFICA);
                    vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpad_Eum_Info_Descargo.IP_MODIFICA);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpad_Eum_Info_Descargo;
        }

        public int AnularT_Sgpad_Eum_Info_DescargoPorCodigo(int vId_Eum_Info_Descargo)
        {
            int vResultado = 0;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_EUM_INFO_DESCARGO.USP_DEL_EUM_INFO_DESCARGO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_EUM_INFO_DESCARGO", vId_Eum_Info_Descargo);
                    vCnn.Open();
                    vResultado = vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vResultado;
        }

        public IEnumerable<T_Sgpad_Eum_Info_Descargo> ListarPaginadoT_Sgpad_Eum_Info_Descargo(string vFiltro, int vNumPag, int vCantRegxPag)
        {
           List<T_Sgpad_Eum_Info_Descargo> vLista = new List<T_Sgpad_Eum_Info_Descargo>();
           T_Sgpad_Eum_Info_Descargo vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_EUM_INFO_DESCARGO.USP_PAG_EUM_INFO_DESCARGO", vCnn))
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
                        vEntidad = new T_Sgpad_Eum_Info_Descargo(vRdr);
                        vEntidad.TotalVirtual = System.Convert.ToInt32(vRdr["TotalVirtual"]);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public IEnumerable<T_Sgpad_Eum_Info_Descargo> ListarPorIdEumT_Sgpad_Eum_Info_Descargo(int vId_Eum)
        {
            List<T_Sgpad_Eum_Info_Descargo> vLista = new List<T_Sgpad_Eum_Info_Descargo>();
            T_Sgpad_Eum_Info_Descargo vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_EUM_INFO_DESCARGO.USP_LIS_POR_IDEUM_EUM_INFO_DESCARGO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_EUM", vId_Eum);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();

                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpad_Eum_Info_Descargo(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }
    }
}