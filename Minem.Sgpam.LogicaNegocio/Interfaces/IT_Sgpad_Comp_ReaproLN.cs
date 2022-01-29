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
    public interface IT_Sgpad_Comp_ReaproLN
    {
        IEnumerable<Comp_ReaproDTO> ListarComp_ReaproDTO(int vIdComponente);
        Comp_ReaproDTO RecuperarComp_ReaproDTOPorCodigo(int vId_Comp_Reapro);
        Comp_ReaproDTO GrabarComp_ReaproDTO(Comp_ReaproDTO vComp_ReaproDTO);
        int AnularComp_ReaproDTOPorCodigo(Comp_ReaproDTO vComp_ReaproDTO);
        IEnumerable<Comp_ReaproDTO> ListarPaginadoComp_ReaproDTO(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}