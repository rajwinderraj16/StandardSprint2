using MarsFramework.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsFramework
{
    public class Program
    {
        [TestFixture]
        [Category("Sprint1")]
        class SkillTrade : Global.Base
        {

            [Test]
            public void UserProfile()
            {
                // Creates a toggle for the given test, adds all log events under it    
                test = extent.StartTest("Test Passesd");


                // Create an class and obk.ect to call the method
               // Profile profileobj = new Profile();
               // profileobj.EditProfile();
            }

            [Test]
            public void TestSearchSkill()
            {
                //Create a searchskill class object to call the method
                //SearchSkill skill = new SearchSkill();
               // skill.EnterSkill();
            }

            [Test]
            public void Testchangepassword()
            {
                //Create a changepassword class object to call the method
                //ChangePassword chpass = new ChangePassword();
                //chpass.ChangePass();
            }

            [Test]
            public void TestManageListing()
            {
                //Create a managelisting class object to call the method
                //ManageListing Managelist = new ManageListing();
                //Managelist.ManageListFunc();
            }

            [Test]
            public void SearchCategory()
            {
                //Create a SearchCategory class object to call the method
               // SearchByCategory Sc = new SearchByCategory();
               // Sc.SearchCategory();
            }

            [Test]
            public void ShareSkill()
            {
                //Create a ShareSkill class object to call the method
                //ShareSkill shareskill = new ShareSkill();
                //shareskill.Skillsharing();

            }
        }
    }
}







