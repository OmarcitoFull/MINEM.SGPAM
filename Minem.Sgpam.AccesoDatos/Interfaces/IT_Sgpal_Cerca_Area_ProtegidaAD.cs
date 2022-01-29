using Minem.Sgpam.Entidades;
using System.Collections.Generic;

namespace Minem.Sgpam.AccesoDatos.Interfaces
{
    /// <summary>
    /// Objetivo:	Interfaz que matricula las operaciones para la tabla T_SGPAL_CERCA_AREA_PROTEGIDA
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public interface IT_Sgpal_Cerca_Area_ProtegidaAD
    {
        IEnumerable<T_Sgpal_Cerca_Area_Protegida> ListarT_Sgpal_Cerca_Area_Protegida();
        T_Sgpal_Cerca_Area_Protegida RecuperarT_Sgpal_Cerca_Area_ProtegidaPorCodigo(int vId_Cerca_Area_Protegida);
        T_Sgpal_Cerca_Area_Protegida InsertarT_Sgpal_Cerca_Area_Protegida(T_Sgpal_Cerca_Area_Protegida vT_Sgpal_Cerca_Area_Protegida);
        T_Sgpal_Cerca_Area_Protegida ActualizarT_Sgpal_Cerca_Area_Protegida(T_Sgpal_Cerca_Area_Protegida vT_Sgpal_Cerca_Area_Protegida);
        int AnularT_Sgpal_Cerca_Area_ProtegidaPorCodigo(int vId_Cerca_Area_Protegida);
        IEnumerable<T_Sgpal_Cerca_Area_Protegida> ListarPaginadoT_Sgpal_Cerca_Area_Protegida(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}