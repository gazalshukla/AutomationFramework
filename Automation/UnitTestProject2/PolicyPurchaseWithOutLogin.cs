using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using TPLFramework;
using System.Threading;
using System.Globalization;
using TPLOperations;
using OpenQA.Selenium.Support.UI;

namespace TPLOperations
{
    public class PolicyPurchaseWithOutLogin : HelperClass
    {
        PolicyPurchaseOperation ops = new PolicyPurchaseOperation();
        public void homePage()
        {
            WaitForElement(By.Id("UniqueID"));
            driver.FindElement(By.Id("UniqueID")).SendKeys("1100720448");
            driver.FindElement(By.Id("strPolicyEffectiveDate")).Click();
            Thread.Sleep(1000);
            IJavaScriptExecutor jsa = (IJavaScriptExecutor)driver;
            //jsa.ExecuteScript("scroll(686,601)");
            driver.FindElement(By.Id("strPolicyEffectiveDate")).SendKeys(Keys.Down);
            driver.FindElement(By.Id("strPolicyEffectiveDate")).SendKeys(Keys.Enter);
            driver.FindElement(By.Id("select2-ArabicMonth-container")).Click();
            IWebElement month = driver.FindElement(By.CssSelector(".select2-dropdown"));
            month.Click();
            WaitForElement(By.Id("select2-dobArabic-container"));
            driver.FindElement(By.Id("select2-dobArabic-container")).Click();
            Actions actions = new Actions(driver);
            IWebElement year = driver.FindElement(By.XPath("/html/body/span/span/span[1]/input"));
            actions.MoveToElement(year);
            actions.Click();
            actions.SendKeys("1458").SendKeys(Keys.Enter).Build().Perform();          
            driver.FindElement(By.Id("btnSetQuoteInformation2")).Click();
            Thread.Sleep(4000);
            driver.FindElement(By.PartialLinkText("أسعار تأمين ضد الغير")).Click();
        }
        public void newAddVehicle()
        {            
            Thread.Sleep(5000);
            WaitForElement(By.Id("select2-PurposeofVehicleUseID-container"));
            driver.FindElement(By.Id("select2-PurposeofVehicleUseID-container")).Click();
            driver.FindElement(By.CssSelector(".select2-dropdown")).Click();
            driver.FindElement(By.Id("SequenceNumber")).SendKeys(PolicyPurchaseOperation.SequenceNumber);
            driver.FindElement(By.CssSelector("#ownertransferdiv > div.input-box.custom-radio > div > label:nth-child(1) > span")).Click();
            driver.FindElement(By.CssSelector("#policySteps > div.content.clearfix > div > div.form-section > div > div:nth-child(9) > div > div > div > div:nth-child(2) > div:nth-child(2) > div.input-box.custom-radio > div > label:nth-child(1) > span")).Click();
            driver.FindElement(By.Id("select2-RegionID-container")).Click();
            driver.FindElement(By.CssSelector(".select2-dropdown")).Click();
            IJavaScriptExecutor jsa = (IJavaScriptExecutor)driver;
            jsa.ExecuteScript("scroll(686,601)");
            Thread.Sleep(2000);
            driver.FindElement(By.Id("select2-VehicleDriveCityID-container")).Click();
            driver.FindElement(By.CssSelector(".select2-dropdown")).Click();
            driver.FindElement(By.Id("select2-occupation-container")).Click();
            driver.FindElement(By.CssSelector(".select2-dropdown")).Click();            
            driver.FindElement(By.Id("select2-ManufactureYear-container")).Click();
            Actions actions = new Actions(driver);
            IWebElement year = driver.FindElement(By.XPath("/html/body/span/span/span[1]/input"));
            actions.MoveToElement(year);
            actions.Click();
            actions.SendKeys("2012").SendKeys(Keys.Enter).Build().Perform();
           // driver.FindElement(By.CssSelector(".select2-dropdown")).Click();
            driver.FindElement(By.Id("select2-CoverAgainstAdditionPremium-container")).Click();
            driver.FindElement(By.CssSelector(".select2-dropdown")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//*[@id='policySteps']/div[2]/div/div[2]/div/div[5]/div[1]/div[2]/div/div/div/label/span")).Click();
            jsa.ExecuteScript("scroll(950,901)");
            driver.FindElement(By.Id("btnNext")).Click();
        }
        public void newLogin()
        {
            Thread.Sleep(3000);
            IJavaScriptExecutor jsa = (IJavaScriptExecutor)driver;
            jsa.ExecuteScript("scroll(950,901)");
            driver.FindElement(By.Id("btnMyAccount")).Click();
            driver.FindElement(By.Id("login-email-freequote")).SendKeys("qasophos00@gmail.com");
            driver.FindElement(By.Id("login-password-freequote")).SendKeys("123456");
            driver.FindElement(By.Id("btnLogin-freequote")).Click();
            Thread.Sleep(3000);
            ops.AddVehicleOp();
            ops.PolicyEffectiveDateOp();
            ops.QuoteListOp();
            ops.SummaryReportOp(); 

        }

        
    }
}
