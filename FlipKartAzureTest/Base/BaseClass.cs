﻿using NUnit.Framework;
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

        [TearDown]
        public void Close()
        {
            var filepath = $"{ TestContext.CurrentContext.TestDirectory}\\{TestContext.CurrentContext.Test.MethodName}.jpg";
            ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile(filepath);
            TestContext.AddTestAttachment(filepath, "Test Screenshots");
        }

            [OneTimeTearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
