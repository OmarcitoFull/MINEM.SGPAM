using Minem.Sgpam.Entidades;
using System.Collections.Generic;

namespace Minem.Sgpam.AccesoDatos.Interfaces
{
    /// <summary>
    /// Objetivo:	Interfaz que matricula las operaciones para la tabla T_SGPAD_COMP_RESULTADO
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public interface IT_Sgpad_Comp_ResultadoAD
    {
        IEnumerable<T_Sgpad_Comp_Resultado> ListarT_Sgpad_Comp_Resultado(int vIdComponente);
        T_Sgpad_Comp_Resultado RecuperarT_Sgpad_Comp_ResultadoPorCodigo(int vId_Comp_Resultado);
        T_Sgpad_Comp_Resultado InsertarT_Sgpad_Comp_Resultado(T_Sgpad_Comp_Resultado vT_Sgpad_Comp_Resultado);
        T_Sgpad_Comp_Resultado ActualizarT_Sgpad_Comp_Resultado(T_Sgpad_Comp_Resultado vT_Sgpad_Comp_Resultado);
        int AnularT_Sgpad_Comp_ResultadoPorCodigo(int vId_Comp_Resultado);
        IEnumerable<T_Sgpad_Comp_Resultado> ListarPaginadoT_Sgpad_Comp_Resultado(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}