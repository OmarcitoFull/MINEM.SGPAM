using Minem.Sgpam.Entidades;
using System.Collections.Generic;

namespace Minem.Sgpam.AccesoDatos.Interfaces
{
    /// <summary>
    /// Objetivo:	Interfaz que matricula las operaciones para la tabla T_SGPAL_POT_ELECTRICO
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public interface IT_Sgpal_Pot_ElectricoAD
    {
        IEnumerable<T_Sgpal_Pot_Electrico> ListarT_Sgpal_Pot_Electrico();
        T_Sgpal_Pot_Electrico RecuperarT_Sgpal_Pot_ElectricoPorCodigo(int vId_Pot_Electrico);
        T_Sgpal_Pot_Electrico InsertarT_Sgpal_Pot_Electrico(T_Sgpal_Pot_Electrico vT_Sgpal_Pot_Electrico);
        T_Sgpal_Pot_Electrico ActualizarT_Sgpal_Pot_Electrico(T_Sgpal_Pot_Electrico vT_Sgpal_Pot_Electrico);
        int AnularT_Sgpal_Pot_ElectricoPorCodigo(int vId_Pot_Electrico);
        IEnumerable<T_Sgpal_Pot_Electrico> ListarPaginadoT_Sgpal_Pot_Electrico(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}