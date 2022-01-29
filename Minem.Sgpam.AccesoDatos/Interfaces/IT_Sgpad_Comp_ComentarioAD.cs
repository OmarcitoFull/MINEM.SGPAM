using Minem.Sgpam.Entidades;
using System.Collections.Generic;

namespace Minem.Sgpam.AccesoDatos.Interfaces
{
    /// <summary>
    /// Objetivo:	Interfaz que matricula las operaciones para la tabla T_SGPAD_COMP_COMENTARIO
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public interface IT_Sgpad_Comp_ComentarioAD
    {
        IEnumerable<T_Sgpad_Comp_Comentario> ListarT_Sgpad_Comp_Comentario(int vIdComponente);
        T_Sgpad_Comp_Comentario RecuperarT_Sgpad_Comp_ComentarioPorCodigo(int vId_Comp_Comentario);
        T_Sgpad_Comp_Comentario InsertarT_Sgpad_Comp_Comentario(T_Sgpad_Comp_Comentario vT_Sgpad_Comp_Comentario);
        T_Sgpad_Comp_Comentario ActualizarT_Sgpad_Comp_Comentario(T_Sgpad_Comp_Comentario vT_Sgpad_Comp_Comentario);
        int AnularT_Sgpad_Comp_ComentarioPorCodigo(int vId_Comp_Comentario);
        IEnumerable<T_Sgpad_Comp_Comentario> ListarPaginadoT_Sgpad_Comp_Comentario(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}