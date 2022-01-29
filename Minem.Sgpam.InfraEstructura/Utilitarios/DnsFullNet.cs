using System.Net;

namespace Minem.Sgpam.InfraEstructura.Utilitarios
{
    public class DnsFullNet
    {
        //public static string IP = Dns.GetHostByName(Dns.GetHostName()).AddressList[4].ToString();
        //public static string IP = Dns.GetHostEntry(Dns.GetHostName()).AddressList[4].ToString(); 

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
