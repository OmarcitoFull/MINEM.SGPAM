using Minem.Sgpam.TransporteDatos.DtoEntidades;
using System.Collections.Generic;
using System;

namespace Minem.Sgpam.LogicaNegocio.Interfaces
{
    /// <summary>
    /// Objetivo:	Interfaz que matricula las operaciones de las entidades para la lógica de negocio
    /// Creado Por:	Mateo Salvador Paucar
    /// Fecha Creación:	15/02/2022
    /// </summary>
    public interface IT_Sgpad_Eum_InformeLN
    {
        IEnumerable<Eum_InformeDTO> ListarEum_InformeDTO();
        Eum_InformeDTO RecuperarEum_InformeDTOPorCodigo(int vId_Eum_Informe);
        Eum_InformeDTO GrabarEum_InformeDTO(Eum_InformeDTO vEum_InformeDTO);
        bool AnularEum_InformeDTOPorCodigo(Eum_InformeDTO vEum_InformeDTO);
        IEnumerable<Eum_InformeDTO> ListarPaginadoEum_InformeDTO(string vFiltro, int vNumPag, int vCantRegxPag);
        IEnumerable<Eum_InformeDTO> ListarPorIdEumEum_InformeDTO(int vId_Eum);
    }
}