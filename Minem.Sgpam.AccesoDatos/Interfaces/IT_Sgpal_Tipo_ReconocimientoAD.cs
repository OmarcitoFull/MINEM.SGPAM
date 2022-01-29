using Minem.Sgpam.Entidades;
using System.Collections.Generic;

namespace Minem.Sgpam.AccesoDatos.Interfaces
{
    /// <summary>
    /// Objetivo:	Interfaz que matricula las operaciones para la tabla T_SGPAL_TIPO_RECONOCIMIENTO
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public interface IT_Sgpal_Tipo_ReconocimientoAD
    {
        IEnumerable<T_Sgpal_Tipo_Reconocimiento> ListarT_Sgpal_Tipo_Reconocimiento();
        T_Sgpal_Tipo_Reconocimiento RecuperarT_Sgpal_Tipo_ReconocimientoPorCodigo(int vId_Tipo_Reconocimiento);
        T_Sgpal_Tipo_Reconocimiento InsertarT_Sgpal_Tipo_Reconocimiento(T_Sgpal_Tipo_Reconocimiento vT_Sgpal_Tipo_Reconocimiento);
        T_Sgpal_Tipo_Reconocimiento ActualizarT_Sgpal_Tipo_Reconocimiento(T_Sgpal_Tipo_Reconocimiento vT_Sgpal_Tipo_Reconocimiento);
        int AnularT_Sgpal_Tipo_ReconocimientoPorCodigo(int vId_Tipo_Reconocimiento);
        IEnumerable<T_Sgpal_Tipo_Reconocimiento> ListarPaginadoT_Sgpal_Tipo_Reconocimiento(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}