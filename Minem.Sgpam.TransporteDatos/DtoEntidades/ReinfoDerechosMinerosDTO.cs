using Minem.Sgpam.TransporteDatos.Base;
using System;

namespace Minem.Sgpam.TransporteDatos.DtoEntidades
{
    /// <summary>
    /// Objetivo:	Objeto de negocio para el cliente
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	26/11/2021
    /// </summary>
    public partial class ReinfoDerechosMinerosDTO : BaseOTD
    {
        #region Propiedades
        public string Ruc { get; set; }
        public string Minero { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Departamento { get; set; }
        public string Provincia { get; set; }
        public string Distrito { get; set; }
        public string Estado_Vigencia { get; set; }
        public string Este_Psad56 { get; set; }
        public string Norte_Psad56 { get; set; }
        public string Este_Wgs84_1p { get; set; }
        public string Norte_Wgs84_1p { get; set; }
        public string Este_Wgs84_2p { get; set; }
        public string Norte_Wgs84_2p { get; set; }
        public string Tipo_Actividad { get; set; }
        #endregion
    }
}