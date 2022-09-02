using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft_ToDO.PageObject
{
    public class LoginPage: Helper.BaseClass
    {
        
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement Input_Email => driver.FindElement(By.XPath("//input[@type='email']"));
        private IWebElement Next_btn => driver.FindElement(By.XPath("//input[@type='submit']"));

        public void Enter_Email()
        {
            Input_Email.SendKeys(user_name);
        }

        
        public LoginPassPage Click_Sbmt()
        {
            Next_btn.Click();
            return new LoginPassPage(driver);
        }
    }

    public class LoginPassPage : Helper.BaseClass
    {
        
        public LoginPassPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement Input_Pass => driver.FindElement(By.XPath("//input[@name='passwd']"));
        
        private IWebElement Next_btn2 => driver.FindElement(By.XPath("//input[@type='submit']"));

        public void Enter_Pass()
        {
            Input_Pass.SendKeys(Pass);
        }
        public void Click_Sbmt2()
        {
            Next_btn2.Click();

        }
    }
}
