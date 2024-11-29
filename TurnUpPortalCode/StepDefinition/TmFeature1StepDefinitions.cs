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
        [When(@"I update the '([^']*)' on an existing Time record")]
        public void WhenIUpdateTheOnAnExistingTimeRecord(string code)
        {
            TmPage tmPageObject = new TmPage();
            tmPageObject.editTimeRecord(driver, code);
        }
         
        [Then(@"The record should  be updated '([^']*)'")]
        public void ThenTheRecordShouldBeUpdated(string code)
        {
            TmPage tmPageObject = new TmPage();
         String editedCode=  tmPageObject.getEditedCode(driver);
            Assert.That(editedCode == code, "Expected Edited code does not match with the actual");
            
        }

    }
}