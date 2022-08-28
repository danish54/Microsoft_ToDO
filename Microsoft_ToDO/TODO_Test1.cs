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



        }


        [TestCleanup]
        public void Teardown()
        {
            driver.Quit();
        }
    }
}
