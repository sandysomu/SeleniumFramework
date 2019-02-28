using System;
using System.Collections.Generic;
using System.Text;
using TheInternetThings.WebPages;
using Xunit;

namespace TheInternetThings.Test
{
    public class FramesTests
    {


        [Fact]
        public void Can_Read_Data_from_Frames()
        {
            Pages.HomePage.GoToFramesPage();
            Pages.FramesPage.GoToiFrame();
            Pages.FramesPage.ReadDataFromFrame();

        }

        


    }
}
