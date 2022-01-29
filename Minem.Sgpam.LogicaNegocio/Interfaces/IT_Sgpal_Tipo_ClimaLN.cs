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
    public interface IT_Sgpal_Tipo_ClimaLN
    {
        IEnumerable<Tipo_ClimaDTO> ListarTipo_ClimaDTO();
        Tipo_ClimaDTO RecuperarTipo_ClimaDTOPorCodigo(int vId_Tipo_Clima);
        Tipo_ClimaDTO InsertarTipo_ClimaDTO(Tipo_ClimaDTO vTipo_ClimaDTO);
        Tipo_ClimaDTO ActualizarTipo_ClimaDTO(Tipo_ClimaDTO vTipo_ClimaDTO);
        int AnularTipo_ClimaDTOPorCodigo(Tipo_ClimaDTO vTipo_ClimaDTO);
        IEnumerable<Tipo_ClimaDTO> ListarPaginadoTipo_ClimaDTO(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}