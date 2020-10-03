using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FlipKartAzureTest.Pages
{
    public class Logout
    {
        IWebDriver driver;

        public Logout(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }


        [FindsBy(How = How.XPath, Using = "//img[@class='_1e_EAo']")]
        public IWebElement HomeButton;
        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'pushkar')]")]
        public IWebElement MyAccount;
        [FindsBy(How = How.XPath, Using = "//body/div[@id='container']/div/div/div/div/div[3]/div[1]/div[1]/div[1]")]
        public IWebElement DropdownButton;
        [FindsBy(How = How.XPath, Using = "//body//div[@id='container']//div//div//div//div//div//li[10]//a[1]")]
        public IWebElement LogoutButton;

        public void LogoutFromAccount()
        {
            Thread.Sleep(3000);
            HomeButton.Click();
            Thread.Sleep(5000);
            MyAccount.Click();
            Thread.Sleep(5000);
            DropdownButton.Click();
            Thread.Sleep(5000);
            LogoutButton.Click();

        }
    }
}
