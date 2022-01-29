using Minem.Sgpam.Entidades;
using System.Collections.Generic;

namespace Minem.Sgpam.AccesoDatos.Interfaces
{
    /// <summary>
    /// Objetivo:	Interfaz que matricula las operaciones para la tabla T_SGPAL_AIRE_ACONDICIONADO
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public interface IT_Sgpal_Aire_AcondicionadoAD
    {
        IEnumerable<T_Sgpal_Aire_Acondicionado> ListarT_Sgpal_Aire_Acondicionado();
        T_Sgpal_Aire_Acondicionado RecuperarT_Sgpal_Aire_AcondicionadoPorCodigo(int vId_Aire_Acondicionado);
        T_Sgpal_Aire_Acondicionado InsertarT_Sgpal_Aire_Acondicionado(T_Sgpal_Aire_Acondicionado vT_Sgpal_Aire_Acondicionado);
        T_Sgpal_Aire_Acondicionado ActualizarT_Sgpal_Aire_Acondicionado(T_Sgpal_Aire_Acondicionado vT_Sgpal_Aire_Acondicionado);
        int AnularT_Sgpal_Aire_AcondicionadoPorCodigo(int vId_Aire_Acondicionado);
        IEnumerable<T_Sgpal_Aire_Acondicionado> ListarPaginadoT_Sgpal_Aire_Acondicionado(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}