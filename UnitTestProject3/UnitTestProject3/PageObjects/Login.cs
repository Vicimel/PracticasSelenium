using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace UnitTestProject3.PageObjects
{
    public class Login
    {

        [FindsBy(How = How.Name, Using = "username")]
        public IWebElement Username { get; set; }

        [FindsBy(How = How.Name, Using = "password")]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='loginfrm']/div[1]/div[5]/button")]
        public IWebElement SubmitButton { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[4]/div/div/div[2]/ul/li[1]/a")]
        public IWebElement AccountButton { get; set; }

        // [FindsBy(How = How.XPath, Using = "(//*[@id='li_myaccount']/a)[2]")]
        // public IWebElement LoginValidation { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[4]/div/div/div[2]/ul/li[1]/ul/li[2]/a")]
        public IWebElement Logout { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class = 'alert alert-danger']")]
        public IWebElement ErrorLoginText { get; set; }

        public void LogIn(string usuario, string password)
        {
            Username.SendKeys(usuario);
            Password.SendKeys(password);
            SubmitButton.Click();
        }
    }
}
