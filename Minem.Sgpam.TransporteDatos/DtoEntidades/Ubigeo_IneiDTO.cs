using Minem.Sgpam.TransporteDatos.Base;
using System;
using System.Collections.Generic;

namespace Minem.Sgpam.TransporteDatos.DtoEntidades
{
    /// <summary>
    /// Objetivo:	Objeto de negocio para el cliente
    /// Creado Por:	Mateo Salvador Paucar    
    /// Fecha Creación:	31/10/2022
    /// </summary>
    public partial class Ubigeo_IneiDTO : BaseOTD
    {
		#region Propiedades
		public string Id_Ubigeo_Inei { get; set; }
		public string Ubigeo { get; set; }
		public string Departamento { get; set; }
		public string Provincia { get; set; }
		public string Distrito { get; set; }
		public string Id_Departamento { get; set; }
		public string Id_Provincia { get; set; }
		public string Id_Distrito { get; set; }
		public string Flg_Estado { get; set; }
		#endregion
	}
}
