using Minem.Sgpam.Entidades;
using System.Collections.Generic;

namespace Minem.Sgpam.AccesoDatos.Interfaces
{
    /// <summary>
    /// Objetivo:	Interfaz que matricula las operaciones para la tabla T_SGPAD_COMP_COMENTARIO
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public interface IV_ExternosAD
    {
        List<V_Ext_ReinfoDerechosMineros> Listar_ReinfoDerechosMineros();
        List<V_Ext_SituacionPrincipalesProductos> Listar_SituacionPrincipalesProductos();
        List<V_Ext_TitularesReferencialesDerechos> Listar_TitularesReferencialesDerechos(int vId_Componente);
        List<V_Ext_DerechosMineros> Listar_DerechosMineros(int vId_Componente);

        void Insertar_DerechosMineros(T_Sgpad_Componente vT_Sgpad_Componente);
        void Insertar_TitularesReferenciales(T_Sgpad_Componente vT_Sgpad_Componente);
        List<T_Sgpal_Cuenca> Listar_Cuenca(int vId_Componente);
    }
}