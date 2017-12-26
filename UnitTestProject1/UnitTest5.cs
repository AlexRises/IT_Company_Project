using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kursovoy_Proekt;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest5
    {
        [TestMethod]
        public void TestMethod5()
        {
            Request_For_BeetRoot total_price = new Request_For_BeetRoot(new BeetRoot());
            int total = 0;

            total += total_price.Get_Execution_Time_For_Design_in_Hours();


            total += total_price.Get_Execution_Time_For_FrontEnd_in_Hours();

            total += total_price.Get_Execution_Time_For_Python_in_Hours();

            int compare = 440;

            Assert.AreEqual(total, compare);
        
          

        }
    }
}
