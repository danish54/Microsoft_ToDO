using OpenQA.Selenium;
using OpenQA.Selenium.Edge;

namespace Microsoft_ToDO
{
    [TestClass]
    public class UnitTest1
    {
        IWebDriver driver;
        String Base_url = "https://to-do.microsoft.com";
        String user_name = "smbtest89@gmail.com";
        String Pass = "08Apples";

        [TestInitialize]
        public void Setup()
        {
            driver = new EdgeDriver(); 
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.Navigate().GoToUrl(Base_url);
        }
        [TestMethod]
        public void login()
        {
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


        [TestCleanup]
        public void Teardown()
        {
            //driver.Quit();
        }
    }

}