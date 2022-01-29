using Minem.Sgpam.Entidades;
using System.Collections.Generic;

namespace Minem.Sgpam.AccesoDatos.Interfaces
{
    /// <summary>
    /// Objetivo:	Interfaz que matricula las operaciones para la tabla T_SGPAL_ESTADO_GESTION
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public interface IT_Sgpal_Estado_GestionAD
    {
        IEnumerable<T_Sgpal_Estado_Gestion> ListarT_Sgpal_Estado_Gestion();
        T_Sgpal_Estado_Gestion RecuperarT_Sgpal_Estado_GestionPorCodigo(int vId_Estado_Gestion);
        T_Sgpal_Estado_Gestion InsertarT_Sgpal_Estado_Gestion(T_Sgpal_Estado_Gestion vT_Sgpal_Estado_Gestion);
        T_Sgpal_Estado_Gestion ActualizarT_Sgpal_Estado_Gestion(T_Sgpal_Estado_Gestion vT_Sgpal_Estado_Gestion);
        int AnularT_Sgpal_Estado_GestionPorCodigo(int vId_Estado_Gestion);
        IEnumerable<T_Sgpal_Estado_Gestion> ListarPaginadoT_Sgpal_Estado_Gestion(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}