using Minem.Sgpam.TransporteDatos.Base;
using System;

namespace Minem.Sgpam.TransporteDatos.DtoEntidades
{
    /// <summary>
    /// Objetivo:	Objeto de negocio para el cliente
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public partial class Eum_InformeDTO : BaseOTD
    {
        #region Propiedades
		public int Id_Eum_Informe { get; set; }
		public int Id_Eum { get; set; }
		public string Nro_Expediente { get; set; }
		public string Nro_Informe { get; set; }
		public DateTime? Fecha_Informe { get; set; }
		public string Descripcion { get; set; }  		public string Nombre_Informe { get; set; }  		public string Ruta_Informe { get; set; }
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