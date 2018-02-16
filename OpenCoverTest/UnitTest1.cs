using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenCover;

namespace OpenCoverTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Calculator c = new Calculator();
            Assert.AreEqual<int>(7, c.Sum(2, 4));
        }
    }
}
