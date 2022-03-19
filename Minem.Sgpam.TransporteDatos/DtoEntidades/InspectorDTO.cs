using Minem.Sgpam.TransporteDatos.Base;
using System;

namespace Minem.Sgpam.TransporteDatos.DtoEntidades
{
    /// <summary>
    /// Objetivo:	Objeto de negocio para el cliente
    /// Creado Por:	Mateo Salvador paucar    
    /// Fecha Creación:	20/02/2022
    /// </summary>
    public partial class InspectorDTO : BaseOTD
    {
        #region Propiedades
        public int Id_Inspector { get; set; }
        public string Nom_Inspector { get; set; }
        public string Ape_Paterno { get; set; }
        public string Ape_Materno { get; set; }
        public string Nombre_Completo { get; set; }
        public string Usu_Modifica { get; set; }
        public string Ip_Ingreso { get; set; }
        public string Usu_Ingreso { get; set; }
        public string Ip_Modifica { get; set; }
        public DateTime? Fec_Ingreso { get; set; }
        public DateTime? Fec_Modifica { get; set; }
        public string Flg_Estado { get; set; }

        #endregion

    }
}
