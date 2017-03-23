using System;
using LibraryB;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProjectC
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            MatlabWrapper.Run();
        }
    }
}
