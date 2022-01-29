using Minem.Sgpam.Entidades;
using System.Collections.Generic;

namespace Minem.Sgpam.AccesoDatos.Interfaces
{
    /// <summary>
    /// Objetivo:	Interfaz que matricula las operaciones para la tabla T_SGPAM_VISITA
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public interface IT_Sgpam_VisitaAD
    {
        IEnumerable<T_Sgpam_Visita> ListarT_Sgpam_Visita();
        T_Sgpam_Visita RecuperarT_Sgpam_VisitaPorCodigo(int vId_Visita);
        T_Sgpam_Visita InsertarT_Sgpam_Visita(T_Sgpam_Visita vT_Sgpam_Visita);
        T_Sgpam_Visita ActualizarT_Sgpam_Visita(T_Sgpam_Visita vT_Sgpam_Visita);
        int AnularT_Sgpam_VisitaPorCodigo(int vId_Visita);
        IEnumerable<T_Sgpam_Visita> ListarPaginadoT_Sgpam_Visita(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}