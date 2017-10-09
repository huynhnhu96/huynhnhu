using System;
using System.Net;
namespace bai1
{
    ///
    /// Gets IP addresses of the local machine
    ///
    class classGetIPCS
    {
        ///
        /// Gets IP addresses of the local machine
        ///
        [STAThread]
        static void Main(string[] args)
        {
            // Get host name
            String strHostName = Dns.GetHostName();
            Console.WriteLine("Host Name: " + strHostName);

            // Find host by name
            IPHostEntry iphostentry = Dns.GetHostByName(strHostName);

            // Enumerate IP addresses
            int nIP = 0;
            foreach (IPAddress ipaddress in iphostentry.AddressList)
            {
                Console.WriteLine("IP #" + ++nIP + ": " +
                                  ipaddress.ToString());
            }
        }
    }
}