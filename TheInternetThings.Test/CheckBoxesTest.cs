using System;
using TheInternetThings.WebPages;
using Xunit;

namespace TheInternetThings.Test
{
    
    public class CheckBoxesTest : IDisposable
    {
        [Fact]
        public void Can_We_Open_HomePage()
        {
            Pages.HomePage.GoToCheckBoxPage();
            Assert.True(Pages.CheckBoxPage.IsAt());
        }

        [Fact]
        public void Can_Check_FirstBox()
        {
            BasicOperation();
            Pages.CheckBoxPage.CheckFirstBox();
            Assert.True(Pages.CheckBoxPage.IsFirstBoxChecked());
        }

        [Fact]
        public void Can_Check_SecondBox()
        {
            BasicOperation();
            Pages.CheckBoxPage.CheckSecondBox();
            Assert.True(Pages.CheckBoxPage.IsSecondBoxChecked());
        }

         

        public void BasicOperation()
        {
            Assert.True(Pages.HomePage.IsAt());
            Pages.HomePage.GoToCheckBoxPage();
        }


        public void Dispose()
        {
            Pages.HomePage.CloseBrowser();
        }


       
    }
}
