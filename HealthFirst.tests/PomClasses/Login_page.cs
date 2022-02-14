using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using HealthFirst.tests.Utilities;

namespace HealthFirst.tests.PomClasses
{
    class Login_page
    {
        [FindsBy(How = How.Name, Using = "email")]
        private IWebElement Usertbx;

        [FindsBy(How = How.Id, Using = "password")]
        private IWebElement Passwordtbx;

        [FindsBy(How = How.XPath, Using = "//button[@type='submit']")]
        private IWebElement Loginbtn;
        
         [FindsBy(How = How.Id, Using = "admin")]
        private IWebElement adminbtn;

        [FindsBy(How = How.Id, Using = "doctor")]
        private IWebElement doctorbtn;

        [FindsBy(How = How.Id, Using = "patient")]
        private IWebElement patientbtn;

        [FindsBy(How = How.Id, Using = "nurse")]
        private IWebElement nursebtn;

        [FindsBy(How = How.Id, Using = "receptionist")]
        private IWebElement receptionistbtn;

        [FindsBy(How = How.Id, Using = "laboratorist")]
        private IWebElement laboratoristbtn;

        [FindsBy(How = How.Id, Using = "pharmacist")]
        private IWebElement pharmacistbtn;

        [FindsBy(How = How.Id, Using = "accountant")]
        private IWebElement accountantbtn;

        public Login_page()
        {
            PageFactory.InitElements(Browser.driver, this);
        }

        public void LoginAsAdmin()
        {
            adminbtn.Click();
            Loginbtn.Click();

        }

        public void LoginAsDoctor()
        {
            doctorbtn.Click();
            Loginbtn.Click();

        }

        public void LoginAsPatient()
        {
            patientbtn.Click();
            Loginbtn.Click();

        }

        public void LoginAsNurse()
        {
            nursebtn.Click();
            Loginbtn.Click();

        }

        public void LoginAsReceptionist()
        {
            receptionistbtn.Click();
            Loginbtn.Click();

        }

        public void LoginAsLaboratorist()
        {
            laboratoristbtn.Click();
            Loginbtn.Click();

        }

        public void LoginAsPharmacist()
        {
            pharmacistbtn.Click();
            Loginbtn.Click();

        }

        public void LoginAsAccountant()
        {
            accountantbtn.Click();
            Loginbtn.Click();

        }

    }
}
