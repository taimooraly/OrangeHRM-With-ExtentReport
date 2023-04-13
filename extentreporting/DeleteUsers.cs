using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OrangeHRM;
using System;
using System.Threading;

namespace OrangeHRM
{
    public class DeleteUser : BasePage
    {
        public void deleteuser()
        {
            Thread.Sleep(7000);
            driver.FindElement(By.XPath("/html/body/div/div[1]/div[2]/div[2]/div/div[1]/div[2]/form/div[1]/div/div[1]/div/div[2]/input")).SendKeys("Touseef");
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("/html/body/div/div[1]/div[2]/div[2]/div/div[1]/div[2]/form/div[2]/button[2]")).Click();
            driver.FindElement(By.XPath("/html/body/div/div[1]/div[2]/div[2]/div/div[1]/div[2]/form/div[2]/button[2]")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("/html/body/div/div[1]/div[2]/div[2]/div/div[2]/div[3]/div/div[1]/div/div[1]/div/label/span")).Click();
            driver.FindElement(By.XPath("/html/body/div/div[1]/div[2]/div[2]/div/div[2]/div[2]/div/div/button")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("/html/body/div/div[3]/div/div/div/div[3]/button[2]")).Click();
            Thread.Sleep(3000);
        }
    }
}
