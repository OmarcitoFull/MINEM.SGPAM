using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minem.Sgpam.TransporteDatos.DtoEntidades
{
    public class ListarVisitaDTO
    {
        public VisitaDTO Visita { get; set; }
        public List<VisitaDTO> ListaVisita { get; set; }

    }
}
