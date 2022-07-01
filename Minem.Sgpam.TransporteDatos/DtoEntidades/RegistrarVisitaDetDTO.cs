using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minem.Sgpam.TransporteDatos.DtoEntidades
{
    public class RegistrarVisitaDetDTO
    {
        public Visita_DetDTO Visita_Det { get; set; }
        public List<Tipo_ClimaDTO> CboTipoClima { get; set; }
    }
}
