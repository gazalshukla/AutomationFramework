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
    public class LogoutTest : TestBase
    {

        HelperClass hc1 = new HelperClass();
        LoginLogoutOperation logout = new LoginLogoutOperation();

        [Test]
        public void Logout()
        {
            hc1.LogintoApplication("qasophos00@gmail.com", "123456");
            logout.LogoutOp();
        }

    }
}
