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
    public interface IT_Sgpad_Comp_Riesgo_Fau_ConLN
    {
        IEnumerable<Comp_Riesgo_Fau_ConDTO> ListarComp_Riesgo_Fau_ConDTO(int vIdComponente);
        Comp_Riesgo_Fau_ConDTO RecuperarComp_Riesgo_Fau_ConDTOPorCodigo(int vId_Comp_Riesgo_Fau_Con);
        Comp_Riesgo_Fau_ConDTO GrabarComp_Riesgo_Fau_ConDTO(Comp_Riesgo_Fau_ConDTO vComp_Riesgo_Fau_ConDTO);
        int AnularComp_Riesgo_Fau_ConDTOPorCodigo(Comp_Riesgo_Fau_ConDTO vComp_Riesgo_Fau_ConDTO);
        IEnumerable<Comp_Riesgo_Fau_ConDTO> ListarPaginadoComp_Riesgo_Fau_ConDTO(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}