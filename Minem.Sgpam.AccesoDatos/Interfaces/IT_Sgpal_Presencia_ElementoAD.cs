using Minem.Sgpam.Entidades;
using System.Collections.Generic;

namespace Minem.Sgpam.AccesoDatos.Interfaces
{
    /// <summary>
    /// Objetivo:	Interfaz que matricula las operaciones para la tabla T_SGPAL_PRESENCIA_ELEMENTO
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public interface IT_Sgpal_Presencia_ElementoAD
    {
        IEnumerable<T_Sgpal_Presencia_Elemento> ListarT_Sgpal_Presencia_Elemento();
        T_Sgpal_Presencia_Elemento RecuperarT_Sgpal_Presencia_ElementoPorCodigo(int vId_Presencia_Elemento);
        T_Sgpal_Presencia_Elemento InsertarT_Sgpal_Presencia_Elemento(T_Sgpal_Presencia_Elemento vT_Sgpal_Presencia_Elemento);
        T_Sgpal_Presencia_Elemento ActualizarT_Sgpal_Presencia_Elemento(T_Sgpal_Presencia_Elemento vT_Sgpal_Presencia_Elemento);
        int AnularT_Sgpal_Presencia_ElementoPorCodigo(int vId_Presencia_Elemento);
        IEnumerable<T_Sgpal_Presencia_Elemento> ListarPaginadoT_Sgpal_Presencia_Elemento(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}