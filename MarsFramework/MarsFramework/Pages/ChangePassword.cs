using MarsFramework.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsFramework.Pages
{
    class ChangePassword
    {

 #region  Initialization of WebElements with Lambda Expression

        //Initialize the dropdown link field
        IWebElement Dropdownlink => GlobalDefinitions.driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/span[1]"));

        //Initialize the Change Password
        IWebElement Changemypass => GlobalDefinitions.driver.FindElement(By.XPath("//a[contains(text(),'Change Password')]"));

        //Initialize the current password field
        IWebElement CurrentPassword => GlobalDefinitions.driver.FindElement(By.XPath("//input[@placeholder='Current Password']"));

        //Initialize the new  password field
        IWebElement Newpassword => GlobalDefinitions.driver.FindElement(By.XPath("//input[@placeholder='New Password']"));

        //Initialize the confirm password field
        IWebElement Confirmpassword => GlobalDefinitions.driver.FindElement(By.XPath("/input[@placeholder='Confirm Password']"));

        //Initialize the save button
        IWebElement Save => GlobalDefinitions.driver.FindElement(By.XPath("//button[@class='ui button ui teal button']"));

        public void ClickOnDropdwon()
        {
            //Hover mouse over dropdown
            Actions act = new Actions(GlobalDefinitions.driver);
            act.MoveToElement(Dropdownlink).Build().Perform();
        }

        public void ClickOnChangePassword()
        {
            //Click on the ChangePassword
            Changemypass.Click();
        }

        public void Enter_CurrentPassword()
        {
            //Populate the Excel Sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "changepassword");

            //Enter the current password
            Thread.Sleep(2000);
            CurrentPassword.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "CurrentPassword"));

        }

        public void Enter_NewPassword()
        {
            //Populate the Excel Sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "changepassword");

            Thread.Sleep(2000);
            //Enter the new password
            Newpassword.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "NewPassword"));
        }

        public void Enter_ConfirmedPassword()
        {
            //Populate the Excel Sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "changepassword");

            Thread.Sleep(2000);
            //Enter the confirm password
            Confirmpassword.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "ConfirmPassword"));
        }

        public void ClickOnSave()
        {
            //Populate the Excel Sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "changepassword");

            Thread.Sleep(2000);
            //Click on the save button
            Save.Click();

        }
    }
}

#endregion

#region PageFactory  Approach with FindBy Approach
/*public ChangePassword()


{
    PageFactory.InitElements(MarsFramework.Global.GlobalDefinitions.driver, this);
}

// Initialize Web Elements 

//Initialize the dropdown link field
[FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/span[1]")]
private IWebElement Dropdownlink1 { get; set; }

//Initialize the Change Password
[FindsBy(How = How.XPath, Using = "//a[contains(text(),'Change Password')]")]
private IWebElement Changemypass1 { get; set; }


//Initialize the current password field
[FindsBy(How = How.XPath, Using = "//input[@placeholder='Current Password']")]
private IWebElement CurrentPassword1 { get; set; }

//Initialize the  new password field
[FindsBy(How = How.XPath, Using = "//input[@placeholder='New Password']")]
private IWebElement Newpassword1 { get; set; }

//Initialize the confirm password field
[FindsBy(How = How.XPath, Using = "//input[@placeholder='Confirm Password']")]
private IWebElement Confirmpassword1 { get; set; }


//Initialize the save button
[FindsBy(How = How.XPath, Using = "//button[@class='ui button ui teal button']")]
private IWebElement Save1 { get; set; }

internal void ChangePass()
{

    //Populate the Excel Sheet
    GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "changepassword");

    Thread.Sleep(3000);
    //Click on the dropdownlink
    Actions act = new Actions(GlobalDefinitions.driver);
    act.MoveToElement(Dropdownlink1).Build().Perform();


    Thread.Sleep(2000);
    //Click on the change password
    Changemypass1.Click();

    Thread.Sleep(2000);
    //Enter the current password
    CurrentPassword1.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "CurrentPassword"));

    Thread.Sleep(2000);
    //Enter the new password
    Newpassword1.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "NewPassword"));

    Thread.Sleep(2000);
    //Enter the confirm password
    Confirmpassword1.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "ConfirmPassword"));

    Thread.Sleep(2000);
    //Click on the save button
    Save1.Click();
    }
    }
    }*/

#endregion PageFactory Approach


















