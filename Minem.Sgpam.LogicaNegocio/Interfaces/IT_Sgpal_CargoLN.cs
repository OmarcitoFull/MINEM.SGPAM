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
    public interface IT_Sgpal_CargoLN
    {
        IEnumerable<CargoDTO> ListarCargoDTO();
        CargoDTO RecuperarCargoDTOPorCodigo(int vId_Cargo);
        CargoDTO InsertarCargoDTO(CargoDTO vCargoDTO);
        CargoDTO ActualizarCargoDTO(CargoDTO vCargoDTO);
        int AnularCargoDTOPorCodigo(CargoDTO vCargoDTO);
        IEnumerable<CargoDTO> ListarPaginadoCargoDTO(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}
