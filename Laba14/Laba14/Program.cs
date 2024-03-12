using System;
using System.Text.RegularExpressions;

namespace Laba14
{
    class Program
    {
        static void Main(string[] args)
        {
            string ip_address = Console.ReadLine();
            Regex ip4 = new Regex(@"^(((([01]?[0-9][0-9]?)|(2[0-4][0-9])|(25[0-5]))\.){3}(([01]?[0-9][0-9]?)|(2[0-4][0-9])|(25[0-5])))$");
            Regex ip6 = new Regex(@"^(([0-9A-Fa-f]{1,4}:){7}[0-9A-Fa-f]{1,4}|([0-9A-Fa-f]{1,4}:){1,7}:|([0-9A-Fa-f]{1,4}:){1,6}:[0-9A-Fa-f]{1,4}|([0-9A-Fa-f]{1,4}:){1,5}(:[0-9A-Fa-f]{1,4}){1,2}|([0-9A-Fa-f]{1,4}:){1,4}(:[0-9A-Fa-f]{1,4}){1,3}|([0-9A-Fa-f]{1,4}:){1,3}(:[0-9A-Fa-f]{1,4}){1,4}|([0-9A-Fa-f]{1,4}:){1,2}(:[0-9A-Fa-f]{1,4}){1,5}|[0-9A-Fa-f]{1,4}:((:[0-9A-Fa-f]{1,4}){1,6}|:)|:((:[0-9A-Fa-f]{1,4}){1,7})|(::))$");
            
           

            Match matchIP4 = ip4.Match(ip_address);
            Match matchIP6 = ip6.Match(ip_address);

            if (matchIP4.Success)
            {
                Console.WriteLine("IP4: " + matchIP4.Value);
            }
            else if (matchIP6.Success)
            {
                Console.WriteLine("IP6: " + matchIP6.Value);
            }
            else
            {
                Console.WriteLine("IP-адресс не найден");
            }

        }
    }
}
