using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minem.Sgpam.TransporteDatos.DtoEntidades
{
    public class RegistrarEumOperacionDTO
    {
        public Eum_OperacionDTO Eum_Operacion { get; set; }
        public List<Tipo_OperacionDTO> CboTipoOperacion { get; set; }
    }
}
