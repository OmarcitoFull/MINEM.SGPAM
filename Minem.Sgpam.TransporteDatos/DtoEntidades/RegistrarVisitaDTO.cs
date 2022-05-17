using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minem.Sgpam.TransporteDatos.DtoEntidades
{
    public class RegistrarVisitaDTO
    {
        public VisitaDTO Visita { get; set; }

        public List<MaestraDTO> EumInforme { get; set; }
        public List<LnrDTO> ListaLnr { get; set; }

    }
}
