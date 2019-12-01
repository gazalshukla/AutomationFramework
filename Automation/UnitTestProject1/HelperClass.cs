using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bytescout.Spreadsheet;
using OpenQA.Selenium.Interactions;

namespace TPLFramework
{
    public class HelperClass : BaseClass
    {
        string applicationUrl = "http://policyuat.gettameeni.com";
        

        public void BrowseApplicationUrl()
        {
            driver.Navigate().GoToUrl(applicationUrl);
        }
        public void LogintoApplication(string userName, string password)
        {
            driver.FindElement(By.XPath("/html/body/div[4]/header/div[1]/div/div[3]/div/ul/li[2]/a")).Click();
            Thread.Sleep(5000);
            SetTextToField(driver.FindElement(By.Id("login-email")), userName);
            SetTextToField1(driver.FindElement(By.Id("login-password")), password);
            driver.FindElement(By.Id("btnLogin")).Click();
        }

        public void SetTextToField(IWebElement element, string text)
        {
            element.SendKeys(text);
        }

        public void SetTextToField1(IWebElement element, string text)
        {
            element.SendKeys(text);
        }

        public void SelectElementByText(IWebElement element, string text)
        {
            SelectElement se = new SelectElement(element);
            se.SelectByText(text);
        }

        public void SelectElementByText(IWebElement element, int index)
        {
            SelectElement se = new SelectElement(element);
            se.SelectByIndex(index);
        }

        public void WaitForElement(By element)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(59));
            wait.Until(ExpectedConditions.ElementIsVisible(element));
        }

        public string ReadDataFromExcel(string path, string sheetName, int row, int col)
        {
            string data = "";
            Spreadsheet document = new Spreadsheet();
            try
            {
                string startupPath = AppDomain.CurrentDomain.BaseDirectory;

                document.LoadFromFile(startupPath + path);
                Worksheet worksheet = document.Workbook.Worksheets.ByName(sheetName);

                data = worksheet.Cell(row, col).ValueAsString;
            }
            catch (Exception e)
            {
                string mess = e.Message;
            }
            finally
            {
                document.Close();
            }
            return data;
        }

        public void CloseDriver()
        {
            driver.Close();
        }
    }
}
