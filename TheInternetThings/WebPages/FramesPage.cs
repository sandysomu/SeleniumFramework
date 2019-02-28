using OpenQA.Selenium;
using TheInternetThings.Selenium;

namespace TheInternetThings.WebPages
{
    public class FramesPage
    {
        public FramesPage()
        {
        }

        public void GoToNestedFrame()
        {
            Browser.Driver.FindElement(By.CssSelector(".example > ul:nth-child(2) > li:nth-child(1) > a:nth-child(1)")).Click();
        }

        public void GoToiFrame()
        {
            Browser.Driver.FindElement(By.CssSelector(".example > ul:nth-child(2) > li:nth-child(2) > a:nth-child(1)")).Click();
        }

        public void ReadDataFromFrame()
        {
            Browser.Driver.SwitchTo().Frame("mceu_13"); //html

            Browser.Driver.FindElement(By.CssSelector("#tinymce > p:nth-child(1)")).SendKeys("Nameshkaar ");


        }
    }
}