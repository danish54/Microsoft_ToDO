using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft_ToDO.PageObject
{
    public class LoginPage: Helper.HelperClass
    {

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement Input_Email => driver.FindElement(By.XPath("//input[@type='email']"));
        private IWebElement Next_btn => driver.FindElement(By.XPath("//input[@type='submit']"));

        //These are for LoginWhole
        private IWebElement Input_Pass => driver.FindElement(By.XPath("//input[@name='passwd']"));
        private IWebElement Next_btn2 => driver.FindElement(By.XPath("//input[@type='submit']"));
        private IWebElement GetStarted_btn => driver.FindElement(By.XPath("//a[@id='actionButton']"));

        public void Enter_Email()
        {
            
            Input_Email.SendKeys(user_name);
        }
        public void LoginWhole()
        {
            GetStarted_btn.Click();
            Input_Email.SendKeys(user_name);
            Next_btn.Click();
            Input_Pass.SendKeys(Pass);
            Thread.Sleep(2000);
            Next_btn2.Click();
        }
        
        public LoginPassPage Click_Sbmt()
        {
            Next_btn.Click();
            return new LoginPassPage(driver);
        }
    }

    public class LoginPassPage : Helper.HelperClass
    {
        
        public LoginPassPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement Input_Pass => driver.FindElement(By.XPath("//input[@name='passwd']"));
        
        private IWebElement Next_btn2 => driver.FindElement(By.XPath("//input[@type='submit']"));

        public void Enter_Pass()
        {
            XPWait("//input[@name='passwd']");
            Input_Pass.SendKeys(Pass);
        }
        public DashboardPage Click_Sbmt2()
        {
            Next_btn2.Click();
            Next_btn2.Click();
            return new DashboardPage(driver);

        }
        
    }
}
