using MarsFramework.Global;
using MarsFramework.Pages;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace MarsFramework.SpecflowSteps
{
    [Binding]
    public class SearchByCategorySteps :Base
    {
        //Creating object of SearchByCategory class
        SearchByCategory Sc = new SearchByCategory();

        [Given(@"I am on the profile page")]
        public void GivenIAmOnTheProfilePage()
        {
            //Initialization of driver by calling Base class method
            Thread.Sleep(2000);
            Base.Inititalize();
            
        }
        
        [Given(@"I click on the serach icon")]
        public void GivenIClickOnTheSerachIcon()
        {
            //Enter the skill to search
            Sc.Enter_search();
        }
        
        [When(@"I select the category")]
        public void WhenISelectTheCategory()
        {
            //Enter the Category to serach
            Sc.select_category();
        }
        
        [Then(@"the selected category result should be displayed")]
        public void ThenTheSelectedCategoryResultShouldBeDisplayed()
        {
            //Capture the result
            Sc.Confirmsearchresult();
        }
    }
}
