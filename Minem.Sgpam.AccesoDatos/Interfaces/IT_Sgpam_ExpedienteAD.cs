using Minem.Sgpam.Entidades;
using System.Collections.Generic;

namespace Minem.Sgpam.AccesoDatos.Interfaces
{
    /// <summary>
    /// Objetivo:	Interfaz que matricula las operaciones para la tabla T_SGPAM_EXPEDIENTE
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public interface IT_Sgpam_ExpedienteAD
    {
        IEnumerable<T_Sgpam_Expediente> ListarT_Sgpam_Expediente();
        T_Sgpam_Expediente RecuperarT_Sgpam_ExpedientePorCodigo(int vId_Expediente);
        T_Sgpam_Expediente InsertarT_Sgpam_Expediente(T_Sgpam_Expediente vT_Sgpam_Expediente);
        T_Sgpam_Expediente ActualizarT_Sgpam_Expediente(T_Sgpam_Expediente vT_Sgpam_Expediente);
        int AnularT_Sgpam_ExpedientePorCodigo(int vId_Expediente);
        IEnumerable<T_Sgpam_Expediente> ListarPaginadoT_Sgpam_Expediente(string vNroExp, string vFiltro, int vNumPag, int vCantRegxPag);
    }
}