using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minem.Sgpam.TransporteDatos.DtoEntidades
{
    public class RegistrarVisitaPersonaDTO
    {
        public Visita_PersonaDTO Visita_Persona { get; set; }
        public List<CargoDTO> CboCargo { get; set; }
    }
}
