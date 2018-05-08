using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System.Threading;

namespace UnitTestProject3
{
    /// <summary>
    /// Summary description for PrimerTest
    /// </summary>
    [TestClass]
    public class PrimerTest
    {
       internal IWebDriver driver = new FirefoxDriver();

        [TestMethod]
        public void OpenUrl()
        {
                
            driver.Url = "http://toolsqa.com/Automation-practice-form/";

            // Click on "Partial Link Text" link
          driver.FindElement(By.PartialLinkText("Partial")).Click();
            //driver.FindElement(By.LinkText("Link Test")).Click();

            //Saving the URL into the Variable PageURL
            String PageURL = driver.Url;

            //Saving the Lenght of the URL
            int LongURL = PageURL.Length;

            //Imprimir the URL en la Consola    
              Console.WriteLine("Partial Link Test Pass --> " + PageURL);
            //Console.WriteLine("Link Test Pass --> " + PageURL);

            //Imprimir la Longitud URL en la Consola    
            Console.WriteLine("The Length of the URL is --> " + LongURL);

            driver.FindElement(By.Name("firstname")).SendKeys("VICIMEL");
            driver.FindElement(By.Name("lastname")).SendKeys("MEDINA");

            //Thread.Sleep(2300);
        }
        [TestCleanup]
        public void EndTest()
        {
            Thread.Sleep(10000);
            driver.Quit();
         
        }
    }
}
