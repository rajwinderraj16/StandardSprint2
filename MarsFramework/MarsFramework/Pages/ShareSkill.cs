using MarsFramework.Global;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using RelevantCodes.ExtentReports;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsFramework.Pages
{
    class ShareSkill:Base
    {

 #region  PageFactroy with Lambda Expression approach


        //Initialization of  Web Elements user detail

        //Initialize ShareSkill button
        IWebElement ShareSkillBtn => GlobalDefinitions.driver.FindElement(By.XPath("//a[@class='ui basic green button']"));

        //Initialize the Title text field
        IWebElement Title => GlobalDefinitions.driver.FindElement(By.XPath("//input[@placeholder='Write a title to describe the service you provide.']"));

        //Initilize the Error Msg
        IWebElement ErrorMsg => GlobalDefinitions.driver.FindElement(By.XPath("//div[@class='ui basic red prompt label transition visible']"));

        //Initialize the Description text field
        IWebElement Description => GlobalDefinitions.driver.FindElement(By.XPath("//textarea[@name='description']"));

        //Initialize the DescriptionErrorMsg text field
        IWebElement DescpErrMsg => GlobalDefinitions.driver.FindElement(By.XPath("//div[contains(text(),'Description is required')]"));

        //Initialize the Category dropdown button
        IWebElement Categorybtn => GlobalDefinitions.driver.FindElement(By.XPath("//select[@name='categoryId']//option[contains(text(),'Programming & Tech')]"));

        //Initialize the Sub Category dropdown button
        IWebElement SubCategory => GlobalDefinitions.driver.FindElement(By.XPath("//select[@name='subcategoryId']"));

        //Initialize the Tag input 
        IWebElement Tag => GlobalDefinitions.driver.FindElement(By.XPath("//body/div/div/div[@id='service-listing-section']/div[contains(@class,'ui container')]/div[contains(@class,'listing')]/form[contains(@class,'ui form')]/div[contains(@class,'tooltip-target ui grid')]/div[contains(@class,'twelve wide column')]/div[contains(@class,'')]/div[@class='ReactTags__tags']/div[@class='ReactTags__selected']/div[@class='ReactTags__tagInput']/input[1]"));

        //Initialize the Hourly basis radio button
        IWebElement HourBase => GlobalDefinitions.driver.FindElement(By.XPath("//div[@class='ui radio checkbox']//label[contains(text(),'Hourly basis service')]"));

        //Initialize One-off-service radio button
        IWebElement OneOfService => GlobalDefinitions.driver.FindElement(By.XPath("//div[@class='ui radio checkbox']//label[contains(text(),'One-off service')]"));

        //Initialize On-site radio button
        IWebElement OneSite => GlobalDefinitions.driver.FindElement(By.XPath("//div[@class='ui radio checkbox']//label[contains(text(),'On-site')]"));

        //Initialize Online radio button
        IWebElement Online => GlobalDefinitions.driver.FindElement(By.XPath("//div[@class='ui radio checkbox']//label[contains(text(),'Online')]"));

        //Initialize StartDate
        IWebElement StartDate => GlobalDefinitions.driver.FindElement(By.XPath("//input[@placeholder='Start date']"));

        //Initilize the Error Msg of startdate in the past
        IWebElement StartErrorMsg => GlobalDefinitions.driver.FindElement(By.XPath("//div[contains(text(),'Start Date cannot be set to a day in the past')]"));

        //Initialize the Enddate
        IWebElement EndDate => GlobalDefinitions.driver.FindElement(By.XPath("//input[@placeholder='End date']"));

        //Initilize the Error Msg of smaller end date 
        IWebElement EndErrorMsg => GlobalDefinitions.driver.FindElement(By.XPath("div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(7) div.twelve.wide.column > div.ui.basic.red.prompt.label.transition.visible"));

        //Initialize StartTime
        IWebElement StartTime => GlobalDefinitions.driver.FindElement(By.XPath("//div[@class='twelve wide column']//div[2]//div[2]//input[1]"));

        //Initialize EndTime
        IWebElement EndTime => GlobalDefinitions.driver.FindElement(By.XPath("//div[@class='twelve wide column']//div[2]//div[3]//input[1]"));

        //Initialize Skillexchange
        IWebElement Skillexchange => GlobalDefinitions.driver.FindElement(By.XPath("//div[@class='form-wrapper']//input[@placeholder='Add new tag']"));

        //Initialize WorkSample button
        IWebElement WorkSample => GlobalDefinitions.driver.FindElement(By.XPath("//i[@class='huge plus circle icon padding-25']"));

        //Initilize the Error Msg of worksample
        IWebElement WorkSampleErrorMsg => GlobalDefinitions.driver.FindElement(By.XPath("//div[@class='ns-box-inner'][contains(text(),'Max file size is 2 MB and supported file types are gif/jpeg/png/jpg/doc(x)/pdf/txt/xls(x)'"));

        //Initialize the save button
        IWebElement Save => GlobalDefinitions.driver.FindElement(By.XPath("//input[@class='ui teal button']"));

        //Initialize the cancel button
        IWebElement cancel => GlobalDefinitions.driver.FindElement(By.XPath("//input[@class='ui button']"));

        public void Click_ShareskillTab()
        {
            //Click on the shareskill button 
            Thread.Sleep(1500);
            ShareSkillBtn.Click();
        }

        public void Enter_ShareSkillDetail()
        {

            //Populate the Excel Sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "shareskill");

            //Enter the Title
            Thread.Sleep(1500);
            Title.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Title"));

           /* //Negative Scenario:Check if user can enter any special character in Title
            Thread.Sleep(1500);
            Title.SendKeys(GlobalDefinitions.ExcelLib.ReadData(3, "Title"));

            //verification
            String ERR = ErrorMsg.GetAttribute("innerHTML");
            String ExpectedERR = "Special characters are not allowed.";

            if (ERR == ExpectedERR)
            {
                Console.WriteLine("user can not enter any special characters");
            }

            else
            {
                Console.WriteLine("user can enter special characters");

            }*/

            //Enter the Description
            Thread.Sleep(1500);
            Description.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Description"));


            /*//Nagetive Scenario:Check if user is able to Leave the description empty 
            Thread.Sleep(1500);
            Description.SendKeys(GlobalDefinitions.ExcelLib.ReadData(3, "Description"));*/

            //Select the Caterory
            Thread.Sleep(1500);
            Categorybtn.Click();

            //Select the Subcatogery
            Thread.Sleep(1500);
            SelectElement suboption = new SelectElement(SubCategory);
            suboption.SelectByIndex(5);


            //Negative scenario: check whether multiple options can be selected from the subcategory dropdown button
            Thread.Sleep(1500);
            SelectElement selectele = new SelectElement(SubCategory);
            bool isMultiple = selectele.IsMultiple;
            Console.WriteLine(isMultiple); // it will return true if multiple selection is supported and false if it is not supported

            //Enter the Tag
            Thread.Sleep(1500);
            Tag.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Tag"));
            Tag.SendKeys(Keys.Enter);



            //verification of dependent tag input field appear or not upon entering the main tag
            if (Tag.Displayed)
            {
                Console.WriteLine("The dependent tag input displayed");
            }
            else
            {
                Console.WriteLine("The dependent tag input did not diplayed");
            }


            //Enter the HourBase
            //Thread.Sleep(1500);
            //HourBase.Click();

            //Enter the OneOfServices
            Thread.Sleep(1500);
            OneOfService.Click();

            //Enter the Onsite
            //Thread.Sleep(1500);
            // OneSite.Click();

            //Enter the Online
            Thread.Sleep(1500);
            Online.Click();

            //Enter the StartDate
            Thread.Sleep(1500);
            StartDate.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "StartDate"));

            //Negative Scenario: Check whether Start Date cannot be set to a day in the past
            //Thread.Sleep(1500);
            //StartDate.SendKeys(GlobalDefinitions.ExcelLib.ReadData(3, "StartDate"));

            //Enter the EndDate
            Thread.Sleep(1500);
            EndDate.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "EndDate"));

            //Negative Scenario: Check whether End Date can be smaller than start date
            //Thread.Sleep(1500);
            //EndDate.SendKeys(GlobalDefinitions.ExcelLib.ReadData(3, "EndDate"));

            //Enter the StartTime
            Thread.Sleep(1500);
            StartTime.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "StartTime"));

            //Enter the end time
            Thread.Sleep(1500);
            EndTime.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "EndTime"));

            //Enter the skill exchange
            Thread.Sleep(1500);
            Skillexchange.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "SkillExchange"));
            Skillexchange.SendKeys(Keys.Enter);

            //Click on the save button   
            Thread.Sleep(1500);
            Save.Click();
        }

        public void Confirm_shareskill()
        {

            //Verification of added service
            String title = Global.GlobalDefinitions.driver.Title;
            Console.WriteLine("Title is=" + title);


            String expectedTitle1 = "ServiceListing";

            if (title == expectedTitle1)
            {
                Console.WriteLine("Nanigated to the ManageLlisting Page");
            }
            else
                Console.WriteLine("Not navigated to the Service detail page");
            Base.test.Log(LogStatus.Info, "Service added successfully");


           
           
            
            /*//verification:Try to save without description
            Thread.Sleep(1500);
            string DesErr = DescpErrMsg.GetAttribute("innerHTML");
            string ExpectedDesErr = "Description is required";

            if (DesErr == ExpectedDesErr)
            {

                Console.WriteLine("user cant leave the description empty");
            }

            else
            {

                Console.WriteLine("user can leave the description empty");

            }

            //verification of start date from the past
            Thread.Sleep(1500);
            string starterr = StartErrorMsg.GetAttribute("innerHTML");
            string Expectedstartdate = "Start Date cannot be set to a day in the past";

            if (starterr == Expectedstartdate)
            {
                Console.WriteLine("user can not enter date from the  past");
            }

            else
            {
                Console.WriteLine("user can enter date from the past");

            }

            //verification of end date smaller than start date
            Thread.Sleep(1500);
            string EndErr = EndErrorMsg.Text;
            string ExpectedEndErr = "Start Date shouldn't be greater than End Date";

            if (EndErr == ExpectedEndErr)
            {
                Console.WriteLine("user can not enter any date which is smaller than the start date");
            }

            else
            {
                Console.WriteLine("user can enter the bigger end date than start sate");

            }



            //Click on the cancel button
            //cancel.Click();
            //String title = Global.GlobalDefinitions.driver.Title;
            // Console.WriteLine("Title is=" + title);

            //Verification of the PageTitle on clicking the cancel button
            string expectedTitle = "Profile";

            if (title == expectedTitle)
            {
                Console.WriteLine("User is navigated to the profile page");
            }

            else
            {
                Console.WriteLine("user is not navigated to the profile page");
            }*/
        }
    }
}

#endregion

#region  PageFactroy with FindBy approach
/*public ShareSkill()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        //Initialization of  Web Elements user detail

        //Initialize ShareSkill button
        [FindsBy(How = How.XPath, Using = "//a[@class='ui basic green button']")]
        private IWebElement ShareSkillBtn { get; set; }

        //Initialize the Title text field
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Write a title to describe the service you provide.']")]
        private IWebElement Title { get; set; }

        //Initilize the Error Msg
        [FindsBy(How = How.XPath, Using = "//div[@class='ui basic red prompt label transition visible']")]
        private IWebElement ErrorMsg { get; set; }

        //Initialize the Description text field
        [FindsBy(How = How.XPath, Using = "//textarea[@name='description']")]
        private IWebElement Description { get; set; }

        //Initialize the DescriptionErrorMsg text field
        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'Description is required')]")]
        private IWebElement DescpErrMsg { get; set; }


        //Initialize the Category dropdown button
        [FindsBy(How = How.XPath, Using = "//select[@name='categoryId']//option[contains(text(),'Programming & Tech')]")]
        private IWebElement Categorybtn { get; set; }

        //Initialize the Sub Category dropdown button
        [FindsBy(How = How.XPath, Using = "//select[@name='subcategoryId']")]
        private IWebElement SubCategory { get; set; }

        //Initialize the Tag input 
        [FindsBy(How = How.XPath, Using = "//body/div/div/div[@id='service-listing-section']/div[contains(@class,'ui container')]/div[contains(@class,'listing')]/form[contains(@class,'ui form')]/div[contains(@class,'tooltip-target ui grid')]/div[contains(@class,'twelve wide column')]/div[contains(@class,'')]/div[@class='ReactTags__tags']/div[@class='ReactTags__selected']/div[@class='ReactTags__tagInput']/input[1]")]
        private IWebElement Tag { get; set; }

        //Initialize the Hourly basis radio button
        [FindsBy(How = How.XPath, Using = "//div[@class='ui radio checkbox']//label[contains(text(),'Hourly basis service')]")]
        private IWebElement HourBase { get; set; }

        //Initialize One-off-service radio button
        [FindsBy(How = How.XPath, Using = "//div[@class='ui radio checkbox']//label[contains(text(),'One-off service')]")]
        private IWebElement OneOfService { get; set; }


        //Initialize On-site radio button
        [FindsBy(How = How.XPath, Using = "//div[@class='ui radio checkbox']//label[contains(text(),'On-site')]")]
        private IWebElement OneSite { get; set; }


        //Initialize Online radio button
        [FindsBy(How = How.XPath, Using = "//div[@class='ui radio checkbox']//label[contains(text(),'Online')]")]
        private IWebElement Online { get; set; }

        //Initialize StartDate
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Start date']")]
        private IWebElement StartDate { get; set; }

        //Initilize the Error Msg of startdate in the past
        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'Start Date cannot be set to a day in the past')]")]
        private IWebElement StartErrorMsg { get; set; }

        //Initialize the Enddate
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='End date']")]
        private IWebElement EndDate { get; set; }

        //Initilize the Error Msg of smaller end date 
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(7) div.twelve.wide.column > div.ui.basic.red.prompt.label.transition.visible")]
        private IWebElement EndErrorMsg { get; set; }

        //Initialize StartTime
        [FindsBy(How = How.XPath, Using = "//div[@class='twelve wide column']//div[2]//div[2]//input[1]")]
        private IWebElement StartTime { get; set; }

        //Initialize EndTime
        [FindsBy(How = How.XPath, Using = "//div[@class='twelve wide column']//div[2]//div[3]//input[1]")]
        private IWebElement EndTime { get; set; }

        //Initialize Skillexchange
        [FindsBy(How = How.XPath, Using = "//div[@class='form-wrapper']//input[@placeholder='Add new tag']")]
        private IWebElement Skillexchange { get; set; }

        //Initialize WorkSample button
        [FindsBy(How = How.XPath, Using = " //i[@class='huge plus circle icon padding-25']")]
        private IWebElement WorkSample { get; set; }


        //Initilize the Error Msg of worksample
        [FindsBy(How = How.XPath, Using = "//div[@class='ns-box-inner'][contains(text(),'Max file size is 2 MB and supported file types are gif/jpeg/png/jpg/doc(x)/pdf/txt/xls(x)'")]
        private IWebElement WorkSampleErrorMsg { get; set; }


        //Initialize the save button
        [FindsBy(How = How.XPath, Using = "//input[@class='ui teal button']")]
        private IWebElement Save { get; set; }

        /* //Initialize the cancel button
         [FindsBy(How = How.XPath, Using = "//input[@class='ui button']")]
         private IWebElement cancel { get; set; }



        internal void Skillsharing()
        {

            //Populate the Excel Sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ShareSkill");

            //Click on the shareskill button 
            Thread.Sleep(1500);
            ShareSkillBtn.Click();

            //Enter the Title
            Thread.Sleep(1500);
            Title.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Title"));

            //Negative Scenario:Check if user can enter any special character in Title
            Thread.Sleep(1500);
            Title.SendKeys(GlobalDefinitions.ExcelLib.ReadData(3, "Title"));

            //verification
            String ERR = ErrorMsg.GetAttribute("innerHTML");
            String ExpectedERR = "Special characters are not allowed.";

            if (ERR == ExpectedERR)
            {
                Console.WriteLine("user can not enter any special characters");
            }

            else
            {
                Console.WriteLine("user can enter special characters");

            }

            //Enter the Description
            Thread.Sleep(1500);
            Description.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Description"));


            //Nagetive Scenario:Check if user is able to Leave the description empty 
            Thread.Sleep(1500);
            Description.SendKeys(GlobalDefinitions.ExcelLib.ReadData(3, "Description"));

            //Select the Caterory
            Thread.Sleep(1500);
            Categorybtn.Click();

            //Select the Subcatogery
            Thread.Sleep(1500);
            SelectElement suboption = new SelectElement(SubCategory);
            suboption.SelectByIndex(5);


            //Negative scenario: check whether multiple options can be selected from the subcategory dropdown button
            Thread.Sleep(1500);
            SelectElement selectele = new SelectElement(SubCategory);
            bool isMultiple = selectele.IsMultiple;
            Console.WriteLine(isMultiple); // it will return true if multiple selection is supported and false if it is not supported

            //Enter the Tag
            Thread.Sleep(1500);
            Tag.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Tag"));
            Tag.SendKeys(Keys.Enter);



            //verification of dependent tag input field appear or not upon entering the main tag
            if (Tag.Displayed)
            {
                Console.WriteLine("The dependent tag input displayed");
            }
            else
            {
                Console.WriteLine("The dependent tag input did not diplayed");
            }


            //Enter the HourBase
            Thread.Sleep(1500);
            HourBase.Click();

            //Enter the OneOfServices
            Thread.Sleep(1500);
            OneOfService.Click();

            //Enter the Onsite
            //Thread.Sleep(1500);
            // OneSite.Click();

            //Enter the Online
            Thread.Sleep(1500);
            Online.Click();

            //Enter the StartDate
            Thread.Sleep(1500);
            StartDate.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "StartDate"));

            //Negative Scenario: Check whether Start Date cannot be set to a day in the past
            //Thread.Sleep(1500);
            //StartDate.SendKeys(GlobalDefinitions.ExcelLib.ReadData(3, "StartDate"));

            //Enter the EndDate
            Thread.Sleep(1500);
            EndDate.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "EndDate"));

            //Negative Scenario: Check whether End Date can be smaller than start date
            //Thread.Sleep(1500);
            //EndDate.SendKeys(GlobalDefinitions.ExcelLib.ReadData(3, "EndDate"));

            //Enter the StartTime
            Thread.Sleep(1500);
            StartTime.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "StartTime"));

            //Enter the end time
            Thread.Sleep(1500);
            EndTime.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "EndTime"));

            //Enter the skill exchange
            Thread.Sleep(1500);
            Skillexchange.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "SkillExchange"));
            Skillexchange.SendKeys(Keys.Enter);



            //Upload the worksample with "AutoIt"
            //Thread.Sleep(1500);
           // WorkSample.Click();
           // AutoItX3 autoit = new AutoItX3();
           // autoit.WinActivate("Open");
            //Thread.Sleep(2000);
            //autoit.Send(@"C:\Users\admin\Jellyfish.jpg");
            //Thread.Sleep(2000);
            //autoit.Send("{Enter}");

            //Negative Scenario: Upload the file which size is more than 2 MB
           // Thread.Sleep(2000);
            //WorkSample.Click();
           // AutoItX3 autoit = new AutoItX3();
           // autoit.WinActivate("Open");
            //autoit.WinActivate("Open");
            //Thread.Sleep(2000);
            //autoit.Send(@"C:\Users\admin\mywork.bmp");
            //Thread.Sleep(2000);
            //autoit.Send("{Enter}");

            //Verification of Workfile with 2 MB size

            GlobalDefinitions.WaitForElement(Global.GlobalDefinitions.driver, By.XPath("WorkSampleErrorMsg"), 30);
            string MASSAGE = WorkSampleErrorMsg.Text;
            string ExpWorkSampleErr = "Max file size is 2 MB and supported file types are gif / jpeg / png / jpg / doc(x) / pdf / txt / xls(x)";

            if (MASSAGE == ExpWorkSampleErr)
            {
                Console.WriteLine("File is oversize, cannot upload");
            }
            else
            {
                Console.WriteLine("File is uploaded");
            }


            //Click on the save button   
            Thread.Sleep(1500);
            Save.Click();

            //Verification of added service
            String title = Global.GlobalDefinitions.driver.Title;
            Console.WriteLine("Title is=" + title);


            String expectedTitle1 = "ServiceListing";

            if (title == expectedTitle1)
            {
                Console.WriteLine("Nanigated to the ManageLlisting Page");
            }
            else
                Console.WriteLine("Not navigated to the Service detail page");
            Base.test.Log(LogStatus.Info, "Service added successfully");


            //Assertion of the added skill

            string actualmassage = GlobalDefinitions.driver.FindElement(By.XPath("//div[@class='ns-box-inner']")).Text;
            string expectedmasage = "Service Listing Added sucessfully";
            Assert.AreEqual(expectedmasage, actualmassage);


               
            //verification:Try to save without description
            Thread.Sleep(1500);
            String DesErr = DescpErrMsg.GetAttribute("innerHTML");
            String ExpectedDesErr = "Description is required";

            if (DesErr == ExpectedDesErr)
            {

                Console.WriteLine("user cant leave the description empty");
            }

            else
            {

                Console.WriteLine("user can leave the description empty");

            }

            //verification of start date from the past
            Thread.Sleep(1500);
            String starterr = StartErrorMsg.GetAttribute("innerHTML");
            String Expectedstartdate = "Start Date cannot be set to a day in the past";

            if (starterr == Expectedstartdate)
            {
                Console.WriteLine("user can not enter date from the  past");
            }

            else
            {
                Console.WriteLine("user can enter date from the past");

            }

            //verification of end date smaller than start date
            Thread.Sleep(1500);
            String EndErr = EndErrorMsg.Text;
            String ExpectedEndErr = "Start Date shouldn't be greater than End Date";

            if (EndErr == ExpectedEndErr)
            {
                Console.WriteLine("user can not enter any date which is smaller than the start date");
            }

            else
            {
                Console.WriteLine("user can enter the bigger end date than start sate");

            }

            //Click on the cancel button
            //cancel.Click();
            //String title = Global.GlobalDefinitions.driver.Title;
            // Console.WriteLine("Title is=" + title);

            //Verification of the PageTitle on clicking the cancel button
            String expectedTitle = "Profile";

            if (title == expectedTitle)
            {
                Console.WriteLine("User is navigated to the profile page");
            }

            else
            {
                Console.WriteLine("user is not navigated to the profile page");
            }
        }
    }
}*/

#endregion