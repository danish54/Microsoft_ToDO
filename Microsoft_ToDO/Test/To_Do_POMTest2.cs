using Microsoft_ToDO.PageObject;

namespace Microsoft_ToDO.Test
{
    [TestClass]
    public class To_Do_POMTest2 : Helper.HelperClass

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
        public void SwitchToTabs()
        {
           
            var _navalltab = new DashboardPage(driver);
            _navalltab.NavEachTab();
        }

        [TestMethod]
        public void LoginTest()
        {
            Boolean logvrfy = base.ToDoPOM_Login();
            Assert.IsTrue(logvrfy);
        }

        [TestMethod]
        public void LoginWhole()
        {
            var _getstarted = new LoginPage(driver);
           
        }
        [TestMethod]
        public void HmenuCollaps()
        {
            LoginTest();

            var _hammenu = new DashboardPage(driver);
            _hammenu.Click_Hammenu();
            Boolean _sidemenuvisibilty = _hammenu.SideMenuVisibility();

            Console.WriteLine("Menu Visibility = "+ _sidemenuvisibilty);
            
            Assert.IsFalse(_sidemenuvisibilty);
            Console.WriteLine("HamBurger Menu Closed");

            _hammenu.Click_Hammenu();
            Boolean _sidemenuvisibilty2 = _hammenu.SideMenuVisibility();
            Console.WriteLine("Menu Visibility during Open FInal = " + _sidemenuvisibilty2);

            Assert.IsTrue(_sidemenuvisibilty2);
            Console.WriteLine("HamBurger Menu Opned again");
        }
        [TestMethod]
        public void AddTask()
        {
            LoginTest();
            var _addTask = new DashboardPage(driver);
            _addTask.InputTask();
        }
    }
}
