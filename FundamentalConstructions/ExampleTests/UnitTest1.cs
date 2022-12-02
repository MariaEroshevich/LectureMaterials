using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ExampleTests
{
    [TestClass]
    public class UnitTest1
    {
        [ClassInitialize()]
        public static void ClassInit(TestContext test)
        {
            Console.WriteLine("Class init");
        }


        [ClassCleanup()]
        public static void ClassCleanup()
        {
            Console.WriteLine("Class clean up");
        }

        [TestInitialize()]
        public void Init()
        {
            Console.WriteLine("Init test");
        }

        [TestMethod]
        public void TestMethod1()
        {
            string hello = "Hello test";
            Console.WriteLine(hello);
            Assert.AreEqual(hello, "Hello test");
        }

        [TestCleanup()]
        public void Cleanup()
        {
            Console.WriteLine("Clean up");
        }

    }
}
