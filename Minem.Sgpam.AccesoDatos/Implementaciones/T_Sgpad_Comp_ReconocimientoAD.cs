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
    /// Objetivo:	Clase que genera las operaciones para la tabla T_SGPAD_COMP_RECONOCIMIENTO
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	27/10/2021
    /// </summary>
    public partial class T_Sgpad_Comp_ReconocimientoAD : BaseAD, IT_Sgpad_Comp_ReconocimientoAD
    {
        public T_Sgpad_Comp_ReconocimientoAD(IConfiguration vConfiguration)
        {
            CnnString = vConfiguration.GetSection(Constantes.BD).Value;
        }

        public IEnumerable<V_Sgpad_Comp_Reconocimiento> ListarT_Sgpad_Comp_Reconocimiento(int vIdComponente)
        {
            List<V_Sgpad_Comp_Reconocimiento> vLista = new List<V_Sgpad_Comp_Reconocimiento>();
            V_Sgpad_Comp_Reconocimiento vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_RECONOCIMIENTO.USP_LIS_COMP_RECONOCIMIENTO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_COMPONENTE", vIdComponente);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new V_Sgpad_Comp_Reconocimiento(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public T_Sgpad_Comp_Reconocimiento RecuperarT_Sgpad_Comp_ReconocimientoPorCodigo(int vId_Comp_Reconocimiento)
        {
            T_Sgpad_Comp_Reconocimiento vEntidad = null;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_RECONOCIMIENTO.USP_SEL_COMP_RECONOCIMIENTO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_COMP_RECONOCIMIENTO", vId_Comp_Reconocimiento);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpad_Comp_Reconocimiento(vRdr);
                    }
                }
                vCnn.Close();
            }
            return vEntidad;
        }

        public T_Sgpad_Comp_Reconocimiento InsertarT_Sgpad_Comp_Reconocimiento(T_Sgpad_Comp_Reconocimiento vT_Sgpad_Comp_Reconocimiento)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_RECONOCIMIENTO.USP_INS_COMP_RECONOCIMIENTO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pALTURA", vT_Sgpad_Comp_Reconocimiento.ALTURA);
                    vCmd.Parameters.Add("pID_TIPO_RECONOCIMIENTO", vT_Sgpad_Comp_Reconocimiento.ID_TIPO_RECONOCIMIENTO);
                    vCmd.Parameters.Add("pBASE", vT_Sgpad_Comp_Reconocimiento.BASE);
                    vCmd.Parameters.Add("pID_COMP_RECONOCIMIENTO", vT_Sgpad_Comp_Reconocimiento.ID_COMP_RECONOCIMIENTO);
                    vCmd.Parameters.Add("pANCHO", vT_Sgpad_Comp_Reconocimiento.ANCHO);
                    vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpad_Comp_Reconocimiento.USU_INGRESO);
                    vCmd.Parameters.Add("pID_TIPO_MINERIA", vT_Sgpad_Comp_Reconocimiento.ID_TIPO_MINERIA);
                    vCmd.Parameters.Add("pID_COMPONENTE", vT_Sgpad_Comp_Reconocimiento.ID_COMPONENTE);
                    vCmd.Parameters.Add("pVOLUMEN", vT_Sgpad_Comp_Reconocimiento.VOLUMEN);
                    vCmd.Parameters.Add("pLARGO", vT_Sgpad_Comp_Reconocimiento.LARGO);
                    vCmd.Parameters.Add("pCANTIDAD", vT_Sgpad_Comp_Reconocimiento.CANTIDAD);
                    vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpad_Comp_Reconocimiento.IP_MODIFICA);
                    vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpad_Comp_Reconocimiento.FLG_ESTADO);
                    vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpad_Comp_Reconocimiento.FEC_MODIFICA);
                    vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpad_Comp_Reconocimiento.IP_INGRESO);
                    vCmd.Parameters.Add("pPROFUNDIDAD", vT_Sgpad_Comp_Reconocimiento.PROFUNDIDAD);
                    vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpad_Comp_Reconocimiento.USU_MODIFICA);
                    vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpad_Comp_Reconocimiento.FEC_INGRESO);
                    vCmd.Parameters.Add("pAREA", vT_Sgpad_Comp_Reconocimiento.AREA);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpad_Comp_Reconocimiento;
        }

        public T_Sgpad_Comp_Reconocimiento ActualizarT_Sgpad_Comp_Reconocimiento(T_Sgpad_Comp_Reconocimiento vT_Sgpad_Comp_Reconocimiento)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_RECONOCIMIENTO.USP_UPD_COMP_RECONOCIMIENTO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pALTURA", vT_Sgpad_Comp_Reconocimiento.ALTURA);
                    vCmd.Parameters.Add("pID_TIPO_RECONOCIMIENTO", vT_Sgpad_Comp_Reconocimiento.ID_TIPO_RECONOCIMIENTO);
                    vCmd.Parameters.Add("pBASE", vT_Sgpad_Comp_Reconocimiento.BASE);
                    vCmd.Parameters.Add("pID_COMP_RECONOCIMIENTO", vT_Sgpad_Comp_Reconocimiento.ID_COMP_RECONOCIMIENTO);
                    vCmd.Parameters.Add("pANCHO", vT_Sgpad_Comp_Reconocimiento.ANCHO);
                    //vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpad_Comp_Reconocimiento.USU_INGRESO);
                    vCmd.Parameters.Add("pID_TIPO_MINERIA", vT_Sgpad_Comp_Reconocimiento.ID_TIPO_MINERIA);
                    vCmd.Parameters.Add("pID_COMPONENTE", vT_Sgpad_Comp_Reconocimiento.ID_COMPONENTE);
                    vCmd.Parameters.Add("pVOLUMEN", vT_Sgpad_Comp_Reconocimiento.VOLUMEN);
                    vCmd.Parameters.Add("pLARGO", vT_Sgpad_Comp_Reconocimiento.LARGO);
                    vCmd.Parameters.Add("pCANTIDAD", vT_Sgpad_Comp_Reconocimiento.CANTIDAD);
                    vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpad_Comp_Reconocimiento.IP_MODIFICA);
                    vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpad_Comp_Reconocimiento.FLG_ESTADO);
                    vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpad_Comp_Reconocimiento.FEC_MODIFICA);
                    //vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpad_Comp_Reconocimiento.IP_INGRESO);
                    vCmd.Parameters.Add("pPROFUNDIDAD", vT_Sgpad_Comp_Reconocimiento.PROFUNDIDAD);
                    vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpad_Comp_Reconocimiento.USU_MODIFICA);
                    //vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpad_Comp_Reconocimiento.FEC_INGRESO);
                    vCmd.Parameters.Add("pAREA", vT_Sgpad_Comp_Reconocimiento.AREA);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpad_Comp_Reconocimiento;
        }

        public int AnularT_Sgpad_Comp_ReconocimientoPorCodigo(int vId_Comp_Reconocimiento)
        {
            int vResultado = 0;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_RECONOCIMIENTO.USP_DEL_COMP_RECONOCIMIENTO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_COMP_RECONOCIMIENTO", vId_Comp_Reconocimiento);
                    vCnn.Open();
                    vResultado = vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vResultado;
        }

        public IEnumerable<T_Sgpad_Comp_Reconocimiento> ListarPaginadoT_Sgpad_Comp_Reconocimiento(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            List<T_Sgpad_Comp_Reconocimiento> vLista = new List<T_Sgpad_Comp_Reconocimiento>();
            T_Sgpad_Comp_Reconocimiento vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_RECONOCIMIENTO.USP_PAG_COMP_RECONOCIMIENTO", vCnn))
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
                        vEntidad = new T_Sgpad_Comp_Reconocimiento(vRdr);
                        vEntidad.TotalVirtual = System.Convert.ToInt32(vRdr["TotalVirtual"]);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public int InsertarT_Sgpad_Comp_Reconocimiento_Tipo(T_Sgpad_Comp_Reconocimiento vT_Sgpad_Comp_Reconocimiento, int? vIdTipoPam)
        {
            int vResult;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_RECONOCIMIENTO.USP_INS_RECONOCIMIENTO_TIPO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_COMPONENTE", vT_Sgpad_Comp_Reconocimiento.ID_COMPONENTE);
                    vCmd.Parameters.Add("pID_TIPO_PAM", vIdTipoPam);
                    vCmd.Parameters.Add("pID_TIPO_MINERIA", vT_Sgpad_Comp_Reconocimiento.ID_TIPO_MINERIA);
                    vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpad_Comp_Reconocimiento.USU_INGRESO);
                    vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpad_Comp_Reconocimiento.IP_INGRESO);
                    vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpad_Comp_Reconocimiento.FEC_INGRESO);
                    vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpad_Comp_Reconocimiento.USU_MODIFICA);
                    vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpad_Comp_Reconocimiento.IP_MODIFICA);
                    vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpad_Comp_Reconocimiento.FEC_MODIFICA);
                    vCnn.Open();
                    vResult = vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vResult;
        }

    }
}