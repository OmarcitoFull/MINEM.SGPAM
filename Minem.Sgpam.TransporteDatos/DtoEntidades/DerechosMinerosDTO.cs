using Minem.Sgpam.TransporteDatos.Base;
using System;

namespace Minem.Sgpam.TransporteDatos.DtoEntidades
{
    /// <summary>
    /// Objetivo:	Objeto de negocio para el cliente
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public partial class DerechosMinerosDTO : BaseOTD
    {
        #region Propiedades
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string UEA { get; set; }
        public string Tipo { get; set; }
        public string Sustancia { get; set; }
        public string Situacion { get; set; }
        public string Estado { get; set; }
        public string Resolucion { get; set; }
        public string Fecha_Resolucion { get; set; }
        public string Resolucion_Caducidad { get; set; }
        public string Fecha_Caducidad { get; set; }
        #endregion
    }
}