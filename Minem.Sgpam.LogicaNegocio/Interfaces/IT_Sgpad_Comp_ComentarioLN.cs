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
    public interface IT_Sgpad_Comp_ComentarioLN
    {
        IEnumerable<Comp_ComentarioDTO> ListarComp_ComentarioDTO(int vIdComponente);
        Comp_ComentarioDTO RecuperarComp_ComentarioDTOPorCodigo(int vId_Comp_Comentario);
        Comp_ComentarioDTO GrabarComp_ComentarioDTO(Comp_ComentarioDTO vComp_ComentarioDTO);
        int AnularComp_ComentarioDTOPorCodigo(Comp_ComentarioDTO vComp_ComentarioDTO);
        IEnumerable<Comp_ComentarioDTO> ListarPaginadoComp_ComentarioDTO(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}