using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumFramework.Selenium
{
    public static class Browser
    {
        private static IWebDriver _driver;

        static Browser()
        {
            _driver = new ChromeDriver();
        }

        public static string Title
        {
            get => _driver.Title;
        }

        public static IWebDriver Driver => _driver;
        

        public static void GoTo(string url)
        {
            _driver.Navigate().GoToUrl(url);
            _driver.Manage().Window.Maximize();
        }

       public static void CloseBrowser()
        {
            _driver.Close();
        }
    }
}
