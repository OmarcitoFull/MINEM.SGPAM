using Minem.Sgpam.TransporteDatos.Base;
using System;

namespace Minem.Sgpam.TransporteDatos.DtoEntidades
{
    /// <summary>
    /// Objetivo:	Objeto de negocio para el cliente
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public partial class Comp_Dm_TitularDTO : BaseOTD
    {
        #region Propiedades
        public int? Id_Estado { get; set; }  		public string Usu_Modifica { get; set; }  		public string Flg_Estado { get; set; }  		public string Ip_Modifica { get; set; }  		public int Id_Comp_Dm_Titular { get; set; }  		public string Usu_Ingreso { get; set; }  		public int Id_Comp_Dm { get; set; }  		public DateTime? Fec_Modifica { get; set; }  		public int Id_Empresa { get; set; }  		public DateTime? Fec_Ingreso { get; set; }  		public DateTime Fecha_Inicio { get; set; }  		public string Ip_Ingreso { get; set; }  		public DateTime? Fecha_Fin { get; set; }  		
        #endregion
    }
}