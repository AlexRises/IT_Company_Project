using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kursovoy_Proekt;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod2()
        {
            Request_For_Attract_Group price_Python = new Request_For_Attract_Group(new Attract_Group());
            int pr_py = 0;
            pr_py += price_Python.Get_Price_For_BackEnd_Python();
            Request_For_Attract_Group price_PHP = new Request_For_Attract_Group(new Attract_Group());
            int pr_php = 0;
            pr_php += price_PHP.Get_Price_For_BackEnd_PHP();


            Assert.AreNotEqual(pr_py, pr_php);
        }
    }
}
