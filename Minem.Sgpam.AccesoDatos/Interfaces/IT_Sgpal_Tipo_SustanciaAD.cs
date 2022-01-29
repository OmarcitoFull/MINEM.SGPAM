using Minem.Sgpam.Entidades;
using System.Collections.Generic;

namespace Minem.Sgpam.AccesoDatos.Interfaces
{
    /// <summary>
    /// Objetivo:	Interfaz que matricula las operaciones para la tabla T_SGPAL_TIPO_SUSTANCIA
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public interface IT_Sgpal_Tipo_SustanciaAD
    {
        IEnumerable<T_Sgpal_Tipo_Sustancia> ListarT_Sgpal_Tipo_Sustancia();
        T_Sgpal_Tipo_Sustancia RecuperarT_Sgpal_Tipo_SustanciaPorCodigo(int vId_Tipo_Sustancia);
        T_Sgpal_Tipo_Sustancia InsertarT_Sgpal_Tipo_Sustancia(T_Sgpal_Tipo_Sustancia vT_Sgpal_Tipo_Sustancia);
        T_Sgpal_Tipo_Sustancia ActualizarT_Sgpal_Tipo_Sustancia(T_Sgpal_Tipo_Sustancia vT_Sgpal_Tipo_Sustancia);
        int AnularT_Sgpal_Tipo_SustanciaPorCodigo(int vId_Tipo_Sustancia);
        IEnumerable<T_Sgpal_Tipo_Sustancia> ListarPaginadoT_Sgpal_Tipo_Sustancia(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}