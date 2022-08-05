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
    /// Objetivo:	Clase que genera las operaciones para la tabla T_SGPAD_VISITA_PERSONA
    /// Creado Por:	Mateo Salvador Paucar
    /// Fecha Creación:	27/10/2021
    /// </summary>
    public partial class T_Sgpad_Visita_PersonaAD : BaseAD, IT_Sgpad_Visita_PersonaAD
    {
        public T_Sgpad_Visita_PersonaAD(IConfiguration vConfiguration)
        {
            CnnString = vConfiguration.GetSection(Constantes.BD).Value;
        }

        public IEnumerable<T_Sgpad_Visita_Persona> ListarT_Sgpad_Visita_Persona()
        {
            List<T_Sgpad_Visita_Persona> vLista = new List<T_Sgpad_Visita_Persona>();
            T_Sgpad_Visita_Persona vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_VISITA_PERSONA.USP_LIS_VISITA_PERSONA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpad_Visita_Persona(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public T_Sgpad_Visita_Persona RecuperarT_Sgpad_Visita_PersonaPorCodigo(int vId_Visita_Persona)
        {
            T_Sgpad_Visita_Persona vEntidad = null;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_VISITA_PERSONA.USP_SEL_VISITA_PERSONA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_VISITA_PERSONA", vId_Visita_Persona);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpad_Visita_Persona(vRdr);
                    }
                }
                vCnn.Close();
            }
            return vEntidad;
        }

        public T_Sgpad_Visita_Persona InsertarT_Sgpad_Visita_Persona(T_Sgpad_Visita_Persona vT_Sgpad_Visita_Persona)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_VISITA_PERSONA.USP_INS_VISITA_PERSONA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_VISITA", vT_Sgpad_Visita_Persona.ID_VISITA);
                    vCmd.Parameters.Add("pID_CARGO", vT_Sgpad_Visita_Persona.ID_CARGO);
                    vCmd.Parameters.Add("pDNI", vT_Sgpad_Visita_Persona.DNI);
                    vCmd.Parameters.Add("pNOMBRE_COMPLETO", vT_Sgpad_Visita_Persona.NOMBRE_COMPLETO);
                    vCmd.Parameters.Add("pCORREO", vT_Sgpad_Visita_Persona.CORREO);
                    vCmd.Parameters.Add("pCONTACTO", vT_Sgpad_Visita_Persona.CONTACTO);
                    vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpad_Visita_Persona.USU_INGRESO);
                    vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpad_Visita_Persona.FEC_INGRESO);
                    vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpad_Visita_Persona.IP_INGRESO);
                    vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpad_Visita_Persona.FLG_ESTADO);
                    vCmd.Parameters.Add(":pID_VISITA_PERSONA", OracleDbType.Int64).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vT_Sgpad_Visita_Persona.ID_VISITA_PERSONA = Convert.ToInt32(vCmd.Parameters[":pID_VISITA_PERSONA"].Value.ToString());
                    vCnn.Close();
                }
            }
            return vT_Sgpad_Visita_Persona;
        }

        public T_Sgpad_Visita_Persona ActualizarT_Sgpad_Visita_Persona(T_Sgpad_Visita_Persona vT_Sgpad_Visita_Persona)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_VISITA_PERSONA.USP_UPD_VISITA_PERSONA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_VISITA_PERSONA", vT_Sgpad_Visita_Persona.ID_VISITA_PERSONA);
                    vCmd.Parameters.Add("pID_CARGO", vT_Sgpad_Visita_Persona.ID_CARGO);
                    vCmd.Parameters.Add("pDNI", vT_Sgpad_Visita_Persona.DNI);
                    vCmd.Parameters.Add("pNOMBRE_COMPLETO", vT_Sgpad_Visita_Persona.NOMBRE_COMPLETO);
                    vCmd.Parameters.Add("pCORREO", vT_Sgpad_Visita_Persona.CORREO);
                    vCmd.Parameters.Add("pCONTACTO", vT_Sgpad_Visita_Persona.CONTACTO);
                    vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpad_Visita_Persona.USU_MODIFICA);
                    vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpad_Visita_Persona.FEC_MODIFICA);
                    vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpad_Visita_Persona.IP_MODIFICA);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpad_Visita_Persona;
        }

        public int AnularT_Sgpad_Visita_PersonaPorCodigo(T_Sgpad_Visita_Persona vT_Sgpad_Visita_Persona)
        {
            int vResultado = 0;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_VISITA_PERSONA.USP_DEL_VISITA_PERSONA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_VISITA_PERSONA", vT_Sgpad_Visita_Persona.ID_VISITA_PERSONA);
                    vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpad_Visita_Persona.USU_MODIFICA);
                    vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpad_Visita_Persona.FEC_MODIFICA);
                    vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpad_Visita_Persona.IP_MODIFICA);
                    vCnn.Open();
                    vResultado = vCmd.ExecuteNonQuery();
                    vCnn.Close();
                    vResultado = (vResultado == -1) ? vResultado * -1 : vResultado;
                }
            }
            return vResultado;
        }

        public IEnumerable<T_Sgpad_Visita_Persona> ListarPaginadoT_Sgpad_Visita_Persona(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            List<T_Sgpad_Visita_Persona> vLista = new List<T_Sgpad_Visita_Persona>();
            T_Sgpad_Visita_Persona vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_VISITA_PERSONA.USP_PAG_VISITA_PERSONA", vCnn))
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
                        vEntidad = new T_Sgpad_Visita_Persona(vRdr);
                        //vEntidad.TotalVirtual = System.Convert.ToInt32(vRdr["TotalVirtual"]);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public IEnumerable<T_Sgpad_Visita_Persona> ListarPorIdVisitaT_Sgpad_Visita_Persona(int vId_Visita)
        {
            List<T_Sgpad_Visita_Persona> vLista = new List<T_Sgpad_Visita_Persona>();
            T_Sgpad_Visita_Persona vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_VISITA_PERSONA.USP_LIS_POR_IDVISITA_VISITA_PERSONA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_VISITA", vId_Visita);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();

                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpad_Visita_Persona(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }


    }
}
