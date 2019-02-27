
using TheInternetThings.WebPages;
using Xunit;

namespace TheInternetThings.Test
{
    public class DropDownTests
    {

        [Fact]
        public void Can_We_Open_HomePage()
        {
            Pages.HomePage.GoTo();
            Assert.True(Pages.HomePage.IsAt());
            Pages.HomePage.GoToCheckBoxPage();
            Assert.True(Pages.CheckBoxPage.IsAt());
        }

        [Fact]
        public void Can_We_Pick_FirstOptione()
        {
            Pages.HomePage.GoTo();
            Assert.True(Pages.HomePage.IsAt());
            Pages.HomePage.GoToDropDownListPage();
            Pages.DropDownListPage.SelectFirstOption();
        }





    }
}
