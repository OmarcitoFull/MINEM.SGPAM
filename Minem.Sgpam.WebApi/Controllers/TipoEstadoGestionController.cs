using Microsoft.AspNetCore.Mvc;
using Minem.Sgpam.LogicaNegocio.Interfaces;
using Minem.Sgpam.TransporteDatos.DtoEntidades;
using System.Collections.Generic;

namespace Minem.Sgpam.WebApi.Controllers
{
    public class TipoEstadoGestionController : BaseController
    {
        public readonly IT_Sgpal_Estado_GestionLN Estado_GestionLN;
        public TipoEstadoGestionController(IT_Sgpal_Estado_GestionLN vIT_Sgpal_Estado_GestionLN)
        {
            Estado_GestionLN = vIT_Sgpal_Estado_GestionLN;
        }

        [HttpGet("List")]
        public IEnumerable<Estado_GestionDTO> List()
        {
            return Estado_GestionLN.ListarEstado_GestionDTO();
        }

    }
}
