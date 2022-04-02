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
    /// Objetivo:	Clase que genera las operaciones para la tabla T_SGPAD_COMP_COMENTARIO
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	27/10/2021
    /// </summary>
    public partial class V_ExternosAD : BaseAD, IV_ExternosAD
    {
        public V_ExternosAD(IConfiguration vConfiguration)
        {
            CnnString = vConfiguration.GetSection(Constantes.BD).Value;
        }

        public List<V_Ext_ReinfoDerechosMineros> Listar_ReinfoDerechosMineros(int vId_Componente)
        {
            List<V_Ext_ReinfoDerechosMineros> vLista = new List<V_Ext_ReinfoDerechosMineros>();
            V_Ext_ReinfoDerechosMineros vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_FULLEXTERNOS.USP_LIS_CONSULTA_REINFO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_COMPONENTE", vId_Componente);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new V_Ext_ReinfoDerechosMineros(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public List<V_Ext_SituacionPrincipalesProductos> Listar_SituacionPrincipalesProductos(int vId_Componente)
        {
            List<V_Ext_SituacionPrincipalesProductos> vLista = new List<V_Ext_SituacionPrincipalesProductos>();
            V_Ext_SituacionPrincipalesProductos vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_FULLEXTERNOS.USP_LIS_CONSULTA_SITUACION", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_COMPONENTE", vId_Componente);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new V_Ext_SituacionPrincipalesProductos(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public List<V_Ext_TitularesReferencialesDerechos> Listar_TitularesReferencialesDerechos(int vId_Componente)
        {
            List<V_Ext_TitularesReferencialesDerechos> vLista = new List<V_Ext_TitularesReferencialesDerechos>();
            V_Ext_TitularesReferencialesDerechos vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_FULLEXTERNOS.USP_LIS_TITULARES_REFERENCIAL", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_COMPONENTE", vId_Componente);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new V_Ext_TitularesReferencialesDerechos(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public List<V_Ext_DerechosMineros> Listar_DerechosMineros(int vId_Componente)
        {
            List<V_Ext_DerechosMineros> vLista = new List<V_Ext_DerechosMineros>();
            V_Ext_DerechosMineros vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_FULLEXTERNOS.USP_LIS_DERECHOS_MINEROS", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_COMPONENTE", vId_Componente);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new V_Ext_DerechosMineros(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public List<V_Ext_DerechosMineros> Listar_EstudioAmbiental()
        {
            List<V_Ext_DerechosMineros> vLista = new List<V_Ext_DerechosMineros>();
            V_Ext_DerechosMineros vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_FULLEXTERNOS.USP_LIS_DERECHOS_MINEROS", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new V_Ext_DerechosMineros(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }



        public void Insertar_DerechosMineros(T_Sgpad_Componente vT_Sgpad_Componente)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_FULLEXTERNOS.USP_INS_DERECHOS_MINEROS", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_COMPONENTE", vT_Sgpad_Componente.ID_COMPONENTE);
                    vCmd.Parameters.Add("pID_ZONA", vT_Sgpad_Componente.ID_ZONA);
                    vCmd.Parameters.Add("pID_DATUM", vT_Sgpad_Componente.ID_DATUM);
                    vCmd.Parameters.Add("pESTE", vT_Sgpad_Componente.ESTE);
                    vCmd.Parameters.Add("pNORTE", vT_Sgpad_Componente.NORTE);
                    vCmd.Parameters.Add("pUBIGEO", vT_Sgpad_Componente.UBIGEO);
                    vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpad_Componente.USU_INGRESO);
                    vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpad_Componente.FEC_INGRESO);
                    vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpad_Componente.IP_INGRESO);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
        }


        public void Insertar_TitularesReferenciales(T_Sgpad_Componente vT_Sgpad_Componente)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_FULLEXTERNOS.USP_INS_TITULARES_REFERENCIAL", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_COMPONENTE", vT_Sgpad_Componente.ID_COMPONENTE);
                    vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpad_Componente.USU_INGRESO);
                    vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpad_Componente.FEC_INGRESO);
                    vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpad_Componente.IP_INGRESO);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
        }

        public List<T_Sgpal_Cuenca> Listar_Cuenca(int vId_Componente)
        {
            List<T_Sgpal_Cuenca> vLista = new List<T_Sgpal_Cuenca>();
            T_Sgpal_Cuenca vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_FULLEXTERNOS.USP_LIS_UBIGEO_CUENCA", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_COMPONENTE", vId_Componente);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpal_Cuenca(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

    }
}