using Minem.Sgpam.Entidades.Base;
using System;

namespace Minem.Sgpam.Entidades
{
    /// <summary>
    /// Objetivo:	Entidad que mapea una tabla de base de datos
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	25/10/2021
    /// </summary>
    public partial class T_Sgpad_Comp_Reinfo_Dm : BEPaginacion
    {
        #region Propiedades
        public int ID_COMP_REINFO_DM { get; set; }  
        #endregion
    }
}