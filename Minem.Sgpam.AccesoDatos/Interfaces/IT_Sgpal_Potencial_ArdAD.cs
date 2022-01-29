using Minem.Sgpam.Entidades;
using System.Collections.Generic;

namespace Minem.Sgpam.AccesoDatos.Interfaces
{
    /// <summary>
    /// Objetivo:	Interfaz que matricula las operaciones para la tabla T_SGPAL_POTENCIAL_ARD
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public interface IT_Sgpal_Potencial_ArdAD
    {
        IEnumerable<T_Sgpal_Potencial_Ard> ListarT_Sgpal_Potencial_Ard();
        T_Sgpal_Potencial_Ard RecuperarT_Sgpal_Potencial_ArdPorCodigo(int vId_Potencial_Ard);
        T_Sgpal_Potencial_Ard InsertarT_Sgpal_Potencial_Ard(T_Sgpal_Potencial_Ard vT_Sgpal_Potencial_Ard);
        T_Sgpal_Potencial_Ard ActualizarT_Sgpal_Potencial_Ard(T_Sgpal_Potencial_Ard vT_Sgpal_Potencial_Ard);
        int AnularT_Sgpal_Potencial_ArdPorCodigo(int vId_Potencial_Ard);
        IEnumerable<T_Sgpal_Potencial_Ard> ListarPaginadoT_Sgpal_Potencial_Ard(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}