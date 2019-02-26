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
            Pages.HomePage.SelectAutomationExercisePage();
            Assert.True(Pages.HomePage.IsAtExercisePage());
        }


        public void Dispose()
        {
            Browser.CloseBrowser();
        }
    }
}
