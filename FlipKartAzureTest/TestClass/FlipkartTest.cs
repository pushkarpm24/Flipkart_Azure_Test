﻿using FlipKartAzureTest.Base;
using FlipKartAzureTest.Pages;
using NUnit.Framework;

namespace FlipKartAzureTest
{
    public class FlipkartTest: BaseClass
    {
        [Test, Order(0)]
        public void LoginTest()
        {
            Login login = new Login(driver);
            login.LoginPage();
        }

        [Test, Order(1)]
        public void SearchProductTest()
        {
            Home home = new Home(driver);
            home.SelectProduct();
        }
    }
}
