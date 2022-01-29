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
    public interface IT_Sgpal_Cuenca_HidrograficaLN
    {
        IEnumerable<Cuenca_HidrograficaDTO> ListarCuenca_HidrograficaDTO();
        Cuenca_HidrograficaDTO RecuperarCuenca_HidrograficaDTOPorCodigo(int vId_Cuenca_Hidro);
        Cuenca_HidrograficaDTO InsertarCuenca_HidrograficaDTO(Cuenca_HidrograficaDTO vCuenca_HidrograficaDTO);
        Cuenca_HidrograficaDTO ActualizarCuenca_HidrograficaDTO(Cuenca_HidrograficaDTO vCuenca_HidrograficaDTO);
        int AnularCuenca_HidrograficaDTOPorCodigo(Cuenca_HidrograficaDTO vCuenca_HidrograficaDTO);
        IEnumerable<Cuenca_HidrograficaDTO> ListarPaginadoCuenca_HidrograficaDTO(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}