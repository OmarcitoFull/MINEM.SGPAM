using Minem.Sgpam.TransporteDatos.Base;
using System;

namespace Minem.Sgpam.TransporteDatos.DtoEntidades
{
    /// <summary>
    /// Objetivo:	Objeto de negocio para el cliente
    /// Creado Por:	Omar Rodriguez Muñoz    
    /// Fecha Creación:	28/10/2021
    /// </summary>
    public partial class Presencia_LiquidoDTO : BaseOTD
    {
        #region Propiedades
        public int Id_Presencia_Liquido { get; set; }  
        #endregion
    }
}