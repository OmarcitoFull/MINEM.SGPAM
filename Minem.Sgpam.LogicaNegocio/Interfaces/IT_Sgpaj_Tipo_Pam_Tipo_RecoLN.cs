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
    public interface IT_Sgpaj_Tipo_Pam_Tipo_RecoLN
    {
        IEnumerable<Tipo_Pam_Tipo_RecoDTO> ListarTipo_Pam_Tipo_RecoDTO();
        Tipo_Pam_Tipo_RecoDTO RecuperarTipo_Pam_Tipo_RecoDTOPorCodigo(int vId_Tipo_Pam_Tipo_Reco);
        Tipo_Pam_Tipo_RecoDTO InsertarTipo_Pam_Tipo_RecoDTO(Tipo_Pam_Tipo_RecoDTO vTipo_Pam_Tipo_RecoDTO);
        Tipo_Pam_Tipo_RecoDTO ActualizarTipo_Pam_Tipo_RecoDTO(Tipo_Pam_Tipo_RecoDTO vTipo_Pam_Tipo_RecoDTO);
        int AnularTipo_Pam_Tipo_RecoDTOPorCodigo(Tipo_Pam_Tipo_RecoDTO vTipo_Pam_Tipo_RecoDTO);
        IEnumerable<Tipo_Pam_Tipo_RecoDTO> ListarPaginadoTipo_Pam_Tipo_RecoDTO(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}