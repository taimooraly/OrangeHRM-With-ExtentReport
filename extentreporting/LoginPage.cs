using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OrangeHRM;
using System;
using System.Threading;

namespace OrangeHRM
{

    public class LoginPage : BasePage 
    {

        By UsernameTxt = By.Name("username");        
        By PasswordTxt = By.Name("password");
        By LoginBTN = By.XPath("//*[@id='app']/div[1]/div/div[1]/div/div[2]/div[2]/form/div[3]/button");


        public void Login(string url, string user, string pass)
        {
            url = driver.Url = "https://opensource-demo.orangehrmlive.com/web/index.php/auth/login";
            Thread.Sleep(3000);
            Write(UsernameTxt, user);
            Write(PasswordTxt, pass);
            Click(LoginBTN);
        }
    }
}

