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
        void Insertar_DerechosMineros(ComponenteDTO vComponenteDTO);
        List<DerechosMinerosDTO> Listar_DerechosMineros(int vId_Componente);

        void Insertar_SituacionPrincipalesProductos(ComponenteDTO vComponenteDTO);
        List<SituacionPrincipalesProductosDTO> Listar_SituacionPrincipalesProductos(int vId_Componente);

        void Insertar_TitularesReferenciales(ComponenteDTO vComponenteDTO);
        List<TitularesReferencialesDerechosDTO> Listar_TitularesReferencialesDerechos(int vId_Componente);

        void Insertar_ReinfoDerechosMineros(ComponenteDTO vComponenteDTO);
        List<ReinfoDerechosMinerosDTO> Listar_ReinfoDerechosMineros(int vId_Componente);
        

        List<CuencaDTO> Listar_Cuenca(int vId_Componente);
    }
}