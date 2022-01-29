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
    public interface IT_Sgpad_Comp_Info_GraficaLN
    {
        IEnumerable<Comp_Info_GraficaDTO> ListarComp_Info_GraficaDTO(int vIdComponente);
        Comp_Info_GraficaDTO RecuperarComp_Info_GraficaDTOPorCodigo(int vId_Comp_Info_Grafica);
        Comp_Info_GraficaDTO GrabarComp_Info_GraficaDTO(Comp_Info_GraficaDTO vComp_Info_GraficaDTO);
        int AnularComp_Info_GraficaDTOPorCodigo(Comp_Info_GraficaDTO vComp_Info_GraficaDTO);
        IEnumerable<Comp_Info_GraficaDTO> ListarPaginadoComp_Info_GraficaDTO(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}