using System;
using HelloAnaPaula;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace helloAnaPaulaTest
{
    [TestClass]
    public class UnitTest1
    {


        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("Hello World this is Ana Paula here",Program.createMessage());
        }
    }
}