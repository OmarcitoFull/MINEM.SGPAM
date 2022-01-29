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
    public interface IT_Sgpad_Comp_Reinfo_DmLN
    {
        IEnumerable<Comp_Reinfo_DmDTO> ListarComp_Reinfo_DmDTO();
        Comp_Reinfo_DmDTO RecuperarComp_Reinfo_DmDTOPorCodigo(int vId_Comp_Reinfo_Dm);
        Comp_Reinfo_DmDTO InsertarComp_Reinfo_DmDTO(Comp_Reinfo_DmDTO vComp_Reinfo_DmDTO);
        Comp_Reinfo_DmDTO ActualizarComp_Reinfo_DmDTO(Comp_Reinfo_DmDTO vComp_Reinfo_DmDTO);
        int AnularComp_Reinfo_DmDTOPorCodigo(Comp_Reinfo_DmDTO vComp_Reinfo_DmDTO);
        IEnumerable<Comp_Reinfo_DmDTO> ListarPaginadoComp_Reinfo_DmDTO(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}