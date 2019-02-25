using System;
using System.Collections.Generic;
using System.Text;
using SeleniumFramework.Selenium;

namespace SeleniumFramework
{
    public static class Pages
    {
        public static class HomePage
        {
            private static string Url = "https://beteasy.com.au/sports-betting";
            private readonly static string PageTitle = "Test Something";


            public static void Goto()
            {
                Browser.GoTo(Url);
            }

            public static bool IsAt()
            {
                return Browser.Title == PageTitle;
            }
        }
    }


}
