using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kursovoy_Proekt;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void TestMethod3()
        {
            Request_For_Attract_Group price_Python = new Request_For_Attract_Group(new Attract_Group());
            int time_py = 0;
            time_py += price_Python.Get_Execution_Time_For_Python_in_Hours();
            Request_For_Attract_Group price_PHP = new Request_For_Attract_Group(new Attract_Group());
            int time_php = 0;
            time_php += price_PHP.Get_Execution_Time_For_PHP_in_Hours();


            Assert.AreEqual(time_py, time_php);
        }
    }
}
