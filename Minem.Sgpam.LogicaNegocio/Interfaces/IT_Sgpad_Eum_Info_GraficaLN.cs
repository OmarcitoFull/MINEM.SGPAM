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
    public interface IT_Sgpad_Eum_Info_GraficaLN
    {
        IEnumerable<Eum_Info_GraficaDTO> ListarEum_Info_GraficaDTO();
        Eum_Info_GraficaDTO RecuperarEum_Info_GraficaDTOPorCodigo(int vId_Eum_Info_Grafica);
        Eum_Info_GraficaDTO GrabarEum_Info_GraficaDTO(Eum_Info_GraficaDTO vEum_Info_GraficaDTO);
        int AnularEum_Info_GraficaDTOPorCodigo(Eum_Info_GraficaDTO vEum_Info_GraficaDTO);
        IEnumerable<Eum_Info_GraficaDTO> ListarPaginadoEum_Info_GraficaDTO(string vFiltro, int vNumPag, int vCantRegxPag);
        IEnumerable<Eum_Info_GraficaDTO> ListarPorIdEumEum_Info_GraficaDTO(int vId_Eum);
    }
}