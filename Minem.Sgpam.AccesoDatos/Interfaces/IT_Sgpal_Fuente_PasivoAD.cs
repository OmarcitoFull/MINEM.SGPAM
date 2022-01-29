using Minem.Sgpam.Entidades;
using System.Collections.Generic;

namespace Minem.Sgpam.AccesoDatos.Interfaces
{
    /// <summary>
    /// Objetivo:	Interfaz que matricula las operaciones para la tabla T_SGPAL_FUENTE_PASIVO
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public interface IT_Sgpal_Fuente_PasivoAD
    {
        IEnumerable<T_Sgpal_Fuente_Pasivo> ListarT_Sgpal_Fuente_Pasivo();
        T_Sgpal_Fuente_Pasivo RecuperarT_Sgpal_Fuente_PasivoPorCodigo(int vId_Fuente_Pasivo);
        T_Sgpal_Fuente_Pasivo InsertarT_Sgpal_Fuente_Pasivo(T_Sgpal_Fuente_Pasivo vT_Sgpal_Fuente_Pasivo);
        T_Sgpal_Fuente_Pasivo ActualizarT_Sgpal_Fuente_Pasivo(T_Sgpal_Fuente_Pasivo vT_Sgpal_Fuente_Pasivo);
        int AnularT_Sgpal_Fuente_PasivoPorCodigo(int vId_Fuente_Pasivo);
        IEnumerable<T_Sgpal_Fuente_Pasivo> ListarPaginadoT_Sgpal_Fuente_Pasivo(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}