using Minem.Sgpam.Entidades;
using System.Collections.Generic;

namespace Minem.Sgpam.AccesoDatos.Interfaces
{
    /// <summary>
    /// Objetivo:	Interfaz que matricula las operaciones para la tabla T_SGPAL_ATRACCION_FAUNA
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public interface IT_Sgpal_Atraccion_FaunaAD
    {
        IEnumerable<T_Sgpal_Atraccion_Fauna> ListarT_Sgpal_Atraccion_Fauna();
        T_Sgpal_Atraccion_Fauna RecuperarT_Sgpal_Atraccion_FaunaPorCodigo(int vId_Atraccion_Fauna);
        T_Sgpal_Atraccion_Fauna InsertarT_Sgpal_Atraccion_Fauna(T_Sgpal_Atraccion_Fauna vT_Sgpal_Atraccion_Fauna);
        T_Sgpal_Atraccion_Fauna ActualizarT_Sgpal_Atraccion_Fauna(T_Sgpal_Atraccion_Fauna vT_Sgpal_Atraccion_Fauna);
        int AnularT_Sgpal_Atraccion_FaunaPorCodigo(int vId_Atraccion_Fauna);
        IEnumerable<T_Sgpal_Atraccion_Fauna> ListarPaginadoT_Sgpal_Atraccion_Fauna(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}