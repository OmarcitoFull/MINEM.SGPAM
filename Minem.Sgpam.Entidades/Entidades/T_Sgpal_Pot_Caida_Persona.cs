using Minem.Sgpam.Entidades.Base;
using System;

namespace Minem.Sgpam.Entidades
{
    /// <summary>
    /// Objetivo:	Entidad que mapea una tabla de base de datos
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	25/10/2021
    /// </summary>
    public partial class T_Sgpal_Pot_Caida_Persona : BEPaginacion
    {
        #region Propiedades
        public int? PESO_ORM { get; set; }  
        #endregion
    }
}