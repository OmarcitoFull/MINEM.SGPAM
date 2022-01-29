using Minem.Sgpam.TransporteDatos.Base;
using System;

namespace Minem.Sgpam.TransporteDatos.DtoEntidades
{
    /// <summary>
    /// Objetivo:	Objeto de negocio para el cliente
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public partial class Comp_ResultadoDTO : BaseOTD
    {
        #region Propiedades
        public string Act_Sgp_Descripcion { get; set; }  		public string Act_Inv_Region { get; set; }  		public string Act_Inv_Sub_Tipo { get; set; }  		public string Exc_Otros { get; set; }  		public int Id_Componente { get; set; }  		public string Flg_Estado { get; set; }  		public string Act_Sgp_Ph { get; set; }  		public string Usu_Ingreso { get; set; }  		public string Ip_Modifica { get; set; }  		public string Act_Inv_Generador { get; set; }  		public string Act_Inv_Eum { get; set; }  		public string Exc_No_Sig_Rie { get; set; }  		public string Act_Inv_Res_Remedia { get; set; }  		public string Inc_Inventario { get; set; }  		public string Act_Inv_Coordenadas { get; set; }  		public string Act_Sgp_Condiciones { get; set; }  		public string Act_Inv_Provincia { get; set; }  		public DateTime? Fec_Modifica { get; set; }  		public string Ip_Ingreso { get; set; }  		public string Act_Inv_Distrito { get; set; }  		public string Exc_No_Exi_Pam { get; set; }  		public int Id_Comp_Resultado { get; set; }  		public DateTime? Fec_Ingreso { get; set; }  		public string Act_Sgp_Q { get; set; }  		public string Act_Inv_Cuenca { get; set; }  		public string Act_Sgp_Areas { get; set; }  		public string Usu_Modifica { get; set; }  		public string Exc_Pam_Inf_Dup { get; set; }  		public string Exc_Agr_Pam_Id { get; set; }  		
        #endregion
    }
}