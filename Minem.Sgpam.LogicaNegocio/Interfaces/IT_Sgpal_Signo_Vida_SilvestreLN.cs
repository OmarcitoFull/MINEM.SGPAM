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
    public interface IT_Sgpal_Signo_Vida_SilvestreLN
    {
        IEnumerable<Signo_Vida_SilvestreDTO> ListarSigno_Vida_SilvestreDTO();
        Signo_Vida_SilvestreDTO RecuperarSigno_Vida_SilvestreDTOPorCodigo(int vId_Signo_Vida_Silvestre);
        Signo_Vida_SilvestreDTO InsertarSigno_Vida_SilvestreDTO(Signo_Vida_SilvestreDTO vSigno_Vida_SilvestreDTO);
        Signo_Vida_SilvestreDTO ActualizarSigno_Vida_SilvestreDTO(Signo_Vida_SilvestreDTO vSigno_Vida_SilvestreDTO);
        int AnularSigno_Vida_SilvestreDTOPorCodigo(Signo_Vida_SilvestreDTO vSigno_Vida_SilvestreDTO);
        IEnumerable<Signo_Vida_SilvestreDTO> ListarPaginadoSigno_Vida_SilvestreDTO(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}