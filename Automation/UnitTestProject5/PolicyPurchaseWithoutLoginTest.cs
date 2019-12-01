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
    class PolicyPurchaseWithoutLoginTest : TestBase
    {

        PolicyPurchaseWithOutLogin withOutlogin = new PolicyPurchaseWithOutLogin();

        [Test]
        public void PolicyPurchaseWithOutLogin()
        {
            withOutlogin.homePage();
            withOutlogin.newAddVehicle();
            withOutlogin.newLogin();

        }
    }
}
