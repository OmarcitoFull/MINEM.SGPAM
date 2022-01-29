using Minem.Sgpam.Entidades;
using System.Collections.Generic;

namespace Minem.Sgpam.AccesoDatos.Interfaces
{
    /// <summary>
    /// Objetivo:	Interfaz que matricula las operaciones para la tabla T_SGPAD_COMP_RECONOCIMIENTO
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public interface IT_Sgpad_Comp_ReconocimientoAD
    {
        IEnumerable<V_Sgpad_Comp_Reconocimiento> ListarT_Sgpad_Comp_Reconocimiento(int vIdComponente);
        T_Sgpad_Comp_Reconocimiento RecuperarT_Sgpad_Comp_ReconocimientoPorCodigo(int vId_Comp_Reconocimiento);
        T_Sgpad_Comp_Reconocimiento InsertarT_Sgpad_Comp_Reconocimiento(T_Sgpad_Comp_Reconocimiento vT_Sgpad_Comp_Reconocimiento);
        T_Sgpad_Comp_Reconocimiento ActualizarT_Sgpad_Comp_Reconocimiento(T_Sgpad_Comp_Reconocimiento vT_Sgpad_Comp_Reconocimiento);
        int AnularT_Sgpad_Comp_ReconocimientoPorCodigo(int vId_Comp_Reconocimiento);
        IEnumerable<T_Sgpad_Comp_Reconocimiento> ListarPaginadoT_Sgpad_Comp_Reconocimiento(string vFiltro, int vNumPag, int vCantRegxPag);
        int InsertarT_Sgpad_Comp_Reconocimiento_Tipo(T_Sgpad_Comp_Reconocimiento vT_Sgpad_Comp_Reconocimiento, int? vIdTipoPam);
    }
}