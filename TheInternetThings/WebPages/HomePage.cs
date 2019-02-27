using System;
using System.IO.Compression;
using OpenQA.Selenium;
using TheInternetThings.Selenium;

namespace TheInternetThings.WebPages
{
    public class HomePage
    {
        private static string url = "http://the-internet.herokuapp.com/";
        private static string title = "The Internet";


        public void GoTo()
        {
            Browser.GoToUrl(url);
        }

        public bool IsAt()
        {
            return Browser.Title == title;
        }

        public void GoToCheckBoxPage()
        {
            Browser.Driver.FindElement(By.CssSelector("#content > ul:nth-child(4) > li:nth-child(5) > a:nth-child(1)")).Click();
        }

        public void GoToDropDownListPage()
        {
            Browser.Driver.FindElement(By.CssSelector("#content > ul:nth-child(4) > li:nth-child(9) > a:nth-child(1)")).Click();
        }

        public void CloseBrowser()
        {
            Browser.CloseWindow();
        }
    }
}