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
    public class PolicPurchaseTest : TestBase
    {
        HelperClass hc1 = new HelperClass();
        PolicyPurchaseOperation PolicyPurchaseOp = new PolicyPurchaseOperation();

        [Test]
        public void PolicyPurchase()
        {

            hc1.LogintoApplication("qasophos00@gmail.com", "123456");
            PolicyPurchaseOp.PolicyHolderOp();
            PolicyPurchaseOp.AddVehicleOp();
            PolicyPurchaseOp.PolicyEffectiveDateOp();
            PolicyPurchaseOp.QuoteListOp();
            PolicyPurchaseOp.SummaryReportOp();

        }
    }
}
