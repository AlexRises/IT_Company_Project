using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace Kursovoy_Proekt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's Start");

            Request_For_BeetRoot Client1 = null;

            Client1 = new Request_For_BeetRoot(new BeetRoot());
            Client1.Request_For_Development_Design();
            Thread.Sleep(5000);


        }
    }
}
