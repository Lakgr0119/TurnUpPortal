using System;
using System.Text.RegularExpressions;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using TurnUpPortalCode.Pages;
using TurnUpPortalCode.Utilities;

namespace TurnUpPortalCode.StepDefinition
{
    [Binding]
    public class TmFeature1StepDefinitions : CommonDriver
    {
        [Given(@"I logged into turnup portal  successfully")]
        public void GivenILoggedIntoTurnupPortalSuccessfully()
        {

            driver = new ChromeDriver();
            Login loginObject = new Login();
            loginObject.loginActions(driver);
        }

        [When(@"I navigate to time and material  page")]
        public void WhenINavigateToTimeAndMaterialPage()
        {
            HomePage homePageObject = new HomePage();
            homePageObject.navigateToTmPage(driver);
        }

        [When(@"I create a time record")]
        public void WhenICreateATimeRecord()
        {
            TmPage tmPageObject = new TmPage();
            tmPageObject.createTimeRecord(driver);
        }

        [Then(@"the record should be created successfully]")]
        public void ThenTheRecordShouldBeCreatedSuccessfully()
        {
            TmPage tmPageObject = new TmPage();
            String newCode = tmPageObject.getCode(driver);
            Assert.That(newCode == "TypeText", "Actual code does not match with the expected");
            String newDescription = tmPageObject.getNewDescription(driver);
            Assert.That(newDescription == "Description Given", "Actual Description does not match with the expected");
            String newPrice = tmPageObject.getNewPrice(driver);
            Assert.That(newPrice == "12", "Actual price does not match with the expected");

        }
        [When(@"I update the '([^']*)' and '([^']*)'on an existing Time record")]
        public void WhenIUpdateTheAndOnAnExistingTimeRecord(string code, string description)
        {
            TmPage tmPageObject = new TmPage();
            tmPageObject.editTimeRecord(driver, code, description);
        }

        [Then(@"The record should  be updated '([^']*)' and '([^']*)'")]
        public void ThenTheRecordShouldBeUpdatedAnd(string code, string description)
        {
            TmPage tmPageObject = new TmPage();
            string editedCode = tmPageObject.getEditedCode(driver);
            string editedDescription = tmPageObject.getEditedDescription(driver);
            Assert.That(editedCode == code, "Expected Edited code and actual do not match");
            Assert.That(editedDescription == description, "Expected Edited description and actual do not match");
        }


    }
}