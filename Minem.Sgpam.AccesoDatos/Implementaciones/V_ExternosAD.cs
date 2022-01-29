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

        public List<V_Ext_ReinfoDerechosMineros> Listar_ReinfoDerechosMineros()
        {
            List<V_Ext_ReinfoDerechosMineros> vLista = new List<V_Ext_ReinfoDerechosMineros>();
            V_Ext_ReinfoDerechosMineros vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_FULLEXTERNOS.USP_LIS_CONSULTA_REINFO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
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

        public List<V_Ext_SituacionPrincipalesProductos> Listar_SituacionPrincipalesProductos()
        {
            List<V_Ext_SituacionPrincipalesProductos> vLista = new List<V_Ext_SituacionPrincipalesProductos>();
            V_Ext_SituacionPrincipalesProductos vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_FULLEXTERNOS.USP_LIS_CONSULTA_SITUACION", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
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

        public List<V_Ext_TitularesReferencialesDerechos> Listar_TitularesReferencialesDerechos()
        {
            List<V_Ext_TitularesReferencialesDerechos> vLista = new List<V_Ext_TitularesReferencialesDerechos>();
            V_Ext_TitularesReferencialesDerechos vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_FULLEXTERNOS.USP_LIS_TITULARES_REFERENCIAL", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
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

        public List<V_Ext_DerechosMineros> Listar_DerechosMineros()
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
    }
}