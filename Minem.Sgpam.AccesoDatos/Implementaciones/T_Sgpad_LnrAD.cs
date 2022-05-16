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
    /// Objetivo:	Clase que genera las operaciones para la tabla T_SGPAD_LNR
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	27/10/2021
    /// </summary>
    public partial class T_Sgpad_LnrAD: BaseAD, IT_Sgpad_LnrAD
    {
        public T_Sgpad_LnrAD(IConfiguration vConfiguration)
        {
            CnnString = vConfiguration.GetSection(Constantes.BD).Value;
        }

        public IEnumerable<T_Sgpad_Lnr> ListarT_Sgpad_Lnr()
        {
           List<T_Sgpad_Lnr> vLista = new List<T_Sgpad_Lnr>();
           T_Sgpad_Lnr vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_LNR.USP_LIS_LNR", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpad_Lnr(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public T_Sgpad_Lnr RecuperarT_Sgpad_LnrPorCodigo(int vId_Lnr)
        {
           T_Sgpad_Lnr vEntidad = null;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_LNR.USP_SEL_LNR", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_LNR", vId_Lnr);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpad_Lnr(vRdr);
                    }
                }
                vCnn.Close();
            }
            return vEntidad;
        }

        public T_Sgpad_Lnr InsertarT_Sgpad_Lnr(T_Sgpad_Lnr vT_Sgpad_Lnr)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_LNR.USP_INS_LNR", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    //vCmd.Parameters.Add("pID_LNR", vT_Sgpad_Lnr.ID_LNR);
                    vCmd.Parameters.Add("pID_EXPEDIENTE", vT_Sgpad_Lnr.ID_EXPEDIENTE);
                    vCmd.Parameters.Add("pNRO_EXPEDIENTE", vT_Sgpad_Lnr.NRO_EXPEDIENTE);
                    vCmd.Parameters.Add("pCODIGO_DECLARADO", vT_Sgpad_Lnr.CODIGO_DECLARADO);
                    vCmd.Parameters.Add("pID_TIPO_LNR", vT_Sgpad_Lnr.ID_TIPO_LNR);
                    vCmd.Parameters.Add("pID_SUB_TIPO_LNR", vT_Sgpad_Lnr.ID_SUB_TIPO_LNR);
                    vCmd.Parameters.Add("pSUB_TIPO_DECLARADO", vT_Sgpad_Lnr.SUB_TIPO_DECLARADO);
                    vCmd.Parameters.Add("pUBIGEO", vT_Sgpad_Lnr.UBIGEO);
                    vCmd.Parameters.Add("pNORTE", vT_Sgpad_Lnr.NORTE);
                    vCmd.Parameters.Add("pESTE", vT_Sgpad_Lnr.ESTE);
                    vCmd.Parameters.Add("pID_ZONA", vT_Sgpad_Lnr.ID_ZONA);
                    vCmd.Parameters.Add("pANCHO", vT_Sgpad_Lnr.ANCHO);
                    vCmd.Parameters.Add("pANCHO_DESC", vT_Sgpad_Lnr.ANCHO_DESC);
                    vCmd.Parameters.Add("pLARGO", vT_Sgpad_Lnr.LARGO);
                    vCmd.Parameters.Add("pLARGO_DESC", vT_Sgpad_Lnr.LARGO_DESC);
                    vCmd.Parameters.Add("pALTO", vT_Sgpad_Lnr.ALTO);
                    vCmd.Parameters.Add("pALTO_DESC", vT_Sgpad_Lnr.ALTO_DESC);
                    vCmd.Parameters.Add("pPROFUNDIDAD", vT_Sgpad_Lnr.PROFUNDIDAD);
                    vCmd.Parameters.Add("pPROFUNDIDAD_DESC", vT_Sgpad_Lnr.PROFUNDIDAD_DESC);
                    vCmd.Parameters.Add("pAREA", vT_Sgpad_Lnr.AREA);
                    vCmd.Parameters.Add("pAREA_DESC", vT_Sgpad_Lnr.AREA_DESC);
                    vCmd.Parameters.Add("pVOLUMEN", vT_Sgpad_Lnr.VOLUMEN);
                    vCmd.Parameters.Add("pVOLUMEN_DESC", vT_Sgpad_Lnr.VOLUMEN_DESC);
                    vCmd.Parameters.Add("pID_TEMPORALIDAD", vT_Sgpad_Lnr.ID_TEMPORALIDAD);
                    vCmd.Parameters.Add("pEVA_LABOR", vT_Sgpad_Lnr.EVA_LABOR);
                    vCmd.Parameters.Add("pEVA_EVIDENCIA", vT_Sgpad_Lnr.EVA_EVIDENCIA);
                    vCmd.Parameters.Add("pEVA_CAIDA", vT_Sgpad_Lnr.EVA_CAIDA);
                    vCmd.Parameters.Add("pEVA_ELEMENTOS", vT_Sgpad_Lnr.EVA_ELEMENTOS);
                    vCmd.Parameters.Add("pEVA_DRENAJES", vT_Sgpad_Lnr.EVA_DRENAJES);
                    vCmd.Parameters.Add("pEVA_MATERIAL", vT_Sgpad_Lnr.EVA_MATERIAL);
                    vCmd.Parameters.Add("pEVA_AFECTACION", vT_Sgpad_Lnr.EVA_AFECTACION);
                    vCmd.Parameters.Add("pEVA_GENERADOR", vT_Sgpad_Lnr.EVA_GENERADOR);
                    vCmd.Parameters.Add("pEVA_RESTOS", vT_Sgpad_Lnr.EVA_RESTOS);
                    vCmd.Parameters.Add("pEVA_POSIBILIDAD", vT_Sgpad_Lnr.EVA_POSIBILIDAD);
                    vCmd.Parameters.Add("pEVA_POTENCIAL", vT_Sgpad_Lnr.EVA_POTENCIAL);
                    vCmd.Parameters.Add("pEVA_ELEMENTO", vT_Sgpad_Lnr.EVA_ELEMENTO);
                    vCmd.Parameters.Add("pFEC_REGISTRO", vT_Sgpad_Lnr.FEC_REGISTRO);
                    vCmd.Parameters.Add("pNOM_DECLARANTE", vT_Sgpad_Lnr.NOM_DECLARANTE); 				    vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpad_Lnr.USU_INGRESO);
                    vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpad_Lnr.FEC_INGRESO);
                    vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpad_Lnr.IP_INGRESO);
                    vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpad_Lnr.FLG_ESTADO);
                    vCmd.Parameters.Add(":pID_LNR", OracleDbType.Int64).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vT_Sgpad_Lnr.ID_LNR = Convert.ToInt32(vCmd.Parameters[":pID_LNR"].Value.ToString());
                    vCnn.Close();
                }
            }
            return vT_Sgpad_Lnr;
        }
        
        public T_Sgpad_Lnr ActualizarT_Sgpad_Lnr(T_Sgpad_Lnr vT_Sgpad_Lnr)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_LNR.USP_UPD_LNR", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_LNR", vT_Sgpad_Lnr.ID_LNR);
                    vCmd.Parameters.Add("pID_EXPEDIENTE", vT_Sgpad_Lnr.ID_EXPEDIENTE);
                    vCmd.Parameters.Add("pNRO_EXPEDIENTE", vT_Sgpad_Lnr.NRO_EXPEDIENTE);
                    vCmd.Parameters.Add("pCODIGO_DECLARADO", vT_Sgpad_Lnr.CODIGO_DECLARADO);
                    vCmd.Parameters.Add("pID_TIPO_LNR", vT_Sgpad_Lnr.ID_TIPO_LNR);
                    vCmd.Parameters.Add("pID_SUB_TIPO_LNR", vT_Sgpad_Lnr.ID_SUB_TIPO_LNR);
                    vCmd.Parameters.Add("pSUB_TIPO_DECLARADO", vT_Sgpad_Lnr.SUB_TIPO_DECLARADO);
                    vCmd.Parameters.Add("pUBIGEO", vT_Sgpad_Lnr.UBIGEO);
                    vCmd.Parameters.Add("pNORTE", vT_Sgpad_Lnr.NORTE);
                    vCmd.Parameters.Add("pESTE", vT_Sgpad_Lnr.ESTE);
                    vCmd.Parameters.Add("pID_ZONA", vT_Sgpad_Lnr.ID_ZONA);
                    vCmd.Parameters.Add("pANCHO", vT_Sgpad_Lnr.ANCHO);
                    vCmd.Parameters.Add("pANCHO_DESC", vT_Sgpad_Lnr.ANCHO_DESC);
                    vCmd.Parameters.Add("pLARGO", vT_Sgpad_Lnr.LARGO);
                    vCmd.Parameters.Add("pLARGO_DESC", vT_Sgpad_Lnr.LARGO_DESC);
                    vCmd.Parameters.Add("pALTO", vT_Sgpad_Lnr.ALTO);
                    vCmd.Parameters.Add("pALTO_DESC", vT_Sgpad_Lnr.ALTO_DESC);
                    vCmd.Parameters.Add("pPROFUNDIDAD", vT_Sgpad_Lnr.PROFUNDIDAD);
                    vCmd.Parameters.Add("pPROFUNDIDAD_DESC", vT_Sgpad_Lnr.PROFUNDIDAD_DESC);
                    vCmd.Parameters.Add("pAREA", vT_Sgpad_Lnr.AREA);
                    vCmd.Parameters.Add("pAREA_DESC", vT_Sgpad_Lnr.AREA_DESC);
                    vCmd.Parameters.Add("pVOLUMEN", vT_Sgpad_Lnr.VOLUMEN);
                    vCmd.Parameters.Add("pVOLUMEN_DESC", vT_Sgpad_Lnr.VOLUMEN_DESC);
                    vCmd.Parameters.Add("pID_TEMPORALIDAD", vT_Sgpad_Lnr.ID_TEMPORALIDAD);
                    vCmd.Parameters.Add("pEVA_LABOR", vT_Sgpad_Lnr.EVA_LABOR);
                    vCmd.Parameters.Add("pEVA_EVIDENCIA", vT_Sgpad_Lnr.EVA_EVIDENCIA);
                    vCmd.Parameters.Add("pEVA_CAIDA", vT_Sgpad_Lnr.EVA_CAIDA);
                    vCmd.Parameters.Add("pEVA_ELEMENTOS", vT_Sgpad_Lnr.EVA_ELEMENTOS);
                    vCmd.Parameters.Add("pEVA_DRENAJES", vT_Sgpad_Lnr.EVA_DRENAJES);
                    vCmd.Parameters.Add("pEVA_MATERIAL", vT_Sgpad_Lnr.EVA_MATERIAL);
                    vCmd.Parameters.Add("pEVA_AFECTACION", vT_Sgpad_Lnr.EVA_AFECTACION);
                    vCmd.Parameters.Add("pEVA_GENERADOR", vT_Sgpad_Lnr.EVA_GENERADOR);
                    vCmd.Parameters.Add("pEVA_RESTOS", vT_Sgpad_Lnr.EVA_RESTOS);
                    vCmd.Parameters.Add("pEVA_POSIBILIDAD", vT_Sgpad_Lnr.EVA_POSIBILIDAD);
                    vCmd.Parameters.Add("pEVA_POTENCIAL", vT_Sgpad_Lnr.EVA_POTENCIAL);
                    vCmd.Parameters.Add("pEVA_ELEMENTO", vT_Sgpad_Lnr.EVA_ELEMENTO);
                    vCmd.Parameters.Add("pFEC_REGISTRO", vT_Sgpad_Lnr.FEC_REGISTRO);
                    vCmd.Parameters.Add("pNOM_DECLARANTE", vT_Sgpad_Lnr.NOM_DECLARANTE);
                    vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpad_Lnr.USU_MODIFICA);
                    vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpad_Lnr.FEC_MODIFICA);
                    vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpad_Lnr.IP_MODIFICA);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpad_Lnr;
        }

        public int AnularT_Sgpad_LnrPorCodigo(int vId_Lnr)
        {
            int vResultado = 0;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_LNR.USP_DEL_LNR", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_LNR", vId_Lnr);
                    vCnn.Open();
                    vResultado = vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vResultado;
        }

        public IEnumerable<T_Sgpad_Lnr> ListarPaginadoT_Sgpad_Lnr(string vFiltro, int vNumPag, int vCantRegxPag)
        {
           List<T_Sgpad_Lnr> vLista = new List<T_Sgpad_Lnr>();
           T_Sgpad_Lnr vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_LNR.USP_PAG_LNR", vCnn))
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
                        vEntidad = new T_Sgpad_Lnr(vRdr);
                        vEntidad.TotalVirtual = System.Convert.ToInt32(vRdr["TotalVirtual"]);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public IEnumerable<T_Sgpad_Lnr> ListarPorIdExpedienteT_Sgpad_Lnr(int vId_Expediente)
        {
            List<T_Sgpad_Lnr> vLista = new List<T_Sgpad_Lnr>();
            T_Sgpad_Lnr vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_LNR.USP_LIS_POR_IDEXPEDIENTE_LNR", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pId_Expediente", vId_Expediente);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpad_Lnr(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }
    }
}