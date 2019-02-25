using System;
using Xunit;

namespace SeleniumFramework.Test
{
    public class UnitTest1
    {

   

        [Fact]
        public void Can_Go_To_HomePage()
        {

            Pages.HomePage.Goto();
            Assert.True(Pages.HomePage.IsAt());

        }
    }
}
