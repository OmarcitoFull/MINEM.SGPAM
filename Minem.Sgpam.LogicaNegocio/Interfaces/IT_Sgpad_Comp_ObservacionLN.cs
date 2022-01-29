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
    public interface IT_Sgpad_Comp_ObservacionLN
    {
        IEnumerable<Comp_ObservacionDTO> ListarComp_ObservacionDTO(int vIdComponente);
        Comp_ObservacionDTO RecuperarComp_ObservacionDTOPorCodigo(int vId_Comp_Observacion);
        Comp_ObservacionDTO GrabarComp_ObservacionDTO(Comp_ObservacionDTO vComp_ObservacionDTO);
        int AnularComp_ObservacionDTOPorCodigo(Comp_ObservacionDTO vComp_ObservacionDTO);
        IEnumerable<Comp_ObservacionDTO> ListarPaginadoComp_ObservacionDTO(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}