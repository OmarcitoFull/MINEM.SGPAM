using Minem.Sgpam.TransporteDatos.DtoEntidades;
using System.Collections.Generic;
using System;

namespace Minem.Sgpam.LogicaNegocio.Interfaces
{
    /// <summary>
    /// Objetivo:	Interfaz que matricula las operaciones de las entidades para la lógica de negocio
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	29/10/2021
    /// </summary>
    public interface IT_Sgpad_Comp_Dm_TitularLN
    {
        IEnumerable<Comp_Dm_TitularDTO> ListarComp_Dm_TitularDTO();
        Comp_Dm_TitularDTO RecuperarComp_Dm_TitularDTOPorCodigo(int vId_Comp_Dm_Titular);
        Comp_Dm_TitularDTO InsertarComp_Dm_TitularDTO(Comp_Dm_TitularDTO vComp_Dm_TitularDTO);
        Comp_Dm_TitularDTO ActualizarComp_Dm_TitularDTO(Comp_Dm_TitularDTO vComp_Dm_TitularDTO);
        int AnularComp_Dm_TitularDTOPorCodigo(Comp_Dm_TitularDTO vComp_Dm_TitularDTO);
        IEnumerable<Comp_Dm_TitularDTO> ListarPaginadoComp_Dm_TitularDTO(string vFiltro, int vNumPag, int vCantRegxPag);
    }
}