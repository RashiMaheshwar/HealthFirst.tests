using HealthFirst.tests.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthFirst.tests.PomClasses
{
    class Accountant_page
    {
        [FindsBy(How = How.XPath, Using = "//a[contains(.,'Logout')]")]
        private IWebElement Logoutbtn;
        public Accountant_page()
        {
            PageFactory.InitElements(Browser.driver, this);
        }

        public static void Logout()
        {
            new Accountant_page().Logoutbtn.Click();
        }
    }
}
