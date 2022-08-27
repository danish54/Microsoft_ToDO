using OpenQA.Selenium.Edge;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.Events;

namespace Microsoft_ToDO
{
    internal class BaseClass
    {
        IWebDriver driver;
        String Base_url = "https://to-do.microsoft.com";
        String user_name = "smbtest89@gmail.com";
        String Pass = "08Apples";

        public void BrowserLaunch()
        {
            
            driver = new EdgeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            
        }
        public void Login()
        {
            driver.Navigate().GoToUrl(Base_url);

            driver.FindElement(By.XPath("//a[@id='actionButton']")).Click(); //get started
            driver.FindElement(By.XPath("//div[@id='otherTile']")).Click(); //Skipping V-id
            driver.FindElement(By.XPath("//input[@type='email']")).SendKeys(user_name); //entering user name
            driver.FindElement(By.XPath("//input[@type='submit']")).Click(); //clicking Next
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//input[@name='passwd']")).SendKeys(Pass); //entering passwrod
            driver.FindElement(By.XPath("//input[@type='submit']")).Click(); //clicking Next
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//input[@type='submit']")).Click(); //clicking Next
            Thread.Sleep(5000);
        }
    }
}
