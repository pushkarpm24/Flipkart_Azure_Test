﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Configuration;
using System.Threading;

namespace FlipKartAzureTest.Pages
{
    public class Login
    {
        readonly string Email = ConfigurationManager.AppSettings["email"];
        readonly string Password = ConfigurationManager.AppSettings["password"];

        public IWebDriver driver;

        [System.Obsolete]
        public Login(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//input[@class='_2zrpKA _1dBPDZ']")]
        IWebElement email;

        [FindsBy(How = How.XPath, Using = "//input[@class='_2zrpKA _3v41xv _1dBPDZ']")]
        IWebElement password;

        [FindsBy(How = How.XPath, Using = "//button[@class='_2AkmmA _1LctnI _7UHT_c']//span[contains(text(),'Login')]")]
        IWebElement LoginBtn2;

        public void LoginPage()
        {
            Thread.Sleep(3000);
            email.SendKeys(Email);
            Thread.Sleep(2000);
            password.SendKeys(Password);
            Thread.Sleep(2000);
            LoginBtn2.Click();
            Thread.Sleep(3000);
        }
    }
}
