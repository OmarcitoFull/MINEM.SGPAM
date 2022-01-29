using Minem.Sgpam.Entidades;
using System.Collections.Generic;

namespace Minem.Sgpam.AccesoDatos.Interfaces
{
    /// <summary>
    /// Objetivo:	Interfaz que matricula las operaciones para la tabla T_SGPAL_VEGETACION_INVASIVA
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public interface IT_Sgpal_Vegetacion_InvasivaAD
    {
        IEnumerable<T_Sgpal_Vegetacion_Invasiva> ListarT_Sgpal_Vegetacion_Invasiva();
        T_Sgpal_Vegetacion_Invasiva RecuperarT_Sgpal_Vegetacion_InvasivaPorCodigo(int vId_Vegetacion_Invasiva);
        T_Sgpal_Vegetacion_Invasiva InsertarT_Sgpal_Vegetacion_Invasiva(T_Sgpal_Vegetacion_Invasiva vT_Sgpal_Vegetacion_Invasiva);
        T_Sgpal_Vegetacion_Invasiva ActualizarT_Sgpal_Vegetacion_Invasiva(T_Sgpal_Vegetacion_Invasiva vT_Sgpal_Vegetacion_Invasiva);
        int AnularT_Sgpal_Vegetacion_InvasivaPorCodigo(int vId_Vegetacion_Invasiva);
        IEnumerable<T_Sgpal_Vegetacion_Invasiva> ListarPaginadoT_Sgpal_Vegetacion_Invasiva(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}