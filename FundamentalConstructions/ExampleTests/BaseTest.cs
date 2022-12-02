using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ExampleTests
{
    [TestClass]
    public class BaseTest
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
    }
}
