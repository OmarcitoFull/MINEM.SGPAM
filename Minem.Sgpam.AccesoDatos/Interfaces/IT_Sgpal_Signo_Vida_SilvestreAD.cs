using Minem.Sgpam.Entidades;
using System.Collections.Generic;

namespace Minem.Sgpam.AccesoDatos.Interfaces
{
    /// <summary>
    /// Objetivo:	Interfaz que matricula las operaciones para la tabla T_SGPAL_SIGNO_VIDA_SILVESTRE
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public interface IT_Sgpal_Signo_Vida_SilvestreAD
    {
        IEnumerable<T_Sgpal_Signo_Vida_Silvestre> ListarT_Sgpal_Signo_Vida_Silvestre();
        T_Sgpal_Signo_Vida_Silvestre RecuperarT_Sgpal_Signo_Vida_SilvestrePorCodigo(int vId_Signo_Vida_Silvestre);
        T_Sgpal_Signo_Vida_Silvestre InsertarT_Sgpal_Signo_Vida_Silvestre(T_Sgpal_Signo_Vida_Silvestre vT_Sgpal_Signo_Vida_Silvestre);
        T_Sgpal_Signo_Vida_Silvestre ActualizarT_Sgpal_Signo_Vida_Silvestre(T_Sgpal_Signo_Vida_Silvestre vT_Sgpal_Signo_Vida_Silvestre);
        int AnularT_Sgpal_Signo_Vida_SilvestrePorCodigo(int vId_Signo_Vida_Silvestre);
        IEnumerable<T_Sgpal_Signo_Vida_Silvestre> ListarPaginadoT_Sgpal_Signo_Vida_Silvestre(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}