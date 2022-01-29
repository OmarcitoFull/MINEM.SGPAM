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
    public interface IT_Sgpad_Comp_MedicionLN
    {
        IEnumerable<Comp_MedicionDTO> ListarComp_MedicionDTO(int vIdComponente);
        Comp_MedicionDTO RecuperarComp_MedicionDTOPorCodigo(int vId_Comp_Medicion);
        Comp_MedicionDTO GrabarComp_MedicionDTO(Comp_MedicionDTO vComp_MedicionDTO);
        int AnularComp_MedicionDTOPorCodigo(Comp_MedicionDTO vComp_MedicionDTO);
        IEnumerable<Comp_MedicionDTO> ListarPaginadoComp_MedicionDTO(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}