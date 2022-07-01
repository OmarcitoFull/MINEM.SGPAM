using Minem.Sgpam.TransporteDatos.DtoEntidades;
using System.Collections.Generic;
using System;

namespace Minem.Sgpam.LogicaNegocio.Interfaces
{
    /// <summary>
    /// Objetivo:	Interfaz que matricula las operaciones de las entidades para la lógica de negocio
    /// Creado Por:	Mateo Salvador Paucar
    /// Fecha Creación:	08/04/2022
    /// </summary>
    public interface IT_Sgpad_Visita_PersonaLN
    {
        IEnumerable<Visita_PersonaDTO> ListarVisita_PersonaDTO();
        Visita_PersonaDTO RecuperarVisita_PersonaDTOPorCodigo(int vId_Visita_Persona);
        Visita_PersonaDTO GrabarVisita_PersonaDTO(Visita_PersonaDTO vVisita_PersonaDTO);
        bool AnularVisita_PersonaDTOPorCodigo(Visita_PersonaDTO vVisita_PersonaDTO);
        IEnumerable<Visita_PersonaDTO> ListarPaginadoVisita_PersonaDTO(string vFiltro, int vNumPag, int vCantRegxPag);
        IEnumerable<Visita_PersonaDTO> ListarPorIdVisitaVisita_PersonaDTO(int vId_Visita);
        RegistrarVisitaPersonaDTO RecuperarFullVisita_PersonaDTOPorCodigo(int vId_Visita_Persona);
    }
}
