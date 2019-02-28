using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TheInternetThings.Selenium;

namespace TheInternetThings.WebPages
{
    public class DropDownListPage
    {
        public void SelectFirstOption()
        {
            var selectedElement = new SelectElement(Browser.Driver.FindElement(By.CssSelector("#dropdown")));
            selectedElement.SelectByIndex(1);
        }

        public bool IsFirstOptionSelected()
        {
          return  new SelectElement(Browser.Driver.FindElement(By.CssSelector("#dropdown"))).SelectedOption.Text == "Option 1";
        }
    }
}