using Minem.Sgpam.Entidades;
using System.Collections.Generic;

namespace Minem.Sgpam.AccesoDatos.Interfaces
{
    /// <summary>
    /// Objetivo:	Interfaz que matricula las operaciones para la tabla T_SGPAD_EUM_INFO_DESCARGO
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public interface IT_Sgpad_Eum_Info_DescargoAD
    {
        IEnumerable<T_Sgpad_Eum_Info_Descargo> ListarT_Sgpad_Eum_Info_Descargo();
        T_Sgpad_Eum_Info_Descargo RecuperarT_Sgpad_Eum_Info_DescargoPorCodigo(int vId_Eum_Info_Descargo);
        T_Sgpad_Eum_Info_Descargo InsertarT_Sgpad_Eum_Info_Descargo(T_Sgpad_Eum_Info_Descargo vT_Sgpad_Eum_Info_Descargo);
        T_Sgpad_Eum_Info_Descargo ActualizarT_Sgpad_Eum_Info_Descargo(T_Sgpad_Eum_Info_Descargo vT_Sgpad_Eum_Info_Descargo);
        int AnularT_Sgpad_Eum_Info_DescargoPorCodigo(int vId_Eum_Info_Descargo);
        IEnumerable<T_Sgpad_Eum_Info_Descargo> ListarPaginadoT_Sgpad_Eum_Info_Descargo(string vFiltro, int vNumPag, int vCantRegxPag);
        IEnumerable<T_Sgpad_Eum_Info_Descargo> ListarPorIdEumT_Sgpad_Eum_Info_Descargo(int vId_Eum);
    }
}