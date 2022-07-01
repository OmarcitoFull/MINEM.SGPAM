using Minem.Sgpam.Entidades;
using System.Collections.Generic;

namespace Minem.Sgpam.AccesoDatos.Interfaces
{
    /// <summary>
    /// Objetivo:	Interfaz que matricula las operaciones para la tabla T_SGPAD_COMP_OBSERVACION
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public interface IT_Sgpad_Visita_PersonaAD
    {
        IEnumerable<T_Sgpad_Visita_Persona> ListarT_Sgpad_Visita_Persona();
        T_Sgpad_Visita_Persona RecuperarT_Sgpad_Visita_PersonaPorCodigo(int vId_Visita_Persona);
        T_Sgpad_Visita_Persona InsertarT_Sgpad_Visita_Persona(T_Sgpad_Visita_Persona vT_Sgpad_Visita_Persona);
        T_Sgpad_Visita_Persona ActualizarT_Sgpad_Visita_Persona(T_Sgpad_Visita_Persona vT_Sgpad_Visita_Persona);
        int AnularT_Sgpad_Visita_PersonaPorCodigo(T_Sgpad_Visita_Persona vT_Sgpad_Visita_Persona);
        IEnumerable<T_Sgpad_Visita_Persona> ListarPaginadoT_Sgpad_Visita_Persona(string vFiltro, int vNumPag, int vCantRegxPag);
        IEnumerable<T_Sgpad_Visita_Persona> ListarPorIdVisitaT_Sgpad_Visita_Persona(int vId_Visita);
    }
}
