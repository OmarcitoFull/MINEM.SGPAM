using Minem.Sgpam.Entidades;
using System.Collections.Generic;

namespace Minem.Sgpam.AccesoDatos.Interfaces
{
    /// <summary>
    /// Objetivo:	Interfaz que matricula las operaciones para la tabla T_SGPAL_TIPO_MINERIA
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public interface IT_Sgpal_Tipo_MineriaAD
    {
        IEnumerable<T_Sgpal_Tipo_Mineria> ListarT_Sgpal_Tipo_Mineria();
        T_Sgpal_Tipo_Mineria RecuperarT_Sgpal_Tipo_MineriaPorCodigo(int vId_Tipo_Mineria);
        T_Sgpal_Tipo_Mineria InsertarT_Sgpal_Tipo_Mineria(T_Sgpal_Tipo_Mineria vT_Sgpal_Tipo_Mineria);
        T_Sgpal_Tipo_Mineria ActualizarT_Sgpal_Tipo_Mineria(T_Sgpal_Tipo_Mineria vT_Sgpal_Tipo_Mineria);
        int AnularT_Sgpal_Tipo_MineriaPorCodigo(int vId_Tipo_Mineria);
        IEnumerable<T_Sgpal_Tipo_Mineria> ListarPaginadoT_Sgpal_Tipo_Mineria(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}