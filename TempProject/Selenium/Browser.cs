using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TempProject.Selenium
{
    public static class Browser
    {

        static readonly IWebDriver _driver = new ChromeDriver();

        public static IWebDriver Driver => _driver;


        public static void GoTo(string url)
        {
            _driver.Navigate().GoToUrl(url);
        }
    }
}
