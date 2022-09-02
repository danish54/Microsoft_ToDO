using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Microsoft_ToDO.PageObject
{
    internal class DashboradPage : Helper.BaseClass
    {


        public DashboradPage(IWebDriver driver) 
        {
            this.driver = driver;
        }
        
        private IWebElement GetStarted_btn => driver.FindElement(By.XPath("//a[@id='actionButton']"));

        public LoginPage GetStarted()
        {
            GetStarted_btn.Click();
            return new LoginPage(driver);
        }
    }
    }
    

    

