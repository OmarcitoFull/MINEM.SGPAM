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
    /// Objetivo:	Clase que genera las operaciones para la tabla T_SGPAD_EUM_INFO_GRAFICA
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	27/10/2021
    /// </summary>
    public partial class T_Sgpad_Eum_Info_GraficaAD: BaseAD, IT_Sgpad_Eum_Info_GraficaAD
    {
        public T_Sgpad_Eum_Info_GraficaAD(IConfiguration vConfiguration)
        {
            CnnString = vConfiguration.GetSection(Constantes.BD).Value;
        }

        public IEnumerable<T_Sgpad_Eum_Info_Grafica> ListarT_Sgpad_Eum_Info_Grafica()
        {
           List<T_Sgpad_Eum_Info_Grafica> vLista = new List<T_Sgpad_Eum_Info_Grafica>();
           T_Sgpad_Eum_Info_Grafica vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_EUM_INFO_GRAFICA.USP_LIS_EUM_INFO_GRAFICA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpad_Eum_Info_Grafica(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public T_Sgpad_Eum_Info_Grafica RecuperarT_Sgpad_Eum_Info_GraficaPorCodigo(int vId_Eum_Info_Grafica)
        {
           T_Sgpad_Eum_Info_Grafica vEntidad = null;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_EUM_INFO_GRAFICA.USP_SEL_EUM_INFO_GRAFICA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_EUM_INFO_GRAFICA", vId_Eum_Info_Grafica);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpad_Eum_Info_Grafica(vRdr);
                    }
                }
                vCnn.Close();
            }
            return vEntidad;
        }

        public T_Sgpad_Eum_Info_Grafica InsertarT_Sgpad_Eum_Info_Grafica(T_Sgpad_Eum_Info_Grafica vT_Sgpad_Eum_Info_Grafica)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_EUM_INFO_GRAFICA.USP_INS_EUM_INFO_GRAFICA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    //vCmd.Parameters.Add("pID_EUM_INFO_GRAFICA", vT_Sgpad_Eum_Info_Grafica.ID_EUM_INFO_GRAFICA); 
                    vCmd.Parameters.Add("pID_EUM", vT_Sgpad_Eum_Info_Grafica.ID_EUM);
                    vCmd.Parameters.Add("pDESCRIPCION", vT_Sgpad_Eum_Info_Grafica.DESCRIPCION);
                    vCmd.Parameters.Add("pNOMBRE_IMAGEN", vT_Sgpad_Eum_Info_Grafica.NOMBRE_IMAGEN);
                    vCmd.Parameters.Add("pRUTA_IMAGEN", vT_Sgpad_Eum_Info_Grafica.RUTA_IMAGEN); 
				    vCmd.Parameters.Add("pEXTENCION", vT_Sgpad_Eum_Info_Grafica.EXTENCION); 
				    vCmd.Parameters.Add("pTAMANO", vT_Sgpad_Eum_Info_Grafica.TAMANO);
                    vCmd.Parameters.Add("pFECHA_TOMA", vT_Sgpad_Eum_Info_Grafica.FECHA_TOMA);
                    vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpad_Eum_Info_Grafica.USU_INGRESO);
                    vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpad_Eum_Info_Grafica.FEC_INGRESO);
                    vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpad_Eum_Info_Grafica.IP_INGRESO);
                    vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpad_Eum_Info_Grafica.FLG_ESTADO);
                    vCmd.Parameters.Add(":pID_EUM_INFO_GRAFICA", OracleDbType.Int64).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vT_Sgpad_Eum_Info_Grafica.ID_EUM_INFO_GRAFICA =   Convert.ToInt32(vCmd.Parameters[":pID_EUM_INFO_GRAFICA"].Value.ToString());
                    vCnn.Close();
                }
            }
            return vT_Sgpad_Eum_Info_Grafica;
        }
        
        public T_Sgpad_Eum_Info_Grafica ActualizarT_Sgpad_Eum_Info_Grafica(T_Sgpad_Eum_Info_Grafica vT_Sgpad_Eum_Info_Grafica)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_EUM_INFO_GRAFICA.USP_UPD_EUM_INFO_GRAFICA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_EUM_INFO_GRAFICA", vT_Sgpad_Eum_Info_Grafica.ID_EUM_INFO_GRAFICA);
                    vCmd.Parameters.Add("pNOMBRE_IMAGEN", vT_Sgpad_Eum_Info_Grafica.NOMBRE_IMAGEN);
                    vCmd.Parameters.Add("pRUTA_IMAGEN", vT_Sgpad_Eum_Info_Grafica.RUTA_IMAGEN);
                    vCmd.Parameters.Add("pEXTENCION", vT_Sgpad_Eum_Info_Grafica.EXTENCION);
                    vCmd.Parameters.Add("pTAMANO", vT_Sgpad_Eum_Info_Grafica.TAMANO);
                    vCmd.Parameters.Add("pFECHA_TOMA", vT_Sgpad_Eum_Info_Grafica.FECHA_TOMA);
                    vCmd.Parameters.Add("pDESCRIPCION", vT_Sgpad_Eum_Info_Grafica.DESCRIPCION);
                    vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpad_Eum_Info_Grafica.USU_MODIFICA);
                    vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpad_Eum_Info_Grafica.FEC_MODIFICA);
                    vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpad_Eum_Info_Grafica.IP_MODIFICA);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpad_Eum_Info_Grafica;
        }

        public int AnularT_Sgpad_Eum_Info_GraficaPorCodigo(int vId_Eum_Info_Grafica)
        {
            int vResultado = 0;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_EUM_INFO_GRAFICA.USP_DEL_EUM_INFO_GRAFICA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_EUM_INFO_GRAFICA", vId_Eum_Info_Grafica);
                    vCnn.Open();
                    vResultado = vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vResultado;
        }

        public IEnumerable<T_Sgpad_Eum_Info_Grafica> ListarPaginadoT_Sgpad_Eum_Info_Grafica(string vFiltro, int vNumPag, int vCantRegxPag)
        {
           List<T_Sgpad_Eum_Info_Grafica> vLista = new List<T_Sgpad_Eum_Info_Grafica>();
           T_Sgpad_Eum_Info_Grafica vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_EUM_INFO_GRAFICA.USP_PAG_EUM_INFO_GRAFICA", vCnn))
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
                        vEntidad = new T_Sgpad_Eum_Info_Grafica(vRdr);
                        vEntidad.TotalVirtual = System.Convert.ToInt32(vRdr["TotalVirtual"]);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

                                    
        public IEnumerable<T_Sgpad_Eum_Info_Grafica> ListarPorIdEumT_Sgpad_Eum_Info_Grafica(int vId_Eum)
        {
            List<T_Sgpad_Eum_Info_Grafica> vLista = new List<T_Sgpad_Eum_Info_Grafica>();
            T_Sgpad_Eum_Info_Grafica vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_EUM_INFO_GRAFICA.USP_LIS_POR_IDEUM_EUM_INFO_GRAFICA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_EUM", vId_Eum);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();

                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpad_Eum_Info_Grafica(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

    }
}