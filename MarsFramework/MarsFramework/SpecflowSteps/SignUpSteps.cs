using MarsFramework.Global;
using MarsFramework.Pages;
using System;
using TechTalk.SpecFlow;

namespace MarsFramework.SpecflowSteps
{
    [Binding]
    public class SignUpSteps:Base
    {
        SignUp Signup = new SignUp();

        [Given(@"I have launched the website")]
        public void GivenIHaveLaunchedTheWebsite()
        {
            Base.Inititalize();

        }
        
        [Given(@"I click on the Join button")]
        public void GivenIClickOnTheJoinButton()
        {
            //Click on the Join button to create account 
             Signup.ClickJoinBTN();
        }
        
        [When(@"I enter the required details")]
        public void WhenIEnterTheRequiredDetails()
        {
            //Enter username and passowrd
            //Signup.EnterDetails();
        }

        [Then(@"I click on the join button and I would be a regitered user")]
        public void ThenIClickOnTheJoinButtonAndIWouldBeARegiteredUser()
        {
           //Click on the join button to get registerd
          //Signup.Joinbtn();
        }
    }
}
