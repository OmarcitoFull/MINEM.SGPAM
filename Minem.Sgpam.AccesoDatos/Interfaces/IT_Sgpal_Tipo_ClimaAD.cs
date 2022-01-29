using Minem.Sgpam.Entidades;
using System.Collections.Generic;

namespace Minem.Sgpam.AccesoDatos.Interfaces
{
    /// <summary>
    /// Objetivo:	Interfaz que matricula las operaciones para la tabla T_SGPAL_TIPO_CLIMA
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public interface IT_Sgpal_Tipo_ClimaAD
    {
        IEnumerable<T_Sgpal_Tipo_Clima> ListarT_Sgpal_Tipo_Clima();
        T_Sgpal_Tipo_Clima RecuperarT_Sgpal_Tipo_ClimaPorCodigo(int vId_Tipo_Clima);
        T_Sgpal_Tipo_Clima InsertarT_Sgpal_Tipo_Clima(T_Sgpal_Tipo_Clima vT_Sgpal_Tipo_Clima);
        T_Sgpal_Tipo_Clima ActualizarT_Sgpal_Tipo_Clima(T_Sgpal_Tipo_Clima vT_Sgpal_Tipo_Clima);
        int AnularT_Sgpal_Tipo_ClimaPorCodigo(int vId_Tipo_Clima);
        IEnumerable<T_Sgpal_Tipo_Clima> ListarPaginadoT_Sgpal_Tipo_Clima(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}