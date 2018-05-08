using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using System.Linq;
using OpenQA.Selenium.Chrome;

namespace UnitTestProject3
{

    /// Summary description for TercerTest

    [TestClass]
    public class TercerTest
    {
        internal IWebDriver driver;

        [TestInitialize]
        public void setup()
        {
            driver = new FirefoxDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.google.com/";
        }

        [TestMethod]
        public void SearchGoogle()
        {

            driver.FindElement(By.Name("q")).SendKeys("seleniumhq");
            driver.FindElement(By.Name("btnK")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.LinkText("Selenium - Web Browser Automation")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.LinkText("Download Selenium")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.LinkText("supports the Selenium project")).Click();
            Thread.Sleep(1000);
            Assert.IsTrue(driver.FindElement(By.XPath("//img[@src='/sponsors/testbirds.jpg']")).Displayed,"Si Existe");
        }
        [TestCleanup]
        public void EndTest()
        {
            Thread.Sleep(10000);
            driver.Quit();

        }

    }
}