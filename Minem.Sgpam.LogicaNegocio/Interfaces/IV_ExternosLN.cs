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
        List<TitularesReferencialesDerechosDTO> Listar_TitularesReferencialesDerechos(int vId_Componente);
        List<DerechosMinerosDTO> Listar_DerechosMineros(int vId_Componente);

        void Insertar_DerechosMineros(ComponenteDTO vComponenteDTO);
        void Insertar_TitularesReferenciales(ComponenteDTO vComponenteDTO);
        List<CuencaDTO> Listar_Cuenca(int vId_Componente);
    }
}