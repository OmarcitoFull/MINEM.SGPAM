﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minem.Sgpam.TransporteDatos.DtoEntidades
{
    public class RegistrarExpedienteDTO
    {
        public ExpedienteDTO Expediente { get; set; }
        public List<LnrDTO> ListaLNR { get; set; }
    }
}
