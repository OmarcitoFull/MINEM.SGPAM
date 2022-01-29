using Minem.Sgpam.Entidades;
using System.Collections.Generic;

namespace Minem.Sgpam.AccesoDatos.Interfaces
{
    /// <summary>
    /// Objetivo:	Interfaz que matricula las operaciones para la tabla T_SGPAL_TAMANO_PARTICULA
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public interface IT_Sgpal_Tamano_ParticulaAD
    {
        IEnumerable<T_Sgpal_Tamano_Particula> ListarT_Sgpal_Tamano_Particula();
        T_Sgpal_Tamano_Particula RecuperarT_Sgpal_Tamano_ParticulaPorCodigo(int vId_Tamano_Particula);
        T_Sgpal_Tamano_Particula InsertarT_Sgpal_Tamano_Particula(T_Sgpal_Tamano_Particula vT_Sgpal_Tamano_Particula);
        T_Sgpal_Tamano_Particula ActualizarT_Sgpal_Tamano_Particula(T_Sgpal_Tamano_Particula vT_Sgpal_Tamano_Particula);
        int AnularT_Sgpal_Tamano_ParticulaPorCodigo(int vId_Tamano_Particula);
        IEnumerable<T_Sgpal_Tamano_Particula> ListarPaginadoT_Sgpal_Tamano_Particula(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}