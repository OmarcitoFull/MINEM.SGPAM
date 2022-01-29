using System.Net;

namespace Minem.Sgpam.InfraEstructura.Utilitarios
{
    /// <summary>
    /// Objetivo:	Clase que permite leer el ip
    /// Creado Por:	(ORM) Omar Rodriguez M.
    /// Fecha Creación:	10/12/2021
    /// </summary>
    public class DnsFullNet
    {
        public static string GetIp()
        {
            string vIp = "";
            foreach (var vItem in Dns.GetHostEntry(Dns.GetHostName()).AddressList)
            {
                if (vItem.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork && string.IsNullOrEmpty(vIp))
                {
                    vIp = vItem.ToString();
                    break;
                }
            }
            return vIp;
        }
    }
}
