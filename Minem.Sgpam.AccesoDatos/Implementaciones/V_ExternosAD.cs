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

        public void Insertar_DerechosMineros(V_Ext_Parametros vV_Ext_Parametros)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_FULLEXTERNOS.USP_INS_DERECHOS_MINEROS", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_COMPONENTE", vV_Ext_Parametros.ID_COMPONENTE);
                    vCmd.Parameters.Add("pID_ZONA", vV_Ext_Parametros.ID_ZONA);
                    vCmd.Parameters.Add("pID_DATUM", vV_Ext_Parametros.ID_DATUM);
                    vCmd.Parameters.Add("pESTE", vV_Ext_Parametros.ESTE);
                    vCmd.Parameters.Add("pNORTE", vV_Ext_Parametros.NORTE);
                    vCmd.Parameters.Add("pUBIGEO", vV_Ext_Parametros.UBIGEO);
                    vCmd.Parameters.Add("pUSU_INGRESO", vV_Ext_Parametros.USU_INGRESO);
                    vCmd.Parameters.Add("pFEC_INGRESO", vV_Ext_Parametros.FEC_INGRESO);
                    vCmd.Parameters.Add("pIP_INGRESO", vV_Ext_Parametros.IP_INGRESO);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
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


        public void Insertar_SituacionPrincipalesProductos(V_Ext_Parametros vV_Ext_Parametros)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_FULLEXTERNOS.USP_INS_SITUACION", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_COMPONENTE", vV_Ext_Parametros.ID_COMPONENTE);
                    vCmd.Parameters.Add("pID_COMP_DM", vV_Ext_Parametros.ID_COMP_DM);
                    vCmd.Parameters.Add("pUSU_INGRESO", vV_Ext_Parametros.USU_INGRESO);
                    vCmd.Parameters.Add("pFEC_INGRESO", vV_Ext_Parametros.FEC_INGRESO);
                    vCmd.Parameters.Add("pIP_INGRESO", vV_Ext_Parametros.IP_INGRESO);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
        }

        public List<V_Ext_SituacionPrincipalesProductos> Listar_SituacionPrincipalesProductos(int vId_Componente)
        {
            List<V_Ext_SituacionPrincipalesProductos> vLista = new List<V_Ext_SituacionPrincipalesProductos>();
            V_Ext_SituacionPrincipalesProductos vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_FULLEXTERNOS.USP_LIS_SITUACION", vCnn))
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


        public void Insertar_TitularesReferenciales(V_Ext_Parametros vV_Ext_Parametros)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_FULLEXTERNOS.USP_INS_TITULARES_REFERENCIAL", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_COMPONENTE", vV_Ext_Parametros.ID_COMPONENTE);
                    vCmd.Parameters.Add("pID_COMP_DM", vV_Ext_Parametros.ID_COMP_DM);
                    vCmd.Parameters.Add("pUSU_INGRESO", vV_Ext_Parametros.USU_INGRESO);
                    vCmd.Parameters.Add("pFEC_INGRESO", vV_Ext_Parametros.FEC_INGRESO);
                    vCmd.Parameters.Add("pIP_INGRESO", vV_Ext_Parametros.IP_INGRESO);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
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


        public void Insertar_ReinfoDerechosMineros(V_Ext_Parametros vV_Ext_Parametros)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_FULLEXTERNOS.USP_INS_REINFO_DERECHOS", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_COMPONENTE", vV_Ext_Parametros.ID_COMPONENTE);
                    vCmd.Parameters.Add("pID_COMP_DM", vV_Ext_Parametros.ID_COMP_DM);
                    vCmd.Parameters.Add("pUSU_INGRESO", vV_Ext_Parametros.USU_INGRESO);
                    vCmd.Parameters.Add("pFEC_INGRESO", vV_Ext_Parametros.FEC_INGRESO);
                    vCmd.Parameters.Add("pIP_INGRESO", vV_Ext_Parametros.IP_INGRESO);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
        }

        public List<V_Ext_ReinfoDerechosMineros> Listar_ReinfoDerechosMineros(int vId_Componente)
        {
            List<V_Ext_ReinfoDerechosMineros> vLista = new List<V_Ext_ReinfoDerechosMineros>();
            V_Ext_ReinfoDerechosMineros vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_FULLEXTERNOS.USP_LIS_REINFO_DERECHOS", vCnn))
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


        
        //public List<V_Ext_DerechosMineros> Listar_EstudioAmbiental()
        //{
        //    List<V_Ext_DerechosMineros> vLista = new List<V_Ext_DerechosMineros>();
        //    V_Ext_DerechosMineros vEntidad;

        //    using (OracleConnection vCnn = new OracleConnection(CnnString))
        //    {
        //        using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_FULLEXTERNOS.USP_LIS_DERECHOS_MINEROS", vCnn))
        //        {
        //            vCmd.CommandType = CommandType.StoredProcedure;
        //            vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
        //            vCnn.Open();
        //            OracleDataReader vRdr = vCmd.ExecuteReader();
        //            while (vRdr.Read())
        //            {
        //                vEntidad = new V_Ext_DerechosMineros(vRdr);
        //                vLista.Add(vEntidad);
        //            }
        //        }
        //        vCnn.Close();
        //    }
        //    return vLista;
        //}



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