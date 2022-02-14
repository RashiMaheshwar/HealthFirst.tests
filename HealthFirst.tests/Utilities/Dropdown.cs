using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace HealthFirst.tests.Utilities
{
    class Dropdown
    {
        public static void SelectByIndex(IWebElement element,int index)
        {
            SelectElement select = new SelectElement(element);
            select.SelectByIndex(index);
        }

        public static void SelectByValue(IWebElement element, string value)
        {
            SelectElement select = new SelectElement(element);
            select.SelectByValue(value);
        }

        public static void SelectByText(IWebElement element, string text)
        {
            SelectElement select = new SelectElement(element);
            select.SelectByText(text);
        }
    }
}
