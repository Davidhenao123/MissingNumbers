using Microsoft.VisualStudio.TestTools.UnitTesting;
using MissingNumbers.Business;
using System;

namespace MissingNumbers.UnitTest
{
    [TestClass]
    public class TestCase0
    {
        private IController business = new Controller();

        /// <summary>
        /// Caso de prueba numero uno.
        /// </summary>
        [TestMethod]
        public void TestCase0Method()
        {
            String target = "204 205 206";
            String input = "10";
            input += "\n203 204 205 206 207 208 203 204 205 206";
            input += "\n13";
            input += "\n203 204 204 205 206 207 205 208 203 206 205 206 204";
            String response = business.SearchMissingNumbersChain(input);
            Assert.AreEqual(response, target);
        }
    }
}
