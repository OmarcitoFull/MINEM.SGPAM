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
    public interface IT_Sgpal_Agua_ContaminadaLN
    {
        IEnumerable<Agua_ContaminadaDTO> ListarAgua_ContaminadaDTO();
        Agua_ContaminadaDTO RecuperarAgua_ContaminadaDTOPorCodigo(int vId_Agua_Contaminada);
        Agua_ContaminadaDTO InsertarAgua_ContaminadaDTO(Agua_ContaminadaDTO vAgua_ContaminadaDTO);
        Agua_ContaminadaDTO ActualizarAgua_ContaminadaDTO(Agua_ContaminadaDTO vAgua_ContaminadaDTO);
        int AnularAgua_ContaminadaDTOPorCodigo(Agua_ContaminadaDTO vAgua_ContaminadaDTO);
        IEnumerable<Agua_ContaminadaDTO> ListarPaginadoAgua_ContaminadaDTO(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}