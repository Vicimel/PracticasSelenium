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
using UnitTestProject3.PageObjects;
using OpenQA.Selenium.Support.PageObjects;

namespace UnitTestProject3
{

    /// Summary description for QuintoTest

    [TestClass]
    public class LoginTests
    {
        internal IWebDriver driver;
        internal Login loginpage;
    
        [TestInitialize]
        public void setup()
        {
            driver = new FirefoxDriver();
            loginpage = new Login();
            PageFactory.InitElements(driver, loginpage);
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.phptravels.net/login";
        }


        [TestMethod]
        public void TestLogIn()
        {
            loginpage.LogIn("user@phptravels.com", "demouser");
        }



        [TestMethod]
        public void Login_Password_Empty()
        {
            loginpage.Username.SendKeys("user@phptravels.com");
            //IWebElement UserName = driver.FindElement(By.Name("username"));
            //driver.FindElement(By.Name("username")).SendKeys("user@phptravels.com");
            //serName.SendKeys("user@phptravels.com");
            loginpage.SubmitButton.Click();
            //IWebElement ButtonSubmit = driver.FindElement(By.XPath("//*[@id='loginfrm']/div[1]/div[5]/button"));
            //ButtonSubmit.Click();
            //driver.FindElement(By.XPath("//*[@id='loginfrm']/div[1]/div[5]/button")).Click();
            Thread.Sleep(2000);
            Assert.AreEqual(loginpage.ErrorLoginText.Text, "Invalid Email or Password");
            //Assert.AreEqual(driver.FindElement(By.XPath("//div[@class = 'alert alert-danger']")).Text, "Invalid Email or Password");
        }

        [TestMethod]
        public void Login_UserName_Empty()
        {
            loginpage.Password.SendKeys("demouser");
            //IWebElement Password = driver.FindElement(By.Name("password"));
            //driver.FindElement(By.Name("password")).SendKeys("demouser");
            //Password.SendKeys("demouser");
            loginpage.SubmitButton.Click();
            //IWebElement ButtonSubmit = driver.FindElement(By.XPath("//*[@id='loginfrm']/div[1]/div[5]/button"));
            // ButtonSubmit.Click();
            //driver.FindElement(By.XPath("//*[@id='loginfrm']/div[1]/div[5]/button")).Click();
            Thread.Sleep(3000);
            Assert.AreEqual(loginpage.ErrorLoginText.Text, "Invalid Email or Password");
            //Assert.AreEqual(driver.FindElement(By.XPath("//div[@class = 'alert alert-danger']")).Text, "Invalid Email or Password");
        }

        [TestMethod]
        public void Login_UserNameandPassword_Empty()
        {
            loginpage.SubmitButton.Click();
            //IWebElement ButtonSubmit = driver.FindElement(By.XPath("//*[@id='loginfrm']/div[1]/div[5]/button"));
            //ButtonSubmit.Click();
            //driver.FindElement(By.XPath("//*[@id='loginfrm']/div[1]/div[5]/button")).Click();
            Thread.Sleep(3000);
            Assert.AreEqual(loginpage.ErrorLoginText.Text, "Invalid Email or Password");
            //Assert.AreEqual(driver.FindElement(By.XPath("//div[@class = 'alert alert-danger']")).Text, "Invalid Email or Password");
        }

        [TestMethod]
        public void Login_UserNameIncorrect()
        {

            loginpage.Username.SendKeys("userA@phptravels.com");
            //IWebElement UserName = driver.FindElement(By.Name("username"));
            //UserName.SendKeys("userA@phptravels.com");
            //driver.FindElement(By.Name("username")).SendKeys("userA@phptravels.com");
            loginpage.Password.SendKeys("demouser");
            //IWebElement Password = driver.FindElement(By.Name("password"));
            //Password.SendKeys("demouser");
            //driver.FindElement(By.Name("password")).SendKeys("demouser");
            loginpage.SubmitButton.Click();
            //IWebElement ButtonSubmit = driver.FindElement(By.XPath("//*[@id='loginfrm']/div[1]/div[5]/button"));
            //ButtonSubmit.Click();
            //driver.FindElement(By.XPath("//*[@id='loginfrm']/div[1]/div[5]/button")).Click();
            Thread.Sleep(3000);
            Assert.AreEqual(loginpage.ErrorLoginText.Text, "Invalid Email or Password");
           // Assert.AreEqual(driver.FindElement(By.XPath("//div[@class = 'alert alert-danger']")).Text, "Invalid Email or Password");
        }

        [TestMethod]
        public void Login_PasswordIncorrect()
        {
            loginpage.Username.SendKeys("user@phptravels.com");
            //IWebElement UserName = driver.FindElement(By.Name("username"));
            //UserName.SendKeys("user@phptravels.com");
            //driver.FindElement(By.Name("username")).SendKeys("user@phptravels.com");
            loginpage.Password.SendKeys("demouserA");
            //IWebElement Password = driver.FindElement(By.Name("password"));
            //Password.SendKeys("demouserA");
            //driver.FindElement(By.Name("password")).SendKeys("demouserA");
            loginpage.SubmitButton.Click();
            //IWebElement ButtonSubmit = driver.FindElement(By.XPath("//*[@id='loginfrm']/div[1]/div[5]/button"));
            //ButtonSubmit.Click();
            //driver.FindElement(By.XPath("//*[@id='loginfrm']/div[1]/div[5]/button")).Click();
            Thread.Sleep(3000);
            Assert.AreEqual(loginpage.ErrorLoginText.Text, "Invalid Email or Password");
            //Assert.AreEqual(driver.FindElement(By.XPath("//div[@class = 'alert alert-danger']")).Text, "Invalid Email or Password");
        }


        [TestMethod]
        public void Test_Login_Correct()
        {
            loginpage.Username.SendKeys("user@phptravels.com");
            //IWebElement UserName = driver.FindElement(By.Name("username"));
            //UserName.SendKeys("user@phptravels.com");
            //driver.FindElement(By.Name("username")).SendKeys("user@phptravels.com");
            loginpage.Password.SendKeys("demouser");
            //IWebElement Password = driver.FindElement(By.Name("password"));
            //Password.SendKeys("demouser");
            //driver.FindElement(By.Name("password")).SendKeys("demouser");
            loginpage.SubmitButton.Click();
            //IWebElement ButtonSubmit = driver.FindElement(By.XPath("//*[@id='loginfrm']/div[1]/div[5]/button"));
            //ButtonSubmit.Click();
            //driver.FindElement(By.XPath("//*[@id='loginfrm']/div[1]/div[5]/button")).Click();
            Thread.Sleep(5000);
            loginpage.AccountButton.Click();
            //IWebElement AccountIcon = driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[2]/ul/li[1]/a"));
            //AccountIcon.Click();
            //driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[2]/ul/li[1]/a")).Click();
            Assert.AreEqual(loginpage.AccountButton.Text, "DVHBCERV");
            //Assert.AreEqual(driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[2]/ul/li[1]/a")).Text, "DVHBCERV");

        }

        [TestMethod]
        public void Test_Logout()
        {
            loginpage.Username.SendKeys("user@phptravels.com");
            //driver.FindElement(By.Name("username")).SendKeys("user@phptravels.com");
            loginpage.Password.SendKeys("demouser");
            //driver.FindElement(By.Name("password")).SendKeys("demouser");
            loginpage.SubmitButton.Click();
            //driver.FindElement(By.XPath("//*[@id='loginfrm']/div[1]/div[5]/button")).Click();
            Thread.Sleep(5000);
            loginpage.AccountButton.Click();
            //driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[2]/ul/li[1]/a")).Click();
            Thread.Sleep(5000);
            loginpage.Logout.Click();
            //driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[2]/ul/li[1]/ul/li[2]/a")).Click();
            Thread.Sleep(5000);
            //driver.FindElement(By.XPath("(//*[@id='li_myaccount']/a)[2]")).Click();
            Thread.Sleep(5000);
            Assert.AreEqual(loginpage.AccountButton.Text, "MY ACCOUNT");
            //Assert.AreEqual(driver.FindElement(By.XPath("(//*[@id='li_myaccount']/a)[2]")).Text, "MY ACCOUNT");
         }




        [TestCleanup]
        public void EndTest()
        {
            Thread.Sleep(3000);
            driver.Quit();

        }

    }
}