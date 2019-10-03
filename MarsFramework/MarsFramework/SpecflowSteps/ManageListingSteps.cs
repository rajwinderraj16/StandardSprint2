using MarsFramework.Global;
using MarsFramework.Pages;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace MarsFramework
{
    [Binding]
    public class ManageListingSteps : Base
    {
        //Creating the object of ManageListing class
        ManageListing Mg = new ManageListing();
        
        [Given(@"I cliked on the ManageListing tab")]
        public void GivenIClikedOnTheManageListingTab()
        {
            //Initializing the driver by calling Base class method
            Thread.Sleep(2000);
            Base.Inititalize();
            Mg.Click_ManageListTab();
        }

        [When(@"I enter the new skill the skill")]
        public void WhenIEnterTheNewSkillTheSkill()
        {
            //Cclick on the edit button to edit the skill
            Mg.Edit_ManageList();
        }

        [Then(@"the skill should be edited")]
        public void ThenTheSkillShouldBeEdited()
        {
            //Confirm the edited skill
            Mg.Confirm_SkillAdd();
        }

       [When(@"I clicked on the delete button")]
        public void WhenIClickedOnTheDeleteButton()
        {
            //Click on the delete button to delete the skill
            Mg.Delete_ManageListing();
        }

        [Then(@"the skill should be deleted")]
        public void ThenTheSkillShouldBeDeleted()
        {
            //verfiy the deleted skill
            Mg.Assert_Delete();
        }
    }
}
