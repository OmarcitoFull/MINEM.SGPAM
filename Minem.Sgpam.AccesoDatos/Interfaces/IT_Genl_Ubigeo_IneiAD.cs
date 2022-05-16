using Minem.Sgpam.Entidades;
using System.Collections.Generic;

namespace Minem.Sgpam.AccesoDatos.Interfaces
{
    /// <summary>
    /// Objetivo:	Interfaz que matricula las operaciones para la tabla T_GENL_UBIGEO_INEI
    /// Creado Por:	Mateo Salvador Paucar
    /// Fecha Creación:	31/03/2022
    /// </summary>
    public interface IT_Genl_Ubigeo_IneiAD
    {
        IEnumerable<V_Genl_Ubigeo_Inei> ListarT_Genl_Ubigeo_Inei();

    }
}
