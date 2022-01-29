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
    public interface IT_Sgpal_Acceso_FaunaLN
    {
        IEnumerable<Acceso_FaunaDTO> ListarAcceso_FaunaDTO();
        Acceso_FaunaDTO RecuperarAcceso_FaunaDTOPorCodigo(int vId_Acceso_Fauna);
        Acceso_FaunaDTO InsertarAcceso_FaunaDTO(Acceso_FaunaDTO vAcceso_FaunaDTO);
        Acceso_FaunaDTO ActualizarAcceso_FaunaDTO(Acceso_FaunaDTO vAcceso_FaunaDTO);
        int AnularAcceso_FaunaDTOPorCodigo(Acceso_FaunaDTO vAcceso_FaunaDTO);
        IEnumerable<Acceso_FaunaDTO> ListarPaginadoAcceso_FaunaDTO(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}