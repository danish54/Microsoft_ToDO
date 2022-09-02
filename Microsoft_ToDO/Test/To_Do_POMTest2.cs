using Microsoft_ToDO.PageObject;

namespace Microsoft_ToDO.Test
{
    [TestClass]
    internal class To_Do_POMTest2 : Helper.BaseClass
    {
        [TestInitialize]
        public void Setup()
        {
            base.BrowserLaunch();
        }

        [TestMethod, Priority(5)]
        public void loginTest2()
        {
            var _getstarted = new DashboradPage(driver);
            var _loginpage = _getstarted.GetStarted();
            _loginpage.Email();


        }

        [TestCleanup]
        public void Teardown()
        {
            driver.Quit();
        }
    }
}
