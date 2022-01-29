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
    public interface IT_Sgpal_Presencia_LiquidoLN
    {
        IEnumerable<Presencia_LiquidoDTO> ListarPresencia_LiquidoDTO();
        Presencia_LiquidoDTO RecuperarPresencia_LiquidoDTOPorCodigo(int vId_Presencia_Liquido);
        Presencia_LiquidoDTO InsertarPresencia_LiquidoDTO(Presencia_LiquidoDTO vPresencia_LiquidoDTO);
        Presencia_LiquidoDTO ActualizarPresencia_LiquidoDTO(Presencia_LiquidoDTO vPresencia_LiquidoDTO);
        int AnularPresencia_LiquidoDTOPorCodigo(Presencia_LiquidoDTO vPresencia_LiquidoDTO);
        IEnumerable<Presencia_LiquidoDTO> ListarPaginadoPresencia_LiquidoDTO(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}