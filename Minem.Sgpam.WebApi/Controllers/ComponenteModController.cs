using Microsoft.AspNetCore.Mvc;
using Minem.Sgpam.LogicaNegocio.Interfaces;
using Minem.Sgpam.TransporteDatos.DtoEntidades;
using System.Collections.Generic;

namespace Minem.Sgpam.WebApi.Controllers
{
    public class ComponenteModController : BaseController
    {
        public readonly IT_Sgpah_Componente_ModLN Componente_ModLN;
        public ComponenteModController(IT_Sgpah_Componente_ModLN vIT_Sgpah_Componente_ModLN)
        {
            Componente_ModLN = vIT_Sgpah_Componente_ModLN;
        }

        [HttpGet("List")]
        public IEnumerable<Componente_ModDTO> List(int vIdComponente)
        {
            return Componente_ModLN.ListarComponente_ModDTO(vIdComponente);
        }
    }
}
