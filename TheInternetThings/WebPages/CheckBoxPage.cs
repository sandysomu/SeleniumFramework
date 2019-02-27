using OpenQA.Selenium;
using TheInternetThings.Selenium;

namespace TheInternetThings.WebPages
{
    public class CheckBoxPage
    {
        private string _headingtext = ".example > h3:nth-child(1)";
        private string _1stCheckBox = "#checkboxes > input:nth-child(1)";
        private string _2ndCheckBox = "#checkboxes > input:nth-child(3)";

        public bool IsAt()
        {
           return Browser.Driver.FindElement(By.CssSelector(_headingtext)).Text == "Checkboxes";
        }

        public void CheckFirstBox()
        {
            if (!Browser.Driver.FindElement(By.CssSelector(_1stCheckBox)).Selected)
            {
                Browser.Driver.FindElement(By.CssSelector(_1stCheckBox)).Click();
            }
        }

        public bool IsFirstBoxChecked()
        {
            return Browser.Driver.FindElement(By.CssSelector(_1stCheckBox)).Selected;
        }

        public void CheckSecondBox()
        {
            if (!Browser.Driver.FindElement(By.CssSelector(_2ndCheckBox)).Selected)
            {
                Browser.Driver.FindElement(By.CssSelector(_2ndCheckBox)).Click();
            }
        }

        public bool IsSecondBoxChecked()
        {
            return Browser.Driver.FindElement(By.CssSelector(_2ndCheckBox)).Selected;
        }
    }
}