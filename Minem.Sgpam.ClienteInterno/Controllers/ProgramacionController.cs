﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Minem.Sgpam.ClienteInterno.Controllers
{
    public class ProgramacionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
