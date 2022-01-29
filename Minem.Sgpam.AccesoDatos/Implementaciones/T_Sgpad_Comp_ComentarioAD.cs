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
    public partial class T_Sgpad_Comp_ComentarioAD : BaseAD, IT_Sgpad_Comp_ComentarioAD
    {
        public T_Sgpad_Comp_ComentarioAD(IConfiguration vConfiguration)
        {
            CnnString = vConfiguration.GetSection(Constantes.BD).Value;
        }

        public IEnumerable<T_Sgpad_Comp_Comentario> ListarT_Sgpad_Comp_Comentario(int vIdComponente)
        {
            List<T_Sgpad_Comp_Comentario> vLista = new List<T_Sgpad_Comp_Comentario>();
            T_Sgpad_Comp_Comentario vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_COMENTARIO.USP_LIS_COMP_COMENTARIO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_COMPONENTE", vIdComponente);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpad_Comp_Comentario(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public T_Sgpad_Comp_Comentario RecuperarT_Sgpad_Comp_ComentarioPorCodigo(int vId_Comp_Comentario)
        {
            T_Sgpad_Comp_Comentario vEntidad = null;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_COMENTARIO.USP_SEL_COMP_COMENTARIO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_COMP_COMENTARIO", vId_Comp_Comentario);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new T_Sgpad_Comp_Comentario(vRdr);
                    }
                }
                vCnn.Close();
            }
            return vEntidad;
        }

        public T_Sgpad_Comp_Comentario InsertarT_Sgpad_Comp_Comentario(T_Sgpad_Comp_Comentario vT_Sgpad_Comp_Comentario)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_COMENTARIO.USP_INS_COMP_COMENTARIO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpad_Comp_Comentario.USU_MODIFICA);
                    vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpad_Comp_Comentario.FEC_INGRESO);
                    //vCmd.Parameters.Add("pID_COMP_COMENTARIO", vT_Sgpad_Comp_Comentario.ID_COMP_COMENTARIO);
                    vCmd.Parameters.Add("pID_COMPONENTE", vT_Sgpad_Comp_Comentario.ID_COMPONENTE);
                    vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpad_Comp_Comentario.USU_INGRESO);
                    vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpad_Comp_Comentario.IP_MODIFICA);
                    vCmd.Parameters.Add("pDESCRIPCION", vT_Sgpad_Comp_Comentario.DESCRIPCION);
                    vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpad_Comp_Comentario.IP_INGRESO);
                    vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpad_Comp_Comentario.FEC_MODIFICA);
                    vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpad_Comp_Comentario.FLG_ESTADO);
                    vCmd.Parameters.Add("pFECHA", vT_Sgpad_Comp_Comentario.FECHA);
                    vCmd.Parameters.Add(":pID_COMP_COMENTARIO", OracleDbType.Int64).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vT_Sgpad_Comp_Comentario.ID_COMP_COMENTARIO = Convert.ToInt32(vCmd.Parameters[":pID_COMP_COMENTARIO"].Value.ToString());
                    vCnn.Close();
                }
            }
            return vT_Sgpad_Comp_Comentario;
        }

        public T_Sgpad_Comp_Comentario ActualizarT_Sgpad_Comp_Comentario(T_Sgpad_Comp_Comentario vT_Sgpad_Comp_Comentario)
        {
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_COMENTARIO.USP_UPD_COMP_COMENTARIO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pUSU_MODIFICA", vT_Sgpad_Comp_Comentario.USU_MODIFICA);
                    //vCmd.Parameters.Add("pFEC_INGRESO", vT_Sgpad_Comp_Comentario.FEC_INGRESO);
                    vCmd.Parameters.Add("pID_COMP_COMENTARIO", vT_Sgpad_Comp_Comentario.ID_COMP_COMENTARIO);
                    vCmd.Parameters.Add("pID_COMPONENTE", vT_Sgpad_Comp_Comentario.ID_COMPONENTE);
                    //vCmd.Parameters.Add("pUSU_INGRESO", vT_Sgpad_Comp_Comentario.USU_INGRESO);
                    vCmd.Parameters.Add("pIP_MODIFICA", vT_Sgpad_Comp_Comentario.IP_MODIFICA);
                    vCmd.Parameters.Add("pDESCRIPCION", vT_Sgpad_Comp_Comentario.DESCRIPCION);
                    //vCmd.Parameters.Add("pIP_INGRESO", vT_Sgpad_Comp_Comentario.IP_INGRESO);
                    vCmd.Parameters.Add("pFEC_MODIFICA", vT_Sgpad_Comp_Comentario.FEC_MODIFICA);
                    vCmd.Parameters.Add("pFLG_ESTADO", vT_Sgpad_Comp_Comentario.FLG_ESTADO);
                    vCmd.Parameters.Add("pFECHA", vT_Sgpad_Comp_Comentario.FECHA);
                    vCnn.Open();
                    vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vT_Sgpad_Comp_Comentario;
        }

        public int AnularT_Sgpad_Comp_ComentarioPorCodigo(int vId_Comp_Comentario)
        {
            int vResultado = 0;
            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_COMENTARIO.USP_DEL_COMP_COMENTARIO", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pID_COMP_COMENTARIO", vId_Comp_Comentario);
                    vCnn.Open();
                    vResultado = vCmd.ExecuteNonQuery();
                    vCnn.Close();
                }
            }
            return vResultado;
        }

        public IEnumerable<T_Sgpad_Comp_Comentario> ListarPaginadoT_Sgpad_Comp_Comentario(string vFiltro, int vNumPag, int vCantRegxPag)
        {
            List<T_Sgpad_Comp_Comentario> vLista = new List<T_Sgpad_Comp_Comentario>();
            T_Sgpad_Comp_Comentario vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_COMP_COMENTARIO.USP_PAG_COMP_COMENTARIO", vCnn))
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
                        vEntidad = new T_Sgpad_Comp_Comentario(vRdr);
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