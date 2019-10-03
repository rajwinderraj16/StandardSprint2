using MarsFramework.Global;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsFramework.Pages
{
    class SignIn : Base
    {
        #region PageFactory With Lambda Expression
        //Initialization of Web Elements with Lambda Expression

        //Initialization of SingInTab
        IWebElement SignIntab => GlobalDefinitions.driver.FindElement(By.XPath("//a[@class='item']"));

        //Initialization of Email
        IWebElement Email => GlobalDefinitions.driver.FindElement(By.XPath("//input[@placeholder='Email address']"));

        //Initialization of Password
        IWebElement Password => GlobalDefinitions.driver.FindElement(By.XPath("//input[@placeholder='Password']"));

        //Initialization of Login button
        IWebElement LoginBtn => GlobalDefinitions.driver.FindElement(By.XPath("//button[@class='fluid ui teal button']"));

        public void clickOnSignintab()
        {
            //extent Reports
            Base.test = Base.extent.StartTest("Login Test");

            //Populate the Excel sheet
            Global.GlobalDefinitions.ExcelLib.PopulateInCollection(Global.Base.ExcelPath, "SignIn");

            //Navigate to the Url
            Global.GlobalDefinitions.driver.Navigate().GoToUrl(Global.GlobalDefinitions.ExcelLib.ReadData(2, "Url"));

            //Click on Sign In tab
            Thread.Sleep(2000);
            SignIntab.Click();
        }
        public void EnterUsernamePassword()
        {

            //Enter the data in Username textbox
            Email.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(2, "Username"));
            Thread.Sleep(500);

            //Enter the password 
            Password.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(2, "Password"));
        }

        public void ClickLoginButton()
        {

            //Click on Login button
            LoginBtn.Click();
            Thread.Sleep(1500);

            string text = Global.GlobalDefinitions.driver.FindElement(By.LinkText("Mars Logo")).Text;

            if (text == "Mars Logo")
            {
                Global.Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Login Successful");
            }
            else
                Global.Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Login Unsuccessful");
        }
    }
}

        #endregion Labmda Expression


        #region  PageFactory with FindBy Approach

     /*   public SignIn()
        {
            PageFactory.InitElements(GlobalDefinitions.driver, this);
        }
        // public object driver { get; private set; }


        // #region  Initialize Web Elements 
        //Finding the Sign Link
        [FindsBy(How = How.XPath, Using = "//a[@class='item']")]
        private IWebElement SignIntab { get; set; }

        // Finding the Email Field
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Email address']")]
        private IWebElement Email { get; set; }

        //Finding the Password Field
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Password']")]
        private IWebElement Password { get; set; }

        //Finding the Login Button
        [FindsBy(How = How.XPath, Using = "//button[@class='fluid ui teal button']")]
        private IWebElement LoginBtn { get; set; }


        internal void LoginSteps()

        {
            //extent Reports
            Base.test = Base.extent.StartTest("Login Test");

            //Populate the Excel sheet
            Global.GlobalDefinitions.ExcelLib.PopulateInCollection(Global.Base.ExcelPath, "SignIn");

            //Navigate to the Url
            Global.GlobalDefinitions.driver.Navigate().GoToUrl(Global.GlobalDefinitions.ExcelLib.ReadData(2, "Url"));

            //Click on Sign In tab
            Thread.Sleep(2000);
            SignIntab.Click();

            //Enter the data in Username textbox
            Email.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(2, "Username"));
            Thread.Sleep(500);

            //Enter the password 
            Password.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(2, "Password"));

            //Click on Login button
            Thread.Sleep(2000);
            LoginBtn.Click();

             string text = Global.GlobalDefinitions.driver.FindElement(By.LinkText("Mars Logo")).Text;

              if (text == "Mars Logo")
              {
                  Global.Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Login Successful");
              }
              else
                  Global.Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Login Unsuccessful");
        }
    }
}*/
#endregion PageFactory








































































