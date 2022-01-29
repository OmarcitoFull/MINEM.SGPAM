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
    public interface IT_Sgpal_CuencaLN
    {
        IEnumerable<CuencaDTO> ListarCuencaDTO();
        CuencaDTO RecuperarCuencaDTOPorCodigo(int vId_Cuenca);
        CuencaDTO InsertarCuencaDTO(CuencaDTO vCuencaDTO);
        CuencaDTO ActualizarCuencaDTO(CuencaDTO vCuencaDTO);
        int AnularCuencaDTOPorCodigo(CuencaDTO vCuencaDTO);
        IEnumerable<CuencaDTO> ListarPaginadoCuencaDTO(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}