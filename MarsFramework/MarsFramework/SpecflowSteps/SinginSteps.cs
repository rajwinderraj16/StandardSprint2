using MarsFramework.Global;
using MarsFramework.Pages;
using SeleniumExtras.PageObjects;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace MarsFramework
{
    [Binding]
    public class SinginSteps : Base
    {

         SignIn sg = new SignIn();

        [Given(@"I launched the Skillswappro website")]
        public void GivenILaunchedTheSkillswapproWebsite()
        {
            //Initializing the driver
            Base.Inititalize();

        }
        
       [Given(@"I clicked on the signin tab")]
        public void GivenIClickedOnTheSigninTab()
        {
            //click on signin tab by calling method
            sg.clickOnSignintab();
        }

        [When(@"I entered username,password")]
        public void WhenIEnteredUsernamePassword()
        {
            //Enter username and password by calling method
            sg.EnterUsernamePassword();

        }



        [Then(@"I click on the signin button should be redireted to my homepage")]
        public void ThenIClickOnTheSigninButtonShouldBeRediretedToMyHomepage()
        {
            //click on login button by calling method
            Thread.Sleep(2000);
           sg.ClickLoginButton();
        }
        
    }
}
