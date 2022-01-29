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
    public interface IT_Sgpal_Pot_ColapsoLN
    {
        IEnumerable<Pot_ColapsoDTO> ListarPot_ColapsoDTO();
        Pot_ColapsoDTO RecuperarPot_ColapsoDTOPorCodigo(int vId_Pot_Colapso);
        Pot_ColapsoDTO InsertarPot_ColapsoDTO(Pot_ColapsoDTO vPot_ColapsoDTO);
        Pot_ColapsoDTO ActualizarPot_ColapsoDTO(Pot_ColapsoDTO vPot_ColapsoDTO);
        int AnularPot_ColapsoDTOPorCodigo(Pot_ColapsoDTO vPot_ColapsoDTO);
        IEnumerable<Pot_ColapsoDTO> ListarPaginadoPot_ColapsoDTO(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}