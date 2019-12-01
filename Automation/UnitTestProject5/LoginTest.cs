using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TPLFramework;
using TPLOperations;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using System.Threading;

namespace TPLTest
{
    [TestFixture]
    public class LoginTest : TestBase
    {

        HelperClass hc1 = new HelperClass();
        LoginLogoutOperation logout = new LoginLogoutOperation();
        [Test]
        public void Login()
        {
            hc1.LogintoApplication("qasophos00@gmail.com", "123456");

            //logout.LogoutOp();
            //var date = DateTime.Today.AddDays(+2).ToString("dd/MM/yyyy");
            // Thread.Sleep(3000);                   
        }

    }
}
