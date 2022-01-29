using Minem.Sgpam.TransporteDatos.Base;
using System;

namespace Minem.Sgpam.TransporteDatos.DtoEntidades
{
    /// <summary>
    /// Objetivo:	Objeto de negocio para el cliente
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public partial class Comp_ResultadoResumenDTO : BaseOTD
    {
        #region Propiedades
        public int Id_Componente { get; set; }
        public string Act_Inventario { get; set; }
        public string Act_IGEPAM { get; set; }
        public string Excluir { get; set; }
        public string Incluir { get; set; }
        public DateTime? Fecha { get; set; }
        #endregion
    }
}