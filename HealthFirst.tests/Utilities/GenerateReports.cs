using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RelevantCodes.ExtentReports;
using NUnit.Framework;

namespace HealthFirst.tests.Utilities
{
    public class GenerateReports
    {
        public static ExtentReports reports = new ExtentReports(@"C:\Users\Rashi Maheshwar\Documents\visual studio 2015\Projects\HealthFirst.tests\HealthFirst.tests\Reports\"+TestContext.CurrentContext.Test.MethodName+".html");
        public static ExtentTest test;
    }
}
