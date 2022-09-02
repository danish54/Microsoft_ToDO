using Microsoft_ToDO.PageObject;

namespace Microsoft_ToDO.Test
{
    [TestClass]
    public class To_Do_POMTest2 : Helper.BaseClass
    {
        [TestInitialize]
        public void Setup()
        {
            base.BrowserLaunch();
        }

        [TestCleanup]
        public void Teardown()
        {
            driver.Quit();
        }

        [TestMethod]
        public void LoginTest2()
        {
            var _getstarted = new DashboradPage(driver);
            var _loginpage = _getstarted.GetStarted();
            _loginpage.Enter_Email();
            var _loginPassPage = _loginpage.Click_Sbmt();
            Thread.Sleep(1000);
            _loginPassPage.Enter_Pass();
            _loginPassPage.Click_Sbmt2();
        }

        [TestMethod]
        public void SwitchTabs()
        {

        }
        
    }
}
