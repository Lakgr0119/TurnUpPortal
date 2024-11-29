using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using TurnUpPortalCode.Pages;
using TurnUpPortalCode.Utilities;

namespace TurnUpPortalCode.Tests
{
    [TestFixture]
   public class TmTests: CommonDriver
    {
     [SetUp]
        public void SetupSteps()
        {
            driver = new ChromeDriver();
            Login loginObject = new Login();
            loginObject.loginActions(driver);
            HomePage homePageObject = new HomePage();
            homePageObject.navigateToTmPage(driver);
        }
        [Test]
        public void createTimeTest()
        {
            TmPage tmPageObject = new TmPage();
            tmPageObject.createTimeRecord(driver);
        }
        [Test]
        public void updateTimeTest()
        {
            TmPage tmPageObject = new TmPage();
            tmPageObject.editTimeRecord(driver,"");
        }
        [Test]
        public void deleteTimeTest()
        {
            TmPage tmPageObject = new TmPage();
            tmPageObject.deletTimeRecord(driver);
        }
        [TearDown]
        public void closeTestRun()
        {
            driver.Quit();
        }
    }
}
