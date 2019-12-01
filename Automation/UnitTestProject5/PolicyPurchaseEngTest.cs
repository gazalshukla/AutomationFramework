using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TPLFramework;
using TPLOperations;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using System.Threading;
using TPLTest;


namespace TPLTest
{
    [TestFixture]
    public class PolicyPurchaseEngTest : TestBase
    {
        HelperClass hc1 = new HelperClass();
        PolicyPurchaseOpEnglish engTest = new PolicyPurchaseOpEnglish();
        [Test] 
        public void PolicyPurchaseEnglish()
        {

            hc1.LogintoApplication("qasophos00@gmail.com", "123456");
            engTest.policyHolderEngOp();
            engTest.AddVehicleEngOp();
            engTest.PolicyEffectiveDateEngOp();
            engTest.QuoteListEngOp();
            engTest.SummaryReportEngOp();

        }

    }
}
