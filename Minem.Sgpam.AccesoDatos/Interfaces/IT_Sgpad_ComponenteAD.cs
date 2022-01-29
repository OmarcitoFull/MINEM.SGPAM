using Minem.Sgpam.Entidades;
using System.Collections.Generic;

namespace Minem.Sgpam.AccesoDatos.Interfaces
{
    /// <summary>
    /// Objetivo:	Interfaz que matricula las operaciones para la tabla T_SGPAD_COMPONENTE
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public interface IT_Sgpad_ComponenteAD
    {
        IEnumerable<T_Sgpad_Componente> ListarT_Sgpad_Componente();
        T_Sgpad_Componente RecuperarT_Sgpad_ComponentePorCodigo(int vId_Componente);
        T_Sgpad_Componente InsertarT_Sgpad_Componente(T_Sgpad_Componente vT_Sgpad_Componente);
        T_Sgpad_Componente ActualizarT_Sgpad_Componente(T_Sgpad_Componente vT_Sgpad_Componente);
        int AnularT_Sgpad_ComponentePorCodigo(T_Sgpad_Componente vT_Sgpad_Componente);
        IEnumerable<T_Sgpad_Componente> ListarPaginadoT_Sgpad_Componente(string vFiltro, int vNumPag, int vCantRegxPag);
        IEnumerable<V_Sgpad_Componente> ListarT_Sgpad_Componente_Eum(int vId_Eum);
    }
}