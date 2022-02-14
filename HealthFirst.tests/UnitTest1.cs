using System;
using NUnit.Framework;
using HealthFirst.tests.Utilities;
using HealthFirst.tests.PomClasses;
using System.Threading;

namespace HealthFirst.tests
{
    [TestFixture]
    public class UnitTest1:BaseTest
    {
        [Test]
        public void TestMethod1()
        {
            Login_page login = new Login_page();
            login.LoginAsDoctor();
            Thread.Sleep(8000);

        }
        [Test]
        public void patient()
        {
            Login_page login = new Login_page();
            login.LoginAsPatient();
            Thread.Sleep(8000);

        }
    }
}
