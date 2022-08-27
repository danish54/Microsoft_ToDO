using OpenQA.Selenium.Edge;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft_ToDO
{
    internal class TestUsingBaseClass : BaseClass
    {

        [TestInitialize]
        public void Setup()
        {
            base.BrowserLaunch();
            
        }

        [TestMethod]
        public void BloginTest1()
        {
            base.Login();
        }


        [TestCleanup]
        public void Teardown()
        {
            //driver.Quit();
        }
    }
}
