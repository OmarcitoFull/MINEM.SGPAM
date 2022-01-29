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
    public interface IT_Sgpal_Tamano_ParticulaLN
    {
        IEnumerable<Tamano_ParticulaDTO> ListarTamano_ParticulaDTO();
        Tamano_ParticulaDTO RecuperarTamano_ParticulaDTOPorCodigo(int vId_Tamano_Particula);
        Tamano_ParticulaDTO InsertarTamano_ParticulaDTO(Tamano_ParticulaDTO vTamano_ParticulaDTO);
        Tamano_ParticulaDTO ActualizarTamano_ParticulaDTO(Tamano_ParticulaDTO vTamano_ParticulaDTO);
        int AnularTamano_ParticulaDTOPorCodigo(Tamano_ParticulaDTO vTamano_ParticulaDTO);
        IEnumerable<Tamano_ParticulaDTO> ListarPaginadoTamano_ParticulaDTO(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}