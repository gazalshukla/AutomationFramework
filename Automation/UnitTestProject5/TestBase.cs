using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TPLFramework;
using OpenQA.Selenium.Chrome;
using NUnit.Framework.Interfaces;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using System.Reflection;

namespace TPLTest
{
    public class TestBase : BaseClass
    {
        public static ExtentReports extent;
        public static  ExtentTest test;
        BaseClass bc = new BaseClass();
        HelperClass hc = new HelperClass();
        [SetUp]
        public void TestInitialize()
        {
            //setup chrome driver
            driver = new ChromeDriver();
            //Navigate TPl URL 
            hc.BrowseApplicationUrl();
            //Maximize browser window 
            driver.Manage().Window.Maximize();
            test = extent.CreateTest(TestContext.CurrentContext.Test.Name);
        }
        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            string path = Assembly.GetCallingAssembly().CodeBase;
            string actualpath = path.Substring(0, path.LastIndexOf("bin"));
            string projectpath = new Uri(actualpath).LocalPath;
            string reportpath = projectpath + "Reports\\test.html";
            var extentHtml = new ExtentHtmlReporter(reportpath);
            extentHtml.LoadConfig(projectpath + "extent-config.xml");
            if (extent == null)
                extent = new ExtentReports();
            extentHtml.AppendExisting = true;
            extent.AttachReporter(extentHtml);            
            //extent.AddSystemInfo("Host name", "UAT");
            //extent.AddSystemInfo("Environment", "Automation");
            //extent.AddSystemInfo("Version", "ABCD");
        }
        [TearDown]
        public void TestCleanup()
        {
            var status = TestContext.CurrentContext.Result.Outcome.Status;
            var stacktrace = string.IsNullOrEmpty(TestContext.CurrentContext.Result.StackTrace) ? "" 
                : string.Format("{0}", TestContext.CurrentContext.Result.StackTrace);
            Status logstatus;
            switch (status)
            {
                case TestStatus.Failed:
                    logstatus = Status.Fail;
                    break;
                case TestStatus.Inconclusive:
                    logstatus = Status.Warning;
                    break;
                case TestStatus.Skipped:
                    logstatus = Status.Skip;
                    break;
                default:
                    logstatus = Status.Pass;
                    break;
            }
            test.Log(logstatus, "Test ended with " + logstatus + stacktrace);
            extent.Flush();
            test.Log(logstatus, "Flush() method of ExtentReports wil push/write everything to the document");
            hc.CloseDriver();
        }
    }
}
