using Minem.Sgpam.Entidades;
using System.Collections.Generic;

namespace Minem.Sgpam.AccesoDatos.Interfaces
{
    /// <summary>
    /// Objetivo:	Interfaz que matricula las operaciones para la tabla T_SGPAL_ACCESO_FAUNA
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public interface IT_Sgpal_Acceso_FaunaAD
    {
        IEnumerable<T_Sgpal_Acceso_Fauna> ListarT_Sgpal_Acceso_Fauna();
        T_Sgpal_Acceso_Fauna RecuperarT_Sgpal_Acceso_FaunaPorCodigo(int vId_Acceso_Fauna);
        T_Sgpal_Acceso_Fauna InsertarT_Sgpal_Acceso_Fauna(T_Sgpal_Acceso_Fauna vT_Sgpal_Acceso_Fauna);
        T_Sgpal_Acceso_Fauna ActualizarT_Sgpal_Acceso_Fauna(T_Sgpal_Acceso_Fauna vT_Sgpal_Acceso_Fauna);
        int AnularT_Sgpal_Acceso_FaunaPorCodigo(int vId_Acceso_Fauna);
        IEnumerable<T_Sgpal_Acceso_Fauna> ListarPaginadoT_Sgpal_Acceso_Fauna(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}