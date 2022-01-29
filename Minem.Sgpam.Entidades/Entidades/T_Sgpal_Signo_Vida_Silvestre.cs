using Minem.Sgpam.Entidades.Base;
using System;

namespace Minem.Sgpam.Entidades
{
    /// <summary>
    /// Objetivo:	Entidad que mapea una tabla de base de datos
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	25/10/2021
    /// </summary>
    public partial class T_Sgpal_Signo_Vida_Silvestre : BEPaginacion
    {
        #region Propiedades
        public int ID_SIGNO_VIDA_SILVESTRE { get; set; }  
        #endregion
    }
}