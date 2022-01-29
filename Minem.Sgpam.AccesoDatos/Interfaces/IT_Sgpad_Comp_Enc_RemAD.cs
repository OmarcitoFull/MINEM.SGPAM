using Minem.Sgpam.Entidades;
using System.Collections.Generic;

namespace Minem.Sgpam.AccesoDatos.Interfaces
{
    /// <summary>
    /// Objetivo:	Interfaz que matricula las operaciones para la tabla T_SGPAD_COMP_ENC_REM
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public interface IT_Sgpad_Comp_Enc_RemAD
    {
        IEnumerable<T_Sgpad_Comp_Enc_Rem> ListarT_Sgpad_Comp_Enc_Rem(int vIdComponente);
        T_Sgpad_Comp_Enc_Rem RecuperarT_Sgpad_Comp_Enc_RemPorCodigo(int vId_Comp_Enc_Rem);
        T_Sgpad_Comp_Enc_Rem InsertarT_Sgpad_Comp_Enc_Rem(T_Sgpad_Comp_Enc_Rem vT_Sgpad_Comp_Enc_Rem);
        T_Sgpad_Comp_Enc_Rem ActualizarT_Sgpad_Comp_Enc_Rem(T_Sgpad_Comp_Enc_Rem vT_Sgpad_Comp_Enc_Rem);
        int AnularT_Sgpad_Comp_Enc_RemPorCodigo(int vId_Comp_Enc_Rem);
        IEnumerable<T_Sgpad_Comp_Enc_Rem> ListarPaginadoT_Sgpad_Comp_Enc_Rem(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}