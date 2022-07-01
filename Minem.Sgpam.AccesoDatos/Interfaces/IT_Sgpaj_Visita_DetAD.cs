using Minem.Sgpam.Entidades;
using System.Collections.Generic;

namespace Minem.Sgpam.AccesoDatos.Interfaces
{
    /// <summary>
    /// Objetivo:	Interfaz que matricula las operaciones para la tabla T_SGPAJ_VISITA_DET
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public interface IT_Sgpaj_Visita_DetAD
    {
        IEnumerable<T_Sgpaj_Visita_Det> ListarT_Sgpaj_Visita_Det();
        T_Sgpaj_Visita_Det RecuperarT_Sgpaj_Visita_DetPorCodigo(int vId_Visita_Det);
        T_Sgpaj_Visita_Det InsertarT_Sgpaj_Visita_Det(T_Sgpaj_Visita_Det vT_Sgpaj_Visita_Det);
        T_Sgpaj_Visita_Det ActualizarT_Sgpaj_Visita_Det(T_Sgpaj_Visita_Det vT_Sgpaj_Visita_Det);
        int AnularT_Sgpaj_Visita_DetPorCodigo(T_Sgpaj_Visita_Det vT_Sgpaj_Visita_Det);
        IEnumerable<T_Sgpaj_Visita_Det> ListarPaginadoT_Sgpaj_Visita_Det(string vFiltro, int vNumPag, int vCantRegxPag);
        IEnumerable<T_Sgpaj_Visita_Det> ListarPorIdVisitaT_Sgpaj_Visita_Det(int vId_Visita);
    }
}