using MarsFramework.Global;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsFramework.Pages
{
    class SignUp
    {

        #region PageFactory with Lambda expression
        //Initialization of WebEleemnts
        IWebElement Join => GlobalDefinitions.driver.FindElement(By.XPath("//button[@class='ui green basic button']"));
        IWebElement FirstName => GlobalDefinitions.driver.FindElement(By.XPath("//input[@placeholder='First name']"));
        IWebElement LastName => GlobalDefinitions.driver.FindElement(By.XPath("//input[@placeholder='Last name']"));
        IWebElement Email => GlobalDefinitions.driver.FindElement(By.XPath("//input[@placeholder='Email address']"));
        IWebElement Password => GlobalDefinitions.driver.FindElement(By.XPath("//input[@placeholder='Password']"));
        IWebElement ConfirmPassword => GlobalDefinitions.driver.FindElement(By.XPath("//input[@placeholder='Confirm Password']"));
        IWebElement CheckBox => GlobalDefinitions.driver.FindElement(By.XPath("//input[@name='terms']"));
        IWebElement JoinButton => GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='submit-btn']"));

        public void ClickJoinBTN()
        {
            //Click on the Join button
            Join.Click();
        }

        public void EnterDetails()
        {
            //Populate the excel data
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "SignUp");

            //Enter FirstName
            FirstName.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "FirstName"));

            //Enter LastName
            LastName.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "LastName"));

            //Enter Email
            Email.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Email"));

            //Enter Password
            Password.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Password"));

            //Enter Password again to confirm
            ConfirmPassword.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "ConfirmPswd"));

            //Click on the join button to sign up
            CheckBox.Click();

        }

        public void Joinbtn()
        {
            //Click on the join button
            JoinButton.Click();
        }
    }
}

        #endregion region

        #region Initialization of WebElements with Pagefactory with FindBy Approach

   /*     public SignUp()
        {
            PageFactory.InitElements(MarsFramework.Global.GlobalDefinitions.driver, this);
        }


        //Finding the Join 
        [FindsBy(How = How.XPath, Using = "//*[@id='home']/div/div/div[1]/div/button")]
        private IWebElement Join1 { get; set; }

        //Identify FirstName Textbox
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div/form/div[1]/input")]
        private IWebElement FirstName1 { get; set; }

        //Identify LastName Textbox
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div/form/div[2]/input")]
        private IWebElement LastName1 { get; set; }

        //Identify Email Textbox
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div/form/div[3]/input")]
        private IWebElement Email1 { get; set; }

        //Identify Password Textbox
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div/form/div[4]/input")]
        private IWebElement Password1 { get; set; }

        //Identify Confirm Password Textbox
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div/form/div[5]/input")]
        private IWebElement ConfirmPassword1 { get; set; }

        //Identify Term and Conditions Checkbox
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div/form/div[6]/div/div/input")]
        private IWebElement Checkbox1 { get; set; }

        //Identify join button
        [FindsBy(How = How.XPath, Using = "//*[@id='submit-btn']")]
        private IWebElement JoinBtn1 { get; set; }

        internal void register()
        {
            //Populate the excel data
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "SignUp");
            //Click on Join button
            Join1.Click();

            //Enter FirstName
            FirstName1.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "FirstName"));

            //Enter LastName
            LastName1.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "LastName"));

            //Enter Email
            Email1.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Email"));

            //Enter Password
            Password1.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Password"));

            //Enter Password again to confirm
            ConfirmPassword1.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "ConfirmPswd"));

            //Click on Checkbox
            Checkbox1.Click();

            //Click on join button to Sign Up
            JoinBtn1.Click();


        }
    }
}*/

#endregion Page Factory