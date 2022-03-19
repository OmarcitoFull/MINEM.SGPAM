using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minem.Sgpam.TransporteDatos.DtoEntidades
{
    public class RegistrarEumInspeccionDTO
    {
        public Eum_InspeccionDTO Eum_Inspeccion { get; set; }
        public List<Tipo_ClimaDTO> CboTipoClima { get; set; }
        public List<InspectorDTO> CboInspector { get; set; }
    }
}
