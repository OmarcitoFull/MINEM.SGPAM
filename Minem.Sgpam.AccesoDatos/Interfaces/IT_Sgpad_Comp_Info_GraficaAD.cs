using Minem.Sgpam.Entidades;
using System.Collections.Generic;

namespace Minem.Sgpam.AccesoDatos.Interfaces
{
    /// <summary>
    /// Objetivo:	Interfaz que matricula las operaciones para la tabla T_SGPAD_COMP_INFO_GRAFICA
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public interface IT_Sgpad_Comp_Info_GraficaAD
    {
        IEnumerable<T_Sgpad_Comp_Info_Grafica> ListarT_Sgpad_Comp_Info_Grafica(int vIdComponente);
        T_Sgpad_Comp_Info_Grafica RecuperarT_Sgpad_Comp_Info_GraficaPorCodigo(int vId_Comp_Info_Grafica);
        T_Sgpad_Comp_Info_Grafica InsertarT_Sgpad_Comp_Info_Grafica(T_Sgpad_Comp_Info_Grafica vT_Sgpad_Comp_Info_Grafica);
        T_Sgpad_Comp_Info_Grafica ActualizarT_Sgpad_Comp_Info_Grafica(T_Sgpad_Comp_Info_Grafica vT_Sgpad_Comp_Info_Grafica);
        int AnularT_Sgpad_Comp_Info_GraficaPorCodigo(int vId_Comp_Info_Grafica);
        IEnumerable<T_Sgpad_Comp_Info_Grafica> ListarPaginadoT_Sgpad_Comp_Info_Grafica(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}