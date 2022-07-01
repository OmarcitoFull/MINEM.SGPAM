using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minem.Sgpam.TransporteDatos.DtoEntidades
{
    public class RegistrarEvaluacionLnrDTO
    {
        public LnrDTO Lnr { get; set; }
        public List<Visita_DetDTO> listaConcesiones { get; set; }
        public List<Visita_DetDTO> listaEvaluacionInventario { get; set; }
        public List<Visita_DetDTO> listaEvaluacionPCPAM { get; set; }
        public List<ReinfoDerechosMinerosDTO> ListaReinfoDerechosMineros { get; set; }


    }
}
