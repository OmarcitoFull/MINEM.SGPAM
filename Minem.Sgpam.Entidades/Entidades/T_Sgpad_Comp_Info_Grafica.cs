using Minem.Sgpam.Entidades.Base;
using System;

namespace Minem.Sgpam.Entidades
{
    /// <summary>
    /// Objetivo:	Entidad que mapea una tabla de base de datos
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	25/10/2021
    /// </summary>
    public partial class T_Sgpad_Comp_Info_Grafica : BEPaginacion
    {
        #region Propiedades
        public string USU_INGRESO { get; set; }  
        #endregion
    }
}