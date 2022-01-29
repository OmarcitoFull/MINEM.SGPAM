using Microsoft.AspNetCore.Mvc;
using Minem.Sgpam.LogicaNegocio.Interfaces;
using Minem.Sgpam.TransporteDatos.DtoEntidades;
using System.Collections.Generic;

namespace Minem.Sgpam.WebApi.Controllers
{
    public class TamanioParticulaController : BaseController
    {
        public readonly IT_Sgpal_Tamano_ParticulaLN Tamano_ParticulaLN;
        public TamanioParticulaController(IT_Sgpal_Tamano_ParticulaLN vIT_Sgpal_Tamano_ParticulaLN)
        {
            Tamano_ParticulaLN = vIT_Sgpal_Tamano_ParticulaLN;
        }

        [HttpGet("List")]
        public IEnumerable<Tamano_ParticulaDTO> List()
        {
            return Tamano_ParticulaLN.ListarTamano_ParticulaDTO();
        }
    }
}
