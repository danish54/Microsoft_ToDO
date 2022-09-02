using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft_ToDO.PageObject
{
    internal class LoginPage: Helper.BaseClass
    {
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement Input_Email => driver.FindElement(By.XPath("//input[@type='email']"));

        public void Email()
        {
            Input_Email.Click();

        }

    }
}
