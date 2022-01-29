using Minem.Sgpam.Entidades;
using System.Collections.Generic;

namespace Minem.Sgpam.AccesoDatos.Interfaces
{
    /// <summary>
    /// Objetivo:	Interfaz que matricula las operaciones para la tabla T_SGPAL_AGUA_CONTAMINADA
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public interface IT_Sgpal_Agua_ContaminadaAD
    {
        IEnumerable<T_Sgpal_Agua_Contaminada> ListarT_Sgpal_Agua_Contaminada();
        T_Sgpal_Agua_Contaminada RecuperarT_Sgpal_Agua_ContaminadaPorCodigo(int vId_Agua_Contaminada);
        T_Sgpal_Agua_Contaminada InsertarT_Sgpal_Agua_Contaminada(T_Sgpal_Agua_Contaminada vT_Sgpal_Agua_Contaminada);
        T_Sgpal_Agua_Contaminada ActualizarT_Sgpal_Agua_Contaminada(T_Sgpal_Agua_Contaminada vT_Sgpal_Agua_Contaminada);
        int AnularT_Sgpal_Agua_ContaminadaPorCodigo(int vId_Agua_Contaminada);
        IEnumerable<T_Sgpal_Agua_Contaminada> ListarPaginadoT_Sgpal_Agua_Contaminada(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}