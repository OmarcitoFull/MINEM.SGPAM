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
    /// Objetivo:	Clase que genera las operaciones para la tabla T_SGPAD_EUM_INFORME
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	27/10/2021
    /// </summary>
    public partial class T_Sgpad_Eum_InformeAD : BaseAD, IT_Sgpad_Eum_InformeAD
    {
        public T_Sgpad_Eum_InformeAD(IConfiguration vConfiguration)
        {
            CnnString = vConfiguration.GetSection(Constantes.BD).Value;
        }

        public IEnumerable<T_Sgpad_Eum_Informe> ListarT_Sgpad_Eum_Informe()
        {
            List<T_Sgpad_Eum_Informe> vLista = new List<T_Sgpad_Eum_Informe>();
            T_Sgpad_Eum_Informe vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_EUM_INFORME.USP_LIS_EUM_INFORME", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpad_Eum_Informe(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public T_Sgpad_Eum_Informe RecuperarT_Sgpad_Eum_InformePorCodigo(int vId_Eum_Informe)
        {
            T_Sgpad_Eum_Informe vEntidad = null;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_EUM_INFORME.USP_SEL_EUM_INFORME", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_EUM_INFORME", vId_Eum_Informe);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpad_Eum_Informe(vRdr);
                    }
                }
                vCnn.Close();
            }
            return vEntidad;
        }

        public T_Sgpad_Eum_Informe InsertarT_Sgpad_Eum_Informe(T_Sgpad_Eum_Informe vT_Sgpad_Eum_Informe)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_EUM_INFORME.USP_INS_EUM_INFORME", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_EUM", vT_Sgpad_Eum_Informe.ID_EUM);
                    vCmd.Parameters.Add("pNRO_EXPEDIENTE", vT_Sgpad_Eum_Informe.NRO_EXPEDIENTE);
                    vCmd.Parameters.Add("pNRO_INFORME", vT_Sgpad_Eum_Informe.NRO_INFORME);
                    vCmd.Parameters.Add("pDESCRIPCION", vT_Sgpad_Eum_Informe.DESCRIPCION);
                    vCmd.Parameters.Add("pFECHA_INFORME", vT_Sgpad_Eum_Informe.FECHA_INFORME);
                    vCmd.Parameters.Add("pNOMBRE_INFORME", vT_Sgpad_Eum_Informe.NOMBRE_INFORME);
                    vCmd.Parameters.Add("pRUTA_INFORME", vT_Sgpad_Eum_Informe.RUTA_INFORME);
                    vCmd.Parameters.Add("pTAMANO", vT_Sgpad_Eum_Informe.TAMANO);
                    vCmd.Parameters.Add("pID_LASERFICHE", vT_Sgpad_Eum_Informe.ID_LASERFICHE);
                    vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpad_Eum_Informe.USU_INGRESO);
                    vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpad_Eum_Informe.FEC_INGRESO);
                    vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpad_Eum_Informe.IP_INGRESO);
                    vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpad_Eum_Informe.FLG_ESTADO);
                    vCmd.Parameters.Add(":pID_EUM_INFORME", OracleDbType.Int64).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vT_Sgpad_Eum_Informe.ID_EUM_INFORME = Convert.ToInt32(vCmd.Parameters[":pID_EUM_INFORME"].Value.ToString());
                    vCnn.Close();
                }
            }
            return vT_Sgpad_Eum_Informe;
        }

        public T_Sgpad_Eum_Informe ActualizarT_Sgpad_Eum_Informe(T_Sgpad_Eum_Informe vT_Sgpad_Eum_Informe)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_EUM_INFORME.USP_UPD_EUM_INFORME", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_EUM_INFORME", vT_Sgpad_Eum_Informe.ID_EUM_INFORME);
                    vCmd.Parameters.Add("pNRO_EXPEDIENTE", vT_Sgpad_Eum_Informe.NRO_EXPEDIENTE);
                    vCmd.Parameters.Add("pNRO_INFORME", vT_Sgpad_Eum_Informe.NRO_INFORME);
                    vCmd.Parameters.Add("pDESCRIPCION", vT_Sgpad_Eum_Informe.DESCRIPCION);
                    vCmd.Parameters.Add("pFECHA_INFORME", vT_Sgpad_Eum_Informe.FECHA_INFORME);
                    vCmd.Parameters.Add("pNOMBRE_INFORME", vT_Sgpad_Eum_Informe.NOMBRE_INFORME);
                    vCmd.Parameters.Add("pRUTA_INFORME", vT_Sgpad_Eum_Informe.RUTA_INFORME);
                    vCmd.Parameters.Add("pTAMANO", vT_Sgpad_Eum_Informe.TAMANO);
                    vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpad_Eum_Informe.USU_MODIFICA);
                    vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpad_Eum_Informe.FEC_MODIFICA);
                    vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpad_Eum_Informe.IP_MODIFICA);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpad_Eum_Informe;
        }

        public int AnularT_Sgpad_Eum_InformePorCodigo(T_Sgpad_Eum_Informe vT_Sgpad_Eum_Informe)
        {
            int vResultado = 0;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_EUM_INFORME.USP_DEL_EUM_INFORME", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_EUM_INFORME", vT_Sgpad_Eum_Informe.ID_EUM_INFORME);
                    vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpad_Eum_Informe.USU_MODIFICA);
                    vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpad_Eum_Informe.FEC_MODIFICA);
                    vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpad_Eum_Informe.IP_MODIFICA);
                    vCnn.Open();
                    vResultado = vCmd.ExecuteNonQuery();
                    vCnn.Close();
                    vResultado = (vResultado == -1) ? vResultado * -1 : vResultado;
                }
            }
            return vResultado;
        }

        public IEnumerable<T_Sgpad_Eum_Informe> ListarPaginadoT_Sgpad_Eum_Informe(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            List<T_Sgpad_Eum_Informe> vLista = new List<T_Sgpad_Eum_Informe>();
            T_Sgpad_Eum_Informe vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_EUM_INFORME.USP_PAG_EUM_INFORME", vCnn))
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
                        vEntidad = new T_Sgpad_Eum_Informe(vRdr);
                        //vEntidad.TotalVirtual = System.Convert.ToInt32(vRdr["TotalVirtual"]);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public IEnumerable<T_Sgpad_Eum_Informe> ListarPorIdEumT_Sgpad_Eum_Informe(int vId_Eum)
        {
            List<T_Sgpad_Eum_Informe> vLista = new List<T_Sgpad_Eum_Informe>();
            T_Sgpad_Eum_Informe vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_EUM_INFORME.USP_LIS_POR_IDEUM_EUM_INFORME", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_EUM", vId_Eum);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();

                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpad_Eum_Informe(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

    }
}