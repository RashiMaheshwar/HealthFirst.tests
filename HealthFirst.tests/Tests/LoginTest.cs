using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using HealthFirst.tests.PomClasses;
using System.Threading;
using HealthFirst.tests.Utilities;

namespace HealthFirst.tests.Tests
{
    [TestFixture]
    class LoginTest:BaseTest
    {
       [Test]
        public void login()
        {
            Login_page login = new Login_page();
            login.LoginAsAdmin();
            Thread.Sleep(8000);
            Admin_page.Logout();
            Thread.Sleep(8000);
            Browser.driver.Navigate().Refresh();

            //login.LoginAsDoctor();
            //Thread.Sleep(8000);
            //Doctor_page.Logout();
            //Thread.Sleep(8000);

            //Browser.driver.Navigate().Refresh();
            //login.LoginAsPatient();
            //Thread.Sleep(8000);
            //Patient_page.Logout();
            //Browser.driver.Navigate().Refresh();
            //Thread.Sleep(8000);
            //login.LoginAsNurse();
            //Thread.Sleep(8000);
            //Nurse_page.Logout();
            //Thread.Sleep(8000);

            //Browser.driver.Navigate().Refresh();
            //login.LoginAsLaboratorist();
            //Thread.Sleep(8000);
            //Laboratorist_page.Logout();
            //Thread.Sleep(8000);
        }
    }
}
