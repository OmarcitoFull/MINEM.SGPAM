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
    /// Objetivo:	Clase que genera las operaciones para la tabla T_SGPAD_COMP_REAPRO
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	27/10/2021
    /// </summary>
    public partial class T_Sgpad_Comp_ReaproAD : BaseAD, IT_Sgpad_Comp_ReaproAD
    {
        public T_Sgpad_Comp_ReaproAD(IConfiguration vConfiguration)
        {
            CnnString = vConfiguration.GetSection(Constantes.BD).Value;
        }

        public IEnumerable<T_Sgpad_Comp_Reapro> ListarT_Sgpad_Comp_Reapro(int vIdComponente)
        {
            List<T_Sgpad_Comp_Reapro> vLista = new List<T_Sgpad_Comp_Reapro>();
            T_Sgpad_Comp_Reapro vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_REAPRO.USP_LIS_COMP_REAPRO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_COMPONENTE", vIdComponente);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpad_Comp_Reapro(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public T_Sgpad_Comp_Reapro RecuperarT_Sgpad_Comp_ReaproPorCodigo(int vId_Comp_Reapro)
        {
            T_Sgpad_Comp_Reapro vEntidad = null;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_REAPRO.USP_SEL_COMP_REAPRO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_COMP_REAPRO", vId_Comp_Reapro);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpad_Comp_Reapro(vRdr);
                    }
                }
                vCnn.Close();
            }
            return vEntidad;
        }

        public T_Sgpad_Comp_Reapro InsertarT_Sgpad_Comp_Reapro(T_Sgpad_Comp_Reapro vT_Sgpad_Comp_Reapro)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_REAPRO.USP_INS_COMP_REAPRO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pNOMBRE_PROYECTO", vT_Sgpad_Comp_Reapro.NOMBRE_PROYECTO);
                    vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpad_Comp_Reapro.IP_INGRESO);
                    vCmd.Parameters.Add("pFECHA_EXPEDIENTE", vT_Sgpad_Comp_Reapro.FECHA_EXPEDIENTE);
                    vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpad_Comp_Reapro.FLG_ESTADO);
                    vCmd.Parameters.Add("pFECHA_RESOLUCION", vT_Sgpad_Comp_Reapro.FECHA_RESOLUCION);
                    vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpad_Comp_Reapro.FEC_MODIFICA);
                    vCmd.Parameters.Add("pNRO_EXPEDIENTE", vT_Sgpad_Comp_Reapro.NRO_EXPEDIENTE);
                    //vCmd.Parameters.Add("pID_COMP_REAPRO", vT_Sgpad_Comp_Reapro.ID_COMP_REAPRO);
                    vCmd.Parameters.Add("pID_COMPONENTE", vT_Sgpad_Comp_Reapro.ID_COMPONENTE);
                    vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpad_Comp_Reapro.USU_INGRESO);
                    vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpad_Comp_Reapro.IP_MODIFICA);
                    vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpad_Comp_Reapro.USU_MODIFICA);
                    vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpad_Comp_Reapro.FEC_INGRESO);
                    vCmd.Parameters.Add("pRESOLUCION_REAPRO", vT_Sgpad_Comp_Reapro.RESOLUCION_REAPRO);
                    vCmd.Parameters.Add("pTITULAR", vT_Sgpad_Comp_Reapro.TITULAR);
                    vCmd.Parameters.Add(":pID_COMP_REAPRO", OracleDbType.Int64).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vT_Sgpad_Comp_Reapro.ID_COMP_REAPRO = Convert.ToInt32(vCmd.Parameters[":pID_COMP_REAPRO"].Value.ToString());
                    vCnn.Close();
                }
            }
            return vT_Sgpad_Comp_Reapro;
        }

        public T_Sgpad_Comp_Reapro ActualizarT_Sgpad_Comp_Reapro(T_Sgpad_Comp_Reapro vT_Sgpad_Comp_Reapro)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_REAPRO.USP_UPD_COMP_REAPRO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pNOMBRE_PROYECTO", vT_Sgpad_Comp_Reapro.NOMBRE_PROYECTO);
                    //vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpad_Comp_Reapro.IP_INGRESO);
                    vCmd.Parameters.Add("pFECHA_EXPEDIENTE", vT_Sgpad_Comp_Reapro.FECHA_EXPEDIENTE);
                    vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpad_Comp_Reapro.FLG_ESTADO);
                    vCmd.Parameters.Add("pFECHA_RESOLUCION", vT_Sgpad_Comp_Reapro.FECHA_RESOLUCION);
                    vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpad_Comp_Reapro.FEC_MODIFICA);
                    vCmd.Parameters.Add("pNRO_EXPEDIENTE", vT_Sgpad_Comp_Reapro.NRO_EXPEDIENTE);
                    vCmd.Parameters.Add("pID_COMP_REAPRO", vT_Sgpad_Comp_Reapro.ID_COMP_REAPRO);
                    vCmd.Parameters.Add("pID_COMPONENTE", vT_Sgpad_Comp_Reapro.ID_COMPONENTE);
                    //vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpad_Comp_Reapro.USU_INGRESO);
                    vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpad_Comp_Reapro.IP_MODIFICA);
                    vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpad_Comp_Reapro.USU_MODIFICA);
                    //vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpad_Comp_Reapro.FEC_INGRESO);
                    vCmd.Parameters.Add("pRESOLUCION_REAPRO", vT_Sgpad_Comp_Reapro.RESOLUCION_REAPRO);
                    vCmd.Parameters.Add("pTITULAR", vT_Sgpad_Comp_Reapro.TITULAR);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpad_Comp_Reapro;
        }

        public int AnularT_Sgpad_Comp_ReaproPorCodigo(int vId_Comp_Reapro)
        {
            int vResultado = 0;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_REAPRO.USP_DEL_COMP_REAPRO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_COMP_REAPRO", vId_Comp_Reapro);
                    vCnn.Open();
                    vResultado = vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vResultado;
        }

        public IEnumerable<T_Sgpad_Comp_Reapro> ListarPaginadoT_Sgpad_Comp_Reapro(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            List<T_Sgpad_Comp_Reapro> vLista = new List<T_Sgpad_Comp_Reapro>();
            T_Sgpad_Comp_Reapro vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_REAPRO.USP_PAG_COMP_REAPRO", vCnn))
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
                        vEntidad = new T_Sgpad_Comp_Reapro(vRdr);
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