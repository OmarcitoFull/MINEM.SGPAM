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
    public interface IT_Sgpad_Lnr_Info_GraficaLN
    {
        IEnumerable<Lnr_Info_GraficaDTO> ListarLnr_Info_GraficaDTO();
        Lnr_Info_GraficaDTO RecuperarLnr_Info_GraficaDTOPorCodigo(int vId_Lnr_Info_Grafica);
        Lnr_Info_GraficaDTO InsertarLnr_Info_GraficaDTO(Lnr_Info_GraficaDTO vLnr_Info_GraficaDTO);
        Lnr_Info_GraficaDTO ActualizarLnr_Info_GraficaDTO(Lnr_Info_GraficaDTO vLnr_Info_GraficaDTO);
        int AnularLnr_Info_GraficaDTOPorCodigo(Lnr_Info_GraficaDTO vLnr_Info_GraficaDTO);
        IEnumerable<Lnr_Info_GraficaDTO> ListarPaginadoLnr_Info_GraficaDTO(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}