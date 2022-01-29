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
    public interface IT_Sgpad_Comp_Info_CampoLN
    {
        IEnumerable<Comp_Info_CampoDTO> ListarComp_Info_CampoDTO(int vIdComponente);
        Comp_Info_CampoDTO RecuperarComp_Info_CampoDTOPorCodigo(int vId_Comp_Info_Campo);
        Comp_Info_CampoDTO GrabarComp_Info_CampoDTO(Comp_Info_CampoDTO vComp_Info_CampoDTO);
        int AnularComp_Info_CampoDTOPorCodigo(Comp_Info_CampoDTO vComp_Info_CampoDTO);
        IEnumerable<Comp_Info_CampoDTO> ListarPaginadoComp_Info_CampoDTO(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}