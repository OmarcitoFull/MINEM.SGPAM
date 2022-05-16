using Minem.Sgpam.TransporteDatos.Base;
using System;

namespace Minem.Sgpam.TransporteDatos.DtoEntidades
{
    /// <summary>
    /// Objetivo:	Objeto de negocio para el cliente
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public partial class TitularesReferencialesDerechosDTO : BaseOTD
    {
        #region Propiedades
        public string Titular_Referencial { get; set; }
        public string Fecha_Inicio { get; set; }
        public string Fecha_Final { get; set; }
        public string Estado { get; set; }
        public string Codigo { get; set; }
        #endregion
    }
}