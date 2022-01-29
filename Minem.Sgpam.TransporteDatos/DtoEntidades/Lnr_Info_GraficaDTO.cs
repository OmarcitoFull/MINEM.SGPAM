using Minem.Sgpam.TransporteDatos.Base;
using System;

namespace Minem.Sgpam.TransporteDatos.DtoEntidades
{
    /// <summary>
    /// Objetivo:	Objeto de negocio para el cliente
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public partial class Lnr_Info_GraficaDTO : BaseOTD
    {
        #region Propiedades
        public DateTime? Fec_Ingreso { get; set; }  
        #endregion
    }
}