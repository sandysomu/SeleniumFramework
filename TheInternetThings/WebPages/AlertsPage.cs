using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using TheInternetThings.Selenium;

namespace TheInternetThings.WebPages
{
    public class AlertsPage
    {


        public void ClickForJSalert()
        {
            Browser.Driver.FindElement(By.CssSelector(".example > ul:nth-child(3) > li:nth-child(1) > button:nth-child(1)")).Click();

            Browser.Driver.SwitchTo().Alert();

            var test = Browser.Driver.SwitchTo().Alert().Text;

            Browser.Driver.SwitchTo().Alert().Accept();
        }
    }
}
