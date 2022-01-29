using Minem.Sgpam.Entidades;
using System.Collections.Generic;

namespace Minem.Sgpam.AccesoDatos.Interfaces
{
    /// <summary>
    /// Objetivo:	Interfaz que matricula las operaciones para la tabla T_SGPAL_POT_CAIDA_PERSONA
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public interface IT_Sgpal_Pot_Caida_PersonaAD
    {
        IEnumerable<T_Sgpal_Pot_Caida_Persona> ListarT_Sgpal_Pot_Caida_Persona();
        T_Sgpal_Pot_Caida_Persona RecuperarT_Sgpal_Pot_Caida_PersonaPorCodigo(int vId_Pot_Caida_Persona);
        T_Sgpal_Pot_Caida_Persona InsertarT_Sgpal_Pot_Caida_Persona(T_Sgpal_Pot_Caida_Persona vT_Sgpal_Pot_Caida_Persona);
        T_Sgpal_Pot_Caida_Persona ActualizarT_Sgpal_Pot_Caida_Persona(T_Sgpal_Pot_Caida_Persona vT_Sgpal_Pot_Caida_Persona);
        int AnularT_Sgpal_Pot_Caida_PersonaPorCodigo(int vId_Pot_Caida_Persona);
        IEnumerable<T_Sgpal_Pot_Caida_Persona> ListarPaginadoT_Sgpal_Pot_Caida_Persona(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}