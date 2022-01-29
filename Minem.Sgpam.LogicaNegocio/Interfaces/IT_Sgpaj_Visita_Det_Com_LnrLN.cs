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
    public interface IT_Sgpaj_Visita_Det_Com_LnrLN
    {
        IEnumerable<Visita_Det_Com_LnrDTO> ListarVisita_Det_Com_LnrDTO();
        Visita_Det_Com_LnrDTO RecuperarVisita_Det_Com_LnrDTOPorCodigo(int vId_Visita_Det_Com_Lnr);
        Visita_Det_Com_LnrDTO InsertarVisita_Det_Com_LnrDTO(Visita_Det_Com_LnrDTO vVisita_Det_Com_LnrDTO);
        Visita_Det_Com_LnrDTO ActualizarVisita_Det_Com_LnrDTO(Visita_Det_Com_LnrDTO vVisita_Det_Com_LnrDTO);
        int AnularVisita_Det_Com_LnrDTOPorCodigo(Visita_Det_Com_LnrDTO vVisita_Det_Com_LnrDTO);
        IEnumerable<Visita_Det_Com_LnrDTO> ListarPaginadoVisita_Det_Com_LnrDTO(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}