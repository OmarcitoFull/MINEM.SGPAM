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
    public interface IT_Sgpam_MaestraLN
    {
        IEnumerable<MaestraDTO> ListarMaestraDTO();
        MaestraDTO RecuperarMaestraDTOPorCodigo(int vId_Eum);
        MaestraDTO InsertarMaestraDTO(MaestraDTO vMaestraDTO);
        MaestraDTO ActualizarMaestraDTO(MaestraDTO vMaestraDTO);
        int AnularMaestraDTOPorCodigo(MaestraDTO vMaestraDTO);
        IEnumerable<MaestraDTO> ListarPaginadoMaestraDTO(string vFiltro, string vUbigeo, int vNumPag, int vCantRegxPag);
        RegistrarEumDTO RecuperarFullMaestraDTOPorCodigo(int vId_Eum);
    }
}