using Minem.Sgpam.Entidades;
using System.Collections.Generic;

namespace Minem.Sgpam.AccesoDatos.Interfaces
{
    /// <summary>
    /// Objetivo:	Interfaz que matricula las operaciones para la tabla T_SGPAL_POT_DANO_ESCORIA
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public interface IT_Sgpal_Pot_Dano_EscoriaAD
    {
        IEnumerable<T_Sgpal_Pot_Dano_Escoria> ListarT_Sgpal_Pot_Dano_Escoria();
        T_Sgpal_Pot_Dano_Escoria RecuperarT_Sgpal_Pot_Dano_EscoriaPorCodigo(int vId_Pot_Dano_Escoria);
        T_Sgpal_Pot_Dano_Escoria InsertarT_Sgpal_Pot_Dano_Escoria(T_Sgpal_Pot_Dano_Escoria vT_Sgpal_Pot_Dano_Escoria);
        T_Sgpal_Pot_Dano_Escoria ActualizarT_Sgpal_Pot_Dano_Escoria(T_Sgpal_Pot_Dano_Escoria vT_Sgpal_Pot_Dano_Escoria);
        int AnularT_Sgpal_Pot_Dano_EscoriaPorCodigo(int vId_Pot_Dano_Escoria);
        IEnumerable<T_Sgpal_Pot_Dano_Escoria> ListarPaginadoT_Sgpal_Pot_Dano_Escoria(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}