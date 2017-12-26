using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kursovoy_Proekt;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest4
    {
        [TestMethod]
        public void TestMethod4()
        {
            Request_For_Attract_Group price_Python = new Request_For_Attract_Group(new Attract_Group());
            int price_py = 0;
            price_py += price_Python.Get_Execution_Time_For_Python_in_Hours();
            Request_For_BeetRoot price_Python_be = new Request_For_BeetRoot(new BeetRoot());
            int python_beetroot = 0;
            python_beetroot += price_Python_be.Get_Execution_Time_For_Python_in_Hours();


            Assert.AreNotEqual(price_py, python_beetroot);
        }
    }
}
