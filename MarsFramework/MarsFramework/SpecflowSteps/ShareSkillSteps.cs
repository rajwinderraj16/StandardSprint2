using MarsFramework.Global;
using MarsFramework.Pages;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace MarsFramework.SpecflowSteps
{
    [Binding]
    public class ShareSkillSteps:Base
    {
        //Creating object of Shareskill class
         ShareSkill ss = new ShareSkill();

        [Given(@"I have clicked on the profile tab")]
        public void GivenIHaveClickedOnTheProfileTab()
        {
            //Initializing driver by calling method of Base class
            Thread.Sleep(2000);
            Base.Inititalize();
        }
        
        [Given(@"I click on the Share skill tab")]
        public void GivenIClickOnTheShareSkillTab()
        {
            //Click on the shareskill tab
            ss.Click_ShareskillTab();
        }
        
        [When(@"I enter the skill detail")]
        public void WhenIEnterTheSkillDetail()
        {
            //Enter all the detail about skill
            ss.Enter_ShareSkillDetail();
        }
        
        [Then(@"the skill should be added")]
        public void ThenTheSkillShouldBeAdded()
        {
            //Verification of the newly added skill
            ss.Confirm_shareskill();
        }
    }
}
