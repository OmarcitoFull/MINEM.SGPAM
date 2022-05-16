using Minem.Sgpam.Entidades;
using System.Collections.Generic;

namespace Minem.Sgpam.AccesoDatos.Interfaces
{
    /// <summary>
    /// Objetivo:	Interfaz que matricula las operaciones para la tabla T_SGPAD_LNR_INFO_DOCUMENTO
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public interface IT_Sgpad_Lnr_Info_DocumentoAD
    {
        IEnumerable<T_Sgpad_Lnr_Info_Documento> ListarT_Sgpad_Lnr_Info_Documento();
        T_Sgpad_Lnr_Info_Documento RecuperarT_Sgpad_Lnr_Info_DocumentoPorCodigo(int vId_Lnr_Info_Documento);
        T_Sgpad_Lnr_Info_Documento InsertarT_Sgpad_Lnr_Info_Documento(T_Sgpad_Lnr_Info_Documento vT_Sgpad_Lnr_Info_Documento);
        T_Sgpad_Lnr_Info_Documento ActualizarT_Sgpad_Lnr_Info_Documento(T_Sgpad_Lnr_Info_Documento vT_Sgpad_Lnr_Info_Documento);
        int AnularT_Sgpad_Lnr_Info_DocumentoPorCodigo(int vId_Lnr_Info_Documento);
        IEnumerable<T_Sgpad_Lnr_Info_Documento> ListarPaginadoT_Sgpad_Lnr_Info_Documento(string vFiltro, int vNumPag, int vCantRegxPag);
        IEnumerable<T_Sgpad_Lnr_Info_Documento> ListarPorIdLnrT_Sgpad_Lnr_Info_Documento(int vId_Lnr);
    }
}