using Minem.Sgpam.TransporteDatos.Base;

namespace Minem.Sgpam.TransporteDatos.DtoEntidades
{
    /// <summary>
    /// Objetivo:	Objeto de negocio para el cliente
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public partial class SituacionPrincipalesProductosDTO : BaseOTD
    {
        #region Propiedades
        public string Anio { get; set; }
        public string Id_Cliente { get; set; }
        public string Nombre_Cliente { get; set; }
        public string Id_Unidad { get; set; }
        public string Nombre_Unidad { get; set; }
        public string Situacion { get; set; }
        public string Tipo_Concentrado { get; set; }
        public string Cantidad { get; set; }
        #endregion
    }
}