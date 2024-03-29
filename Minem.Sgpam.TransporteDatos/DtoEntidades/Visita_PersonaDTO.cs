﻿using Minem.Sgpam.TransporteDatos.Base;
using System;
using System.ComponentModel.DataAnnotations;

namespace Minem.Sgpam.TransporteDatos.DtoEntidades
{
    /// <summary>
    /// Objetivo:	Objeto de negocio para el cliente
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public partial class Visita_PersonaDTO : BaseOTD
    {
		#region Propiedades
		public int Id_Visita_Persona { get; set; }
		public int Id_Visita { get; set; }
		public int Id_Cargo { get; set; }
		public string Dni { get; set; }
		[Required]
		[StringLength(100)]
		public string Nombre_Completo { get; set; }
		public string Correo { get; set; }
		public string Contacto { get; set; }
		public string Usu_Ingreso { get; set; }
		public DateTime? Fec_Ingreso { get; set; }
		public string Ip_Ingreso { get; set; }
		public string Usu_Modifica { get; set; }
		public DateTime? Fec_Modifica { get; set; }
		public string Ip_Modifica { get; set; }
		public string Flg_Estado { get; set; }

		public string Cargo { get; set; }
		#endregion
	}
}
