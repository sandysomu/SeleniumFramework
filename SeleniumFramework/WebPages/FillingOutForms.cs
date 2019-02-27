using OpenQA.Selenium;
using SeleniumFramework.Selenium;

namespace SeleniumFramework.WebPages
{
    public class FillingOutForms
    {
        

        public string ComfirmationText {
            get
            {
                new WebPageHelper().WaitUntilElementVisible(By.CssSelector("#et_pb_contact_form_0 > div:nth-child(1) > p:nth-child(1)"));
                return Browser.Driver
                    .FindElement(By.CssSelector("#et_pb_contact_form_0 > div:nth-child(1) > p:nth-child(1)")).Text;
            }
        }

    
        public void FillForm()
        {
            Browser.Driver.FindElement(By.CssSelector("#et_pb_contact_name_0")).SendKeys("Name - Sandeep Singh");
            Browser.Driver.FindElement(By.CssSelector("#et_pb_contact_message_0")).SendKeys("Message - This message has been inserted by automation script.");
            Browser.Driver.FindElement(By.CssSelector("button.et_pb_contact_submit:nth-child(1)")).Click();
        }
    }
}