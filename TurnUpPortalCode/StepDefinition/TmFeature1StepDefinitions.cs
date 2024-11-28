using System;
using TechTalk.SpecFlow;

namespace TurnUpPortalCode
{
    [Binding]
    public class TmFeature1StepDefinitions
    {
        [When(@"I navigate to time and material  page")]
        public void WhenINavigateToTimeAndMaterialPage()
        {
            throw new PendingStepException();
        }

        [When(@"I create a time record")]
        public void WhenICreateATimeRecord()
        {
            throw new PendingStepException();
        }

        [Then(@"the record should be created successfully]")]
        public void ThenTheRecordShouldBeCreatedSuccessfully()
        {
            throw new PendingStepException();
        }
    }
}
