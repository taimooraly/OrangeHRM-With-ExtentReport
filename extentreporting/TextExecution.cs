using OrangeHRM;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using static Reportng_Extent_of_OrangeHRM.TestExecution;

namespace Reportng_Extent_of_OrangeHRM
{
    [TestClass]
    public class TestExecution : BasePage
    {
        public TestContext instance;
        public TestContext TestContext
        {
            set { instance = value; }
            get { return instance; }
        }
        [AssemblyInitialize()]
        public static void AssemblyInit(TestContext context)
        {
            LogReport("TestReport");
        }
        [AssemblyCleanup()]
        public static void AssemblyCleanup()
        {
            extentReports.Flush();
        }
        [TestInitialize]
        public void TestInit()
        {
            SeleniumInitialization("Chrome");
            ParentTest = extentReports.CreateTest(TestContext.TestName);
        }
        [TestCleanup]
        public void TestClose()
        {            
            SeleniumClose();
        }  
        
        [TestMethod]
        public void Login_With_Correct_Credentials()
        {
            ChildTest = ParentTest.CreateNode("Login With Correct Credentials");
            LoginPage loginpage = new LoginPage();
            loginpage.Login("url", "Admin", "admin123");            
        }

        [TestMethod]
        public void Login_With_Incorrect_Credentials()
        {
            ChildTest = ParentTest.CreateNode("Login With Incorrect Credentials");
            LoginPage loginpage = new LoginPage();
            loginpage.Login("url", "8dmin", "admin12");            
        }

        [TestMethod]
        public void Login_With_Special_Characters_And_Incorrect_Credentials()
        {
            ChildTest = ParentTest.CreateNode("Login With Special Characters And Correct Credentials");
            LoginPage loginpage = new LoginPage();
            loginpage.Login("url", "rdmin", "@^&$@");
        }

        [TestMethod]
        public void Admin_Page()
        {
            ChildTest = ParentTest.CreateNode("Login");
            LoginPage loginpage = new LoginPage();
            loginpage.Login("url", "Admin", "admin123");
            ChildTest = ParentTest.CreateNode("Admin Page");
            AdminPage adminpage = new AdminPage();
            adminpage.Admin();            
        }

        [TestMethod]
        public void Add_Users()
        {
            ChildTest = ParentTest.CreateNode("Login");
            LoginPage loginpage = new LoginPage();
            loginpage.Login("url", "Admin", "admin123");
            ChildTest = ParentTest.CreateNode("Admin Page");
            AdminPage adminpage = new AdminPage();
            adminpage.Admin();
            ChildTest = ParentTest.CreateNode("Add Users");
            AddUser adduser = new AddUser();
            adduser.Adduser();
        }

        [TestMethod]
        public void Update_Users()
        {
            ChildTest = ParentTest.CreateNode("Login");
            LoginPage loginpage = new LoginPage();
            loginpage.Login("url", "Admin", "admin123");
            ChildTest = ParentTest.CreateNode("Admin Page");
            AdminPage adminpage = new AdminPage();
            adminpage.Admin();
            ChildTest = ParentTest.CreateNode("Update Users");
            UpdateUser updateUser = new UpdateUser();
            updateUser.updateuser();           
        }

        [TestMethod]
        public void Delete_Users()
        {
            ChildTest = ParentTest.CreateNode("Login");
            LoginPage loginpage = new LoginPage();
            loginpage.Login("url", "Admin", "admin123");
            ChildTest = ParentTest.CreateNode("Admin Page");
            AdminPage adminpage = new AdminPage();
            adminpage.Admin();
            ChildTest = ParentTest.CreateNode("Delete Users");
            DeleteUser deleteUser = new DeleteUser();
            deleteUser.deleteuser();
        }

        [TestMethod]        
        public void Orange_HRM_Whole_Webiste()
        {
            ChildTest = ParentTest.CreateNode("Login");
            LoginPage loginpage = new LoginPage();
            loginpage.Login("url", "Admin", "admin123");
            ChildTest = ParentTest.CreateNode("Admin Page");
            AdminPage adminpage = new AdminPage();
            adminpage.Admin();
            ChildTest = ParentTest.CreateNode("Add Users");
            AddUser adduser = new AddUser();
            adduser.Adduser();
            ChildTest = ParentTest.CreateNode("Update Users");
            UpdateUser updateUser = new UpdateUser();
            updateUser.updateuser();
            ChildTest = ParentTest.CreateNode("Delete Users");
            DeleteUser deleteUser = new DeleteUser();
            deleteUser.deleteuser();
        }
    }
}
