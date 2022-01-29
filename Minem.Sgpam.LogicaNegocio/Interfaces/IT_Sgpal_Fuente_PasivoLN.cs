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
    public interface IT_Sgpal_Fuente_PasivoLN
    {
        IEnumerable<Fuente_PasivoDTO> ListarFuente_PasivoDTO();
        Fuente_PasivoDTO RecuperarFuente_PasivoDTOPorCodigo(int vId_Fuente_Pasivo);
        Fuente_PasivoDTO InsertarFuente_PasivoDTO(Fuente_PasivoDTO vFuente_PasivoDTO);
        Fuente_PasivoDTO ActualizarFuente_PasivoDTO(Fuente_PasivoDTO vFuente_PasivoDTO);
        int AnularFuente_PasivoDTOPorCodigo(Fuente_PasivoDTO vFuente_PasivoDTO);
        IEnumerable<Fuente_PasivoDTO> ListarPaginadoFuente_PasivoDTO(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}