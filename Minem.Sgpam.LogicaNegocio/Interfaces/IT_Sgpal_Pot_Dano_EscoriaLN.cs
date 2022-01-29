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
    public interface IT_Sgpal_Pot_Dano_EscoriaLN
    {
        IEnumerable<Pot_Dano_EscoriaDTO> ListarPot_Dano_EscoriaDTO();
        Pot_Dano_EscoriaDTO RecuperarPot_Dano_EscoriaDTOPorCodigo(int vId_Pot_Dano_Escoria);
        Pot_Dano_EscoriaDTO InsertarPot_Dano_EscoriaDTO(Pot_Dano_EscoriaDTO vPot_Dano_EscoriaDTO);
        Pot_Dano_EscoriaDTO ActualizarPot_Dano_EscoriaDTO(Pot_Dano_EscoriaDTO vPot_Dano_EscoriaDTO);
        int AnularPot_Dano_EscoriaDTOPorCodigo(Pot_Dano_EscoriaDTO vPot_Dano_EscoriaDTO);
        IEnumerable<Pot_Dano_EscoriaDTO> ListarPaginadoPot_Dano_EscoriaDTO(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}