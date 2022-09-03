using Microsoft_ToDO.Helper;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft_ToDO.PageObject
{
    public class DashboardPage : HelperClass
    {
        public DashboardPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement MyDay => driver.FindElement(By.XPath("//h2[@class='listTitle']//*[text() = 'My Day']"));

        private IWebElement NavbarBox => driver.FindElement(By.XPath("//ul[@role='listbox']"));

        private IWebElement HamMenu => driver.FindElement(By.XPath("//button[@class='menu']"));

        private IWebElement Add_Task_Input => driver.FindElement(By.XPath("//input[@id='baseAddInput-addTask-today']"));

        private IWebElement AddTask_btn => driver.FindElement(By.XPath("//button[contains(text(),'Add')]"));
        //private IWebElement Sidemenu => driver.FindElement(By.XPath("//div[@class = 'sidebar']"));

        public Boolean VerifyLogin()
        {
            XPWait("//h2[@class='listTitle']//*[text() = 'My Day']");
            Boolean verifylogin = MyDay.Displayed;
            return verifylogin;
        }
        public IReadOnlyList<IWebElement> FetchAllTab()
        {
            this.ToDoPOM_Login();

            IReadOnlyList<IWebElement> AllTabs = NavbarBox.FindElements(By.TagName("li"));
            return AllTabs;
        }

        public void NavEachTab()
        {

            IReadOnlyList<IWebElement> AllTabs = this.FetchAllTab();
            foreach (IWebElement tab in AllTabs)
            {
                tab.Click();
                Thread.Sleep(1000);
            }
        }
        public void Click_Hammenu()
        {
            
            driver.FindElement(By.XPath("//button[@class='menu']")).Click();
        }
        public Boolean SideMenuVisibility()
        {
            try
            {
                IWebElement HamMenu = driver.FindElement(By.XPath("//div[@class = 'sidebar']"));
                Boolean sidemenu = HamMenu.Displayed;
                return sidemenu;
            }
            catch(Exception e)
            {
                return false;
            }
        }
        public void InputTask()
        {
            Thread.Sleep(4000);
            Add_Task_Input.SendKeys("Test1");
            AddTask_btn.Click();
        }
    }
}
