using Minem.Sgpam.Entidades;
using System.Collections.Generic;

namespace Minem.Sgpam.AccesoDatos.Interfaces
{
    /// <summary>
    /// Objetivo:	Interfaz que matricula las operaciones para la tabla T_SGPAL_COBERTURA
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public interface IT_Sgpal_CoberturaAD
    {
        IEnumerable<T_Sgpal_Cobertura> ListarT_Sgpal_Cobertura();
        T_Sgpal_Cobertura RecuperarT_Sgpal_CoberturaPorCodigo(int vId_Cobertura);
        T_Sgpal_Cobertura InsertarT_Sgpal_Cobertura(T_Sgpal_Cobertura vT_Sgpal_Cobertura);
        T_Sgpal_Cobertura ActualizarT_Sgpal_Cobertura(T_Sgpal_Cobertura vT_Sgpal_Cobertura);
        int AnularT_Sgpal_CoberturaPorCodigo(int vId_Cobertura);
        IEnumerable<T_Sgpal_Cobertura> ListarPaginadoT_Sgpal_Cobertura(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}