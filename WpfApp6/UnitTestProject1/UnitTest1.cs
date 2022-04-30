using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int x = 1;
            int y = 2;  
            int z = 3;
            WpfApp6 c = new WpfApp6();
            int actual = c.Sum(x, y);
            Assert.AreEqual(x, actual);
        }
    }
}
