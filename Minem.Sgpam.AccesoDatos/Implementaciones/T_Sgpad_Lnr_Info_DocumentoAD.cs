using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Extensions.Configuration;
using Minem.Sgpam.AccesoDatos.Base;
using Minem.Sgpam.AccesoDatos.Interfaces;
using Minem.Sgpam.Entidades;
using Oracle.ManagedDataAccess.Client;

namespace Minem.Sgpam.AccesoDatos.Implementaciones
{
    /// <summary>
    /// Objetivo:	Clase que genera las operaciones para la tabla T_SGPAD_LNR_INFO_DOCUMENTO
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	27/10/2021
    /// </summary>
    public partial class T_Sgpad_Lnr_Info_DocumentoAD: BaseAD, IT_Sgpad_Lnr_Info_DocumentoAD
    {   
        public IEnumerable<T_Sgpad_Lnr_Info_Documento> ListarT_Sgpad_Lnr_Info_Documento()
        {
           List<T_Sgpad_Lnr_Info_Documento> vLista = new List<T_Sgpad_Lnr_Info_Documento>();
           T_Sgpad_Lnr_Info_Documento vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_LNR_INFO_DOCUMENTO.USP_LIS_LNR_INFO_DOCUMENTO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpad_Lnr_Info_Documento(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public T_Sgpad_Lnr_Info_Documento RecuperarT_Sgpad_Lnr_Info_DocumentoPorCodigo(int vId_Lnr_Info_Documento)
        {
           T_Sgpad_Lnr_Info_Documento vEntidad = null;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_LNR_INFO_DOCUMENTO.USP_SEL_LNR_INFO_DOCUMENTO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_LNR_INFO_DOCUMENTO", vId_Lnr_Info_Documento);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpad_Lnr_Info_Documento(vRdr);
                    }
                }
                vCnn.Close();
            }
            return vEntidad;
        }

        public T_Sgpad_Lnr_Info_Documento InsertarT_Sgpad_Lnr_Info_Documento(T_Sgpad_Lnr_Info_Documento vT_Sgpad_Lnr_Info_Documento)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_LNR_INFO_DOCUMENTO.USP_INS_LNR_INFO_DOCUMENTO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpad_Lnr_Info_Documento.FEC_INGRESO); 				vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpad_Lnr_Info_Documento.IP_INGRESO); 				vCmd.Parameters.Add("pID_LNR", vT_Sgpad_Lnr_Info_Documento.ID_LNR); 				vCmd.Parameters.Add("pTAMANO", vT_Sgpad_Lnr_Info_Documento.TAMANO); 				vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpad_Lnr_Info_Documento.FLG_ESTADO); 				vCmd.Parameters.Add("pID_LNR_INFO_DOCUMENTO", vT_Sgpad_Lnr_Info_Documento.ID_LNR_INFO_DOCUMENTO); 				vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpad_Lnr_Info_Documento.IP_MODIFICA); 				vCmd.Parameters.Add("pRUTA_DOCUMENTO", vT_Sgpad_Lnr_Info_Documento.RUTA_DOCUMENTO); 				vCmd.Parameters.Add("pNOMBRE_DOCUMENTO", vT_Sgpad_Lnr_Info_Documento.NOMBRE_DOCUMENTO); 				vCmd.Parameters.Add("pEXTENCION", vT_Sgpad_Lnr_Info_Documento.EXTENCION); 				vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpad_Lnr_Info_Documento.FEC_MODIFICA); 				vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpad_Lnr_Info_Documento.USU_MODIFICA); 				vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpad_Lnr_Info_Documento.USU_INGRESO);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpad_Lnr_Info_Documento;
        }
        
        public T_Sgpad_Lnr_Info_Documento ActualizarT_Sgpad_Lnr_Info_Documento(T_Sgpad_Lnr_Info_Documento vT_Sgpad_Lnr_Info_Documento)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_LNR_INFO_DOCUMENTO.USP_UPD_LNR_INFO_DOCUMENTO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpad_Lnr_Info_Documento.FEC_INGRESO); 				vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpad_Lnr_Info_Documento.IP_INGRESO); 				vCmd.Parameters.Add("pID_LNR", vT_Sgpad_Lnr_Info_Documento.ID_LNR); 				vCmd.Parameters.Add("pTAMANO", vT_Sgpad_Lnr_Info_Documento.TAMANO); 				vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpad_Lnr_Info_Documento.FLG_ESTADO); 				vCmd.Parameters.Add("pID_LNR_INFO_DOCUMENTO", vT_Sgpad_Lnr_Info_Documento.ID_LNR_INFO_DOCUMENTO); 				vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpad_Lnr_Info_Documento.IP_MODIFICA); 				vCmd.Parameters.Add("pRUTA_DOCUMENTO", vT_Sgpad_Lnr_Info_Documento.RUTA_DOCUMENTO); 				vCmd.Parameters.Add("pNOMBRE_DOCUMENTO", vT_Sgpad_Lnr_Info_Documento.NOMBRE_DOCUMENTO); 				vCmd.Parameters.Add("pEXTENCION", vT_Sgpad_Lnr_Info_Documento.EXTENCION); 				vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpad_Lnr_Info_Documento.FEC_MODIFICA); 				vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpad_Lnr_Info_Documento.USU_MODIFICA); 				vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpad_Lnr_Info_Documento.USU_INGRESO);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpad_Lnr_Info_Documento;
        }

        public int AnularT_Sgpad_Lnr_Info_DocumentoPorCodigo(int vId_Lnr_Info_Documento)
        {
            int vResultado = 0;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_LNR_INFO_DOCUMENTO.USP_DEL_LNR_INFO_DOCUMENTO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_LNR_INFO_DOCUMENTO", vId_Lnr_Info_Documento);
                    vCnn.Open();
                    vResultado = vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vResultado;
        }

        public IEnumerable<T_Sgpad_Lnr_Info_Documento> ListarPaginadoT_Sgpad_Lnr_Info_Documento(string vFiltro, int vNumPag, int vCantRegxPag)
        {
           List<T_Sgpad_Lnr_Info_Documento> vLista = new List<T_Sgpad_Lnr_Info_Documento>();
           T_Sgpad_Lnr_Info_Documento vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_LNR_INFO_DOCUMENTO.USP_PAG_LNR_INFO_DOCUMENTO", vCnn))
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
                        vEntidad = new T_Sgpad_Lnr_Info_Documento(vRdr);
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