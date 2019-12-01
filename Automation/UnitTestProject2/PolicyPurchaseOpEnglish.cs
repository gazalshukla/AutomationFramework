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
using OpenQA.Selenium.Support.UI;

namespace TPLOperations
{
   public class PolicyPurchaseOpEnglish : HelperClass
    {
        PolicyPurchaseOperation op1 = new PolicyPurchaseOperation();
        public void policyHolderEngOp()
        {
            Thread.Sleep(5000);
            driver.FindElement(By.LinkText("EN")).Click();
            IJavaScriptExecutor jsa = (IJavaScriptExecutor)driver;
            Thread.Sleep(5000);
            driver.FindElement(By.PartialLinkText("Purchase New Policy")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//*[@id='myaccount']/div/div/div[1]/div/div[1]/div/ul/li[1]/a/span")).Click();
            WaitForElement(By.PartialLinkText("Add New Policyholder"));
            //driver.FindElement(By.PartialLinkText("اضف هوية مالك جديد")).Click();
            driver.FindElement(By.Id("btn_26445")).Click();
            jsa.ExecuteScript("scroll(686,601)");
            driver.FindElement(By.Id("btnActiveAddress_25856")).Click();
        }
        public void AddVehicleEngOp()
        {
            op1.AddVehicleOp();
        }
        public void PolicyEffectiveDateEngOp()
        {
            op1.PolicyEffectiveDateOp();
        }
        public void QuoteListEngOp()
        {
            op1.QuoteListOp();
        }
        public void SummaryReportEngOp()
        {
            Thread.Sleep(5000);
            IJavaScriptExecutor jsa = (IJavaScriptExecutor)driver;
            jsa.ExecuteScript("scroll(1150,1101)");
            op1.IBAN();
            driver.FindElement(By.XPath("//div[@id='payment-options']/div[2]/div/div[2]/div/div/div/label/span")).Click();
            jsa.ExecuteScript("scroll(1150,1101)");
            driver.FindElement(By.XPath("//*[@id='declaration']/div[1]/label/span")).Click();
            IWebElement element = driver.FindElement(By.XPath("//*[@id='agreement']/div[1]/label/span"));
            int width = element.Size.Width;
            int height = element.Size.Height;
            Actions act = new Actions(driver);
            act.MoveToElement(element).MoveByOffset((width / 2) - 150, 0).Click().Perform();
            jsa.ExecuteScript("scroll(1150,1101)");
            driver.FindElement(By.Id("next")).Click();
        }

    }
}
