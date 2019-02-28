using System;
using System.Collections.Generic;
using System.Text;
using TheInternetThings.WebPages;
using Xunit;

namespace TheInternetThings.Test
{
    public class AlertTests
    {
        [Fact]
        public void ClickForAlert()
        {
            Pages.HomePage.GoToAlertPage();
            Pages.AlertsPage.ClickForJSalert();

        }
    }
}
