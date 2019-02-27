using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TheInternetThings.Selenium
{
    public static class Browser
    {
        static Browser()
        {
            Driver = new ChromeDriver();
        }


        public static IWebDriver Driver { get; }

        public static string Title => Driver.Title;


        public static void GoToUrl(string url)
        {
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl(url);
        }

        public static void CloseWindow()
        {
            Driver.Close();
        }
    }
}
