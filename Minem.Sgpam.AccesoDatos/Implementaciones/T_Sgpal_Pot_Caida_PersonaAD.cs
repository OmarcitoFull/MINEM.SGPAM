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
    /// Objetivo:	Clase que genera las operaciones para la tabla T_SGPAL_POT_CAIDA_PERSONA
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	27/10/2021
    /// </summary>
    public partial class T_Sgpal_Pot_Caida_PersonaAD : BaseAD, IT_Sgpal_Pot_Caida_PersonaAD
    {
        public T_Sgpal_Pot_Caida_PersonaAD(IConfiguration vConfiguration)
        {
            CnnString = vConfiguration.GetSection(Constantes.BD).Value;
        }

        public IEnumerable<T_Sgpal_Pot_Caida_Persona> ListarT_Sgpal_Pot_Caida_Persona()
        {
            List<T_Sgpal_Pot_Caida_Persona> vLista = new List<T_Sgpal_Pot_Caida_Persona>();
            T_Sgpal_Pot_Caida_Persona vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_POT_CAIDA_PERSONA.USP_LIS_POT_CAIDA_PERSONA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpal_Pot_Caida_Persona(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public T_Sgpal_Pot_Caida_Persona RecuperarT_Sgpal_Pot_Caida_PersonaPorCodigo(int vId_Pot_Caida_Persona)
        {
            T_Sgpal_Pot_Caida_Persona vEntidad = null;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_POT_CAIDA_PERSONA.USP_SEL_POT_CAIDA_PERSONA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_POT_CAIDA_PERSONA", vId_Pot_Caida_Persona);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpal_Pot_Caida_Persona(vRdr);
                    }
                }
                vCnn.Close();
            }
            return vEntidad;
        }

        public T_Sgpal_Pot_Caida_Persona InsertarT_Sgpal_Pot_Caida_Persona(T_Sgpal_Pot_Caida_Persona vT_Sgpal_Pot_Caida_Persona)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_POT_CAIDA_PERSONA.USP_INS_POT_CAIDA_PERSONA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pPESO_ORM", vT_Sgpal_Pot_Caida_Persona.PESO_ORM);
                    vCmd.Parameters.Add("pPESO_I", vT_Sgpal_Pot_Caida_Persona.PESO_I);
                    vCmd.Parameters.Add("pPESO_PQ", vT_Sgpal_Pot_Caida_Persona.PESO_PQ);
                    vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpal_Pot_Caida_Persona.IP_INGRESO);
                    vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpal_Pot_Caida_Persona.FEC_INGRESO);
                    vCmd.Parameters.Add("pID_POT_CAIDA_PERSONA", vT_Sgpal_Pot_Caida_Persona.ID_POT_CAIDA_PERSONA);
                    vCmd.Parameters.Add("pDESCRIPCION", vT_Sgpal_Pot_Caida_Persona.DESCRIPCION);
                    vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpal_Pot_Caida_Persona.FEC_MODIFICA);
                    vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpal_Pot_Caida_Persona.USU_INGRESO);
                    vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpal_Pot_Caida_Persona.FLG_ESTADO);
                    vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpal_Pot_Caida_Persona.USU_MODIFICA);
                    vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpal_Pot_Caida_Persona.IP_MODIFICA);
                    vCmd.Parameters.Add("pPESO_LB", vT_Sgpal_Pot_Caida_Persona.PESO_LB);
                    vCmd.Parameters.Add("pPESO_RM", vT_Sgpal_Pot_Caida_Persona.PESO_RM);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpal_Pot_Caida_Persona;
        }

        public T_Sgpal_Pot_Caida_Persona ActualizarT_Sgpal_Pot_Caida_Persona(T_Sgpal_Pot_Caida_Persona vT_Sgpal_Pot_Caida_Persona)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_POT_CAIDA_PERSONA.USP_UPD_POT_CAIDA_PERSONA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pPESO_ORM", vT_Sgpal_Pot_Caida_Persona.PESO_ORM);
                    vCmd.Parameters.Add("pPESO_I", vT_Sgpal_Pot_Caida_Persona.PESO_I);
                    vCmd.Parameters.Add("pPESO_PQ", vT_Sgpal_Pot_Caida_Persona.PESO_PQ);
                    vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpal_Pot_Caida_Persona.IP_INGRESO);
                    vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpal_Pot_Caida_Persona.FEC_INGRESO);
                    vCmd.Parameters.Add("pID_POT_CAIDA_PERSONA", vT_Sgpal_Pot_Caida_Persona.ID_POT_CAIDA_PERSONA);
                    vCmd.Parameters.Add("pDESCRIPCION", vT_Sgpal_Pot_Caida_Persona.DESCRIPCION);
                    vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpal_Pot_Caida_Persona.FEC_MODIFICA);
                    vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpal_Pot_Caida_Persona.USU_INGRESO);
                    vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpal_Pot_Caida_Persona.FLG_ESTADO);
                    vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpal_Pot_Caida_Persona.USU_MODIFICA);
                    vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpal_Pot_Caida_Persona.IP_MODIFICA);
                    vCmd.Parameters.Add("pPESO_LB", vT_Sgpal_Pot_Caida_Persona.PESO_LB);
                    vCmd.Parameters.Add("pPESO_RM", vT_Sgpal_Pot_Caida_Persona.PESO_RM);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpal_Pot_Caida_Persona;
        }

        public int AnularT_Sgpal_Pot_Caida_PersonaPorCodigo(int vId_Pot_Caida_Persona)
        {
            int vResultado = 0;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_POT_CAIDA_PERSONA.USP_DEL_POT_CAIDA_PERSONA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_POT_CAIDA_PERSONA", vId_Pot_Caida_Persona);
                    vCnn.Open();
                    vResultado = vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vResultado;
        }

        public IEnumerable<T_Sgpal_Pot_Caida_Persona> ListarPaginadoT_Sgpal_Pot_Caida_Persona(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            List<T_Sgpal_Pot_Caida_Persona> vLista = new List<T_Sgpal_Pot_Caida_Persona>();
            T_Sgpal_Pot_Caida_Persona vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_POT_CAIDA_PERSONA.USP_PAG_POT_CAIDA_PERSONA", vCnn))
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
                        vEntidad = new T_Sgpal_Pot_Caida_Persona(vRdr);
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