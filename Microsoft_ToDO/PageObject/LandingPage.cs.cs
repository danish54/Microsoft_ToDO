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
    internal class LandingPage : Helper.HelperClass
    {

        public LandingPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement GetStarted_btn => driver.FindElement(By.XPath("//a[@id='actionButton']"));

        public LoginPage GetStarted()
        {
            XPWait("//a[@id='actionButton']");
            GetStarted_btn.Click();
            return new LoginPage(driver);
        }
    }
}




