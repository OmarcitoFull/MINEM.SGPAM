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
    public interface IT_Sgpad_Comp_Riesgo_Sal_AmbLN
    {
        IEnumerable<Comp_Riesgo_Sal_AmbDTO> ListarComp_Riesgo_Sal_AmbDTO(int vIdComponente);
        Comp_Riesgo_Sal_AmbDTO RecuperarComp_Riesgo_Sal_AmbDTOPorCodigo(int vId_Comp_Riesgo_Sal_Amb);
        Comp_Riesgo_Sal_AmbDTO GrabarComp_Riesgo_Sal_AmbDTO(Comp_Riesgo_Sal_AmbDTO vComp_Riesgo_Sal_AmbDTO);
        int AnularComp_Riesgo_Sal_AmbDTOPorCodigo(Comp_Riesgo_Sal_AmbDTO vComp_Riesgo_Sal_AmbDTO);
        IEnumerable<Comp_Riesgo_Sal_AmbDTO> ListarPaginadoComp_Riesgo_Sal_AmbDTO(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}