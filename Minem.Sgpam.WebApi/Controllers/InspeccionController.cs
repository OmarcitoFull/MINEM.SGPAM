using Microsoft.AspNetCore.Mvc;
using Minem.Sgpam.LogicaNegocio.Interfaces;
using Minem.Sgpam.TransporteDatos.DtoEntidades;
using System.Collections.Generic;

namespace Minem.Sgpam.WebApi.Controllers
{
    public class InspeccionController : BaseController
    {

        public readonly IT_Sgpad_Eum_InspeccionLN InspeccionLN;
        public InspeccionController(IT_Sgpad_Eum_InspeccionLN vIT_Sgpad_Eum_InspeccionLN)
        {
            InspeccionLN = vIT_Sgpad_Eum_InspeccionLN;
        }

        [HttpGet("Get")]
        public Eum_InspeccionDTO Get(int vId)
        {
            return InspeccionLN.RecuperarEum_InspeccionDTOPorCodigo(vId);
        }


    }


}
