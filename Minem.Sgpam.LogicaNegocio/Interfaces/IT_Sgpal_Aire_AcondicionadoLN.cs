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
    public interface IT_Sgpal_Aire_AcondicionadoLN
    {
        IEnumerable<Aire_AcondicionadoDTO> ListarAire_AcondicionadoDTO();
        Aire_AcondicionadoDTO RecuperarAire_AcondicionadoDTOPorCodigo(int vId_Aire_Acondicionado);
        Aire_AcondicionadoDTO InsertarAire_AcondicionadoDTO(Aire_AcondicionadoDTO vAire_AcondicionadoDTO);
        Aire_AcondicionadoDTO ActualizarAire_AcondicionadoDTO(Aire_AcondicionadoDTO vAire_AcondicionadoDTO);
        int AnularAire_AcondicionadoDTOPorCodigo(Aire_AcondicionadoDTO vAire_AcondicionadoDTO);
        IEnumerable<Aire_AcondicionadoDTO> ListarPaginadoAire_AcondicionadoDTO(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}