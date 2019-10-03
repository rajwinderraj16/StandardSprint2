using MarsFramework.Global;
using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using SeleniumExtras.PageObjects;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsFramework.Pages
{
    class SearchSkill : Base
    {
        #region Pagefactroy with Lambda expression Approach

        //Initialization of  Web Elements user detail

        //Initialize SearchSkill field
        IWebElement Searchskill => GlobalDefinitions.driver.FindElement(By.XPath("//input[@placeholder='Search skills']"));

        //Initialize Search icon
        IWebElement SearchIcon => GlobalDefinitions.driver.FindElement(By.XPath("//i[@class='search link icon']"));

        //Initialize Searchresult
        IList<IWebElement> searchresult => GlobalDefinitions.driver.FindElements(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/section[1]/div[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div"));

        //Initialize Search user
        IWebElement Searchuser => GlobalDefinitions.driver.FindElement(By.XPath("//input[@placeholder='Search user']"));

        //Initialize Search dropdown
        IList<IWebElement> searchdropdown => GlobalDefinitions.driver.FindElements(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/section[1]/div[1]/div[1]/div[3]/div[1]/div[1]/div[2]/div/div[1]/span[1]"));


        public void Enter_searchkeyword()
        {

            //Populate the Excel Sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Skills");
            Thread.Sleep(1000);

            //verify if search box is visible on the page or not
            if (Searchskill.Displayed)
            {
                Console.WriteLine("The searchbox is visible on the page");
            }

            //Enter the skill
            Thread.Sleep(1000);
            Searchskill.SendKeys("Automation");
        }

        public void Click_searchicon()
        {

            //Click on the serch icon
            Thread.Sleep(1000);
            SearchIcon.Click();


            //NegativeTesting: Verify the empty search box
            //Leave the search box empty
            //Searchskill.SendKeys("");

            //Click on the search icon 
            // SearchIcon.Click();


        }

        public void serachkey_result()
        {
            //Count the numbers of search result
            Thread.Sleep(2000);
            int num_result = searchresult.Count;
            Console.WriteLine(num_result);

            //Print the list of search result by looping through it

            while (true)
            {
                for (int i = 0; i < num_result; i++)
                {
                    string Listofresult = searchresult.ElementAt(i).Text;
                    Console.WriteLine("The result for automation search is " + Listofresult);


                    if (Listofresult.Contains("Minna dhillon"))
                    {

                        GlobalDefinitions.driver.FindElement(By.XPath("//div[@class='row']//div[2]//div[1]//a[1]")).Click();
                    }
                }


                GlobalDefinitions.driver.FindElement(By.XPath("//button[contains(text(),'>')]")).Click();
            }
        }
                public void searchicon()
                {
                    //Click on the search icon 
                    SearchIcon.Click();
                }

                public void search_users()
                {
                    //Enter the search keyword
                    Searchuser.SendKeys("r");
                }
                public void Search_result()
                {
                    Thread.Sleep(2000);
                    int listofuser = searchdropdown.Count;
                    Console.WriteLine("The list of users is " + listofuser);

                    for (int j = 0; j < listofuser; j++)
                    {
                        string Usersnames = searchdropdown.ElementAt(j).Text;
                        Console.WriteLine(Usersnames);

                        if (Usersnames.Contains("satinder kaur"))
                        {
                            searchdropdown.ElementAt(j).Click();
                        }
                    }
                }
            }
        }
    





        #endregion

        #region Pagefactroy with Findby Approach
       /* public SearchSkill()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        //Initialization of  Web Elements user detail

        //Initialize SearchSkill field
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Search skills']")]
        private IWebElement Searchskill1 { get; set; }


        //Initialize Search icon
        [FindsBy(How = How.XPath, Using = "//i[@class='search link icon']")]
        private IWebElement SearchIcon1 { get; set; }


        //Initialize Searchresult
        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/section[1]/div[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div")]
        private IList<IWebElement> searchresult1 { get; set; }

        //Initialize Search user
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Search user']")]
        private IWebElement Searchuser1 { get; set; }


        //Initialize Search dropdown
        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/section[1]/div[1]/div[1]/div[3]/div[1]/div[1]/div[2]/div/div[1]/span[1]")]
        private IList<IWebElement> searchdropdown1 { get; set; }



        internal void EnterSkill()
        {

            //Populate the Excel Sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Skills");
            Thread.Sleep(1000);

            //verify if search box is visible on the page or not
            if (Searchskill1.Displayed)
            {
                Console.WriteLine("The searchbox is visible on the page");
            }

            //Enter the skill
            Thread.Sleep(1000);
            Searchskill1.SendKeys("Automation");


            //Click on the serch icon
            Thread.Sleep(1000);
            SearchIcon1.Click();


            //NegativeTesting: Verify the empty search box
            //Leave the search box empty
            //Searchskill.SendKeys("");

            //Click on the search icon 
            // SearchIcon.Click();


            //Count the numbers of search result
            Thread.Sleep(2000);
            int num_result = searchresult1.Count;
            Console.WriteLine(num_result);

            //Print the list of search result by looping through it

            while (true)
            {
                for (int i = 1; i < num_result; i++)
                {
                    string Listofresult = searchresult1.ElementAt(i).Text;
                    Console.WriteLine("The result for automation search is " + Listofresult);


                    if (Listofresult.Contains("Ava Yu"))
                    {

                        Thread.Sleep(1000);
                        GlobalDefinitions.driver.FindElement(By.XPath("//div[@class='row']//div[2]//div[1]//a[1]")).Click();

                    }
                }


                GlobalDefinitions.driver.FindElement(By.XPath("//button[contains(text(),'>')]")).Click();



                //Fecthing the particular result by loopin throuh the search user dorpdown autosuggetion

                //Enter the search keyword
                Searchuser1.SendKeys("r");

                Thread.Sleep(2000);
                int listofuser = searchdropdown1.Count;
                Console.WriteLine("The list of users is " + listofuser);

                for (int i = 0; i < listofuser; i++)
                {
                    string Usersnames = searchdropdown1.ElementAt(i).Text;
                    Console.WriteLine(Usersnames);

                    if (Usersnames.Contains("satinder kaur"))
                    {
                        searchdropdown1.ElementAt(i).Click();
                    }
                }
            }
        }
    }
}*/




#endregion








