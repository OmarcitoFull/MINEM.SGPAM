using Minem.Sgpam.Entidades;
using System.Collections.Generic;

namespace Minem.Sgpam.AccesoDatos.Interfaces
{
    /// <summary>
    /// Objetivo:	Interfaz que matricula las operaciones para la tabla T_SGPAD_EUM_OPERACION
    /// Creado Por: Mateo Salvador Paucar
    /// Fecha Creación:	08/02/2022
    /// </summary>
    public interface IT_Sgpad_Eum_OperacionAD
    {
        IEnumerable<T_Sgpad_Eum_Operacion> ListarT_Sgpad_Eum_Operacion();
        T_Sgpad_Eum_Operacion RecuperarT_Sgpad_Eum_OperacionPorCodigo(int vId_Eum_Operacion);
        T_Sgpad_Eum_Operacion InsertarT_Sgpad_Eum_Operacion(T_Sgpad_Eum_Operacion vT_Sgpad_Eum_Operacion);
        T_Sgpad_Eum_Operacion ActualizarT_Sgpad_Eum_Operacion(T_Sgpad_Eum_Operacion vT_Sgpad_Eum_Operacion);
        int AnularT_Sgpad_Eum_OperacionPorCodigo(T_Sgpad_Eum_Operacion vT_Sgpad_Eum_Operacion);
        IEnumerable<T_Sgpad_Eum_Operacion> ListarPaginadoT_Sgpad_Eum_Operacion(string vFiltro, int vNumPag, int vCantRegxPag);
        IEnumerable<T_Sgpad_Eum_Operacion> ListarPorIdEumT_Sgpad_Eum_Operacion(int vId_Eum);
    }
}
