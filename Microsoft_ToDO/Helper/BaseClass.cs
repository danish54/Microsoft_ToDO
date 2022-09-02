using OpenQA.Selenium.Edge;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.Events;
using OpenQA.Selenium.Support.UI;

namespace Microsoft_ToDO.Helper
{
    public class BaseClass
    {
        public IWebDriver driver;
        string Base_url = "https://to-do.microsoft.com";
        string user_name = "smbtest89@gmail.com";
        string Pass = "08Apples";
        public WebDriverWait wait;
        public EdgeOptions options;
        public void BrowserLaunch()
        {
            options = new EdgeOptions();
            //options.AddArgument("disable-notifications");
            //options.AddArgument("disable-sync");
            options.AddArgument("-inprivate");
            driver = new EdgeDriver(options);
            driver.Manage().Window.Maximize();
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);



        }
        public void Login()
        {
            driver.Navigate().GoToUrl(Base_url); //navigating to url
            driver.FindElement(By.XPath("//a[@id='actionButton']")).Click(); //get started

            /* this.ExIWait("//div[@id='otherTile']"); //waiting for account picker
            driver.FindElement(By.XPath("//div[@id='otherTile']")).Click(); //Skipping V-id */

            driver.FindElement(By.XPath("//input[@type='email']")).SendKeys(user_name); //entering user name
            driver.FindElement(By.XPath("//input[@type='submit']")).Click(); //clicking Next
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//input[@name='passwd']")).SendKeys(Pass); //entering passwrod
            driver.FindElement(By.XPath("//input[@type='submit']")).Click(); //clicking Next
            driver.FindElement(By.XPath("//input[@type='submit']")).Click(); //clicking Next
            ExIWait("//h2[@class='listTitle']//*[text() = 'My Day']"); //waiting for title
            IWebElement MyDay = driver.FindElement(By.XPath("//h2[@class='listTitle']//*[text() = 'My Day']"));
            Assert.AreEqual(true, MyDay.Displayed);
            Console.WriteLine("Login Successful!");
        }


        public void ExIWait(string Xpath)
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(c => c.FindElement(By.XPath(Xpath)));
        }
    }
}
