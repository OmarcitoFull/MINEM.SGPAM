using Minem.Sgpam.Entidades;
using System.Collections.Generic;

namespace Minem.Sgpam.AccesoDatos.Interfaces
{
    /// <summary>
    /// Objetivo:	Interfaz que matricula las operaciones para la tabla T_SGPAL_TIPO_ENCARGO
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public interface IT_Sgpal_Tipo_EncargoAD
    {
        IEnumerable<T_Sgpal_Tipo_Encargo> ListarT_Sgpal_Tipo_Encargo();
        T_Sgpal_Tipo_Encargo RecuperarT_Sgpal_Tipo_EncargoPorCodigo(int vId_Tipo_Encargo);
        T_Sgpal_Tipo_Encargo InsertarT_Sgpal_Tipo_Encargo(T_Sgpal_Tipo_Encargo vT_Sgpal_Tipo_Encargo);
        T_Sgpal_Tipo_Encargo ActualizarT_Sgpal_Tipo_Encargo(T_Sgpal_Tipo_Encargo vT_Sgpal_Tipo_Encargo);
        int AnularT_Sgpal_Tipo_EncargoPorCodigo(int vId_Tipo_Encargo);
        IEnumerable<T_Sgpal_Tipo_Encargo> ListarPaginadoT_Sgpal_Tipo_Encargo(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}