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
            

            Request_For_Attract_Group Client2 = null;
            Request_For_BeetRoot Client1 = null;
            BeetRoot BeetRoot_Company = new BeetRoot();
            Attract_Group Attract_Group_Company = new Attract_Group();
            Random rnd = new Random();
            int randomNumber = 0;
            String chosenCompany = "";
            int bill_Attract_Group = 0;
            int total_time_Attract_Group = 0;
            int bill_BeetRoot = 0;
            int total_time_BeetRoot = 0;
            String switchTechnology = "";
            String agreement = "";

            chooseCompany:

            do
            {

                Console.WriteLine("Choose company you would like to visit");
                Console.WriteLine("1) Beetroot\t\t2) Attract Group");
                Console.WriteLine("0) Remove the project ");
                chosenCompany = Console.ReadLine();
            }
            while (chosenCompany != "0" && chosenCompany != "1" && chosenCompany != "2");

            ProvideRequirement:

            if (chosenCompany == "2")            {

                Console.WriteLine("Welcome to AttractGroup! Please, provie your requirements");
                Client2 = new Request_For_Attract_Group(new Attract_Group());
                Client2.Request_For_Development_Design();
                Thread.Sleep(3000);
                Client2.Request_For_Development_FrontEnd();
                Thread.Sleep(3000);
                Client2.Request_For_Development_BackEnd_on_PHP();
                Thread.Sleep(3000);
                /*randomNumber = rnd.Next(1, 6);
                if (randomNumber == 1)
                {
                    Console.WriteLine("We got you, thanks for the requirements. Here the price and execution time for the project");
                    goto withoutSwitch;
                }
                else
                {*/
                    Console.WriteLine("Sorry, our PHP developers are busy right now. We can provide Python developers.");
                    Thread.Sleep(1000);
                    Console.WriteLine("They will make the project faster, but the price will be higher.");
                    Thread.Sleep(1000);
                    do
                    {
                        Console.WriteLine("Do you agree with it?(y/n)");
                        switchTechnology = Console.ReadLine();
                    }
                    while (switchTechnology != "y" && switchTechnology != "n");
                    if (switchTechnology == "y")
                    {
                        goto switchTechnology;
                    }
                    else
                    {
                        goto chooseCompany;
                    }
                //}
                switchTechnology:
                Client2.Switch_The_Technology();
                Thread.Sleep(1000);
                Console.WriteLine("Execution time for design - {0}", Client2.Get_Execution_Time_For_Design_in_Hours());
                total_time_Attract_Group += Client2.Get_Execution_Time_For_Design_in_Hours();
                Thread.Sleep(1500);
                Console.WriteLine("Price time for design - {0}", Client2.Get_Price_For_Design());
                bill_Attract_Group += Client2.Get_Price_For_Design();
                Thread.Sleep(1500);
                Console.WriteLine("Execution time for FrontEnd - {0}", Client2.Get_Execution_Time_For_FrontEnd_in_Hours());
                total_time_Attract_Group += Client2.Get_Execution_Time_For_FrontEnd_in_Hours();
                Thread.Sleep(1500);
                Console.WriteLine("Price time for FrontEnd - {0}", Client2.Get_Price_For_FrontEnd());
                bill_Attract_Group += Client2.Get_Price_For_FrontEnd();
                Thread.Sleep(1500);
                Console.WriteLine("Execution time for BackEnd on Python- {0}", Client2.Get_Execution_Time_For_Python_in_Hours());
                total_time_Attract_Group += Client2.Get_Execution_Time_For_Python_in_Hours();
                Thread.Sleep(1500);
                Console.WriteLine("Price time for FrontEnd - {0}", Client2.Get_Price_For_BackEnd_Python());
                bill_Attract_Group += Client2.Get_Price_For_BackEnd_Python();

                Console.WriteLine("Total execution time - {0}", total_time_Attract_Group);
                Thread.Sleep(1500);
                Console.WriteLine("Total price time - {0}", bill_Attract_Group);
                Thread.Sleep(1500);
                do
                {
                    Console.WriteLine("Do you agree with it?(y/n)");
                    agreement = Console.ReadLine();
                }
                while (agreement != "y" && agreement != "n");
                if (agreement == "y")
                {
                    goto development;
                }
                else
                {
                    goto chooseCompany;
                }

                development:

                Console.WriteLine("Let's Start");
                Thread.Sleep(1500);
                Attract_Group_Company.Start_Design_Development();
                Thread.Sleep(Client2.Get_Execution_Time_For_Design_in_Hours());
                Attract_Group_Company.Finish_Design_Development();
                Thread.Sleep(4000);
                Attract_Group_Company.Start_FrontEnd_Development();
                Thread.Sleep(Client2.Get_Execution_Time_For_FrontEnd_in_Hours());
                Attract_Group_Company.Finish_FrontEnd_Development();
                Thread.Sleep(4000);
                Attract_Group_Company.Start_BackEnd_Development();
                Thread.Sleep(Client2.Get_Execution_Time_For_Python_in_Hours());
                Attract_Group_Company.Finish_BackEnd_Development();

                Console.WriteLine("We have finished the project! Success!!!");
                Console.WriteLine("We will be waiting for the next project");

                goto chooseCompany;

                withoutSwitch:
                Console.WriteLine("Execution time for design - {0}", Client2.Get_Execution_Time_For_Design_in_Hours());
                total_time_Attract_Group += Client2.Get_Execution_Time_For_Design_in_Hours();
                Thread.Sleep(1500);
                Console.WriteLine("Price time for design - {0}", Client2.Get_Price_For_Design());
                bill_Attract_Group += Client2.Get_Price_For_Design();
                Console.WriteLine("Execution time for FrontEnd - {0}", Client2.Get_Execution_Time_For_FrontEnd_in_Hours());
                total_time_Attract_Group += Client2.Get_Execution_Time_For_FrontEnd_in_Hours();
                Thread.Sleep(1500);
                Console.WriteLine("Price time for FrontEnd - {0}", Client2.Get_Price_For_FrontEnd());
                bill_Attract_Group += Client2.Get_Price_For_FrontEnd();
                Thread.Sleep(1500);
                Console.WriteLine("Execution time for BackEnd on Python- {0}", Client2.Get_Execution_Time_For_PHP_in_Hours());
                total_time_Attract_Group += Client2.Get_Execution_Time_For_PHP_in_Hours();
                Thread.Sleep(1500);
                Console.WriteLine("Price time for FrontEnd - {0}", Client2.Get_Price_For_BackEnd_PHP());
                bill_Attract_Group += Client2.Get_Price_For_BackEnd_PHP();

                Console.WriteLine("Total execution time - {0}", total_time_Attract_Group);
                Thread.Sleep(1500);
                Console.WriteLine("Total price time - {0}", bill_Attract_Group);
                Thread.Sleep(4500);
                do
                {
                    Console.WriteLine("Do you agree with it?(y/n)");
                    agreement = Console.ReadLine();
                }
                while (agreement != "y" && agreement != "n");
                if (agreement == "y")
                {
                    goto development_PHP;
                }
                else
                {
                    goto chooseCompany;
                }

                development_PHP:

                Console.WriteLine("Let's Start");
                Attract_Group_Company.Start_Design_Development();
                Thread.Sleep(Client2.Get_Execution_Time_For_Design_in_Hours());
                Attract_Group_Company.Finish_Design_Development();
                Thread.Sleep(4000);
                Attract_Group_Company.Start_FrontEnd_Development();
                Thread.Sleep(Client2.Get_Execution_Time_For_FrontEnd_in_Hours());
                Attract_Group_Company.Finish_FrontEnd_Development();
                Thread.Sleep(4000);
                Attract_Group_Company.Start_BackEnd_Development();
                Thread.Sleep(Client2.Get_Execution_Time_For_PHP_in_Hours());
                Attract_Group_Company.Finish_BackEnd_Development();

                Console.WriteLine("We have finished the project! Success!!!");
                Thread.Sleep(4000);
                Console.WriteLine("We will be waiting for the next project");

                goto chooseCompany;

            }
            else if (chosenCompany == "1")
            {
                Console.WriteLine("Welcome to Bee! Please, provie your requirements");
                Client1 = new Request_For_BeetRoot(new BeetRoot());
                Client1.Request_For_Development_Design();
                Thread.Sleep(3000);
                Client1.Request_For_Development_Mobile();
                Thread.Sleep(3000);
                Client1.Request_For_Development_FrontEnd();
                Thread.Sleep(3000);

                Console.WriteLine("We got you, thanks for the requirements. Here the price and execution time for the project");
                goto beetRootPrice;

                beetRootPrice:
                Thread.Sleep(1000);
                Console.WriteLine("Execution time for design - {0}", Client1.Get_Execution_Time_For_Design_in_Hours());
                total_time_BeetRoot += Client1.Get_Execution_Time_For_Design_in_Hours();
                Thread.Sleep(1500);
                Console.WriteLine("Price time for design - {0}", Client1.Get_Price_For_Design());
                bill_BeetRoot += Client1.Get_Price_For_Design();
                Thread.Sleep(1500);
                Console.WriteLine("Execution time for Mobile - {0}", Client1.Get_Execution_Time_For_Android_in_Hours());
                total_time_BeetRoot += Client1.Get_Price_For_App_Development_on_Android();
                Thread.Sleep(1500);
                Console.WriteLine("Price time for Mobile- {0}", Client1.Get_Price_For_Design());
                bill_BeetRoot += Client1.Get_Price_For_Design();
                Thread.Sleep(1500);
                Console.WriteLine("Execution time for FrontEnd - {0}", Client1.Get_Execution_Time_For_FrontEnd_in_Hours());
                total_time_BeetRoot += Client1.Get_Execution_Time_For_FrontEnd_in_Hours();
                Thread.Sleep(1500);
                Console.WriteLine("Price time for FrontEnd - {0}", Client1.Get_Price_For_FrontEnd());
                bill_BeetRoot += Client1.Get_Price_For_FrontEnd();
                Thread.Sleep(1500);

                Console.WriteLine("Total execution time - {0}", total_time_BeetRoot);
                Thread.Sleep(1500);
                Console.WriteLine("Total price time - {0}", bill_BeetRoot);
                Thread.Sleep(1500);

                do
                {
                    Console.WriteLine("Do you agree with it?(y/n)");
                    agreement = Console.ReadLine();
                }
                while (agreement != "y" && agreement != "n");
                if (agreement == "y")
                {
                    goto development_BeetRoot;
                }
                else
                {
                    goto chooseCompany;
                }

                development_BeetRoot:
                Console.WriteLine("Let's Start");
                Thread.Sleep(2000);
                BeetRoot_Company.Start_Design_Development();
                Thread.Sleep(Client1.Get_Execution_Time_For_Design_in_Hours());
                BeetRoot_Company.Finish_Design_Development();
                Thread.Sleep(2000);
                BeetRoot_Company.Start_Mobile_Development();
                Thread.Sleep(Client1.Get_Execution_Time_For_Android_in_Hours());
                BeetRoot_Company.Finish_Mobile_Development();
                Thread.Sleep(4000);
                BeetRoot_Company.Start_FrontEnd_Development();
                Thread.Sleep(Client1.Get_Execution_Time_For_FrontEnd_in_Hours());
                BeetRoot_Company.Finish_FrontEnd_Development();
                Thread.Sleep(4000);

                Console.WriteLine("We have finished the project! Success!!!");
                Thread.Sleep(4000);
                Console.WriteLine("We will be waiting for the next project");

                goto chooseCompany;







            }
            else
            {
                Console.WriteLine("Don't lie, you have an idea");
                goto chooseCompany;
            }
        }
    }
}
