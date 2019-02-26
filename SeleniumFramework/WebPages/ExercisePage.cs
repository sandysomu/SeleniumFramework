using OpenQA.Selenium;
using SeleniumFramework.Selenium;

namespace SeleniumFramework.WebPages
{
    public class ExercisePage
    {
        public string heading => Browser.Driver.FindElement(By.CssSelector(".et_pb_module_header")).Text;
    }

}