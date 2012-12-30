using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRDServiceTester
{
    class Program
    {
        static void Main(string[] args)
        {
            TRDServiceTester.TRDWCFServices.CanvasserPortalServicesClient client = new TRDWCFServices.CanvasserPortalServicesClient();
            Console.WriteLine("Service Tester Intialized!");
            Console.Write("Please enter a value and press Enter: ");
            string value = Console.ReadLine();
            string response = client.testDBConnections(value);
            Console.WriteLine("The response was: " + response);
            Console.ReadLine();

        }
    }
}
