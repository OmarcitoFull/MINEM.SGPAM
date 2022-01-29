using Minem.Sgpam.Entidades;
using System.Collections.Generic;

namespace Minem.Sgpam.AccesoDatos.Interfaces
{
    /// <summary>
    /// Objetivo:	Interfaz que matricula las operaciones para la tabla T_SGPAL_PRESENCIA_LIQUIDO
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public interface IT_Sgpal_Presencia_LiquidoAD
    {
        IEnumerable<T_Sgpal_Presencia_Liquido> ListarT_Sgpal_Presencia_Liquido();
        T_Sgpal_Presencia_Liquido RecuperarT_Sgpal_Presencia_LiquidoPorCodigo(int vId_Presencia_Liquido);
        T_Sgpal_Presencia_Liquido InsertarT_Sgpal_Presencia_Liquido(T_Sgpal_Presencia_Liquido vT_Sgpal_Presencia_Liquido);
        T_Sgpal_Presencia_Liquido ActualizarT_Sgpal_Presencia_Liquido(T_Sgpal_Presencia_Liquido vT_Sgpal_Presencia_Liquido);
        int AnularT_Sgpal_Presencia_LiquidoPorCodigo(int vId_Presencia_Liquido);
        IEnumerable<T_Sgpal_Presencia_Liquido> ListarPaginadoT_Sgpal_Presencia_Liquido(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}