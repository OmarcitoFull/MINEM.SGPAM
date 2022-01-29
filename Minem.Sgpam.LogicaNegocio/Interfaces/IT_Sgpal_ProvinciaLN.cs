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
    public interface IT_Sgpal_ProvinciaLN
    {
        IEnumerable<ProvinciaDTO> ListarProvinciaDTO();
        ProvinciaDTO RecuperarProvinciaDTOPorCodigo(int vId_Provincia);
        ProvinciaDTO InsertarProvinciaDTO(ProvinciaDTO vProvinciaDTO);
        ProvinciaDTO ActualizarProvinciaDTO(ProvinciaDTO vProvinciaDTO);
        int AnularProvinciaDTOPorCodigo(ProvinciaDTO vProvinciaDTO);
        IEnumerable<ProvinciaDTO> ListarPaginadoProvinciaDTO(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}