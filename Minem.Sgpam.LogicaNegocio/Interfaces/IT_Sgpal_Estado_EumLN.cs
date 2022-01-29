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
    public interface IT_Sgpal_Estado_EumLN
    {
        IEnumerable<Estado_EumDTO> ListarEstado_EumDTO();
        Estado_EumDTO RecuperarEstado_EumDTOPorCodigo(int vId_Estado_Eum);
        Estado_EumDTO InsertarEstado_EumDTO(Estado_EumDTO vEstado_EumDTO);
        Estado_EumDTO ActualizarEstado_EumDTO(Estado_EumDTO vEstado_EumDTO);
        int AnularEstado_EumDTOPorCodigo(Estado_EumDTO vEstado_EumDTO);
        IEnumerable<Estado_EumDTO> ListarPaginadoEstado_EumDTO(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}