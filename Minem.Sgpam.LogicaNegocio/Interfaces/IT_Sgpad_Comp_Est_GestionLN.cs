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
    public interface IT_Sgpad_Comp_Est_GestionLN
    {
        IEnumerable<Comp_Est_GestionDTO> ListarComp_Est_GestionDTO(int vIdComponente);
        Comp_Est_GestionDTO RecuperarComp_Est_GestionDTOPorCodigo(int vId_Comp_Est_Gestion);
        Comp_Est_GestionDTO GrabarComp_Est_GestionDTO(Comp_Est_GestionDTO vComp_Est_GestionDTO);
        int AnularComp_Est_GestionDTOPorCodigo(Comp_Est_GestionDTO vComp_Est_GestionDTO);
        IEnumerable<Comp_Est_GestionDTO> ListarPaginadoComp_Est_GestionDTO(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}