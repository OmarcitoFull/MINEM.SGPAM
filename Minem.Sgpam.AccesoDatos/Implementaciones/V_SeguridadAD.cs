using Microsoft.Extensions.Configuration;
using Minem.Sgpam.AccesoDatos.Base;
using Minem.Sgpam.AccesoDatos.Interfaces;
using Minem.Sgpam.Entidades;
using Minem.Sgpam.Entidades.Entidades;
using Minem.Sgpam.InfraEstructura;
using Oracle.ManagedDataAccess.Client;
using System.Collections.Generic;
using System.Data;

namespace Minem.Sgpam.AccesoDatos.Implementaciones
{
    /// <summary>
    /// Objetivo:	Clase que genera los reportes para distintos informes
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	01/06/2022
    /// </summary>
    public partial class V_SeguridadAD : BaseAD, IV_SeguridadAD
    {
        public V_SeguridadAD(IConfiguration vConfiguration)
        {
            CnnString = vConfiguration.GetSection(Constantes.BD).Value;
        }

        public IEnumerable<V_UsuarioRoles> ListarUsuarioRoles(int vAplicacion, string vUsuario)
        {
            List<V_UsuarioRoles> vLista = new List<V_UsuarioRoles>();
            V_UsuarioRoles vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_SEGURIDAD.USP_LIS_ROLES", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pAPLICACION", vAplicacion);
                    vCmd.Parameters.Add("pUSUARIO", vUsuario);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new V_UsuarioRoles(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }

        public IEnumerable<V_RolOpciones> ListarRolOpciones(int vAplicacion, int vRol)
        {
            List<V_RolOpciones> vLista = new List<V_RolOpciones>();
            V_RolOpciones vEntidad;

            using (OracleConnection vCnn = new OracleConnection(CnnString))
            {
                using (OracleCommand vCmd = new OracleCommand("SIGEPAM.PKG_SEGURIDAD.USP_LIS_OPCIONES", vCnn))
                {
                    vCmd.CommandType = CommandType.StoredProcedure;
                    vCmd.Parameters.Add("pAPLICACION", vAplicacion);
                    vCmd.Parameters.Add("pROL", vRol);
                    vCmd.Parameters.Add("c_Cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    vCnn.Open();
                    OracleDataReader vRdr = vCmd.ExecuteReader();
                    while (vRdr.Read())
                    {
                        vEntidad = new V_RolOpciones(vRdr);
                        vLista.Add(vEntidad);
                    }
                }
                vCnn.Close();
            }
            return vLista;
        }
    }
}
