using MarsFramework.Global;
using MarsFramework.Pages;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace MarsFramework.SpecflowSteps
{
    [Binding]
    public class AddProfileSteps:Base
    {

        Profile Pr = new Profile();
        
       [Given(@"I clicked on the  profile tab")]
        public void GivenIClickedOnTheProfileTab()
        {
            Thread.Sleep(2000);
            Base.Inititalize();
            
        }


        [When(@"I add the detail about availability,hours,salary and location")]
        public void WhenIAddTheDetailAboutAvailabilityHoursSalaryAndLocation()
        {
            Thread.Sleep(2000);
            Pr.EditProfile();
        }


        [Then(@"that details should be displayed on my page")]
        public void ThenThatDetailsShouldBeDisplayedOnMyPage()
        {
            Thread.Sleep(2000);
            Pr.Update();
        }




        [Given(@"I clicked on the Language tab under Profile page")]
        public void GivenIClickedOnTheLanguageTabUnderProfilePage()
        {
            Thread.Sleep(2000);
            Base.Inititalize();
            Pr.Click_Lang();
            
        }

        [When(@"I add new language")]
        public void WhenIAddNewLanguage()
        {
            
           Pr.Enter_LangDetail();
        }


        [Then(@"that language should be displayed on my page")]
        public void ThenThatLanguageShouldBeDisplayedOnMyPage()
        {
            Pr.Add_lang();
        }


      [Given(@"I clicked on the skill tab under Profile page")]
        public void GivenIClickedOnTheSkillTabUnderProfilePage()
        {
            Thread.Sleep(2000);
            Base.Inititalize();
            Pr.click_skillTab();
        }

        [When(@"I add new skill")]
        public void WhenIAddNewSkill()
        {
            Pr.Enter_skillDetail();
        }

        [Then(@"that skill should be displayed on my page")]
        public void ThenThatSkillShouldBeDisplayedOnMyPage()
        {
            Pr.Skill_Add();
        }


       [Given(@"I clicked on the education tab under Profile page")]
        public void GivenIClickedOnTheEducationTabUnderProfilePage()
        {
            Thread.Sleep(2000);
            Base.Inititalize();
            Pr.Click_EduTab();
        }

        [When(@"I add new education")]
        public void WhenIAddNewEducation()
        {
            Pr.Enter_EduDetail();
        }

        [Then(@"that educatiion should be displayed on my page")]
        public void ThenThatEducatiionShouldBeDisplayedOnMyPage()
        {
            Pr.Edu_add();
        }
        

        [Given(@"I clicked on the certification tab under Profile page")]
        public void GivenIClickedOnTheCertificationTabUnderProfilePage()
        {
            Thread.Sleep(2000);
            Base.Inititalize();
            Pr.Click_CertiTab();
        }



        [When(@"I add new certification")]
        public void WhenIAddNewCertification()
        {
            
            Pr.Enter_CertiDetail();
        }

        [Then(@"that certification should be displayed on my page")]
        public void ThenThatCertificationShouldBeDisplayedOnMyPage()
        {
            Pr.Certi_Add();
        }


       [Given(@"I clicked on the description icon under Profile page")]
        public void GivenIClickedOnTheDescriptionIconUnderProfilePage()
        {
            Thread.Sleep(2000);
            Base.Inititalize();
            Pr.Click_Desc();
        }
        
        
       [When(@"I add new description")]
        public void WhenIAddNewDescription()
        {
            Pr.Enter_DescDetails();
        }
        
        
       [Then(@"that description should be displayed on my page")]
        public void ThenThatDescriptionShouldBeDisplayedOnMyPage()
        {
            Pr.Desc_Add();
        }
    }
}
