using Minem.Sgpam.Entidades;
using System.Collections.Generic;

namespace Minem.Sgpam.AccesoDatos.Interfaces
{
    /// <summary>
    /// Objetivo:	Interfaz que matricula las operaciones para la tabla T_SGPAL_CUENCA_HIDROGRAFICA
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public interface IT_Sgpal_Cuenca_HidrograficaAD
    {
        IEnumerable<T_Sgpal_Cuenca_Hidrografica> ListarT_Sgpal_Cuenca_Hidrografica();
        T_Sgpal_Cuenca_Hidrografica RecuperarT_Sgpal_Cuenca_HidrograficaPorCodigo(int vId_Cuenca_Hidro);
        T_Sgpal_Cuenca_Hidrografica InsertarT_Sgpal_Cuenca_Hidrografica(T_Sgpal_Cuenca_Hidrografica vT_Sgpal_Cuenca_Hidrografica);
        T_Sgpal_Cuenca_Hidrografica ActualizarT_Sgpal_Cuenca_Hidrografica(T_Sgpal_Cuenca_Hidrografica vT_Sgpal_Cuenca_Hidrografica);
        int AnularT_Sgpal_Cuenca_HidrograficaPorCodigo(int vId_Cuenca_Hidro);
        IEnumerable<T_Sgpal_Cuenca_Hidrografica> ListarPaginadoT_Sgpal_Cuenca_Hidrografica(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}