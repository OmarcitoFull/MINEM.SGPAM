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
    public interface IT_Sgpal_Presencia_AdvertenciaLN
    {
        IEnumerable<Presencia_AdvertenciaDTO> ListarPresencia_AdvertenciaDTO();
        Presencia_AdvertenciaDTO RecuperarPresencia_AdvertenciaDTOPorCodigo(int vId_Presencia_Advertencia);
        Presencia_AdvertenciaDTO InsertarPresencia_AdvertenciaDTO(Presencia_AdvertenciaDTO vPresencia_AdvertenciaDTO);
        Presencia_AdvertenciaDTO ActualizarPresencia_AdvertenciaDTO(Presencia_AdvertenciaDTO vPresencia_AdvertenciaDTO);
        int AnularPresencia_AdvertenciaDTOPorCodigo(Presencia_AdvertenciaDTO vPresencia_AdvertenciaDTO);
        IEnumerable<Presencia_AdvertenciaDTO> ListarPaginadoPresencia_AdvertenciaDTO(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}