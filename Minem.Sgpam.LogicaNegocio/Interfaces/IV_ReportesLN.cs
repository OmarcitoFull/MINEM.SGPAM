using Minem.Sgpam.TransporteDatos.DtoEntidades;

namespace Minem.Sgpam.LogicaNegocio.Interfaces
{
    /// <summary>
    /// Objetivo:	Interfaz que matricula los reportes e informes
    /// Creado Por:	Omar Rodriguez Muñoz
    /// Fecha Creación:	02/06/2022
    /// </summary>
    public interface IV_ReportesLN
    {
        ReportePamDTO Obtener_ReportePam(int vId_Eum);
    }
}
