using Minem.Sgpam.Entidades;
using System.Collections.Generic;

namespace Minem.Sgpam.AccesoDatos.Interfaces
{
    /// <summary>
    /// Objetivo:	Interfaz que matricula las operaciones para la tabla T_SGPAL_POT_CAIDA_EQUIPO
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public interface IT_Sgpal_Pot_Caida_EquipoAD
    {
        IEnumerable<T_Sgpal_Pot_Caida_Equipo> ListarT_Sgpal_Pot_Caida_Equipo();
        T_Sgpal_Pot_Caida_Equipo RecuperarT_Sgpal_Pot_Caida_EquipoPorCodigo(int vId_Pot_Caida_Equipo);
        T_Sgpal_Pot_Caida_Equipo InsertarT_Sgpal_Pot_Caida_Equipo(T_Sgpal_Pot_Caida_Equipo vT_Sgpal_Pot_Caida_Equipo);
        T_Sgpal_Pot_Caida_Equipo ActualizarT_Sgpal_Pot_Caida_Equipo(T_Sgpal_Pot_Caida_Equipo vT_Sgpal_Pot_Caida_Equipo);
        int AnularT_Sgpal_Pot_Caida_EquipoPorCodigo(int vId_Pot_Caida_Equipo);
        IEnumerable<T_Sgpal_Pot_Caida_Equipo> ListarPaginadoT_Sgpal_Pot_Caida_Equipo(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}