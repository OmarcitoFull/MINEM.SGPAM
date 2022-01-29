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
    public interface IT_Sgpad_Comp_Est_AmbLN
    {
        IEnumerable<Comp_Est_AmbDTO> ListarComp_Est_AmbDTO(int vIdComponente);
        Comp_Est_AmbDTO RecuperarComp_Est_AmbDTOPorCodigo(int vId_Comp_Est_Amb);
        Comp_Est_AmbDTO GrabarComp_Est_AmbDTO(Comp_Est_AmbDTO vComp_Est_AmbDTO);
        int AnularComp_Est_AmbDTOPorCodigo(Comp_Est_AmbDTO vComp_Est_AmbDTO);
        IEnumerable<Comp_Est_AmbDTO> ListarPaginadoComp_Est_AmbDTO(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}