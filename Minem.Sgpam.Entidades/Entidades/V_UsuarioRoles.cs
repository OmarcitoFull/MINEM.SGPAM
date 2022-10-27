using System;
using System.Data;

namespace Minem.Sgpam.Entidades
{
    public class V_UsuarioRoles
    {
        public V_UsuarioRoles()
        {
        }

        public V_UsuarioRoles(IDataReader vRdr)
        {
            if (!Convert.IsDBNull(vRdr["ID_SIS"]))
            {
                this.Id_Sis = Convert.ToInt32(vRdr["ID_SIS"]);
            }

            if (!Convert.IsDBNull(vRdr["ID_ROL"]))
            {
                this.Id_Rol = Convert.ToInt32(vRdr["ID_ROL"]);
            }

            if (!Convert.IsDBNull(vRdr["DES_ROL"]))
            {
                this.Des_Rol = Convert.ToString(vRdr["DES_ROL"]);
            }

            if (!Convert.IsDBNull(vRdr["ID_USUARIO"]))
            {
                this.Id_Usuario = Convert.ToInt32(vRdr["ID_USUARIO"]);
            }

            if (!Convert.IsDBNull(vRdr["DES_USUARIO"]))
            {
                this.Des_Usuario = Convert.ToString(vRdr["DES_USUARIO"]);
            }

            if (!Convert.IsDBNull(vRdr["DES_NOMBRE"]))
            {
                this.Des_Nombre = Convert.ToString(vRdr["DES_NOMBRE"]);
            }
        }

        public int Id_Sis { get; set; }
        public int Id_Rol { get; set; }
        public string Des_Rol { get; set; }
        public int Id_Usuario { get; set; }
        public string Des_Usuario { get; set; }
        public string Des_Nombre { get; set; }
    }
}
