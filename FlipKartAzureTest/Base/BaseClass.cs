using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace FlipKartAzureTest.Base
{
    public class BaseClass
    {
        public IWebDriver driver;

        [OneTimeSetUp]
        public void Setup()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("start-maximized", "--disable-notifications");
            driver = new ChromeDriver(options);
            driver.Url = "https://www.flipkart.com/";
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
