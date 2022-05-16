using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minem.Sgpam.TransporteDatos.DtoEntidades
{
    public class ListarEumDTO
    {
        public MaestraDTO Eum { get; set; }
        public List<MaestraDTO> ListaEum { get; set; }

        public List<RegionDTO> ListaRegion { get; set; }
        public List<ProvinciaDTO> ListaProvincia { get; set; }
        public List<DistritoDTO> ListaDistrito { get; set; }
        public List<Ubigeo_IneiDTO> ListaUbigeo { get; set; }
        public Ubigeo_IneiDTO Ubigeo { get; set; }

    }
}
