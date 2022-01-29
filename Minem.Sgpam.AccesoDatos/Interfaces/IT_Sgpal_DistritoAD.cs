using Minem.Sgpam.Entidades;
using System.Collections.Generic;

namespace Minem.Sgpam.AccesoDatos.Interfaces
{
    /// <summary>
    /// Objetivo:	Interfaz que matricula las operaciones para la tabla T_SGPAL_DISTRITO
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public interface IT_Sgpal_DistritoAD
    {
        IEnumerable<T_Sgpal_Distrito> ListarT_Sgpal_Distrito();
        T_Sgpal_Distrito RecuperarT_Sgpal_DistritoPorCodigo(int vId_Distrito);
        T_Sgpal_Distrito InsertarT_Sgpal_Distrito(T_Sgpal_Distrito vT_Sgpal_Distrito);
        T_Sgpal_Distrito ActualizarT_Sgpal_Distrito(T_Sgpal_Distrito vT_Sgpal_Distrito);
        int AnularT_Sgpal_DistritoPorCodigo(int vId_Distrito);
        IEnumerable<T_Sgpal_Distrito> ListarPaginadoT_Sgpal_Distrito(string vFiltro, int vNumPag, int vCantRegxPag);
        IEnumerable<Ubigeo> ListarT_Ubigeo();
    }
}