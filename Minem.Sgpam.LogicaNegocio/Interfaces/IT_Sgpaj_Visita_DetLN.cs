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
    public interface IT_Sgpaj_Visita_DetLN
    {
        IEnumerable<Visita_DetDTO> ListarVisita_DetDTO();
        Visita_DetDTO RecuperarVisita_DetDTOPorCodigo(int vId_Visita_Det);
        Visita_DetDTO GrabarVisita_DetDTO(Visita_DetDTO vVisita_DetDTO);
        bool AnularVisita_DetDTOPorCodigo(Visita_DetDTO vVisita_DetDTO);
        IEnumerable<Visita_DetDTO> ListarPaginadoVisita_DetDTO(string vFiltro, int vNumPag, int vCantRegxPag);
        IEnumerable<Visita_DetDTO> ListarPorIdVisitaVisita_DetDTO(int vId_Visita);
        RegistrarVisitaDetDTO RecuperarFullVisita_DetDTOPorCodigo(int vId_Visita_Det);
    }
}