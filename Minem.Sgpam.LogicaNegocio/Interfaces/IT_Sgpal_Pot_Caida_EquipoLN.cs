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
    public interface IT_Sgpal_Pot_Caida_EquipoLN
    {
        IEnumerable<Pot_Caida_EquipoDTO> ListarPot_Caida_EquipoDTO();
        Pot_Caida_EquipoDTO RecuperarPot_Caida_EquipoDTOPorCodigo(int vId_Pot_Caida_Equipo);
        Pot_Caida_EquipoDTO InsertarPot_Caida_EquipoDTO(Pot_Caida_EquipoDTO vPot_Caida_EquipoDTO);
        Pot_Caida_EquipoDTO ActualizarPot_Caida_EquipoDTO(Pot_Caida_EquipoDTO vPot_Caida_EquipoDTO);
        int AnularPot_Caida_EquipoDTOPorCodigo(Pot_Caida_EquipoDTO vPot_Caida_EquipoDTO);
        IEnumerable<Pot_Caida_EquipoDTO> ListarPaginadoPot_Caida_EquipoDTO(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}