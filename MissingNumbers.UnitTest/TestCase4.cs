using Microsoft.VisualStudio.TestTools.UnitTesting;
using MissingNumbers.Business;
using System;

namespace MissingNumbers.UnitTest
{
    [TestClass]
    public class TestCase4
    {
        private IController business = new Controller();
        /// <summary>
        /// Caso de prueba numero cuatro.
        /// </summary>
        [TestMethod]
        public void TestCase4Method()
        {
            String target = "3 7 8 10 12";
            String input = "10";
            input += "\n11 4 11 7 13 4 12 11 10 14";
            input += "\n15";
            input += "\n11 4 11 7 3 7 10 13 4 8 12 11 10 14 12";
            String response = business.SearchMissingNumbersChain(input);
            Assert.AreEqual(response, target);
        }
    }
}
