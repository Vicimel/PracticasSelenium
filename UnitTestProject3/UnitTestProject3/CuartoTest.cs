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

    /// Summary description for CuartoTest

    [TestClass]
    public class CuartoTest
    {
        internal IWebDriver driver;

        [TestInitialize]
        public void setup()
        {
            driver = new FirefoxDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.phptravels.net/";
        }

        [TestMethod]
        public void UpdateUserProfile()
        {

            driver.FindElement(By.XPath("(//*[@id='li_myaccount'])[2]")).Click();
            //driver.FindElement(By.Id("li_myaccount")).Click();
            driver.FindElement(By.XPath("( //*[@id='li_myaccount']/ul/li[1]/a)[2]")).Click();
            driver.FindElement(By.Name("username")).SendKeys("user@phptravels.com");
            driver.FindElement(By.Name("password")).SendKeys("demouser");
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//*[@id='loginfrm']/div[1]/div[5]/button")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//a[@href='#profile']")).Click();
            Thread.Sleep(6000);
            Assert.AreEqual(driver.FindElement(By.XPath("//input[@placeholder='First Name']")).GetAttribute("value"), "DVhbCERv");
            String FirstName = driver.FindElement(By.XPath("//input[@placeholder='First Name']")).GetAttribute("value");
            Assert.AreEqual(driver.FindElement(By.XPath("//input[@placeholder='Last Name']")).GetAttribute("value"), "IlqEZZxz");
            String LastName = driver.FindElement(By.XPath("//input[@placeholder='Last Name']")).GetAttribute("value");
            Assert.AreEqual(driver.FindElement(By.XPath("//input[@placeholder='Phone']")).GetAttribute("value"), "1234563242342dfdfaff");
            String PhoneNumber = driver.FindElement(By.XPath("//input[@placeholder='Phone']")).GetAttribute("value");
            Console.WriteLine("First Name TC is OK! Expected <DVhbCERv> and the Actual is --> " + FirstName);
            Console.WriteLine("Last Name TC is OK! Expected <IlqEZZxz> and the Actual is --> " + LastName);
            Console.WriteLine("Phone Number TC is OK! Expected <1234563242342dfdfaff> and Actual is --> " + PhoneNumber);
            driver.FindElement(By.XPath("//input[@placeholder = 'Address 2']")).SendKeys("TEST ADDRESS 2");
            driver.FindElement(By.XPath("//*[@id='profilefrm']/div/div[3]/div[3]/button")).Click();
            Thread.Sleep(8000);
            driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[2]/ul/li[1]/a")).Click();
            Thread.Sleep(3000);
            Assert.AreEqual(driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[2]/ul/li[1]/a")).Text, "DVHBCERV");
            String user = driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[2]/ul/li[1]/a")).Text;
            int longitud = user.Length;
            Console.WriteLine("The User is --> " + user);
            Console.WriteLine("The Lenght of the UserName is --> " + longitud);
            driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[2]/ul/li[1]/ul/li[2]/a")).Click();

        }   
        [TestCleanup]
        public void EndTest()
        {
            Thread.Sleep(10000);
            driver.Quit();

        }

    }
}