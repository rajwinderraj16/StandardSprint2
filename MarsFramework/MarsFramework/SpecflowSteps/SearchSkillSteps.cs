using MarsFramework.Global;
using MarsFramework.Pages;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace MarsFramework
{
    [Binding]
    public class SearchSkillSteps:Base
    {
        //Creating object of SearchSkill class
         SearchSkill Sk = new SearchSkill();

        [Given(@"I am on the profile tab")]
        public void GivenIAmOnTheProfileTab()
        {
            //Initializing driver by calling Base class method
            Thread.Sleep(2000);
            Base.Inititalize();

        }

        [Given(@"I entered the Automation in the search field")]
        public void GivenIEnteredTheAutomationInTheSearchField()
        {
            //Enter the skill to search
            Sk.Enter_searchkeyword();
        }


        [When(@"I click on the serach icon")]
        public void WhenIClickOnTheSerachIcon()
        {
            //Click on the search icon
            Sk.Click_searchicon();
        }

        [Then(@"the relavant result should be displayed")]
        public void ThenTheRelavantResultShouldBeDisplayed()
        {
            //Vefify the search result
            Sk.serachkey_result();
        }

        [Given(@"I click on the serach icon on the serach page")]
        public void GivenIClickOnTheSerachIconOnTheSerachPage()
        {
            //Click on the search icon to get on to the searh page
           
            Sk.searchicon();
        }

        [When(@"I entered the user's name in the user field")]
        public void WhenIEnteredTheUserSNameInTheUserField()
        {
            //Enter the user name
            Sk.search_users();
        }

        [Then(@"the relavant result should be displayed on the page")]
        public void ThenTheRelavantResultShouldBeDisplayedOnThePage()
        {
            //Verify the result
            Sk.Search_result();
        }
    }
}
