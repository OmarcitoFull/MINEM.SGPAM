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
    public interface IT_Sgpal_Cerca_Area_ProtegidaLN
    {
        IEnumerable<Cerca_Area_ProtegidaDTO> ListarCerca_Area_ProtegidaDTO();
        Cerca_Area_ProtegidaDTO RecuperarCerca_Area_ProtegidaDTOPorCodigo(int vId_Cerca_Area_Protegida);
        Cerca_Area_ProtegidaDTO InsertarCerca_Area_ProtegidaDTO(Cerca_Area_ProtegidaDTO vCerca_Area_ProtegidaDTO);
        Cerca_Area_ProtegidaDTO ActualizarCerca_Area_ProtegidaDTO(Cerca_Area_ProtegidaDTO vCerca_Area_ProtegidaDTO);
        int AnularCerca_Area_ProtegidaDTOPorCodigo(Cerca_Area_ProtegidaDTO vCerca_Area_ProtegidaDTO);
        IEnumerable<Cerca_Area_ProtegidaDTO> ListarPaginadoCerca_Area_ProtegidaDTO(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}