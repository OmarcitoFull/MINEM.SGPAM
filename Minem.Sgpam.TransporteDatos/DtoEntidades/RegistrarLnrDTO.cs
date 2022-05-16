using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minem.Sgpam.TransporteDatos.DtoEntidades
{
    public class RegistrarLnrDTO
    {
        public LnrDTO Lnr { get; set; }
        public List<Lnr_Info_GraficaDTO> ListaInformacionGrafica { get; set; }
        public List<Lnr_Info_DocumentoDTO> ListaInformacionDocumento { get; set; }

        public List<Tipo_LnrDTO> CboTipoLnr { get; set; }
        public List<Sub_Tipo_LnrDTO> CboSubTipoLnr { get; set; }
        public List<TemporalidadDTO> CboTemporalidad { get; set; }

    }
}
