using Minem.Sgpam.TransporteDatos.DtoEntidades;
using System.Collections.Generic;

namespace Minem.Sgpam.LogicaNegocio.Interfaces
{
    /// <summary>
    /// Objetivo:	Interfaz que matricula las operaciones de las entidades para la lógica de negocio
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	29/10/2021
    /// </summary>
    public interface IT_Sgpal_DistritoLN
    {
        IEnumerable<DistritoDTO> ListarDistritoDTO();
        DistritoDTO RecuperarDistritoDTOPorCodigo(int vId_Distrito);
        DistritoDTO InsertarDistritoDTO(DistritoDTO vDistritoDTO);
        DistritoDTO ActualizarDistritoDTO(DistritoDTO vDistritoDTO);
        int AnularDistritoDTOPorCodigo(DistritoDTO vDistritoDTO);
        IEnumerable<DistritoDTO> ListarPaginadoDistritoDTO(string vFiltro, int vNumPag, int vCantRegxPag);
        IEnumerable<UbigeoDTO> ListarUbigeoDTO();
    }
}