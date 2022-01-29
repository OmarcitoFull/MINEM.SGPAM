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
    public interface IT_Sgpad_Comp_Riesgo_Seg_HumLN
    {
        IEnumerable<Comp_Riesgo_Seg_HumDTO> ListarComp_Riesgo_Seg_HumDTO(int vIdComponente);
        Comp_Riesgo_Seg_HumDTO RecuperarComp_Riesgo_Seg_HumDTOPorCodigo(int vId_Comp_Riesgo_Seg_Hum);
        Comp_Riesgo_Seg_HumDTO GrabarComp_Riesgo_Seg_HumDTO(Comp_Riesgo_Seg_HumDTO vComp_Riesgo_Seg_HumDTO);
        int AnularComp_Riesgo_Seg_HumDTOPorCodigo(Comp_Riesgo_Seg_HumDTO vComp_Riesgo_Seg_HumDTO);
        IEnumerable<Comp_Riesgo_Seg_HumDTO> ListarPaginadoComp_Riesgo_Seg_HumDTO(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}