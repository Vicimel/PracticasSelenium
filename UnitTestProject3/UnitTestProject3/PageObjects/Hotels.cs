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


namespace UnitTestProject3.PageObjects
{
    public class Hotels
    {

        [FindsBy(How = How.XPath, Using = "//button[@id = 'searchform']")]
        public IWebElement SearchButton { get; set; }

        [FindsBy(How = How.Name, Using = "fullname")]
        public IWebElement YourName { get; set; }

        [FindsBy(How = How.Name, Using = "email")]
        public IWebElement YourEmail { get; set; }

        [FindsBy(How = How.Name, Using = "reviews_comments")]
        public IWebElement ReviewComments { get; set; }

        [FindsBy(How = How.XPath, Using = "(//button[@id = 37])[1]")]
        public IWebElement SubmitReviewButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@href = '#ADDREVIEW']")]
        public IWebElement WriteReviewButton { get; set; }

        [FindsBy(How = How.Name, Using = "reviews_clean")]
        public IWebElement CleanValue { get; set; }

        [FindsBy(How = How.Name, Using = "reviews_facilities")]
        public IWebElement FacilitiesValue { get; set; }

        [FindsBy(How = How.Name, Using = "reviews_comfort")]
        public IWebElement ComfortValue { get; set; }

        [FindsBy(How = How.Name, Using = "reviews_staff")]
        public IWebElement StaffValue { get; set; }

        [FindsBy(How = How.Name, Using = "reviews_location")]
        public IWebElement LocationValue { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='alert alert - success']")]
        //[FindsBy(How = How.XPath, Using = "//div[contains (text(),'Review Posted')]")]
        public IWebElement ReviewValidation { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@class='wishtext']")]
        public IWebElement AddWishlistButton { get; set; }


        public void SelectHotelByName(IWebDriver driver, string Hotel)
        {
            Thread.Sleep(8000);
            driver.FindElement(By.XPath("//b[contains (text(),'" + Hotel + "')]")).Click();
        }

        public void SelectHotelByStarGrade(IWebDriver driver, int Start)
        {
            Thread.Sleep(8000);
            // driver.FindElement(By.XPath("//input[@id = '"+Start+"']")).Click();
            driver.FindElement(By.XPath("//label[@for='" + Start + "']")).Click();
            SearchButton.Click();
            //Thread.Sleep(6000);
        }

        public void WriteReview(IWebDriver driver, string FullName, string EmailAccount, string ReviewText)
        {
            YourName.SendKeys(FullName);
            YourEmail.SendKeys(EmailAccount);
            ReviewComments.SendKeys(ReviewText);
            SubmitReviewButton.Click();
            Thread.Sleep(5000);
        }

        public void SelectPoints(IWebElement Overall, string Points)
        {
            SelectElement OverallPoints = new SelectElement(Overall);
            OverallPoints.SelectByText(Points);
        }



    }
}
