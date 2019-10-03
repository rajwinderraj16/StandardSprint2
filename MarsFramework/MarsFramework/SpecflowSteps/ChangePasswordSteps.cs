using MarsFramework.Global;
using MarsFramework.Pages;
using System;
using TechTalk.SpecFlow;

namespace MarsFramework.SpecflowSteps
{
    [Binding]
    public class ChangePasswordSteps:Base
    {
        //Creating the object of the changepassword class
        ChangePassword ch = new ChangePassword();
        
        [Given(@"I have logged in my profile")]
        public void GivenIHaveLoggedInMyProfile()
        {
            //Initialize driver and login steps by calling method of Base class
            Base.Inititalize();
        }

        [Given(@"I add the new and current password")]
        public void GivenIAddTheNewAndCurrentPassword()
        {
           
        //Calling methods of Changepassword class to create new password
             ch.ClickOnDropdwon();
             ch.ClickOnChangePassword();
             ch.Enter_CurrentPassword();
             ch.Enter_NewPassword();
            
        }

        [When(@"I confirm password")]
        public void WhenIConfirmPassword()
        {
           
            //Enter the password again to confirm
             ch.Enter_ConfirmedPassword();

        }

        [Then(@"the new password should be added to my account")]
        public void ThenTheNewPasswordShouldBeAddedToMyAccount()
        {
            //Click on the save button
            ch.ClickOnSave();
        }
    }
}
