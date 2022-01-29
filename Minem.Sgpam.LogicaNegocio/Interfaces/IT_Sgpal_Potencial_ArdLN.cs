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
    public interface IT_Sgpal_Potencial_ArdLN
    {
        IEnumerable<Potencial_ArdDTO> ListarPotencial_ArdDTO();
        Potencial_ArdDTO RecuperarPotencial_ArdDTOPorCodigo(int vId_Potencial_Ard);
        Potencial_ArdDTO InsertarPotencial_ArdDTO(Potencial_ArdDTO vPotencial_ArdDTO);
        Potencial_ArdDTO ActualizarPotencial_ArdDTO(Potencial_ArdDTO vPotencial_ArdDTO);
        int AnularPotencial_ArdDTOPorCodigo(Potencial_ArdDTO vPotencial_ArdDTO);
        IEnumerable<Potencial_ArdDTO> ListarPaginadoPotencial_ArdDTO(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}