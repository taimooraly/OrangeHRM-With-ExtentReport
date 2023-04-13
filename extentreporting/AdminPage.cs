using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Threading;

namespace OrangeHRM
{

    public class AdminPage : BasePage
    {

        By AdminBTN = By.ClassName("oxd-main-menu-item");

        public void Admin()
        {
            Thread.Sleep(3000);
            Click(AdminBTN);
        }
    }
}
