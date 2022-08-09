using BoDi;
using SpecFlowEnterpriseTechTest.PageObjects;

namespace SpecFlowEnterpriseTechTest.StepDefinitions
{
    [Binding]
    public sealed class AutomateW3schoolHtmlStepDef
    {
        string url => "https://www.w3schools.com/html/html_tables.asp";
        W3schoolPage w3schoolPage;
        ScenarioContext scenarioContext;

        public AutomateW3schoolHtmlStepDef(IObjectContainer _container)
        {
            w3schoolPage = _container.Resolve<W3schoolPage>();
            scenarioContext = _container.Resolve<ScenarioContext>();
        }

       
        [Given(@"I am on w3schools.com")]
        public void GivenIAmOnWww_Wschools_Com()
        {
            w3schoolPage.NavigateToSite(url);
        }


        //[Given("the second number is (.*)")]
        //public void GivenTheSecondNumberIs(int number)
        //{
         
        //}

        //[When("the two numbers are added")]
        //public void WhenTheTwoNumbersAreAdded()
        //{
         
        //}

        //[Then("the result should be (.*)")]
        //public void ThenTheResultShouldBe(int result)
        //{
         
        //}
    }
}