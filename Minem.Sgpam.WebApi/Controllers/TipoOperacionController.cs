using Microsoft.AspNetCore.Mvc;
using Minem.Sgpam.LogicaNegocio.Interfaces;
using Minem.Sgpam.TransporteDatos.DtoEntidades;
using System.Collections.Generic;

namespace Minem.Sgpam.WebApi.Controllers
{
    /// <summary>
    /// Objetivo:	Controlador que implementa los servicios
    /// Creado Por:	Mateo Salvador Paucar
    /// Fecha Creación:	31/03/2022
    /// </summary>
    public class TipoOperacionController : BaseController
    {
        public readonly IT_Sgpal_Tipo_OperacionLN Tipo_OperacionLN;
        public TipoOperacionController(IT_Sgpal_Tipo_OperacionLN vIT_Sgpal_Tipo_OperacionLN)
        {
            Tipo_OperacionLN = vIT_Sgpal_Tipo_OperacionLN;
        }

        [HttpGet("List")]
        public IEnumerable<Tipo_OperacionDTO> List()
        {
            return Tipo_OperacionLN.ListarTipo_OperacionDTO();
        }

        [HttpGet("Get")]
        public Tipo_OperacionDTO Get(int vId)
        {
            return Tipo_OperacionLN.RecuperarTipo_OperacionDTOPorCodigo(vId);
        }

        [HttpPost("Save")]
        public Tipo_OperacionDTO Save([FromBody] Tipo_OperacionDTO vTipo_OperacionDTO)
        {
            return Tipo_OperacionLN.GrabarTipo_OperacionDTO(vTipo_OperacionDTO);
        }

        [HttpPost("Remove")]
        public int Remove([FromBody] Tipo_OperacionDTO vTipo_OperacionDTO)
        {
            return Tipo_OperacionLN.AnularTipo_OperacionDTOPorCodigo(vTipo_OperacionDTO);
        }

        [HttpGet("ListSinIdEum")]
        public IEnumerable<Tipo_OperacionDTO> List(int vIdEum)
        {
            return Tipo_OperacionLN.ListarSinIdEumTipo_OperacionDTO(vIdEum);
        }


    }
}
