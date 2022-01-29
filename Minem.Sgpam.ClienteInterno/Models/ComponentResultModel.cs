using Minem.Sgpam.InfraEstructura;
using Minem.Sgpam.InfraEstructura.Enumerados;

namespace Minem.Sgpam.ClienteInterno.Models
{
    /// <summary>
    /// Objetivo:	Modelo que representa un resultado por json
    /// Creado Por:	(ORM) - Omar Rodriguez M.
    /// Fecha Creación:	01/11/2021
    /// </summary>
    public class ComponentResultModel
    {
        public ComponentResultModel()
        {
            Operation = Constantes.Error;
            Type = TipoErr.SERVER;
            Key = 0;
        }

        public ComponentResultModel(int vIdErr)
        {
            Operation = vIdErr > 0 ? Constantes.Ok : Constantes.Error;
            Key = 0;
        }

        public string Operation { get; set; }
        public int Key { get; set; }
        public TipoErr Type { get; set; }
    }
}
