using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minem.Sgpam.TransporteDatos.DtoEntidades
{
    public class ListarEumOperacionDTO
    {
        public Eum_OperacionDTO EumOperacion { get; set; }
        public List<Eum_OperacionDTO> ListaEumOperacion { get; set; }

    }
}
