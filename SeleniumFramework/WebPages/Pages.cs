using System;
using System.Collections.Generic;
using System.Text;
using SeleniumFramework.Selenium;

namespace SeleniumFramework.WebPages
{
    public static class Pages
    {
        public static HomePage HomePage => new HomePage();

        public static ExercisePage ExercisePage => new ExercisePage();

        public static FillingOutForms FillingOutForms => new FillingOutForms();
    }


}
