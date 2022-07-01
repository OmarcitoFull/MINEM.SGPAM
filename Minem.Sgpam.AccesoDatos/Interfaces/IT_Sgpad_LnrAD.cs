using Minem.Sgpam.Entidades;
using System.Collections.Generic;

namespace Minem.Sgpam.AccesoDatos.Interfaces
{
    /// <summary>
    /// Objetivo:	Interfaz que matricula las operaciones para la tabla T_SGPAD_LNR
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public interface IT_Sgpad_LnrAD
    {
        IEnumerable<T_Sgpad_Lnr> ListarT_Sgpad_Lnr();
        T_Sgpad_Lnr RecuperarT_Sgpad_LnrPorCodigo(int vId_Lnr);
        T_Sgpad_Lnr InsertarT_Sgpad_Lnr(T_Sgpad_Lnr vT_Sgpad_Lnr);
        T_Sgpad_Lnr ActualizarT_Sgpad_Lnr(T_Sgpad_Lnr vT_Sgpad_Lnr);
        int AnularT_Sgpad_LnrPorCodigo(int vId_Lnr);
        IEnumerable<T_Sgpad_Lnr> ListarPaginadoT_Sgpad_Lnr(int vId_Expediente, int vNumPag, int vCantRegxPag);
        IEnumerable<T_Sgpad_Lnr> ListarPorIdExpedienteT_Sgpad_Lnr(int vId_Expediente);

    }
}