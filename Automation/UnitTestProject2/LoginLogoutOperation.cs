using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using TPLFramework;
using System.Threading;

namespace TPLOperations
{
    public class LoginLogoutOperation : HelperClass
    {

        public void LogoutOp()
        {
            Thread.Sleep(5000);
            ClickOnDropDownOp();
            LogoutOperation();
        }
        public void ClickOnDropDownOp()
        {
            var drop = driver.FindElement(By.Id("dropdownMenu1"));
            drop.Click();
        }
        public void LogoutOperation()
        {
            var logoutB = driver.FindElement(By.XPath("/html/body/div[3]/header/div[1]/div/div[3]/div/ul/li[2]/ul/li[2]/a"));            
            logoutB.Click();

        }
       
    }
}
