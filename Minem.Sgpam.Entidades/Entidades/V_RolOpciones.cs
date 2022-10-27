using System;
using System.Data;

namespace Minem.Sgpam.Entidades
{
    public class V_RolOpciones
    {
        public V_RolOpciones()
        {
        }

        public V_RolOpciones(IDataReader vRdr)
        {
            if (!Convert.IsDBNull(vRdr["ID_SIS"]))
            {
                this.Id_Sis = Convert.ToInt32(vRdr["ID_SIS"]);
            }

            if (!Convert.IsDBNull(vRdr["ID_OPCION"]))
            {
                this.Id_Opcion = Convert.ToInt32(vRdr["ID_OPCION"]);
            }

            if (!Convert.IsDBNull(vRdr["ID_OPCION_PADRE"]))
            {
                this.Id_Opcion_Padre = Convert.ToInt32(vRdr["ID_OPCION_PADRE"]);
            }

            if (!Convert.IsDBNull(vRdr["DES_OPCION"]))
            {
                this.Des_Opcion = Convert.ToString(vRdr["DES_OPCION"]);
            }

            if (!Convert.IsDBNull(vRdr["NUM_ORDEN"]))
            {
                this.Num_Orden = Convert.ToInt32(vRdr["NUM_ORDEN"]);
            }

            if (!Convert.IsDBNull(vRdr["NUM_NIVEL"]))
            {
                this.Num_Nivel = Convert.ToInt32(vRdr["NUM_NIVEL"]);
            }
        }

        public int Id_Sis { get; set; }
        public int Id_Opcion { get; set; }
        public int Id_Opcion_Padre { get; set; }
        public string Des_Opcion { get; set; }
        public int Num_Orden { get; set; }
        public int Num_Nivel { get; set; }
    }
}
