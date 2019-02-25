using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumFramework.Selenium
{
    public class Browser
    {
        
        public IWebDriver GetDriver()
        {
            return new ChromeDriver();
        }








    }
    }
