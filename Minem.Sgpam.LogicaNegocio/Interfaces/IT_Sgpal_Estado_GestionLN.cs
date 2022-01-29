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
    public interface IT_Sgpal_Estado_GestionLN
    {
        IEnumerable<Estado_GestionDTO> ListarEstado_GestionDTO();
        Estado_GestionDTO RecuperarEstado_GestionDTOPorCodigo(int vId_Estado_Gestion);
        Estado_GestionDTO InsertarEstado_GestionDTO(Estado_GestionDTO vEstado_GestionDTO);
        Estado_GestionDTO ActualizarEstado_GestionDTO(Estado_GestionDTO vEstado_GestionDTO);
        int AnularEstado_GestionDTOPorCodigo(Estado_GestionDTO vEstado_GestionDTO);
        IEnumerable<Estado_GestionDTO> ListarPaginadoEstado_GestionDTO(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}