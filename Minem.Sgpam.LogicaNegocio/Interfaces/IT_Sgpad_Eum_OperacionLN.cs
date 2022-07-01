using Minem.Sgpam.TransporteDatos.DtoEntidades;
using System.Collections.Generic;
using System;

namespace Minem.Sgpam.LogicaNegocio.Interfaces
{
    /// <summary>
    /// Objetivo:	Interfaz que matricula las operaciones de las entidades para la lógica de negocio
    /// Creado Por:	Mateo Salvador Paucar
    /// Fecha Creación:	08/02/2022
    /// </summary>
    public interface IT_Sgpad_Eum_OperacionLN
    {
        IEnumerable<Eum_OperacionDTO> ListarEum_OperacionDTO();
        Eum_OperacionDTO RecuperarEum_OperacionDTOPorCodigo(int vId_Eum_Operacion);
        Eum_OperacionDTO GrabarEum_OperacionDTO(Eum_OperacionDTO vEum_OperacionDTO);
        bool AnularEum_OperacionDTOPorCodigo(Eum_OperacionDTO vEum_OperacionDTO);
        IEnumerable<Eum_OperacionDTO> ListarPaginadoEum_OperacionDTO(string vFiltro, int vNumPag, int vCantRegxPag);
        IEnumerable<Eum_OperacionDTO> ListarPorIdEumEum_OperacionDTO(int vId_Eum);
        RegistrarEumOperacionDTO RecuperarFullEum_OperacionDTOPorCodigo(int vId_Eum_Operacion);
    }
}
