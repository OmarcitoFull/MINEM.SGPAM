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
    public interface IT_Sgpal_Pot_Explosion_IncendioLN
    {
        IEnumerable<Pot_Explosion_IncendioDTO> ListarPot_Explosion_IncendioDTO();
        Pot_Explosion_IncendioDTO RecuperarPot_Explosion_IncendioDTOPorCodigo();
        Pot_Explosion_IncendioDTO InsertarPot_Explosion_IncendioDTO(Pot_Explosion_IncendioDTO vPot_Explosion_IncendioDTO);
        Pot_Explosion_IncendioDTO ActualizarPot_Explosion_IncendioDTO(Pot_Explosion_IncendioDTO vPot_Explosion_IncendioDTO);
        int AnularPot_Explosion_IncendioDTOPorCodigo(Pot_Explosion_IncendioDTO vPot_Explosion_IncendioDTO);
        IEnumerable<Pot_Explosion_IncendioDTO> ListarPaginadoPot_Explosion_IncendioDTO(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}