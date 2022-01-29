using Minem.Sgpam.Entidades;
using System.Collections.Generic;

namespace Minem.Sgpam.AccesoDatos.Interfaces
{
    /// <summary>
    /// Objetivo:	Interfaz que matricula las operaciones para la tabla T_SGPAL_POT_EXPLOSION_INCENDIO
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public interface IT_Sgpal_Pot_Explosion_IncendioAD
    {
        IEnumerable<T_Sgpal_Pot_Explosion_Incendio> ListarT_Sgpal_Pot_Explosion_Incendio();
        T_Sgpal_Pot_Explosion_Incendio RecuperarT_Sgpal_Pot_Explosion_IncendioPorCodigo();
        T_Sgpal_Pot_Explosion_Incendio InsertarT_Sgpal_Pot_Explosion_Incendio(T_Sgpal_Pot_Explosion_Incendio vT_Sgpal_Pot_Explosion_Incendio);
        T_Sgpal_Pot_Explosion_Incendio ActualizarT_Sgpal_Pot_Explosion_Incendio(T_Sgpal_Pot_Explosion_Incendio vT_Sgpal_Pot_Explosion_Incendio);
        int AnularT_Sgpal_Pot_Explosion_IncendioPorCodigo();
        IEnumerable<T_Sgpal_Pot_Explosion_Incendio> ListarPaginadoT_Sgpal_Pot_Explosion_Incendio(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}