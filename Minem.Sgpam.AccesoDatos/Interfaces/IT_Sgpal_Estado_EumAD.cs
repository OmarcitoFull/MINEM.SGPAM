using Minem.Sgpam.Entidades;
using System.Collections.Generic;

namespace Minem.Sgpam.AccesoDatos.Interfaces
{
    /// <summary>
    /// Objetivo:	Interfaz que matricula las operaciones para la tabla T_SGPAL_ESTADO_EUM
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public interface IT_Sgpal_Estado_EumAD
    {
        IEnumerable<T_Sgpal_Estado_Eum> ListarT_Sgpal_Estado_Eum();
        T_Sgpal_Estado_Eum RecuperarT_Sgpal_Estado_EumPorCodigo(int vId_Estado_Eum);
        T_Sgpal_Estado_Eum InsertarT_Sgpal_Estado_Eum(T_Sgpal_Estado_Eum vT_Sgpal_Estado_Eum);
        T_Sgpal_Estado_Eum ActualizarT_Sgpal_Estado_Eum(T_Sgpal_Estado_Eum vT_Sgpal_Estado_Eum);
        int AnularT_Sgpal_Estado_EumPorCodigo(int vId_Estado_Eum);
        IEnumerable<T_Sgpal_Estado_Eum> ListarPaginadoT_Sgpal_Estado_Eum(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}