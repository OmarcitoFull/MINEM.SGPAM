using Minem.Sgpam.TransporteDatos.DtoEntidades;
using System.Collections.Generic;

namespace Minem.Sgpam.LogicaNegocio.Interfaces
{
    /// <summary>
    /// Objetivo:	Interfaz que matricula las operaciones de las entidades para la lógica de negocio
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	29/10/2021
    /// </summary>
    public interface IV_ExternosLN
    {
        List<ReinfoDerechosMinerosDTO> Listar_ReinfoDerechosMineros();
        List<SituacionPrincipalesProductosDTO> Listar_SituacionPrincipalesProductos();
        List<TitularesReferencialesDerechosDTO> Listar_TitularesReferencialesDerechos();
        List<DerechosMinerosDTO> Listar_DerechosMineros();
    }
}