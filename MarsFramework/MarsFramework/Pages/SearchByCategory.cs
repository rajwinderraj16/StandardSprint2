using MarsFramework.Global;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsFramework.Pages
{
    class SearchByCategory : Base
    {
        #region PageFactory with Lambda Expression

        //Initialization of  Web Elements user detail

        //Initialize SearchSkill field
        IWebElement Searchskill => GlobalDefinitions.driver.FindElement(By.XPath("//input[@placeholder='Search skills']"));

        //Initialize Search icon
        IWebElement SearchIcon => GlobalDefinitions.driver.FindElement(By.XPath("//i[@class='search link icon']"));

        //Initialize Category
        IList<IWebElement> CategoryList => GlobalDefinitions.driver.FindElements(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/section[1]/div[1]/div[1]/div[1]/div[1]/a"));


        //Initialize Category
        IWebElement searchresult => GlobalDefinitions.driver.FindElement(By.XPath("//div[@class='ui stackable three cards']//div[1]//div[1]//a[1]"));



        public void Enter_search()
        {
            Thread.Sleep(1000);
            Searchskill.SendKeys("Automation");

            Thread.Sleep(1000);
            SearchIcon.Click();
        }

        public void select_category()
        {

            Thread.Sleep(1000);
            //Store all categoryies in list
            int NumCategory = CategoryList.Count;
            Console.WriteLine(NumCategory);


            //Thread.Sleep(1000);
            for (int i = 0; i < NumCategory; i++)
            {
                string CategoryName = CategoryList.ElementAt(i).Text;
                Console.WriteLine(CategoryName);

                if (CategoryName.Contains("Writing & Translation"))
                {
                    CategoryList.ElementAt(i).Click();

                }
            }
        }
        //verification
        public void Confirmsearchresult()
        {
            Thread.Sleep(2000);
            if (searchresult.Displayed)
            {
                Console.WriteLine("The result is displayed when Writing & Translation clicked");
            }
        }
    }
}

           
                    


       


#endregion

#region PageFactory with FindBy Approach
/*public SearchByCategory()
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

        //Initialize Category
        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/section[1]/div[1]/div[1]/div[1]/div[1]/a")]
        private IList<IWebElement> CategoryList1 { get; set; }

        internal void SearchCategory()
        {
            Thread.Sleep(1000);
            Searchskill1.SendKeys("Automation");

            Thread.Sleep(1000);
            SearchIcon1.Click();


            Thread.Sleep(1000);
            int NumCategory = CategoryList1.Count;
            Console.WriteLine(NumCategory);

            Thread.Sleep(1000);
            for (int i = 0; i < NumCategory; i++)
            {
                string CategoryName = CategoryList1.ElementAt(i).Text;
                Console.WriteLine(CategoryName);

                if (CategoryName.Contains("Writing & Translation"))
                {
                    Thread.Sleep(2000);
                    CategoryList1.ElementAt(i).Click();
                }
            }
        }
    }
}*/
#endregion








