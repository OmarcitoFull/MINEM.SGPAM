using Minem.Sgpam.TransporteDatos.DtoEntidades;
using System.Collections.Generic;
using System;

namespace Minem.Sgpam.LogicaNegocio.Interfaces
{
    /// <summary>
    /// Objetivo:	Interfaz que matricula las operaciones de las entidades para la lógica de negocio
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	29/10/2021
    /// </summary>
    public interface IT_Sgpal_Pot_Caida_PersonaLN
    {
        IEnumerable<Pot_Caida_PersonaDTO> ListarPot_Caida_PersonaDTO();
        Pot_Caida_PersonaDTO RecuperarPot_Caida_PersonaDTOPorCodigo(int vId_Pot_Caida_Persona);
        Pot_Caida_PersonaDTO InsertarPot_Caida_PersonaDTO(Pot_Caida_PersonaDTO vPot_Caida_PersonaDTO);
        Pot_Caida_PersonaDTO ActualizarPot_Caida_PersonaDTO(Pot_Caida_PersonaDTO vPot_Caida_PersonaDTO);
        int AnularPot_Caida_PersonaDTOPorCodigo(Pot_Caida_PersonaDTO vPot_Caida_PersonaDTO);
        IEnumerable<Pot_Caida_PersonaDTO> ListarPaginadoPot_Caida_PersonaDTO(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}