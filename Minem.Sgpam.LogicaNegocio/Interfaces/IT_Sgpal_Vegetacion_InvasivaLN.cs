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
    public interface IT_Sgpal_Vegetacion_InvasivaLN
    {
        IEnumerable<Vegetacion_InvasivaDTO> ListarVegetacion_InvasivaDTO();
        Vegetacion_InvasivaDTO RecuperarVegetacion_InvasivaDTOPorCodigo(int vId_Vegetacion_Invasiva);
        Vegetacion_InvasivaDTO InsertarVegetacion_InvasivaDTO(Vegetacion_InvasivaDTO vVegetacion_InvasivaDTO);
        Vegetacion_InvasivaDTO ActualizarVegetacion_InvasivaDTO(Vegetacion_InvasivaDTO vVegetacion_InvasivaDTO);
        int AnularVegetacion_InvasivaDTOPorCodigo(Vegetacion_InvasivaDTO vVegetacion_InvasivaDTO);
        IEnumerable<Vegetacion_InvasivaDTO> ListarPaginadoVegetacion_InvasivaDTO(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}