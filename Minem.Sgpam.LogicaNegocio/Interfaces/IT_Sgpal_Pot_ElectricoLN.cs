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
    public interface IT_Sgpal_Pot_ElectricoLN
    {
        IEnumerable<Pot_ElectricoDTO> ListarPot_ElectricoDTO();
        Pot_ElectricoDTO RecuperarPot_ElectricoDTOPorCodigo(int vId_Pot_Electrico);
        Pot_ElectricoDTO InsertarPot_ElectricoDTO(Pot_ElectricoDTO vPot_ElectricoDTO);
        Pot_ElectricoDTO ActualizarPot_ElectricoDTO(Pot_ElectricoDTO vPot_ElectricoDTO);
        int AnularPot_ElectricoDTOPorCodigo(Pot_ElectricoDTO vPot_ElectricoDTO);
        IEnumerable<Pot_ElectricoDTO> ListarPaginadoPot_ElectricoDTO(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}