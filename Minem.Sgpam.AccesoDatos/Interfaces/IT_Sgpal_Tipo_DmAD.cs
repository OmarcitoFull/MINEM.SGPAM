using Minem.Sgpam.Entidades;
using System.Collections.Generic;

namespace Minem.Sgpam.AccesoDatos.Interfaces
{
    /// <summary>
    /// Objetivo:	Interfaz que matricula las operaciones para la tabla T_SGPAL_TIPO_DM
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public interface IT_Sgpal_Tipo_DmAD
    {
        IEnumerable<T_Sgpal_Tipo_Dm> ListarT_Sgpal_Tipo_Dm();
        T_Sgpal_Tipo_Dm RecuperarT_Sgpal_Tipo_DmPorCodigo(int vId_Tipo_Dm);
        T_Sgpal_Tipo_Dm InsertarT_Sgpal_Tipo_Dm(T_Sgpal_Tipo_Dm vT_Sgpal_Tipo_Dm);
        T_Sgpal_Tipo_Dm ActualizarT_Sgpal_Tipo_Dm(T_Sgpal_Tipo_Dm vT_Sgpal_Tipo_Dm);
        int AnularT_Sgpal_Tipo_DmPorCodigo(int vId_Tipo_Dm);
        IEnumerable<T_Sgpal_Tipo_Dm> ListarPaginadoT_Sgpal_Tipo_Dm(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}