using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Kursovoy_Proekt;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Request_For_Attract_Group number = new Request_For_Attract_Group(new Attract_Group());

            int a = 0;
            a += number.Technologies_Company_Develop();

            int amount_of_technologies = 5;

            Assert.AreEqual(a, amount_of_technologies);
        }
    }
}
