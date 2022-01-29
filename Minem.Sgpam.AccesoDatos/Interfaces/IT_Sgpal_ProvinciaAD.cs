using Minem.Sgpam.Entidades;
using System.Collections.Generic;

namespace Minem.Sgpam.AccesoDatos.Interfaces
{
    /// <summary>
    /// Objetivo:	Interfaz que matricula las operaciones para la tabla T_SGPAL_PROVINCIA
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public interface IT_Sgpal_ProvinciaAD
    {
        IEnumerable<T_Sgpal_Provincia> ListarT_Sgpal_Provincia();
        T_Sgpal_Provincia RecuperarT_Sgpal_ProvinciaPorCodigo(int vId_Provincia);
        T_Sgpal_Provincia InsertarT_Sgpal_Provincia(T_Sgpal_Provincia vT_Sgpal_Provincia);
        T_Sgpal_Provincia ActualizarT_Sgpal_Provincia(T_Sgpal_Provincia vT_Sgpal_Provincia);
        int AnularT_Sgpal_ProvinciaPorCodigo(int vId_Provincia);
        IEnumerable<T_Sgpal_Provincia> ListarPaginadoT_Sgpal_Provincia(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}