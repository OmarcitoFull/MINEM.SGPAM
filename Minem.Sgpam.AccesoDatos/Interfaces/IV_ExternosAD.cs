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
        void Insertar_DerechosMineros(V_Ext_Parametros vV_Ext_Parametros);
        List<V_Ext_DerechosMineros> Listar_DerechosMineros(int vId_Componente);

        void Insertar_SituacionPrincipalesProductos(V_Ext_Parametros vV_Ext_Parametros);
        List<V_Ext_SituacionPrincipalesProductos> Listar_SituacionPrincipalesProductos(int vId_Componente);

        void Insertar_TitularesReferenciales(V_Ext_Parametros vV_Ext_Parametros);
        List<V_Ext_TitularesReferencialesDerechos> Listar_TitularesReferencialesDerechos(int vId_Componente);

        void Insertar_ReinfoDerechosMineros(V_Ext_Parametros vV_Ext_Parametros);
        List<V_Ext_ReinfoDerechosMineros> Listar_ReinfoDerechosMineros(int vId_Componente);
        
        List<T_Sgpal_Cuenca> Listar_Cuenca(int vId_Componente);
    }
}