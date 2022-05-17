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
    public interface IT_Sgpal_Tipo_OperacionLN
    {
        IEnumerable<Tipo_OperacionDTO> ListarTipo_OperacionDTO();
        Tipo_OperacionDTO RecuperarTipo_OperacionDTOPorCodigo(int vId_Tipo_Operacion);
        Tipo_OperacionDTO GrabarTipo_OperacionDTO(Tipo_OperacionDTO vTipo_OperacionDTO);
        int AnularTipo_OperacionDTOPorCodigo(Tipo_OperacionDTO vTipo_OperacionDTO);
        IEnumerable<Tipo_OperacionDTO> ListarPaginadoTipo_OperacionDTO(string vFiltro, int vNumPag, int vCantRegxPag);
        IEnumerable<Tipo_OperacionDTO> ListarSinIdEumTipo_OperacionDTO(int vIdEum);
    }
}