using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppTesting;

namespace UnitTestConsoleTesting
{
    [TestClass]
    public class UnitTest1
    {
        Person goodTestPerson = new Person("N", 92);
        Person badTestPerson;

        [TestMethod]
        public void TestNameLength()
        {
            Assert.IsTrue(goodTestPerson.Name.Length > 0);
        }

        [TestMethod]
        public void TestAge()
        {
            Assert.IsTrue(goodTestPerson.Age >= 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestTooHighAge()
        {
            badTestPerson = new Person("bad", 192);
        }

    }
}
