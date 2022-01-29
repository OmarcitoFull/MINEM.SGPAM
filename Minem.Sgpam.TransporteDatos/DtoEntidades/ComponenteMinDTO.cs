using Minem.Sgpam.TransporteDatos.Base;
using System;
using System.Collections.Generic;

namespace Minem.Sgpam.TransporteDatos.DtoEntidades
{
    /// <summary>
    /// Objetivo:	Objeto de negocio para el cliente
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public partial class ComponenteMinDTO : BaseOTD
    {
		#region Propiedades
		public int Id_Componente { get; set; }
		public string Nombre { get; set; }
		public string Tipo { get; set; }
		public string SubTipo { get; set; }
		public int Este { get; set; }
		public int Norte { get; set; }
		public string Zona { get; set; }
		public string Datum { get; set; }
		public string Responsable { get; set; }
		public string Riesgo { get; set; }
		public int? Puntaje { get; set; }
		public string Imagen { get; set; }
		public string Flg_Estado { get; set; }

        #endregion
    }
}