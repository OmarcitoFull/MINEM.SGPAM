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
    /// Objetivo:	Clase que genera las operaciones para la tabla T_SGPAD_COMP_OBSERVACION
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	27/10/2021
    /// </summary>
    public partial class T_Sgpad_Comp_ObservacionAD : BaseAD, IT_Sgpad_Comp_ObservacionAD
    {
        public T_Sgpad_Comp_ObservacionAD(IConfiguration vConfiguration)
        {
            CnnString = vConfiguration.GetSection(Constantes.BD).Value;
        }

        public IEnumerable<T_Sgpad_Comp_Observacion> ListarT_Sgpad_Comp_Observacion(int vIdComponente)
        {
            List<T_Sgpad_Comp_Observacion> vLista = new List<T_Sgpad_Comp_Observacion>();
            T_Sgpad_Comp_Observacion vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_OBSERVACION.USP_LIS_COMP_OBSERVACION", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_COMPONENTE", vIdComponente);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpad_Comp_Observacion(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public T_Sgpad_Comp_Observacion RecuperarT_Sgpad_Comp_ObservacionPorCodigo(int vId_Comp_Observacion)
        {
            T_Sgpad_Comp_Observacion vEntidad = null;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_OBSERVACION.USP_SEL_COMP_OBSERVACION", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_COMP_OBSERVACION", vId_Comp_Observacion);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpad_Comp_Observacion(vRdr);
                    }
                }
                vCnn.Close();
            }
            return vEntidad;
        }

        public T_Sgpad_Comp_Observacion InsertarT_Sgpad_Comp_Observacion(T_Sgpad_Comp_Observacion vT_Sgpad_Comp_Observacion)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_OBSERVACION.USP_INS_COMP_OBSERVACION", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpad_Comp_Observacion.IP_INGRESO);
                    vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpad_Comp_Observacion.FEC_MODIFICA);
                    vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpad_Comp_Observacion.USU_MODIFICA);
                    vCmd.Parameters.Add("pSUELOS_DISTURBADOS", vT_Sgpad_Comp_Observacion.SUELOS_DISTURBADOS);
                    //vCmd.Parameters.Add("pID_COMP_OBSERVACION", vT_Sgpad_Comp_Observacion.ID_COMP_OBSERVACION);
                    vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpad_Comp_Observacion.USU_INGRESO);
                    vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpad_Comp_Observacion.FEC_INGRESO);
                    vCmd.Parameters.Add("pOBRAS_REHABILITACION", vT_Sgpad_Comp_Observacion.OBRAS_REHABILITACION);
                    vCmd.Parameters.Add("pDESCRIPCION_COMP", vT_Sgpad_Comp_Observacion.DESCRIPCION_COMP);
                    vCmd.Parameters.Add("pFECHA", vT_Sgpad_Comp_Observacion.FECHA);
                    vCmd.Parameters.Add("pID_COMPONENTE", vT_Sgpad_Comp_Observacion.ID_COMPONENTE);
                    vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpad_Comp_Observacion.IP_MODIFICA);
                    vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpad_Comp_Observacion.FLG_ESTADO);
                    vCmd.Parameters.Add(":pID_COMP_OBSERVACION", OracleDbType.Int64).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vT_Sgpad_Comp_Observacion.ID_COMP_OBSERVACION = Convert.ToInt32(vCmd.Parameters[":pID_COMP_OBSERVACION"].Value.ToString());
                    vCnn.Close();
                }
            }
            return vT_Sgpad_Comp_Observacion;
        }

        public T_Sgpad_Comp_Observacion ActualizarT_Sgpad_Comp_Observacion(T_Sgpad_Comp_Observacion vT_Sgpad_Comp_Observacion)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_OBSERVACION.USP_UPD_COMP_OBSERVACION", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pFECHA", vT_Sgpad_Comp_Observacion.FECHA);
                    //vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpad_Comp_Observacion.IP_INGRESO);
                    vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpad_Comp_Observacion.FEC_MODIFICA);
                    vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpad_Comp_Observacion.USU_MODIFICA);
                    vCmd.Parameters.Add("pSUELOS_DISTURBADOS", vT_Sgpad_Comp_Observacion.SUELOS_DISTURBADOS);
                    vCmd.Parameters.Add("pID_COMP_OBSERVACION", vT_Sgpad_Comp_Observacion.ID_COMP_OBSERVACION);
                    vCmd.Parameters.Add("pDESCRIPCION_COMP", vT_Sgpad_Comp_Observacion.DESCRIPCION_COMP);
                    //vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpad_Comp_Observacion.USU_INGRESO);
                    //vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpad_Comp_Observacion.FEC_INGRESO);
                    vCmd.Parameters.Add("pOBRAS_REHABILITACION", vT_Sgpad_Comp_Observacion.OBRAS_REHABILITACION);
                    vCmd.Parameters.Add("pID_COMPONENTE", vT_Sgpad_Comp_Observacion.ID_COMPONENTE);
                    vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpad_Comp_Observacion.IP_MODIFICA);
                    vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpad_Comp_Observacion.FLG_ESTADO);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpad_Comp_Observacion;
        }

        public int AnularT_Sgpad_Comp_ObservacionPorCodigo(int vId_Comp_Observacion)
        {
            int vResultado = 0;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_OBSERVACION.USP_DEL_COMP_OBSERVACION", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_COMP_OBSERVACION", vId_Comp_Observacion);
                    vCnn.Open();
                    vResultado = vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vResultado;
        }

        public IEnumerable<T_Sgpad_Comp_Observacion> ListarPaginadoT_Sgpad_Comp_Observacion(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            List<T_Sgpad_Comp_Observacion> vLista = new List<T_Sgpad_Comp_Observacion>();
            T_Sgpad_Comp_Observacion vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_OBSERVACION.USP_PAG_COMP_OBSERVACION", vCnn))
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
                        vEntidad = new T_Sgpad_Comp_Observacion(vRdr);
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