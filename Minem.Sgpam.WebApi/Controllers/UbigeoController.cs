using Microsoft.AspNetCore.Mvc;
using Minem.Sgpam.LogicaNegocio.Interfaces;
using Minem.Sgpam.TransporteDatos.DtoEntidades;
using System.Collections.Generic;

namespace Minem.Sgpam.WebApi.Controllers
{
    /// <summary>
    /// Objetivo:	Controlador que implementa los servicios
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	31/10/2021
    /// </summary>
    public class UbigeoController : BaseController
    {
        public readonly IT_Sgpal_DistritoLN DistritoLN;
        public readonly IT_Sgpal_ProvinciaLN ProvinciaLN;
        public readonly IT_Sgpal_RegionLN RegionLN;
        public readonly IT_Genl_Ubigeo_IneiLN Ubigeo_IneiLN;
        public UbigeoController(
            IT_Sgpal_DistritoLN vIT_Sgpal_DistritoLN,
            IT_Sgpal_ProvinciaLN vIT_Sgpal_ProvinciaLN,
            IT_Sgpal_RegionLN vIT_Sgpal_RegionLN,
            IT_Genl_Ubigeo_IneiLN vIT_Genl_Ubigeo_IneiLN
            )
        {
            DistritoLN = vIT_Sgpal_DistritoLN;
            ProvinciaLN = vIT_Sgpal_ProvinciaLN;
            RegionLN = vIT_Sgpal_RegionLN;
            Ubigeo_IneiLN = vIT_Genl_Ubigeo_IneiLN;
        }

        [HttpGet("List_Distrito")]
        public IEnumerable<DistritoDTO> List_Distrito()
        {
            return DistritoLN.ListarDistritoDTO();
        }

        [HttpGet("List_Provincia")]
        public IEnumerable<ProvinciaDTO> List_Provincia()
        {
            return ProvinciaLN.ListarProvinciaDTO();
        }

        [HttpGet("List_Region")]
        public IEnumerable<RegionDTO> List_Region()
        {
            return RegionLN.ListarRegionDTO();
        }

        [HttpGet("List_Ubigeo_Inei")]
        public IEnumerable<Ubigeo_IneiDTO> List_Ubigeo_Inei()
        {
            return Ubigeo_IneiLN.ListarUbigeoDTO();
        }
    }
}
