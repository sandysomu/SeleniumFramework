using OpenQA.Selenium;
using SeleniumFramework.Selenium;

namespace SeleniumFramework.WebPages
{
    public class ExercisePage
    {
        public string heading => Browser.Driver.FindElement(By.CssSelector(".et_pb_module_header")).Text;


        public void GoToFillForm()
        {
            GoToFillOutForms();
        }

        private void GoToFillOutForms()
        {
            
            Browser.Driver.FindElement(By.CssSelector(".et_pb_text_inner > ul:nth-child(2) > li:nth-child(4) > a:nth-child(1)")).Click();
        }

        public bool FormFilledSuccessfully()
        {

            FillingOutForms form = new FillingOutForms();

            return form.ComfirmationText == "Form filled out successfully";
        }
    }

}