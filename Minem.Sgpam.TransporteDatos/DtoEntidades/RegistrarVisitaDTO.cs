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

        public List<Visita_DetDTO> listaVisitaDet { get; set; }
        public List<Visita_Det_Com_LnrDTO> listaVisitaDetComLnr { get; set; }

        //public List<ExpedienteDTO> listaExpediente { get; set; }
        //public List<MaestraDTO> ListaEum { get; set; }
        //public List<LnrDTO> ListaLnr { get; set; }
        //public List<ComponenteDTO> ListaPam { get; set; }
        public List<Visita_PersonaDTO> ListaVisitaPersona { get; set; }
        public List<Ubigeo_IneiDTO> CboUbigeo { get; set; }

    }
}
