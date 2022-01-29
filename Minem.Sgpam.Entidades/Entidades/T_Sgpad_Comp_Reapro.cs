using Minem.Sgpam.Entidades.Base;
using System;

namespace Minem.Sgpam.Entidades
{
    /// <summary>
    /// Objetivo:	Entidad que mapea una tabla de base de datos
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	25/10/2021
    /// </summary>
    public partial class T_Sgpad_Comp_Reapro : BEPaginacion
    {
        #region Propiedades
        public string NOMBRE_PROYECTO { get; set; }  
		public string TITULAR { get; set; }
		#endregion
	}
}