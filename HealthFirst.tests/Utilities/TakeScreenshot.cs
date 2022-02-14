using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthFirst.tests.Utilities
{
    class TakeScreenshot
    {
        public static void FailedScreenshot()
        {
            ITakesScreenshot ts = (ITakesScreenshot)Browser.driver;
            ts.GetScreenshot().SaveAsFile(@"C:\Users\Rashi Maheshwar\Documents\visual studio 2015\Projects\HealthFirst.tests\HealthFirst.tests\Utilities\" + TestContext.CurrentContext.Test.MethodName + ".png");
        }        
        
        
    }
}
