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
    public interface IT_Sgpad_Lnr_Info_DocumentoLN
    {
        IEnumerable<Lnr_Info_DocumentoDTO> ListarLnr_Info_DocumentoDTO();
        Lnr_Info_DocumentoDTO RecuperarLnr_Info_DocumentoDTOPorCodigo(int vId_Lnr_Info_Documento);
        Lnr_Info_DocumentoDTO InsertarLnr_Info_DocumentoDTO(Lnr_Info_DocumentoDTO vLnr_Info_DocumentoDTO);
        Lnr_Info_DocumentoDTO ActualizarLnr_Info_DocumentoDTO(Lnr_Info_DocumentoDTO vLnr_Info_DocumentoDTO);
        int AnularLnr_Info_DocumentoDTOPorCodigo(Lnr_Info_DocumentoDTO vLnr_Info_DocumentoDTO);
        IEnumerable<Lnr_Info_DocumentoDTO> ListarPaginadoLnr_Info_DocumentoDTO(string vFiltro, int vNumPag, int vCantRegxPag);
        IEnumerable<Lnr_Info_DocumentoDTO> ListarPorIdLnrLnr_Info_DocumentoDTO(int vId_Lnr);
    }
}