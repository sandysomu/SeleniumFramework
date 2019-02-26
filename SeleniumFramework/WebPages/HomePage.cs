using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumFramework.Selenium;

namespace SeleniumFramework.WebPages
{
    public class HomePage
    {
        private string Url = "https://www.ultimateqa.com/";
        private readonly string PageTitle = "Home - Ultimate QA";

        
        public void Goto()
        {
            Browser.GoTo(Url);
        }

        public void SelectExercisePage()
        {
           IWebElement exerciseLink = Browser.Driver.FindElement(By.CssSelector("#top-menu > li:nth-child(3) > a:nth-child(1)")); 
            exerciseLink.Click();
        }

        public bool IsAt()
        {
            return Browser.Title == PageTitle;
        }

        public bool IsAtExercisePage()
        {
            ExercisePage excersizePage = new ExercisePage();
            return excersizePage.heading == "Automation Practice";
        }



    }
}
