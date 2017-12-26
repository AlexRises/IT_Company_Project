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
            BeetRoot Company1 = new BeetRoot();
           

            Client1 = new Request_For_BeetRoot(new BeetRoot());
            Client1.Request_For_Development_Design();
            Company1.Start_Design_Development();
            Company1.Start_FrontEnd_Development();

            Console.WriteLine("Here is the price for the design - {0}", Client1.Get_Price_For_Design());
            Console.WriteLine("Here is the price for the FrontEnd - {0}", Client1.Get_Price_For_FrontEnd());
            int bill = Client1.Get_Price_For_Design();
            bill += Client1.Get_Price_For_FrontEnd();
            Console.WriteLine(" Total bill is - {0}", bill);
            


            Thread.Sleep(5000);


        }
    }
}
