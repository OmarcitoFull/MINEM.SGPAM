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
    public interface IT_Sgpad_Comp_ReconocimientoLN
    {
        IEnumerable<Comp_ReconocimientoDTO> ListarComp_ReconocimientoDTO(int vIdComponente);
        Comp_ReconocimientoDTO RecuperarComp_ReconocimientoDTOPorCodigo(int vId_Comp_Reconocimiento);
        Comp_ReconocimientoDTO GrabarComp_ReconocimientoDTO(Comp_ReconocimientoDTO vComp_ReconocimientoDTO);
        int AnularComp_ReconocimientoDTOPorCodigo(Comp_ReconocimientoDTO vComp_ReconocimientoDTO);
        IEnumerable<Comp_ReconocimientoDTO> ListarPaginadoComp_ReconocimientoDTO(string vFiltro, int vNumPag, int vCantRegxPag);
        int Insertar_Reconocimiento_Tipo(Comp_ReconocimientoDTO vComp_ReconocimientoDTO);
    }
}