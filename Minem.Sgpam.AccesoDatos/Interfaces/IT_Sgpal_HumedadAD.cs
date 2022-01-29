using Minem.Sgpam.Entidades;
using System.Collections.Generic;

namespace Minem.Sgpam.AccesoDatos.Interfaces
{
    /// <summary>
    /// Objetivo:	Interfaz que matricula las operaciones para la tabla T_SGPAL_HUMEDAD
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public interface IT_Sgpal_HumedadAD
    {
        IEnumerable<T_Sgpal_Humedad> ListarT_Sgpal_Humedad();
        T_Sgpal_Humedad RecuperarT_Sgpal_HumedadPorCodigo(int vId_Humedad);
        T_Sgpal_Humedad InsertarT_Sgpal_Humedad(T_Sgpal_Humedad vT_Sgpal_Humedad);
        T_Sgpal_Humedad ActualizarT_Sgpal_Humedad(T_Sgpal_Humedad vT_Sgpal_Humedad);
        int AnularT_Sgpal_HumedadPorCodigo(int vId_Humedad);
        IEnumerable<T_Sgpal_Humedad> ListarPaginadoT_Sgpal_Humedad(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}