using OpenQA.Selenium.Edge;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using System.Collections.ObjectModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Microsoft_ToDO
{
    [TestClass]
    public class TODO_Test1 : BaseClass
    {

        [TestInitialize]
        
        public void Setup()
        {
            base.BrowserLaunch();
        }

        [TestMethod,Priority(1)]
        public void loginTest1()
        {
            base.Login();
        }

        [TestMethod, Priority(2)]
        public void HmenuCollaps()
        {
            base.Login();

            driver.FindElement(By.XPath("//button[@class='menu']")).Click(); //closing hamburger menu
            Console.WriteLine("Clicked on Hamburger menu");
            try
            {
                IWebElement Sidemenu = driver.FindElement(By.XPath("//div[@class = 'sidebar']"));
                Assert.AreEqual(false, Sidemenu.Displayed); //verifying if menu is closed
            }
            catch {
                Console.WriteLine("Side Menu Closed");
            }

            driver.FindElement(By.XPath("//button[@class='menu']")).Click(); //opening hamburger menu again
            Thread.Sleep(2000);
            Console.WriteLine("Clicked on Hamburger menu");
            try
            {
                IWebElement Sidemenu = driver.FindElement(By.XPath("//div[@class = 'sidebar']"));
                Assert.AreEqual(true, Sidemenu.Displayed); //verifying if menu is opened
                Console.WriteLine("Side Menu Opened");
            }
            catch
            {
                Assert.Fail();
                Console.WriteLine("Side Menu not opened");
            }
        }

        [TestMethod, Priority(3)]
        public void AddTask()
        {
            base.Login();
            driver.FindElement(By.XPath("//input[@id='baseAddInput-addTask-today']")).SendKeys("Test1");
            driver.FindElement(By.XPath("//button[contains(text(),'Add')]")).Click();
        }

        [TestMethod, Priority(4)]
        public void NavEachTab()
        {
            base.Login();
            IWebElement Navbar = driver.FindElement(By.XPath("//ul[@role='listbox']"));
            IReadOnlyList<IWebElement> AllTabs = Navbar.FindElements(By.TagName("li"));
            Assert.AreEqual(5, AllTabs.Count);
            foreach (IWebElement tab in AllTabs)
            {
                tab.Click();
                Thread.Sleep(3000);
            }
            
        }

        [TestCleanup]
        public void Teardown()
        {
            driver.Quit();
        }
    }
}
