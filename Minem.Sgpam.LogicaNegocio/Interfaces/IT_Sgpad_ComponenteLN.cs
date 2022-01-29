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
    public interface IT_Sgpad_ComponenteLN
    {
        IEnumerable<ComponenteDTO> ListarComponenteDTO();
        ComponenteDTO RecuperarComponenteDTOPorCodigo(int vId_Componente);
        ComponenteDTO GrabarComponenteDTO(ComponenteDTO vComponenteDTO);
        int AnularComponenteDTOPorCodigo(ComponenteDTO vComponenteDTO);
        IEnumerable<ComponenteDTO> ListarPaginadoComponenteDTO(string vFiltro, int vNumPag, int vCantRegxPag);
        RegistrarPamDTO RecuperarFullComponenteDTOPorCodigo(int vId_Componente);
        IEnumerable<ComponenteMinDTO> ListarComponenteEumDTO(int vId_Eum);
    }
}