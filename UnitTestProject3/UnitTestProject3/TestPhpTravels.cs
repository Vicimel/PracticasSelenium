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

    [TestClass]
    public class PhpTravelsTests
    {
        internal IWebDriver driver;
        internal Dashboard HomePage;
        internal Hotels HotelPage;
       

        [TestInitialize]
        public void setup()
        {
            driver = new FirefoxDriver();
            HomePage = new Dashboard();
            HotelPage = new Hotels();
            PageFactory.InitElements(driver, HotelPage);
            PageFactory.InitElements(driver, HomePage);
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.phptravels.net/";
        }

        [TestMethod]
        public void TestHotelSearchByName()
        {
            HomePage.AccessHotels.Click();
            HotelPage.SelectHotelByName(driver, "Islamabad Marriott Hotel");
            Thread.Sleep(4000);
        }


        [TestMethod]
        public void TestHotelSearchByStart()
        {
            HomePage.AccessHotels.Click();
            HotelPage.SelectHotelByStarGrade(driver, 1);
           // Thread.Sleep(4000);
        }


        [TestMethod]
        public void TestWriteReview()
        {
            HomePage.AccessHotels.Click();
            Thread.Sleep(8000);
            HotelPage.SelectHotelByName(driver, "Islamabad Marriott Hotel");
            Thread.Sleep(4000);
            HotelPage.WriteReviewButton.Click();
            HotelPage.SelectPoints(HotelPage.CleanValue, "10");
            HotelPage.SelectPoints(HotelPage.FacilitiesValue, "5");
            HotelPage.SelectPoints(HotelPage.ComfortValue, "10");
            HotelPage.SelectPoints(HotelPage.StaffValue, "5");
            HotelPage.SelectPoints(HotelPage.LocationValue, "10");
            HotelPage.YourName.SendKeys("VICIMEL MEDINA");
            HotelPage.YourEmail.SendKeys("TEST@TEST.COM");
            HotelPage.ReviewComments.SendKeys("Not so bad. Good Amenities");
            HotelPage.SubmitReviewButton.Click();
            //Thread.Sleep(2000);
            //Assert.AreEqual(HotelPage.ReviewValidation.Text, "Review Posted Successfully");
            //Thread.Sleep(10000);
        }

        [TestMethod]
        public void AddToWishlist()
        {
            HomePage.AccessHotels.Click();
            Thread.Sleep(8000);
            HotelPage.SelectHotelByName(driver, "Islamabad Marriott Hotel");
            Thread.Sleep(4000);
            HotelPage.AddWishlistButton.Click();
            Thread.Sleep(2000);
            driver.SwitchTo().Alert().Accept();
            Thread.Sleep(2000);
            HotelPage.AddWishlistButton.Click();
            Thread.Sleep(5000);
            driver.SwitchTo().Alert().Accept();
        }

        [TestCleanup]
        public void EndTest()
        {
            Thread.Sleep(5000);
            driver.Quit();
        }

    }
}
