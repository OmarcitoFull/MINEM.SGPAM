using Minem.Sgpam.Entidades;
using System.Collections.Generic;

namespace Minem.Sgpam.AccesoDatos.Interfaces
{
    /// <summary>
    /// Objetivo:	Interfaz que matricula las operaciones para la tabla T_SGPAD_COMP_MEDICION
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public interface IT_Sgpad_Comp_MedicionAD
    {
        IEnumerable<T_Sgpad_Comp_Medicion> ListarT_Sgpad_Comp_Medicion(int vIdComponente);
        T_Sgpad_Comp_Medicion RecuperarT_Sgpad_Comp_MedicionPorCodigo(int vId_Comp_Medicion);
        T_Sgpad_Comp_Medicion InsertarT_Sgpad_Comp_Medicion(T_Sgpad_Comp_Medicion vT_Sgpad_Comp_Medicion);
        T_Sgpad_Comp_Medicion ActualizarT_Sgpad_Comp_Medicion(T_Sgpad_Comp_Medicion vT_Sgpad_Comp_Medicion);
        int AnularT_Sgpad_Comp_MedicionPorCodigo(int vId_Comp_Medicion);
        IEnumerable<T_Sgpad_Comp_Medicion> ListarPaginadoT_Sgpad_Comp_Medicion(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}