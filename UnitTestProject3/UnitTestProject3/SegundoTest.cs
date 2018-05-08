using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using System.Linq;

namespace UnitTestProject3
{
    /// <summary>
    /// Summary description for PrimerTest
    /// </summary>
    [TestClass]
    public class SegundoTest
    {
        internal IWebDriver driver; //= new FirefoxDriver();

        [TestInitialize]
        public void setup()
        {
            driver = new FirefoxDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "http://toolsqa.com/Automation-practice-form/";
        }

        [TestMethod]
        public void GeneralTest()
        {

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

            driver.FindElement(By.Id("sex-1")).Click();
            driver.FindElement(By.Id("exp-6")).Click();
            driver.FindElement(By.Id("datepicker")).SendKeys("03-MAYO-2018");
            driver.FindElement(By.Id("profession-0")).Click();
            driver.FindElement(By.Id("tool-2")).Click();

            SelectElement continents = new SelectElement(driver.FindElement(By.Id("continents")));
            continents.SelectByText("North America");

            SelectElement commandos = new SelectElement(driver.FindElement(By.Id("selenium_commands")));
            commandos.SelectByText("1");

            IList<IWebElement> elementCount = continents.Options;
            Console.WriteLine("List of Continents: ");
            int show = elementCount.Count;
            for (int i=0; i<show; i++)
            {
                String AllOptions = elementCount.ElementAt(i).Text;
                Console.WriteLine(AllOptions);
            }

                //driver.FindElement(By.Id("continents"))
        }
       [TestMethod]
        public void FillFields()
        {
            driver.FindElement(By.Name("firstname")).SendKeys("VICIMEL");
            driver.FindElement(By.Name("lastname")).SendKeys("MEDINA");

        }

        [TestCleanup]
        public void EndTest()
        {
            Thread.Sleep(10000);
            driver.Quit();

        }

    }
    }