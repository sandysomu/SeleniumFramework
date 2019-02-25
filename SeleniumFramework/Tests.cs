using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Xunit;

namespace SeleniumFramework
{
    public class Tests : IDisposable
    {
        public IWebDriver driver;

        public Tests()
        {
            try
            {
                driver = new ChromeDriver();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception while starting Browser " + e.InnerException);
            }
        }


        [Fact]
        public void ValidateTitle()
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://beteasy.com.au/sports-betting");
            Assert.Equal("Sports Betting & Odds Online | BetEasy", driver.Title);
        }




        public void Dispose()
        {
            driver.Quit();
        }


    }
}
