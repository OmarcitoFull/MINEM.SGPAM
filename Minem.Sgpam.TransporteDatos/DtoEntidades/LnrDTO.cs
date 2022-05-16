using Minem.Sgpam.TransporteDatos.Base;
using System;

namespace Minem.Sgpam.TransporteDatos.DtoEntidades
{
    /// <summary>
    /// Objetivo:	Objeto de negocio para el cliente
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public partial class LnrDTO : BaseOTD
    {
        #region Propiedades
        public int Id_Zona { get; set; }  		public string Sub_Tipo_Declarado { get; set; }  		public int? Profundidad { get; set; }  		public string Eva_Restos { get; set; }  		public string Volumen_Desc { get; set; }  		public int Id_Sub_Tipo_Lnr { get; set; }  		public int? Ancho { get; set; }  		public string Eva_Material { get; set; }  		public int Norte { get; set; }  		public string Ip_Modifica { get; set; }  		public string Area_Desc { get; set; }  		public int Id_Lnr { get; set; }  		public string Profundidad_Desc { get; set; }  		public DateTime? Fec_Modifica { get; set; }  		public string Ip_Ingreso { get; set; }  		public string Eva_Caida { get; set; }  		public string Eva_Evidencia { get; set; }  		public int Id_Expediente { get; set; }  		public string Ancho_Desc { get; set; }  		public int Este { get; set; }  		public int Id_Tipo_Lnr { get; set; }  		public string Nom_Declarante { get; set; }  		public string Largo_Desc { get; set; }  		public string Eva_Generador { get; set; }  		public string Ubigeo { get; set; }  		public int? Largo { get; set; }  		public string Eva_Elemento { get; set; }  		public string Eva_Drenajes { get; set; }  		public string Eva_Elementos { get; set; }  		public string Alto_Desc { get; set; }  		public string Eva_Afectacion { get; set; }  		public string Eva_Posibilidad { get; set; }  		public string Eva_Potencial { get; set; }  		public string Nro_Expediente { get; set; }  		public string Codigo_Declarado { get; set; }  		public int? Area { get; set; }  		public int? Alto { get; set; }  		public DateTime? Fec_Ingreso { get; set; }  		public string Eva_Labor { get; set; }  		public int Id_Temporalidad { get; set; }  		public DateTime Fec_Registro { get; set; }  		public string Usu_Ingreso { get; set; }  		public string Usu_Modifica { get; set; }  		public string Flg_Estado { get; set; }  		public int? Volumen { get; set; }


		public string Des_Tipo_Lnr { get; set; }
		#endregion
	}
}