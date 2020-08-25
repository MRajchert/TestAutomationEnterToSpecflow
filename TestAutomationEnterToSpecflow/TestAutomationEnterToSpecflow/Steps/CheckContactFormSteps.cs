using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace TestAutomationEnterToSpecflow.Steps
{
    [Binding]
    public sealed class CheckContactFormSteps
    {
        private readonly ScenarioContext _scenarioContext;

        public CheckContactFormSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"I enter to ""(.*)"" page")]
        public void GivenIEnterToPage(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I click on ”Contact” in menu")]
        public void GivenIClickOnContactInMenu()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I fill contact form")]
        public void WhenIFillContactForm()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I expect to see message as „Message Sent \(go back\)”")]
        public void ThenIExpectToSeeMessageAs()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
