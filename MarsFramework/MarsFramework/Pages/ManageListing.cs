using MarsFramework.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using RelevantCodes.ExtentReports;
using NUnit.Framework;

namespace MarsFramework.Pages
{
    public class ManageListing : Base
    {
        #region PageFactory with Lambda Expression

        // Initialize Web Elements 

        //Initialize the dropdown link field
        IWebElement manageListing => GlobalDefinitions.driver.FindElement(By.XPath("//a[contains(text(),'Manage Listings')]"));


        //Initialize the dropdown link field
        IList<IWebElement> Title => GlobalDefinitions.driver.FindElements(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/table[1]//tr//td[3] "));


        //Initialize the Title text field
        IWebElement Edit => GlobalDefinitions.driver.FindElement(By.XPath("//tr[2]//td[8]//i[2]"));


        //Initialize the Title text field
        IWebElement Delete => GlobalDefinitions.driver.FindElement(By.XPath("//tr[2]//td[8]//i[3]"));


        //Initialize the Title text field
        IWebElement ConfirmDelete => GlobalDefinitions.driver.FindElement(By.XPath("//i[@class='checkmark icon']"));


        //Initialize the Title text field
        IWebElement title => GlobalDefinitions.driver.FindElement(By.XPath("//input[@placeholder='Write a title to describe the service you provide.']"));

        //Initialize the Description text field
        IWebElement Description => GlobalDefinitions.driver.FindElement(By.XPath("//textarea[@name='description']"));


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

        //Initialize the Enddate
        IWebElement EndDate => GlobalDefinitions.driver.FindElement(By.XPath("//input[@placeholder='End date']"));

        //Initialize StartTime
        IWebElement StartTime => GlobalDefinitions.driver.FindElement(By.XPath("//div[@class='twelve wide column']//div[2]//div[2]//input[1]"));

        //Initialize EndTime
        IWebElement EndTime => GlobalDefinitions.driver.FindElement(By.XPath("//div[@class='twelve wide column']//div[2]//div[3]//input[1]"));

        //Initialize Skillexchange
        IWebElement Skillexchange => GlobalDefinitions.driver.FindElement(By.XPath("//div[@class='form-wrapper']//input[@placeholder='Add new tag']"));

        //Initialize the save button
        IWebElement Save => GlobalDefinitions.driver.FindElement(By.XPath("//input[@class='ui teal button']"));


        public void Click_ManageListTab()
        {
            //Click on the managing listing tab 
            Thread.Sleep(1000);
            manageListing.Click();
        }

        public void Delete_ManageListing()
        {
            //count the numbers of data in Title 
            Thread.Sleep(2000);
            int listtitle = Title.Count;
            Console.WriteLine(listtitle);


            //Retreiving a particular data by looping through the Title header and delete it
            while (true)
            {
                for (int i = 0; i <= listtitle; i++)
                {
                    string nameoftitle = Title.ElementAt(i).Text;
                    Console.WriteLine(nameoftitle);

                    Thread.Sleep(1000);
                    if (Title.ElementAt(i).Text == "ABC")

                    {

                        //Click on the delete button
                        Thread.Sleep(2000);
                        Delete.Click();

                        //Click on the Yes button to confirm the delete action
                        Thread.Sleep(1000);
                        ConfirmDelete.Click();
                    }
                }

                GlobalDefinitions.driver.FindElement(By.XPath("//button[contains(text(),'>')]")).Click();

            }
        }

        public void Assert_Delete()
        {


            //Assertion that record has been deleted successfully

            string ActaulDeleteMaasage = GlobalDefinitions.driver.FindElement(By.XPath("//div[@class='ns-box-inner'][contains(text(),'ABC has been deleted']")).Text;
            string ExpDeleteMassge = "ABC has been deleted";

            Assert.AreEqual(ExpDeleteMassge, ActaulDeleteMaasage);

        }


        public void Edit_ManageList()
        {
            //count the numbers of data in Title 
            Thread.Sleep(2000);
            int nametitle = Title.Count;
            Console.WriteLine(nametitle);


            //Retreiving a particular data by looping through the Title header and edit it
            while (true)
            {
                for (int j = 0; j < nametitle; j++)
                {
                    string nameoftitle = Title.ElementAt(j).Text;
                    Console.WriteLine(nameoftitle);

                    Thread.Sleep(1000);
                    if (Title.ElementAt(j).Text == "API Testing")

                    {


                        Thread.Sleep(1500);
                        Edit.Click();

                        //Populate the Excel Sheet
                        Global.GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "shareskill");

                        Thread.Sleep(1500);
                        title.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Title"));


                        //Enter the Description
                        Thread.Sleep(1500);
                        Description.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Description"));

                        //Select the Caterory
                        Thread.Sleep(1500);
                        Categorybtn.Click();

                        //Select the Subcatogery
                        Thread.Sleep(1500);
                        SelectElement suboption = new SelectElement(SubCategory);
                        suboption.SelectByIndex(5);

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

                        //Enter the EndDate
                        Thread.Sleep(1500);
                        EndDate.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "EndDate"));

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
                }

                GlobalDefinitions.driver.FindElement(By.XPath("//button[contains(text(),'>')]")).Click();
            }
        }
        public void Confirm_SkillAdd()
        {


            //Assertion that record has been deleted successfully

            string ActaulDeleteMaasage = GlobalDefinitions.driver.FindElement(By.XPath("//div[contains(text(),'Service Listing Added successfully'")).Text;
            string ExpDeleteMassge = "Service Listing Added successfully";

            Assert.AreEqual(ExpDeleteMassge, ActaulDeleteMaasage);

        }

    }
}


        #endregion PageFactory


        #region Initialization of WebElements with PageFactory With FindBy Approach
     /*   public ManageListing()
        {
            PageFactory.InitElements(MarsFramework.Global.GlobalDefinitions.driver, this);
        }

        // Initialize Web Elements 

        //Initialize the dropdown link field
        [FindsBy(How = How.XPath, Using = " //a[contains(text(),'Manage Listings')]")]
        private IWebElement manageListing1 { get; set; }

        //Initialize the dropdown link field
        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/table[1]//tr//td[3] ")]
        private IList<IWebElement> Title1 { get; set; }

        //Initialize the Title text field
        [FindsBy(How = How.XPath, Using = "//tr[3]//td[8]//i[2]")]
        private IWebElement Edit1 { get; set; }

        //Initialize the Title text field
        [FindsBy(How = How.XPath, Using = "//tr[2]//td[8]//i[3]")]
        private IWebElement Delete1 { get; set; }

        //Initialize the Title text field
        [FindsBy(How = How.XPath, Using = "//button[@class='ui icon positive right labeled button']")]
        private IWebElement ConfirmDelete1 { get; set; }

        //Initialize the Title text field
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Write a title to describe the service you provide.']")]
        private IWebElement title1 { get; set; }

        //Initialize the Description text field
        [FindsBy(How = How.XPath, Using = "//textarea[@name='description']")]
        private IWebElement Description1 { get; set; }

        //Initialize the Category dropdown button
        [FindsBy(How = How.XPath, Using = "//select[@name='categoryId']//option[contains(text(),'Programming & Tech')]")]
        private IWebElement Categorybtn1 { get; set; }

        //Initialize the Sub Category dropdown button
        [FindsBy(How = How.XPath, Using = "//select[@name='subcategoryId']")]
        private IWebElement SubCategory1 { get; set; }

        //Initialize the Tag input 
        [FindsBy(How = How.XPath, Using = "//body/div/div/div[@id='service-listing-section']/div[contains(@class,'ui container')]/div[contains(@class,'listing')]/form[contains(@class,'ui form')]/div[contains(@class,'tooltip-target ui grid')]/div[contains(@class,'twelve wide column')]/div[contains(@class,'')]/div[@class='ReactTags__tags']/div[@class='ReactTags__selected']/div[@class='ReactTags__tagInput']/input[1]")]
        private IWebElement Tag1 { get; set; }

        //Initialize the Hourly basis radio button
        [FindsBy(How = How.XPath, Using = "//div[@class='ui radio checkbox']//label[contains(text(),'Hourly basis service')]")]
        private IWebElement HourBase1 { get; set; }

        //Initialize One-off-service radio button
        [FindsBy(How = How.XPath, Using = "//div[@class='ui radio checkbox']//label[contains(text(),'One-off service')]")]
        private IWebElement OneOfService1 { get; set; }


        //Initialize On-site radio button
        [FindsBy(How = How.XPath, Using = "//div[@class='ui radio checkbox']//label[contains(text(),'On-site')]")]
        private IWebElement OneSite1 { get; set; }


        //Initialize Online radio button
        [FindsBy(How = How.XPath, Using = "//div[@class='ui radio checkbox']//label[contains(text(),'Online')]")]
        private IWebElement Online1 { get; set; }

        //Initialize StartDate
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Start date']")]
        private IWebElement StartDate1 { get; set; }

        //Initialize the Enddate
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='End date']")]
        private IWebElement EndDate1 { get; set; }


        //Initialize StartTime
        [FindsBy(How = How.XPath, Using = "//div[@class='twelve wide column']//div[2]//div[2]//input[1]")]
        private IWebElement StartTime1 { get; set; }

        //Initialize EndTime
        [FindsBy(How = How.XPath, Using = "//div[@class='twelve wide column']//div[2]//div[3]//input[1]")]
        private IWebElement EndTime1 { get; set; }

        //Initialize Skillexchange
        [FindsBy(How = How.XPath, Using = "//div[@class='form-wrapper']//input[@placeholder='Add new tag']")]
        private IWebElement Skillexchange1 { get; set; }


        //Initialize the save button
        [FindsBy(How = How.XPath, Using = "//input[@class='ui teal button']")]
        private IWebElement Save1 { get; set; }



        internal void ManageListFunc()
        {

            //Populate the Excel Sheet
            Global.GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "shareskill");

            //Click on the managing listing tab 
            Thread.Sleep(1000);
            manageListing1.Click();

            //count the numbers of data in Title 
            Thread.Sleep(2000);
            int listtitle = Title1.Count;
            Console.WriteLine(listtitle);


            //Retreiving a particular data by looping through the Title header and delete it

            for (int i = 0; i < listtitle; i++)
            {
                string nameoftitle = Title1.ElementAt(i).Text;
                Console.WriteLine(nameoftitle);

                Thread.Sleep(1000);
                if (Title1.ElementAt(i).Text == "Funtional Testing")

                {

                    //Click on the delete button
                    Thread.Sleep(1000);
                    Delete1.Click();

                    //Click on the Yes button to confirm the delete action
                    Thread.Sleep(1000);
                    ConfirmDelete1.Click();

                    //Assertion that record has been deleted successfully

                    string ActaulDeleteMaasage = GlobalDefinitions.driver.FindElement(By.XPath("//div[@class='ns-box-inner']")).Text;
                    string ExpDeleteMassge = "Funtional Testing has been deleted";

                    Assert.AreEqual(ExpDeleteMassge, ActaulDeleteMaasage);

                }
            }


            //Retreiving a particular data by looping through the Title header and edit it
            while (true)
            {
                for (int j = 0; j < listtitle; j++)
                {
                    string nameoftitle = Title1.ElementAt(j).Text;
                    Console.WriteLine(nameoftitle);

                    Thread.Sleep(1000);
                    if (Title1.ElementAt(j).Text == "API Testing")

                    {

                        Thread.Sleep(1000);
                        Edit1.Click();

                        Thread.Sleep(1500);
                        title1.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Title"));


                        //Enter the Description
                        Thread.Sleep(1500);
                        Description1.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Description"));

                        //Select the Caterory
                        Thread.Sleep(1500);
                        Categorybtn1.Click();

                        //Select the Subcatogery
                        Thread.Sleep(1500);
                        SelectElement suboption = new SelectElement(SubCategory1);
                        suboption.SelectByIndex(5);

                        //Enter the Tag
                        Thread.Sleep(1500);
                        Tag1.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Tag"));
                        Tag1.SendKeys(Keys.Enter);



                        //verification of dependent tag input field appear or not upon entering the main tag
                        if (Tag1.Displayed)
                        {
                            Console.WriteLine("The dependent tag input displayed");
                        }
                        else
                        {
                            Console.WriteLine("The dependent tag input did not diplayed");
                        }


                        //Enter the HourBase
                        //Thread.Sleep(1500);
                        //HourBase1.Click();

                        //Enter the OneOfServices
                        Thread.Sleep(1500);
                        OneOfService.Click();

                        //Enter the Onsite
                        //Thread.Sleep(1500);
                        // OneSite1.Click();

                        //Enter the Online
                        Thread.Sleep(1500);
                        Online1.Click();

                        //Enter the StartDate
                        Thread.Sleep(1500);
                        StartDate1.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "StartDate"));

                        //Enter the EndDate
                        Thread.Sleep(1500);
                        EndDate1.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "EndDate"));

                        //Enter the StartTime
                        Thread.Sleep(1500);
                        StartTime1.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "StartTime"));

                        //Enter the end time
                        Thread.Sleep(1500);
                        EndTime1.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "EndTime"));

                        //Enter the skill exchange
                        Thread.Sleep(1500);
                        Skillexchange1.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "SkillExchange"));
                        Skillexchange1.SendKeys(Keys.Enter);

                        //Click on the save button   
                        Thread.Sleep(1500);
                        Save1.Click();


                        // Verification Of newly added record

                    }
                }

                GlobalDefinitions.driver.FindElement(By.XPath("//button[contains(text(),'>')]")).Click();
            }
        }
    }
}*/





#endregion PageFactory
