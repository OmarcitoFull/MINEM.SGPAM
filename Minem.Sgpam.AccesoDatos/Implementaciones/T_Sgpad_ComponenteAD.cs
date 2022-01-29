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
    /// Objetivo:	Clase que genera las operaciones para la tabla T_SGPAD_COMPONENTE
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	27/10/2021
    /// </summary>
    public partial class T_Sgpad_ComponenteAD : BaseAD, IT_Sgpad_ComponenteAD
    {
        public T_Sgpad_ComponenteAD(IConfiguration vConfiguration)
        {
            CnnString = vConfiguration.GetSection(Constantes.BD).Value;
        }

        public IEnumerable<T_Sgpad_Componente> ListarT_Sgpad_Componente()
        {
            List<T_Sgpad_Componente> vLista = new List<T_Sgpad_Componente>();
            T_Sgpad_Componente vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMPONENTE.USP_LIS_COMPONENTE", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpad_Componente(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public T_Sgpad_Componente RecuperarT_Sgpad_ComponentePorCodigo(int vId_Componente)
        {
            T_Sgpad_Componente vEntidad = null;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMPONENTE.USP_SEL_COMPONENTE", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_COMPONENTE", vId_Componente);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpad_Componente(vRdr);
                    }
                }
                vCnn.Close();
            }
            return vEntidad;
        }

        public T_Sgpad_Componente InsertarT_Sgpad_Componente(T_Sgpad_Componente vT_Sgpad_Componente)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMPONENTE.USP_INS_COMPONENTE", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_DATUM", vT_Sgpad_Componente.ID_DATUM);
                    vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpad_Componente.USU_INGRESO);
                    vCmd.Parameters.Add("pID_HUMEDAD", vT_Sgpad_Componente.ID_HUMEDAD);
                    vCmd.Parameters.Add("pID_EUM", vT_Sgpad_Componente.ID_EUM);
                    vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpad_Componente.FEC_MODIFICA);
                    vCmd.Parameters.Add("pID_TAMANO_PARTICULA", vT_Sgpad_Componente.ID_TAMANO_PARTICULA);
                    vCmd.Parameters.Add("pNOMBRE", vT_Sgpad_Componente.NOMBRE);
                    vCmd.Parameters.Add("pOTRO_DESCRIPCION", vT_Sgpad_Componente.OTRO_DESCRIPCION);
                    vCmd.Parameters.Add("pID_TIPO_MINERIA", vT_Sgpad_Componente.ID_TIPO_MINERIA);
                    vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpad_Componente.FLG_ESTADO);
                    //vCmd.Parameters.Add("pID_COMPONENTE", vT_Sgpad_Componente.ID_COMPONENTE);
                    vCmd.Parameters.Add("pID_CUENCA", vT_Sgpad_Componente.ID_CUENCA);
                    vCmd.Parameters.Add("pPUNTAJE_NORMALIZADO", vT_Sgpad_Componente.PUNTAJE_NORMALIZADO);
                    vCmd.Parameters.Add("pCARACTERISTICA", vT_Sgpad_Componente.CARACTERISTICA);
                    vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpad_Componente.IP_INGRESO);
                    vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpad_Componente.FEC_INGRESO);
                    vCmd.Parameters.Add("pUBICACION", vT_Sgpad_Componente.UBICACION);
                    vCmd.Parameters.Add("pPUNTAJE", vT_Sgpad_Componente.PUNTAJE);
                    vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpad_Componente.USU_MODIFICA);
                    vCmd.Parameters.Add("pID_SITUACION_PAM", vT_Sgpad_Componente.ID_SITUACION_PAM);
                    vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpad_Componente.IP_MODIFICA);
                    vCmd.Parameters.Add("pID_ZONA", vT_Sgpad_Componente.ID_ZONA);
                    vCmd.Parameters.Add("pID_TIPO_CONCESION", vT_Sgpad_Componente.ID_TIPO_CONCESION);
                    vCmd.Parameters.Add("pID_SUB_TIPO_PAM", vT_Sgpad_Componente.ID_SUB_TIPO_PAM);
                    vCmd.Parameters.Add("pESTE", vT_Sgpad_Componente.ESTE);
                    vCmd.Parameters.Add("pID_CUENCA_HIDRO", vT_Sgpad_Componente.ID_CUENCA_HIDRO);
                    vCmd.Parameters.Add("pID_CUENCA_SECUNDARIA", vT_Sgpad_Componente.ID_CUENCA_SECUNDARIA);
                    vCmd.Parameters.Add("pUBIGEO", vT_Sgpad_Componente.UBIGEO);
                    vCmd.Parameters.Add("pID_TIPO_PAM", vT_Sgpad_Componente.ID_TIPO_PAM);
                    vCmd.Parameters.Add("pID_COBERTURA", vT_Sgpad_Componente.ID_COBERTURA);
                    vCmd.Parameters.Add("pNORTE", vT_Sgpad_Componente.NORTE);
                    vCmd.Parameters.Add("pDESCRIPCION", vT_Sgpad_Componente.DESCRIPCION);
                    vCmd.Parameters.Add(":pID_COMPONENTE", OracleDbType.Int64).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vT_Sgpad_Componente.ID_COMPONENTE = Convert.ToInt32(vCmd.Parameters[":pID_COMPONENTE"].Value.ToString());
                    vCnn.Close();
                }
            }
            return vT_Sgpad_Componente;
        }

        public T_Sgpad_Componente ActualizarT_Sgpad_Componente(T_Sgpad_Componente vT_Sgpad_Componente)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMPONENTE.USP_UPD_COMPONENTE", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_DATUM", vT_Sgpad_Componente.ID_DATUM);
                    vCmd.Parameters.Add("pID_HUMEDAD", vT_Sgpad_Componente.ID_HUMEDAD);
                    vCmd.Parameters.Add("pID_EUM", vT_Sgpad_Componente.ID_EUM);
                    vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpad_Componente.FEC_MODIFICA);
                    vCmd.Parameters.Add("pID_TAMANO_PARTICULA", vT_Sgpad_Componente.ID_TAMANO_PARTICULA);
                    vCmd.Parameters.Add("pNOMBRE", vT_Sgpad_Componente.NOMBRE);
                    vCmd.Parameters.Add("pOTRO_DESCRIPCION", vT_Sgpad_Componente.OTRO_DESCRIPCION);
                    vCmd.Parameters.Add("pID_TIPO_MINERIA", vT_Sgpad_Componente.ID_TIPO_MINERIA);
                    vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpad_Componente.FLG_ESTADO);
                    vCmd.Parameters.Add("pID_COMPONENTE", vT_Sgpad_Componente.ID_COMPONENTE);
                    vCmd.Parameters.Add("pID_CUENCA", vT_Sgpad_Componente.ID_CUENCA);
                    vCmd.Parameters.Add("pPUNTAJE_NORMALIZADO", vT_Sgpad_Componente.PUNTAJE_NORMALIZADO);
                    vCmd.Parameters.Add("pCARACTERISTICA", vT_Sgpad_Componente.CARACTERISTICA);
                    vCmd.Parameters.Add("pUBICACION", vT_Sgpad_Componente.UBICACION);
                    vCmd.Parameters.Add("pPUNTAJE", vT_Sgpad_Componente.PUNTAJE);
                    vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpad_Componente.USU_MODIFICA);
                    vCmd.Parameters.Add("pID_SITUACION_PAM", vT_Sgpad_Componente.ID_SITUACION_PAM);
                    vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpad_Componente.IP_MODIFICA);
                    vCmd.Parameters.Add("pID_ZONA", vT_Sgpad_Componente.ID_ZONA);
                    vCmd.Parameters.Add("pID_TIPO_CONCESION", vT_Sgpad_Componente.ID_TIPO_CONCESION);
                    vCmd.Parameters.Add("pID_SUB_TIPO_PAM", vT_Sgpad_Componente.ID_SUB_TIPO_PAM);
                    vCmd.Parameters.Add("pESTE", vT_Sgpad_Componente.ESTE);
                    vCmd.Parameters.Add("pID_CUENCA_HIDRO", vT_Sgpad_Componente.ID_CUENCA_HIDRO);
                    vCmd.Parameters.Add("pID_CUENCA_SECUNDARIA", vT_Sgpad_Componente.ID_CUENCA_SECUNDARIA);
                    vCmd.Parameters.Add("pUBIGEO", vT_Sgpad_Componente.UBIGEO);
                    vCmd.Parameters.Add("pID_TIPO_PAM", vT_Sgpad_Componente.ID_TIPO_PAM);
                    vCmd.Parameters.Add("pID_COBERTURA", vT_Sgpad_Componente.ID_COBERTURA);
                    vCmd.Parameters.Add("pNORTE", vT_Sgpad_Componente.NORTE);
                    vCmd.Parameters.Add("pDESCRIPCION", vT_Sgpad_Componente.DESCRIPCION);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpad_Componente;
        }

        public int AnularT_Sgpad_ComponentePorCodigo(int vId_Componente)
        {
            int vResultado = 0;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMPONENTE.USP_DEL_COMPONENTE", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_COMPONENTE", vId_Componente);
                    vCnn.Open();
                    vResultado = vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vResultado;
        }

        public IEnumerable<T_Sgpad_Componente> ListarPaginadoT_Sgpad_Componente(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            List<T_Sgpad_Componente> vLista = new List<T_Sgpad_Componente>();
            T_Sgpad_Componente vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMPONENTE.USP_PAG_COMPONENTE", vCnn))
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
                        vEntidad = new T_Sgpad_Componente(vRdr);
                        vEntidad.TotalVirtual = System.Convert.ToInt32(vRdr["TotalVirtual"]);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public IEnumerable<V_Sgpad_Componente> ListarT_Sgpad_Componente_Eum(int vId_Eum)
        {
            List<V_Sgpad_Componente> vLista = new List<V_Sgpad_Componente>();
            V_Sgpad_Componente vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMPONENTE.USP_LIS_COMPONENTE_EUMA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_EUM", vId_Eum);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new V_Sgpad_Componente(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }
    }
}