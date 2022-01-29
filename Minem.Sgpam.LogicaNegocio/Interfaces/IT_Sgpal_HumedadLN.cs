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
    public interface IT_Sgpal_HumedadLN
    {
        IEnumerable<HumedadDTO> ListarHumedadDTO();
        HumedadDTO RecuperarHumedadDTOPorCodigo(int vId_Humedad);
        HumedadDTO InsertarHumedadDTO(HumedadDTO vHumedadDTO);
        HumedadDTO ActualizarHumedadDTO(HumedadDTO vHumedadDTO);
        int AnularHumedadDTOPorCodigo(HumedadDTO vHumedadDTO);
        IEnumerable<HumedadDTO> ListarPaginadoHumedadDTO(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}