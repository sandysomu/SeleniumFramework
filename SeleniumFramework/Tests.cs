using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumFramework.Selenium;
using Xunit;

namespace SeleniumFramework
{
    public class Tests 
    {
        readonly Browser _browse = new Browser();
        private readonly IWebDriver _driver;

        public Tests()
        {
            _driver = _browse.GetDriver();
        }
        

        [Fact]
        public void ValidateTitle()
        {
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl("https://beteasy.com.au/sports-betting");
            Assert.Equal("Sports Betting & Odds Online | BetEasy", _driver.Title);
        }






    }
}
