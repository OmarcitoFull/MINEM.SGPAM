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
    /// Objetivo:	Clase que genera las operaciones para la tabla T_SGPAD_COMP_MEDICION
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	27/10/2021
    /// </summary>
    public partial class T_Sgpad_Comp_MedicionAD : BaseAD, IT_Sgpad_Comp_MedicionAD
    {
        public T_Sgpad_Comp_MedicionAD(IConfiguration vConfiguration)
        {
            CnnString = vConfiguration.GetSection(Constantes.BD).Value;
        }

        public IEnumerable<T_Sgpad_Comp_Medicion> ListarT_Sgpad_Comp_Medicion(int vIdComponente)
        {
            List<T_Sgpad_Comp_Medicion> vLista = new List<T_Sgpad_Comp_Medicion>();
            T_Sgpad_Comp_Medicion vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_MEDICION.USP_LIS_COMP_MEDICION", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_COMPONENTE", vIdComponente);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpad_Comp_Medicion(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public T_Sgpad_Comp_Medicion RecuperarT_Sgpad_Comp_MedicionPorCodigo(int vId_Comp_Medicion)
        {
            T_Sgpad_Comp_Medicion vEntidad = null;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_MEDICION.USP_SEL_COMP_MEDICION", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_COMP_MEDICION", vId_Comp_Medicion);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpad_Comp_Medicion(vRdr);
                    }
                }
                vCnn.Close();
            }
            return vEntidad;
        }

        public T_Sgpad_Comp_Medicion InsertarT_Sgpad_Comp_Medicion(T_Sgpad_Comp_Medicion vT_Sgpad_Comp_Medicion)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_MEDICION.USP_INS_COMP_MEDICION", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pOBSERVACION", vT_Sgpad_Comp_Medicion.OBSERVACION);
                    vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpad_Comp_Medicion.IP_MODIFICA);
                    vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpad_Comp_Medicion.IP_INGRESO);
                    vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpad_Comp_Medicion.FEC_MODIFICA);
                    vCmd.Parameters.Add("pCONDUCTIVIDAD", vT_Sgpad_Comp_Medicion.CONDUCTIVIDAD);
                    vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpad_Comp_Medicion.USU_MODIFICA);
                    vCmd.Parameters.Add("pCAUDAL", vT_Sgpad_Comp_Medicion.CAUDAL);
                    //vCmd.Parameters.Add("pID_COMP_MEDICION", vT_Sgpad_Comp_Medicion.ID_COMP_MEDICION);
                    vCmd.Parameters.Add("pPH", vT_Sgpad_Comp_Medicion.PH);
                    vCmd.Parameters.Add("pID_COMPONENTE", vT_Sgpad_Comp_Medicion.ID_COMPONENTE);
                    vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpad_Comp_Medicion.FLG_ESTADO);
                    vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpad_Comp_Medicion.USU_INGRESO);
                    vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpad_Comp_Medicion.FEC_INGRESO);
                    vCmd.Parameters.Add("pFECHA_DESICION", vT_Sgpad_Comp_Medicion.FECHA_DESICION);
                    vCmd.Parameters.Add(":pID_COMP_MEDICION", OracleDbType.Int64).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vT_Sgpad_Comp_Medicion.ID_COMP_MEDICION = Convert.ToInt32(vCmd.Parameters[":pID_COMP_MEDICION"].Value.ToString());
                    vCnn.Close();
                }
            }
            return vT_Sgpad_Comp_Medicion;
        }

        public T_Sgpad_Comp_Medicion ActualizarT_Sgpad_Comp_Medicion(T_Sgpad_Comp_Medicion vT_Sgpad_Comp_Medicion)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_MEDICION.USP_UPD_COMP_MEDICION", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pOBSERVACION", vT_Sgpad_Comp_Medicion.OBSERVACION);
                    vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpad_Comp_Medicion.IP_MODIFICA);
                    //vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpad_Comp_Medicion.IP_INGRESO);
                    vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpad_Comp_Medicion.FEC_MODIFICA);
                    vCmd.Parameters.Add("pCONDUCTIVIDAD", vT_Sgpad_Comp_Medicion.CONDUCTIVIDAD);
                    vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpad_Comp_Medicion.USU_MODIFICA);
                    vCmd.Parameters.Add("pCAUDAL", vT_Sgpad_Comp_Medicion.CAUDAL);
                    vCmd.Parameters.Add("pID_COMP_MEDICION", vT_Sgpad_Comp_Medicion.ID_COMP_MEDICION);
                    vCmd.Parameters.Add("pPH", vT_Sgpad_Comp_Medicion.PH);
                    vCmd.Parameters.Add("pID_COMPONENTE", vT_Sgpad_Comp_Medicion.ID_COMPONENTE);
                    vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpad_Comp_Medicion.FLG_ESTADO);
                    //vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpad_Comp_Medicion.USU_INGRESO);
                    //vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpad_Comp_Medicion.FEC_INGRESO);
                    vCmd.Parameters.Add("pFECHA_DESICION", vT_Sgpad_Comp_Medicion.FECHA_DESICION);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpad_Comp_Medicion;
        }

        public int AnularT_Sgpad_Comp_MedicionPorCodigo(int vId_Comp_Medicion)
        {
            int vResultado = 0;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_MEDICION.USP_DEL_COMP_MEDICION", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_COMP_MEDICION", vId_Comp_Medicion);
                    vCnn.Open();
                    vResultado = vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vResultado;
        }

        public IEnumerable<T_Sgpad_Comp_Medicion> ListarPaginadoT_Sgpad_Comp_Medicion(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            List<T_Sgpad_Comp_Medicion> vLista = new List<T_Sgpad_Comp_Medicion>();
            T_Sgpad_Comp_Medicion vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_MEDICION.USP_PAG_COMP_MEDICION", vCnn))
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
                        vEntidad = new T_Sgpad_Comp_Medicion(vRdr);
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