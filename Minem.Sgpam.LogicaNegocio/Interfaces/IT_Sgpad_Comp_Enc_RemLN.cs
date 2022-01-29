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
    public interface IT_Sgpad_Comp_Enc_RemLN
    {
        IEnumerable<Comp_Enc_RemDTO> ListarComp_Enc_RemDTO(int vIdComponente);
        Comp_Enc_RemDTO RecuperarComp_Enc_RemDTOPorCodigo(int vId_Comp_Enc_Rem);
        Comp_Enc_RemDTO GrabarComp_Enc_RemDTO(Comp_Enc_RemDTO vComp_Enc_RemDTO);
        int AnularComp_Enc_RemDTOPorCodigo(Comp_Enc_RemDTO vComp_Enc_RemDTO);
        IEnumerable<Comp_Enc_RemDTO> ListarPaginadoComp_Enc_RemDTO(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}