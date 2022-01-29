using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Minem.Sgpam.ClienteInterno.Helpers;
using Minem.Sgpam.ClienteInterno.Models;
using Minem.Sgpam.InfraEstructura;
using Minem.Sgpam.InfraEstructura.Enumerados;
using Minem.Sgpam.TransporteDatos.DtoEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Minem.Sgpam.ClienteInterno.Controllers
{
    public class ExpedienteController : Controller
    {
        public async Task<IActionResult> Index()
        {
            //List<MaestraDTO> vMasters = await Services<MaestraDTO>.Listar("Eum/Listar");
            ListarExpedienteDTO vRecord = new ListarExpedienteDTO();
            vRecord.ListaExpediente = await Services<ExpedienteDTO>.Listar("Expediente/ListarPaginadoExpedienteDTO?vvNroExp=0&vFiltro=''&vNumPag=1&vCantRegxPag=1");
            return View(vRecord);
        }



    }
}
