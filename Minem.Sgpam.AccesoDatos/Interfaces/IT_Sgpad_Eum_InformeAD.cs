using Minem.Sgpam.Entidades;
using System.Collections.Generic;

namespace Minem.Sgpam.AccesoDatos.Interfaces
{
    /// <summary>
    /// Objetivo:	Interfaz que matricula las operaciones para la tabla T_SGPAD_EUM_INFORME
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public interface IT_Sgpad_Eum_InformeAD
    {
        IEnumerable<T_Sgpad_Eum_Informe> ListarT_Sgpad_Eum_Informe();
        T_Sgpad_Eum_Informe RecuperarT_Sgpad_Eum_InformePorCodigo(int vId_Eum_Informe);
        T_Sgpad_Eum_Informe InsertarT_Sgpad_Eum_Informe(T_Sgpad_Eum_Informe vT_Sgpad_Eum_Informe);
        T_Sgpad_Eum_Informe ActualizarT_Sgpad_Eum_Informe(T_Sgpad_Eum_Informe vT_Sgpad_Eum_Informe);
        int AnularT_Sgpad_Eum_InformePorCodigo(T_Sgpad_Eum_Informe vT_Sgpad_Eum_Informe);
        IEnumerable<T_Sgpad_Eum_Informe> ListarPaginadoT_Sgpad_Eum_Informe(string vFiltro, int vNumPag, int vCantRegxPag);
        IEnumerable<T_Sgpad_Eum_Informe> ListarPorIdEumT_Sgpad_Eum_Informe(int vId_Eum);
    }
}