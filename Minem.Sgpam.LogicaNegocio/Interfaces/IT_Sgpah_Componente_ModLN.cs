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
    public interface IT_Sgpah_Componente_ModLN
    {
        IEnumerable<Componente_ModDTO> ListarComponente_ModDTO(int vIdComponente);
        Componente_ModDTO RecuperarComponente_ModDTOPorCodigo(int vId_Componente_Mod);
        Componente_ModDTO GrabarComponente_ModDTO(Componente_ModDTO vComponente_ModDTO);
        int AnularComponente_ModDTOPorCodigo(Componente_ModDTO vComponente_ModDTO);
        IEnumerable<Componente_ModDTO> ListarPaginadoComponente_ModDTO(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}