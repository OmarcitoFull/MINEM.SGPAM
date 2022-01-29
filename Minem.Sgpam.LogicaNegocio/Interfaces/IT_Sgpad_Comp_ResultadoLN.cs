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
    public interface IT_Sgpad_Comp_ResultadoLN
    {
        IEnumerable<Comp_ResultadoResumenDTO> ListarComp_ResultadoDTO(int vIdComponente);
        Comp_ResultadoDTO RecuperarComp_ResultadoDTOPorCodigo(int vId_Comp_Resultado);
        Comp_ResultadoDTO GrabarComp_ResultadoDTO(Comp_ResultadoDTO vComp_ResultadoDTO);
        int AnularComp_ResultadoDTOPorCodigo(Comp_ResultadoDTO vComp_ResultadoDTO);
        IEnumerable<Comp_ResultadoDTO> ListarPaginadoComp_ResultadoDTO(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}