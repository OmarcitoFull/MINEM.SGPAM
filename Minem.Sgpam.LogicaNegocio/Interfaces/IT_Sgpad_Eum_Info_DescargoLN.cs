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
    public interface IT_Sgpad_Eum_Info_DescargoLN
    {
        IEnumerable<Eum_Info_DescargoDTO> ListarEum_Info_DescargoDTO();
        Eum_Info_DescargoDTO RecuperarEum_Info_DescargoDTOPorCodigo(int vId_Eum_Info_Descargo);
        Eum_Info_DescargoDTO InsertarEum_Info_DescargoDTO(Eum_Info_DescargoDTO vEum_Info_DescargoDTO);
        Eum_Info_DescargoDTO ActualizarEum_Info_DescargoDTO(Eum_Info_DescargoDTO vEum_Info_DescargoDTO);
        int AnularEum_Info_DescargoDTOPorCodigo(Eum_Info_DescargoDTO vEum_Info_DescargoDTO);
        IEnumerable<Eum_Info_DescargoDTO> ListarPaginadoEum_Info_DescargoDTO(string vFiltro, int vNumPag, int vCantRegxPag);
        IEnumerable<Eum_Info_DescargoDTO> ListarPorIdEumEum_Info_DescargoDTO(int vId_Eum);
    }
}