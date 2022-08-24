using OpenQA.Selenium;
using OpenQA.Selenium.Edge;

namespace Microsoft_ToDO
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //String user_name = "";
            //String Pass = "";
            String Base_url = "https://to-do.microsoft.com";

            IWebDriver driver;
            driver = new EdgeDriver(); 
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.Navigate().GoToUrl(Base_url);
        }
    }
}