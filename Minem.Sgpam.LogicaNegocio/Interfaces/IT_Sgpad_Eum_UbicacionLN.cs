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
    public interface IT_Sgpad_Eum_UbicacionLN
    {
        IEnumerable<Eum_UbicacionDTO> ListarEum_UbicacionDTO();
        Eum_UbicacionDTO RecuperarEum_UbicacionDTOPorCodigo(int vId_Eum_Ubicacion);
        Eum_UbicacionDTO InsertarEum_UbicacionDTO(Eum_UbicacionDTO vEum_UbicacionDTO);
        Eum_UbicacionDTO ActualizarEum_UbicacionDTO(Eum_UbicacionDTO vEum_UbicacionDTO);
        int AnularEum_UbicacionDTOPorCodigo(Eum_UbicacionDTO vEum_UbicacionDTO);
        IEnumerable<Eum_UbicacionDTO> ListarPaginadoEum_UbicacionDTO(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}