using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace TPLFramework
{
    public class BaseClass
    {
        public static IWebDriver driver;

        //public IWebDriver InitializeChromeDriver(string path)
        //{
        //	driver = new ChromeDriver(path);
        //	return driver;
        //}

        //public IWebDriver InitializeFirefoxDriver()
        //{
        //	driver = new FirefoxDriver();
        //	return driver;
        //}
    }
}
