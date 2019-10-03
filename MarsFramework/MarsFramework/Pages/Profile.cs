
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.PageObjects;

using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Support.UI;
using RelevantCodes.ExtentReports;

using System.Collections.Generic;
using System.Threading;
using MarsFramework.Global;
using System;

namespace MarsFramework.Pages
{
    public class Profile : Base
    {

        #region Initilization of web elements with lambda expression


        //Click on Edit button
        IWebElement ProfileEdit => GlobalDefinitions.driver.FindElement(By.XPath("//div[@class='extra content']//div[2]//i[@class='right floated outline small write icon']"));

        //Click on Availability Time dropdown
        IWebElement AvailabilityTime => GlobalDefinitions.driver.FindElement(By.XPath("//select[@name='availabiltyType']"));


        //Click on Availability Time option
        IWebElement AvailabilityTimeOpt => GlobalDefinitions.driver.FindElement(By.XPath("//select[@class='ui right labeled dropdown']//option"));


        //Click on Availability Hour dropdown
        IWebElement AvailabilityHour => GlobalDefinitions.driver.FindElement(By.XPath("//div[@class='extra content']//div[3]//div[1]//i[@class='right floated outline small write icon']"));


        //Click on Availability Hour dropdown
        IWebElement AvailabilityHourss => GlobalDefinitions.driver.FindElement(By.XPath("//select[@name='availabiltyHour']//option[contains(text(),'Less than 30hours a week')]"));


        //Click on salary  dropdown
        IWebElement Salary => GlobalDefinitions.driver.FindElement(By.XPath("//div[@class='four wide column']//div[4]//div[1]//i[@class='right floated outline small write icon']"));


        //Select the salary option
        IWebElement SalaryOpt => GlobalDefinitions.driver.FindElement(By.XPath("//select[@name='availabiltyTarget']//option[3]"));

        //Click on Location
        IWebElement Location => GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[2]/div/div[2]/div"));

        //Choose Location
        IWebElement LocationOpt => GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[2]/div/div[2]/div/div[2]"));


        //Click on City
        IWebElement City => GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[2]/div/div[3]/div"));

        //Choose City
        IWebElement CityOpt => GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[2]/div/div[3]/div/div[2]"));

        //Click on Add new to add new Language
        IWebElement AddNewLangBtn => GlobalDefinitions.driver.FindElement(By.XPath("//div[contains(text(),'Add New')][1]"));


        //Enter the Language on text box
        IWebElement AddLangText => GlobalDefinitions.driver.FindElement(By.XPath("//input[@placeholder='Add Language']"));


        //Click on the Language Level fron the dropdown
        IWebElement ChooseLang => GlobalDefinitions.driver.FindElement(By.XPath("//select[@name='level']"));


        //Select Language from the dropdown
        IWebElement ChooseLangOpt => GlobalDefinitions.driver.FindElement(By.XPath("//select[@name='level']//option[contains(text(),'Fluent')]"));


        //Add Language
        IWebElement AddLang => GlobalDefinitions.driver.FindElement(By.XPath("//input[@class='ui teal button']"));


        //Click on the skill tab
        IWebElement AddNewSkillBtn => GlobalDefinitions.driver.FindElement(By.XPath("//a[contains(text(),'Skills')]"));


        //Click on the add new button to add skill
        IWebElement SkillButton => GlobalDefinitions.driver.FindElement(By.XPath("//div[@class='ui teal button']"));


        //Enter the new skill
        IWebElement EnterSkill => GlobalDefinitions.driver.FindElement(By.XPath("//input[@placeholder='Add Skill']"));


        //Click on skill level dropdown
        IWebElement ChooseSkill => GlobalDefinitions.driver.FindElement(By.XPath("//select[@name='level']"));


        //Choose the skill level option
        IWebElement ChooseSkilllevel => GlobalDefinitions.driver.FindElement(By.XPath("//select[@name='level']//option[contains(text(),'Beginner')]"));


        //Add Skill
        IWebElement Add_skill => GlobalDefinitions.driver.FindElement(By.XPath("//input[contains(@class,'ui teal button')]"));


        //Click on Educaiton tab
        IWebElement EducationTab => GlobalDefinitions.driver.FindElement(By.XPath("//a[@class='item'][contains(text(),'Education')]"));

        //Click on Add New  Educaiton button
        IWebElement Educationbutton => GlobalDefinitions.driver.FindElement(By.XPath("//table[@class='ui fixed table']//th[6]//div[contains(@class,'ui teal button')]"));


        //Enter university in the text box
        IWebElement EnterUniversity => GlobalDefinitions.driver.FindElement(By.XPath("//input[@placeholder='College/University Name']"));


        //Click on the Choose country dropdown
        IWebElement ChooseCountry => GlobalDefinitions.driver.FindElement(By.XPath("//select[@name='country']"));

        //Choose the country
        IWebElement ChooseCountryOpt => GlobalDefinitions.driver.FindElement(By.XPath("//select[@name='country']//option[contains(text(),'Austria')]"));


        //Click on Title dropdown
        IWebElement ChooseTitle => GlobalDefinitions.driver.FindElement(By.XPath("//select[@name='title']"));


        //Choose title
        IWebElement ChooseTitleOpt => GlobalDefinitions.driver.FindElement(By.XPath("//select[@name='title']//option[contains(text(),'BFA')]"));


        //Degree
        IWebElement Degree => GlobalDefinitions.driver.FindElement(By.XPath("//input[@placeholder='Degree']"));


        //Year of graduation
        IWebElement DegreeYear => GlobalDefinitions.driver.FindElement(By.XPath("//select[@name='yearOfGraduation']"));


        //Choose Year
        IWebElement DegreeYearOpt => GlobalDefinitions.driver.FindElement(By.XPath("//select[@name='yearOfGraduation']//option[contains(text(),'2018')]"));


        //Click on Add
        IWebElement AddEdu => GlobalDefinitions.driver.FindElement(By.XPath(" /html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/div[1]/div[3]/div[1]/input[1]"));

        //Click on the Certification tab
        IWebElement AddNewCertiTab => GlobalDefinitions.driver.FindElement(By.XPath("//a[contains(text(),'Certifications')]"));


        IWebElement AddNewCertibtn => GlobalDefinitions.driver.FindElement(By.XPath("//div[@class='ui bottom attached tab segment tooltip-target active']//div[contains(@class,'ui teal button')][contains(text(),'Add New')]"));

        IWebElement EnterCerti => GlobalDefinitions.driver.FindElement(By.XPath("//input[@placeholder='Certificate or Award']"));

        //Certified from
        IWebElement CertiFrom => GlobalDefinitions.driver.FindElement(By.XPath("//input[@placeholder='Certified From (e.g. Adobe)']"));

        //Year
        IWebElement CertiYear => GlobalDefinitions.driver.FindElement(By.XPath(" //select[@name='certificationYear']"));

        //Choose Opt from Year
        IWebElement CertiYearOpt => GlobalDefinitions.driver.FindElement(By.XPath("//select[@name='certificationYear']//option[contains(text(),'2017')]"));

        //Add Ceritification
        IWebElement AddCerti => GlobalDefinitions.driver.FindElement(By.XPath("//div[@class='five wide field']//input[contains(@class,'ui teal button')]"));

        //To Add desctiption click on the write icon
        IWebElement DescriptionIcon => GlobalDefinitions.driver.FindElement(By.XPath("//h3[@class='ui dividing header']//i[@class='outline write icon']"));
        
        //To Add description click on the write icon
        IWebElement Description => GlobalDefinitions.driver.FindElement(By.XPath("//textarea[@placeholder='Please tell us about any hobbies, additional expertise, or anything else you’d like to add.']"));

        //Click on Save Button
        IWebElement Save => GlobalDefinitions.driver.FindElement(By.XPath("//div[@class='ui twelve wide column']//button[@class='ui teal button'][contains(text(),'Save')]"));

        //Availability Updated
        IWebElement AvailabilityUpdate => GlobalDefinitions.driver.FindElement(By.XPath("//div[@class='ns-box-inner'][Contains(text(),'Availability updated')]"));

     public void EditProfile()
        {
            #region Availability
            //Populate the Excel Sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Profile");
            Thread.Sleep(1000);

            //Click on Edit button
            ProfileEdit.Click();

            //Availability Type button
            Thread.Sleep(1500);
            Actions action = new Actions(GlobalDefinitions.driver);
            action.MoveToElement(AvailabilityTime).Build().Perform();

            //Availability type options
            Thread.Sleep(1000);
            IList<IWebElement> AvailableTime = AvailabilityTimeOpt.FindElements(By.TagName("div"));
            int count = AvailableTime.Count;
            for (int i = 0; i < count; i++)
            {
                if (AvailableTime[i].Text == GlobalDefinitions.ExcelLib.ReadData(2, "AvailableTime"))
                {
                    AvailableTime[i].Click();
                    Base.test.Log(LogStatus.Info, "Select the available time");

                }
            }

            //Availability Hours
            AvailabilityHour.Click();
            //Availability Hours option
            AvailabilityHourss.Click();

            //Salary 
            Thread.Sleep(2000);
            Salary.Click();

            //Choose the option from salary dropdown
            Thread.Sleep(2000);
            SalaryOpt.Click();

            //Choose Location
            Thread.Sleep(1000);
            action.MoveToElement(Location).Build().Perform();
            Thread.Sleep(1000);
            IList<IWebElement> LocCountry = LocationOpt.FindElements(By.TagName("div"));
            int countrycount = LocCountry.Count;
            for (int i = 0; i < countrycount; i++)
            {
                if (LocCountry[i].Text == GlobalDefinitions.ExcelLib.ReadData(2, "Country"))
                {
                    LocCountry[i].Click();
                    Base.test.Log(LogStatus.Info, "Selected Country");
                }
            }

            //Choose City
            Thread.Sleep(1000);
            action.MoveToElement(City).Build().Perform();
            Thread.Sleep(1000);
            IList<IWebElement> LocCity = CityOpt.FindElements(By.TagName("div"));
            int citycount = LocCity.Count;
            for (int i = 0; i < citycount; i++)
            {
                if (LocCity[i].Text == GlobalDefinitions.ExcelLib.ReadData(2, "City"))
                {
                    LocCity[i].Click();
                    Base.test.Log(LogStatus.Info, "Selected City");
                }
            }
        }

        public void Update()
        {
            //Verification
            string ExpectedText = "Availability updated";

            if (ExpectedText == "Availability updated")
            {
                Console.WriteLine("Profile Deatils has been Updated");
            }

            else
            {
                Console.WriteLine("Profile Deatils has not been Updated");
            }
        }
        #endregion Avialability

        #region language
        //Add Language Function
        public void Click_Lang()
        {
            try
            {
                //Click on Add New Language button
                Thread.Sleep(2000);
                AddNewLangBtn.Click();

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public void Enter_LangDetail()
        {

            //Populate the Excel Sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Profile");

            //Enter the Language
            Thread.Sleep(2000);
            AddLangText.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Language"));

            //Choose Lang
            ChooseLang.Click();
            Thread.Sleep(2000);

            //Choose lang option
            Thread.Sleep(2000);
            ChooseLangOpt.Click();


        }
        public void Add_lang()
        {
            //Click on Add language button
            AddLang.Click();
            Base.test.Log(LogStatus.Info, "Added Language successfully");
        }


        #endregion language

        #region Skills
        //Add Skills on the profile
        public void click_skillTab()
        {
            //Click on Add New Skill Button
            Thread.Sleep(2000);
            AddNewSkillBtn.Click();
            //Enter the skill 
            Thread.Sleep(2000);
            SkillButton.Click();
        }

        public void Enter_skillDetail()
        {
            //Populate the Excel Sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Profile");


            //Enter the skill
            Thread.Sleep(2000);
            EnterSkill.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Skill"));

            //Click the skill dropdown
            Thread.Sleep(2000);
            ChooseSkill.Click();
            Thread.Sleep(2000);
            ChooseSkilllevel.Click();
        }
        public void Skill_Add()
        {
            try
            {


                Thread.Sleep(2000);
                Add_skill.Click();

                Thread.Sleep(2000);
                Base.test.Log(LogStatus.Info, "Added Skills successfully");

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        #endregion skill

        #region education
        //Add Education
        public void Click_EduTab()
        {
            //Click on the Education tab
            Thread.Sleep(2000);
            EducationTab.Click();

            //Click on the education button
            Thread.Sleep(2000);
            Educationbutton.Click();
        }

        public void Enter_EduDetail()
        {
            //Populate the Excel Sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Profile");

            //Enter the University
            EnterUniversity.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "University"));

            //Choose Country
            ChooseCountry.Click();

            //Choose Country Level
            ChooseCountryOpt.Click();

            //Choose Title
            ChooseTitle.Click();

            //Choose tile
            Thread.Sleep(2000);
            ChooseTitleOpt.Click();

            //Enter Degree
            Degree.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Degree"));

            //Year of Graduation
            DegreeYear.Click();
            Thread.Sleep(2000);
            DegreeYearOpt.Click();
        }
        public void Edu_add()
        {
            AddEdu.Click();

            Thread.Sleep(2000);
            Base.test.Log(LogStatus.Info, "Added Education successfully");
        }

        #endregion education

        #region Certificates
        public void Click_CertiTab()
        {

            Thread.Sleep(1000);
            //Add new Certificate
            AddNewCertiTab.Click();

            //Add new Certificate
            AddNewCertibtn.Click();
        }

        public void Enter_CertiDetail()
        {
            //Populate the Excel Sheet
            Global.GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Profile");

            //Enter Certificate Name
            EnterCerti.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Certificate"));

            //Enter Certified from
            CertiFrom.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "CertifiedFrom"));

            //Click on  the Year
            CertiYear.Click();

            //Select the Year
            Thread.Sleep(2000);
            CertiYearOpt.Click();

        }
        public void Certi_Add()
        {
            //ADD New Certificate to the profile
            Thread.Sleep(2000);
            AddCerti.Click();

            Global.Base.test.Log(LogStatus.Info, "Added Certificate successfully");
        }

        #endregion Certificate

        #region description
        public void Click_Desc()
        {
            //Click on the description icon 
            DescriptionIcon.Click();
        }
        public void Enter_DescDetails()
        {

            //Add Description
            Description.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Description"));

        }

        public void Desc_Add()
        {
            // Click to save description
            Thread.Sleep(2000);
            Save.Click();
            Base.test.Log(LogStatus.Info, "Added Description successfully");

        }
        #endregion desc
    }
}

#endregion

