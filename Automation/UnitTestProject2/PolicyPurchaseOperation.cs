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
   public class PolicyPurchaseOperation : HelperClass
    {
        #region Elements
        public static string PolicyholderID = "1031275108";
        static int r = (new Random()).Next(1, 1000);
        public static string EmailId = "qatam00+" + r + "@gmail.com";
        public static string MobileNo = "0550069966";
         
        // Adress
        public static string BuildingNo = "7962";
        public static string City = "Riyadh";
        public static string Street = "Prince Muqrin Ibn Abdulaziz";
        public static string ZipCode = "12484";
        public static string District = "Al Mughrizat";
        public static string AdditionalNo = "3594";

        //Add Vehicle
        public static string SequenceNumber = "916921010";

        //Date 
        public static string date = DateTime.Today.AddDays(+2).ToString("dd/MM/yyyy");

        //IBAN XPath
        public string one = "//input[@type='text']";
        public string oneSendkey = "1";
        public string two = "//*[@id='ibanbox']/div[2]/div[1]/input[2]";
        public string twoSendkey = "1";
        public string three = "//*[@id='ibanbox']/div[2]/div[1]/input[3]";
        public string threeSendkey = "1";
        public string four = "//*[@id='ibanbox']/div[2]/div[1]/input[4]";
        public string fourSendkey = "5";
        public string five = "//*[@id='ibanbox']/div[2]/div[1]/input[5]";
        public string fiveSendkey = "6";
        public string six = "//*[@id='ibanbox']/div[2]/div[1]/input[6]";
        public string sixSendkey = "5";
        public string seven = "//*[@id='ibanbox']/div[2]/div[1]/input[7]";
        public string sevenSendkey = "4";
        public string eight = "//*[@id='ibanbox']/div[2]/div[1]/input[8]";
        public string eightSendkey = "2";
        public string nine = "//*[@id='ibanbox']/div[2]/div[1]/input[9]";
        public string nineSendkey = "2";
        public string ten = "//*[@id='ibanbox']/div[2]/div[1]/input[10]";
        public string tenSendkey = "1";
        public string eleven = "//*[@id='ibanbox']/div[2]/div[1]/input[11]";
        public string elevenSendkey = "0";
        public string twelve  = "//*[@id='ibanbox']/div[2]/div[1]/input[12]";
        public string twelveSendkey = "9";
        public string thirteen  = "//*[@id='ibanbox']/div[2]/div[1]/input[13]";
        public string thirteenSendkey = "8";
        public string fourteen = "//*[@id='ibanbox']/div[2]/div[1]/input[14]";
        public string fourteenSendkey = "7";
        public string fifteen = "//*[@id='ibanbox']/div[2]/div[1]/input[15]";
        public string fifteenSendkey = "1";
        public string sixteen = "//*[@id='ibanbox']/div[2]/div[1]/input[16]";
        public string sixteenSendkey = "6";
        public string seventeen = "//*[@id='ibanbox']/div[2]/div[1]/input[17]";
        public string seventeenendkey = "5";
        public string eighteen = "//*[@id='ibanbox']/div[2]/div[1]/input[18]";
        public string eighteenSendkey = "4";
        public string nineteen = "//*[@id='ibanbox']/div[2]/div[1]/input[19]";
        public string nineteenSendkey = "3";
        public string twenty = "//*[@id='ibanbox']/div[2]/div[1]/input[20]";
        public string twentySendkey = "2";
        public string twentyOne = "//*[@id='ibanbox']/div[2]/div[1]/input[21]";
        public string twentyOneSendkey = "1";
        public string twentyTwo = "//*[@id='ibanbox']/div[2]/div[1]/input[22]";
        public string twentyTwoSendkey = "0";


        #endregion

        public void PolicyHolderOp()
        {
            IJavaScriptExecutor jsa = (IJavaScriptExecutor)driver;
            Thread.Sleep(5000);
            driver.FindElement(By.PartialLinkText("شراء وثيقة تأمين جديدة")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//*[@id='myaccount']/div/div/div[1]/div/div[1]/div/ul/li[1]/a/span")).Click();
            WaitForElement(By.PartialLinkText("اضف هوية مالك جديد"));
            //driver.FindElement(By.PartialLinkText("اضف هوية مالك جديد")).Click();
            jsa.ExecuteScript("scroll(686,601)");
            driver.FindElement(By.Id("btn_26445")).Click();
            jsa.ExecuteScript("scroll(686,601)");
            driver.FindElement(By.Id("btnActiveAddress_25856")).Click();
            //driver.FindElement(By.Id("btnActiveAddress_25724")).Click();
            //WaitForElement(By.XPath("//*[@id='PolicyHolderUniqueID']"));
            //driver.FindElement(By.XPath("//*[@id='PolicyHolderUniqueID']")).SendKeys(PolicyholderID);
            //driver.FindElement(By.Id("MobileNumber")).SendKeys(MobileNo);
            //driver.FindElement(By.Id("Email")).SendKeys(EmailId);
            //WaitForElement(By.XPath("//div[@id='dashboard-form']/div/div/div/div"));
            //driver.FindElement(By.XPath("//div[@id='dashboard-form']/div/div/div/div")).Click();
            //driver.FindElement(By.Id("select2-ArabicMonth-container")).Click();
            //IWebElement month = driver.FindElement(By.CssSelector(".select2-dropdown"));
            //month.Click();
            //WaitForElement(By.Id("select2-IDExpiryMonthYear-container"));
            //driver.FindElement(By.Id("select2-IDExpiryMonthYear-container")).Click();
            //IWebElement dob = driver.FindElement(By.CssSelector(".select2-dropdown"));
            //dob.Click();
            ////Address
            //driver.FindElement(By.Id("BuldingNumber")).SendKeys(BuildingNo);
            //driver.FindElement(By.Id("City")).SendKeys(City);
            //driver.FindElement(By.Id("Street")).SendKeys(Street);
            //driver.FindElement(By.Id("ZipCode")).SendKeys(ZipCode);
            //driver.FindElement(By.Id("District")).SendKeys(District);
            //driver.FindElement(By.Id("AdditionalNumber")).SendKeys(AdditionalNo);
            //driver.FindElement(By.Id("AdditionalNumber")).SendKeys(Keys.Enter);
        }
        public void AddVehicleOp()
        {
            //driver.FindElement(By.CssSelector("#policySteps > div.content.clearfix > section > div > div.form-section > div > div.myaccount-add-btn > div > a")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.Id("btn_26791")).Click();
            WaitForElement(By.Id("select2-PurposeofVehicleUseID-container"));
            driver.FindElement(By.Id("select2-PurposeofVehicleUseID-container")).Click();
            driver.FindElement(By.CssSelector(".select2-dropdown")).Click();
           // driver.FindElement(By.Id("SequenceNumber")).SendKeys(SequenceNumber);
            driver.FindElement(By.XPath("//div[@id='policySteps']/div/section/div/div[2]/div/div[3]/div/div/div/div/div[3]/div[2]/div/label[2]/span")).Click();
            driver.FindElement(By.Id("select2-RegionID-container")).Click();
            driver.FindElement(By.CssSelector(".select2-dropdown")).Click();
            IJavaScriptExecutor jsa = (IJavaScriptExecutor)driver;
            jsa.ExecuteScript("scroll(686,601)");
            driver.FindElement(By.Id("select2-VehicleDriveCityID-container")).Click();
            driver.FindElement(By.CssSelector(".select2-dropdown")).Click();
            driver.FindElement(By.Id("select2-occupation-container")).Click();
            driver.FindElement(By.CssSelector(".select2-dropdown")).Click();
           // driver.FindElement(By.Id("select2-yearOfmanufactureId-container")).Click();
            //driver.FindElement(By.CssSelector(".select2-dropdown")).Click();
            driver.FindElement(By.Id("select2-CoverAgainstAdditionPremium-container")).Click();
            driver.FindElement(By.CssSelector(".select2-dropdown")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//div[@id='policySteps']/div/section/div/div[2]/div/div[4]/div/div[2]/div/div/div/label/span")).Click();
            driver.FindElement(By.Id("btnNext")).Click();
        }
        public void PolicyEffectiveDateOp()
        {
            Thread.Sleep(5000);
            driver.FindElement(By.Id("txtPolicyEffectiveDate")).Click();
            Thread.Sleep(1000);
            IJavaScriptExecutor jsa = (IJavaScriptExecutor)driver;
            jsa.ExecuteScript("scroll(686,601)");
            driver.FindElement(By.Id("txtPolicyEffectiveDate")).SendKeys(Keys.Down);
            driver.FindElement(By.Id("txtPolicyEffectiveDate")).SendKeys(Keys.Enter);
           // driver.FindElement(By.Id("txtPolicyEffectiveDate")).SendKeys(date);
            driver.FindElement(By.Id("btnSave")).Click();
            Thread.Sleep(7000);
            
        }
        public void QuoteListOp()
        {
            WaitForElement(By.XPath("//*[@id='policySteps']/div[2]/section/div/div/div/div[1]/h2"));
            IJavaScriptExecutor jsa = (IJavaScriptExecutor)driver;
            jsa.ExecuteScript("scroll(686,601)");
            driver.FindElement(By.XPath("//div[contains(@id,'anch_')]")).Click();
        }
        public void SummaryReportOp()
        {
            Thread.Sleep(5000);            
            IJavaScriptExecutor jsa = (IJavaScriptExecutor)driver;
            jsa.ExecuteScript("scroll(1150,1101)");
            IBAN();
            driver.FindElement(By.XPath("//div[@id='payment-options']/div[2]/div/div[2]/div/div/div/label/span")).Click();

            driver.FindElement(By.XPath("//*[@id='declaration']/div[1]/label/span")).Click();
            IWebElement element = driver.FindElement(By.XPath("//*[@id='agreement']/div[1]/label/span"));
            int width = element.Size.Width;
            Actions act = new Actions(driver);
            act.MoveToElement(element).MoveByOffset((width/2)-2,0).Click().Perform();
            jsa.ExecuteScript("scroll(1250,1201)");
            driver.FindElement(By.Id("next")).Click();
        }

        public void IBAN()
        {
            driver.FindElement(By.XPath(one)).SendKeys(oneSendkey);
            driver.FindElement(By.XPath(two)).SendKeys(twoSendkey);
            driver.FindElement(By.XPath(three)).SendKeys(threeSendkey);
            driver.FindElement(By.XPath(four)).SendKeys(fourSendkey);
            driver.FindElement(By.XPath(five)).SendKeys(fiveSendkey);
            driver.FindElement(By.XPath(six)).SendKeys(sixSendkey);
            driver.FindElement(By.XPath(seven)).SendKeys(sevenSendkey);
            driver.FindElement(By.XPath(eight)).SendKeys(eightSendkey);
            driver.FindElement(By.XPath(nine)).SendKeys(nineSendkey);
            driver.FindElement(By.XPath(ten)).SendKeys(tenSendkey);
            driver.FindElement(By.XPath(eleven)).SendKeys(elevenSendkey);
            driver.FindElement(By.XPath(twelve)).SendKeys(twelveSendkey);
            driver.FindElement(By.XPath(thirteen)).SendKeys(thirteenSendkey);
            driver.FindElement(By.XPath(fourteen)).SendKeys(fourteenSendkey);
            driver.FindElement(By.XPath(fifteen)).SendKeys(fifteenSendkey);
            driver.FindElement(By.XPath(sixteen)).SendKeys(sixteenSendkey);
            driver.FindElement(By.XPath(seventeen)).SendKeys(seventeenendkey);
            driver.FindElement(By.XPath(eighteen)).SendKeys(eighteenSendkey);
            driver.FindElement(By.XPath(nineteen)).SendKeys(nineteenSendkey);
            driver.FindElement(By.XPath(twenty)).SendKeys(twentySendkey);
            driver.FindElement(By.XPath(twentyOne)).SendKeys(twentyOneSendkey);
            driver.FindElement(By.XPath(twentyTwo)).SendKeys(twentyTwoSendkey);
            
        }

    }
}
