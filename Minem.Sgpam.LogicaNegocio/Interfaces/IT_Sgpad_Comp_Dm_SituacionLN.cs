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
    public interface IT_Sgpad_Comp_Dm_SituacionLN
    {
        IEnumerable<Comp_Dm_SituacionDTO> ListarComp_Dm_SituacionDTO();
        Comp_Dm_SituacionDTO RecuperarComp_Dm_SituacionDTOPorCodigo(int vId_Comp_Dm_Situacion);
        Comp_Dm_SituacionDTO InsertarComp_Dm_SituacionDTO(Comp_Dm_SituacionDTO vComp_Dm_SituacionDTO);
        Comp_Dm_SituacionDTO ActualizarComp_Dm_SituacionDTO(Comp_Dm_SituacionDTO vComp_Dm_SituacionDTO);
        int AnularComp_Dm_SituacionDTOPorCodigo(Comp_Dm_SituacionDTO vComp_Dm_SituacionDTO);
        IEnumerable<Comp_Dm_SituacionDTO> ListarPaginadoComp_Dm_SituacionDTO(string vFiltro, int vNumPag, int vCantRegxPag);
        IEnumerable<Comp_Dm_SituacionDTO> ListarPorIdEumComp_Dm_Situacion(int vId_Eum);
    }
}