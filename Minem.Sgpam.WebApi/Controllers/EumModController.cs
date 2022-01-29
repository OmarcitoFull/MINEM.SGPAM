using Microsoft.AspNetCore.Mvc;
using Minem.Sgpam.LogicaNegocio.Interfaces;
using Minem.Sgpam.TransporteDatos.DtoEntidades;
using System.Collections.Generic;

namespace Minem.Sgpam.WebApi.Controllers
{
    public class EumModController : BaseController
    {
        public readonly IT_Sgpah_Eum_ModLN Eum_ModLN;
        public EumModController(IT_Sgpah_Eum_ModLN vIT_Sgpah_Eum_ModLN)
        {
            Eum_ModLN = vIT_Sgpah_Eum_ModLN;
        }

        [HttpGet("List")]
        public IEnumerable<Eum_ModDTO> List()
        {
            return Eum_ModLN.ListarEum_ModDTO();
        }

        [HttpGet("Get")]
        public Eum_ModDTO Get(int vId_Eum_Mod)
        {
            return Eum_ModLN.RecuperarEum_ModDTOPorCodigo(vId_Eum_Mod);
        }

        //        Eum_ModDTO InsertarEum_ModDTO(Eum_ModDTO vEum_ModDTO);
        //        int AnularEum_ModDTOPorCodigo(Eum_ModDTO vEum_ModDTO);

        [HttpGet("ListPorIdEum")]
        public IEnumerable<Eum_ModDTO> ListPorIdEum(int vId_Eum)
        {
            return Eum_ModLN.ListarPorIdEumEum_ModDTO(vId_Eum);
        }
        

    }
}
