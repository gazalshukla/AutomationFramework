using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPLFramework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System.Threading;
using NUnit.Framework;

namespace TPLOperations.ValidationOperation
{
   public class LoginValidationOperation : HelperClass 
    {
        #region Elements 
        public string EnterEmail = "Email is required";
        public string EnterPassword = "Password is required";
        public string InvalidCreds = "Invalid Email or Password";
        public string EnterEmailArabic = "البريد الإلكتروني مطلوب.";
        public string EnterPasswordArabic = "كلمة المرور مطلوبة لتسجيل الدخول لحسابك";       
        public string InvalidCredsArabic = "البريد الإلكتروني أو كلمة السر خاطئة";
        public string CloseButton = "http://policyuat.gettameeni.com/content/Theme2.0/images/popup-close-icon.png";
        #endregion
        HelperClass hc1 = new HelperClass();
        public void EmailBlankOp()
        {
            Thread.Sleep(5000);
            driver.FindElement(By.LinkText("EN")).Click();
            Thread.Sleep(5000);
            hc1.LogintoApplication("","123456");
            string pathFromHomePage =
            driver.FindElement(By.XPath("//div[@id='login-content']/div/div/div/div[3]/div/div/div/span/span")).Text;
            Assert.AreEqual(EnterEmail, pathFromHomePage, "Validation message not displayed");
        }
        public void PasswordBlankOp()
        {
            Thread.Sleep(5000);
            driver.FindElement(By.LinkText("EN")).Click();
            Thread.Sleep(5000);
            hc1.LogintoApplication("qatam00@gmail.com", "");
            string pathFromHomePage =
            driver.FindElement(By.XPath("//div[@id='login-content']/div/div/div/div[3]/div[2]/div/div/span/span")).Text;
            Assert.AreEqual(EnterPassword, pathFromHomePage, "Validation message not displayed");
        }
        public void blankUnamePassOp()
        {
            Thread.Sleep(5000);
            driver.FindElement(By.LinkText("EN")).Click();
            Thread.Sleep(5000);
            hc1.LogintoApplication("","");
            string pathFromHomePage =
            driver.FindElement(By.XPath("//div[@id='login-content']/div/div/div/div[3]/div/div/div/span/span")).Text;
            Assert.AreEqual(EnterEmail, pathFromHomePage, "Validation message not displayed");
            string pathFromHomePage1 =
            driver.FindElement(By.XPath("//div[@id='login-content']/div/div/div/div[3]/div[2]/div/div/span/span")).Text;
            Assert.AreEqual(EnterPassword, pathFromHomePage1, "Validation message not displayed");
        }
        public void WrongCredsValidationOp()
        {
            Thread.Sleep(5000);
            driver.FindElement(By.LinkText("EN")).Click();
            Thread.Sleep(5000);
            hc1.LogintoApplication("qatam64600@gmail.com","1234567");
            Thread.Sleep(5000);
            string pathFromHomePage =
            driver.FindElement(By.Id("LoginErrorMessage")).Text;            
            Assert.AreEqual(InvalidCreds, pathFromHomePage, "Validation message not displayed");

        }
        public void invalidPassOp()
        {
            Thread.Sleep(5000);
            driver.FindElement(By.LinkText("EN")).Click();
            Thread.Sleep(5000);
            hc1.LogintoApplication("qatam00@gmail.com", "1234567");
            Thread.Sleep(5000);
            string pathFromHomePage =
            driver.FindElement(By.Id("LoginErrorMessage")).Text;
            Assert.AreEqual(InvalidCreds, pathFromHomePage, "Validation message not displayed");
        }
        public void invalidEmailOp()
        {
            Thread.Sleep(5000);
            driver.FindElement(By.LinkText("EN")).Click();
            Thread.Sleep(5000);
            hc1.LogintoApplication("qatam00+gdfhgdhfgjfjjfghj@gmail.com", "123456");
            Thread.Sleep(5000);
            string pathFromHomePage =
            driver.FindElement(By.Id("LoginErrorMessage")).Text;
            Assert.AreEqual(InvalidCreds, pathFromHomePage, "Validation message not displayed");
        }
        public void CloseButtonOp()
        {
            Thread.Sleep(5000);
            driver.FindElement(By.LinkText("EN")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("/html/body/div[4]/header/div[1]/div/div[3]/div/ul/li[2]/a")).Click();
            string pathFromHomePage =
            driver.FindElement(By.XPath("//div[@id='login-popup']/div/div/div/div/button/img")).GetAttribute("src");
            Assert.AreEqual(CloseButton, pathFromHomePage, "The close button is not displayed.");
        }
    }
}
