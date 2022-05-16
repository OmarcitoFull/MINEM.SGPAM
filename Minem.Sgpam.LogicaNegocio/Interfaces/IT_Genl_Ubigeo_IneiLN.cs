using Minem.Sgpam.TransporteDatos.DtoEntidades;
using System.Collections.Generic;
using System;

namespace Minem.Sgpam.LogicaNegocio.Interfaces
{
    /// <summary>
    /// Objetivo:	Clase que genera las operaciones para la tabla T_GENL_UBIGEO_INEI
    /// Creado Por:	Mateo Salvador Paucar
    /// Fecha Creación:	31/03/2022
    /// </summary>
    public interface IT_Genl_Ubigeo_IneiLN
    {
        IEnumerable<Ubigeo_IneiDTO> ListarUbigeoDTO();
    }
}
