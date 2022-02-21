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
    public interface IT_Sgpad_Comp_Dd_MineroLN
    {
        IEnumerable<Comp_Dd_MineroDTO> ListarComp_Dd_MineroDTO();
        Comp_Dd_MineroDTO RecuperarComp_Dd_MineroDTOPorCodigo(int vId_Comp_Dm);
        Comp_Dd_MineroDTO InsertarComp_Dd_MineroDTO(Comp_Dd_MineroDTO vComp_Dd_MineroDTO);
        Comp_Dd_MineroDTO ActualizarComp_Dd_MineroDTO(Comp_Dd_MineroDTO vComp_Dd_MineroDTO);
        int AnularComp_Dd_MineroDTOPorCodigo(Comp_Dd_MineroDTO vComp_Dd_MineroDTO);
        IEnumerable<Comp_Dd_MineroDTO> ListarPaginadoComp_Dd_MineroDTO(string vFiltro, int vNumPag, int vCantRegxPag);
        IEnumerable<Comp_Dd_MineroDTO> ListarPorIdEumComp_Dd_MineroDTO(int vId_Eum);

    }
}