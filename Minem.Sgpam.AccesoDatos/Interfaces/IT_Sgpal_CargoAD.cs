using Minem.Sgpam.Entidades;
using System.Collections.Generic;

namespace Minem.Sgpam.AccesoDatos.Interfaces
{
    /// <summary>
    /// Objetivo:	Interfaz que matricula las operaciones para la tabla T_SGPAL_TIPO_OPERACION
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public interface IT_Sgpal_CargoAD
    {
        IEnumerable<T_Sgpal_Cargo> ListarT_Sgpal_Cargo();
        T_Sgpal_Cargo RecuperarT_Sgpal_CargoPorCodigo(int vId_Cargo);
        T_Sgpal_Cargo InsertarT_Sgpal_Cargo(T_Sgpal_Cargo vT_Sgpal_Cargo);
        T_Sgpal_Cargo ActualizarT_Sgpal_Cargo(T_Sgpal_Cargo vT_Sgpal_Cargo);
        int AnularT_Sgpal_CargoPorCodigo(int vId_Cargo);
        IEnumerable<T_Sgpal_Cargo> ListarPaginadoT_Sgpal_Cargo(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}
