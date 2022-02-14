using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using RelevantCodes.ExtentReports;

namespace HealthFirst.tests.Utilities
{
    public class BaseTest:GenerateReports
    {
        [SetUp]
        public void BeforeTest()
        {
            test = reports.StartTest(TestContext.CurrentContext.Test.MethodName);
            Browser.OpenBrowser();
        }

        [TearDown]
        public void AfterTest()
        {
            Browser.CloseBrowser();
            var status = TestContext.CurrentContext.Result.Outcome.Status;
            if (status == TestStatus.Failed)
            {
                test.Log(LogStatus.Fail, "Test failed");
                TakeScreenshot.FailedScreenshot();
            }
            else if (status == TestStatus.Skipped)
            {
                test.Log(LogStatus.Skip, "test skipped");
            }
            else
            {
                test.Log(LogStatus.Pass,"Test passed");
            }
            reports.EndTest(test);
            reports.Flush();

        }
    }
}
