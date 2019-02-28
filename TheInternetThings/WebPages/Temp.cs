using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using TheInternetThings.Selenium;

namespace TheInternetThings.WebPages
{
    public  class Temp
    {
        static Temp()
        {
            Browser.GoToUrl("https://www.toolsqa.com/iframe-practice-page/");
        }


        public  void IframeTesting()
        {
            Browser.Driver.SwitchTo().Frame("iframe1");
            var test = Browser.Driver.FindElement(By.CssSelector("div.control-group:nth-child(35) > strong:nth-child(1)")).Text;
        }


    }
}
