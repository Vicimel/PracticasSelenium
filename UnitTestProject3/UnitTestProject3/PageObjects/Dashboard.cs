using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace UnitTestProject3.PageObjects
{
    public class Dashboard
    {

        [FindsBy(How = How.XPath, Using = "(//a[@title = 'Hotels'])[1]")]
        public IWebElement AccessHotels { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@title = 'Travelstart']")]
        public IWebElement AccessFlights { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@title= 'Tours']")]
        public IWebElement AccessTours { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@title= 'Cars']")]
        public IWebElement AccessCars { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@title= 'Offers']")]
        public IWebElement AccessOffers { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@title= 'Ivisa']")]
        public IWebElement AccessVisa { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@title= 'Blog']")]
        public IWebElement AccessBlog { get; set; }


    }
}
