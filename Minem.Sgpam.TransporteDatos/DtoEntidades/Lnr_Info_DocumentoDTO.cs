using Minem.Sgpam.TransporteDatos.Base;
using System;

namespace Minem.Sgpam.TransporteDatos.DtoEntidades
{
    /// <summary>
    /// Objetivo:	Objeto de negocio para el cliente
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public partial class Lnr_Info_DocumentoDTO : BaseOTD
    {
		#region Propiedades
		public int Id_Lnr_Info_Documento { get; set; }
		public int Id_Lnr { get; set; }
		public DateTime Fecha_Documento { get; set; }
		public string Nombre_Informe { get; set; }
		public string Descripcion { get; set; }
		public string Nombre_Documento { get; set; }
		public string Ruta_Documento { get; set; }
		public string Extencion { get; set; }
		public int? Tamano { get; set; }
		public long? Id_LaserFiche { get; set; }
		public string Usu_Ingreso { get; set; }
		public DateTime? Fec_Ingreso { get; set; }
		public string Ip_Ingreso { get; set; }
		public string Usu_Modifica { get; set; }
		public DateTime? Fec_Modifica { get; set; }
		public string Ip_Modifica { get; set; }
		public string Flg_Estado { get; set; }
		
        #endregion
    }
}