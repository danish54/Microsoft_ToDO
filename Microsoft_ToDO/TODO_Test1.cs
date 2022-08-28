using OpenQA.Selenium.Edge;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

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

        [TestMethod]
        public void loginTest1()
        {
            base.Login();

            Func<IWebDriver, bool> waitForElement = new Func<IWebDriver, bool>((IWebDriver Web) =>
            {
                Console.WriteLine(Web.FindElement(By.XPath("//h2[@class='listTitle']//*[text() = 'My Day']")).GetAttribute("innerHTML"));
                return true;
            });
            wait.Until(waitForElement);

            IWebElement MyDay = driver.FindElement(By.XPath("//h2[@class='listTitle']//*[text() = 'My Day']"));
            Assert.AreEqual(true, MyDay.Displayed);
            Console.WriteLine("My DAY Displayed!");

        }
        [TestMethod]
        public void HmenuCollaps()
        {
            base.Login();
            

            base.ExWait("//h2[@class='listTitle']//*[text() = 'My Day']"); //waiting for title
            IWebElement MyDay = driver.FindElement(By.XPath("//h2[@class='listTitle']//*[text() = 'My Day']"));
            Assert.AreEqual(true, MyDay.Displayed); //validating login

            Console.WriteLine("My DAY Displayed!");
            Console.WriteLine("login successfull!");

            driver.FindElement(By.XPath("//button[@class='menu']")).Click(); //closing on hamburger menu
            Console.WriteLine("Clicked on Hamburger menu");
            try
            {
                IWebElement Sidemenu = driver.FindElement(By.XPath("//div[@class = 'sidebar']"));
                Assert.AreEqual(false, Sidemenu.Displayed); //verifying if menu is closed
            }
            catch {
                Console.WriteLine("Side Menu Closed");
            }

            driver.FindElement(By.XPath("//button[@class='menu']")).Click(); //opening on hamburger menu
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

            [TestCleanup]
        public void Teardown()
        {
            driver.Quit();
        }
    }
}
