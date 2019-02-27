using System;
using SeleniumFramework.Selenium;
using SeleniumFramework.WebPages;
using Xunit;

namespace SeleniumFramework.Test
{
    public class SeleniumTests : IDisposable
    {

        [Fact]
        public void Can_Go_To_HomePage()
        {

            Pages.HomePage.Goto();
            Assert.True(Pages.HomePage.IsAt());
        }

        [Fact]
        public void AutomationExercisePage()
        {
            Pages.HomePage.Goto();
            Pages.HomePage.SelectExercisePage();
            Assert.True(Pages.HomePage.IsAtExercisePage());
        }

        [Fact]
        public void SubmitForm()
        {
            Pages.HomePage.Goto();
            Pages.HomePage.SelectExercisePage();
            Pages.ExercisePage.GoToFillForm();
            Pages.FillingOutForms.FillForm();
            Assert.True(Pages.ExercisePage.FormFilledSuccessfully());
        }


        [Theory]
        [InlineData("Title-Sandeep", "Message-Sandeep")]
        public void SubmitFormUsingData(string name, string message)
        {
            Pages.HomePage.Goto();
            Pages.HomePage.SelectExercisePage();
            Pages.ExercisePage.GoToFillForm();
            Pages.FillingOutForms.FillForm(name, message);
            Assert.True(Pages.ExercisePage.FormFilledSuccessfully());
        }


        public void Dispose()
        {
            Browser.CloseBrowser();
        }
    }
}
