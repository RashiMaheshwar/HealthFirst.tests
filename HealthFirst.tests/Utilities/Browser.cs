using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace HealthFirst.tests.Utilities
{
    class Browser
    {
        public static IWebDriver driver;

        public static void OpenBrowser()
        {
            switch (Constants.browser.ToLower())
            {
                case "chrome": driver = new ChromeDriver();
                    driver.Manage().Window.Maximize();
                    driver.Url = Constants.url;
                    
                    break;

                

                default:driver = new ChromeDriver();
                    break;
            }
        }

        public static void CloseBrowser()
        {
            driver.Quit();
        }
    }
}
