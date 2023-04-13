using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OrangeHRM;
using System;
using System.Threading;

namespace OrangeHRM
{
    public class UpdateUser : BasePage
    {
        public void updateuser()
        {
            Thread.Sleep(7000);
            driver.FindElement(By.XPath("/html/body/div/div[1]/div[2]/div[2]/div/div[1]/div[2]/form/div[1]/div/div[1]/div/div[2]/input")).SendKeys("Taimoor");
            driver.FindElement(By.XPath("/html/body/div/div[1]/div[2]/div[2]/div/div[1]/div[2]/form/div[2]/button[2]")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("/html/body/div/div[1]/div[2]/div[2]/div/div[2]/div[3]/div/div[2]/div/div/div[6]/div/button[2]")).Click();
            Thread.Sleep(3000);
            var element = driver.FindElement(By.XPath("/html/body/div/div[1]/div[2]/div[2]/div/div/form/div[1]/div/div[4]/div/div[2]/input"));
            Actions action = new Actions(driver);
            action.DoubleClick(element).Perform();
            driver.FindElement(By.XPath("/html/body/div/div[1]/div[2]/div[2]/div/div/form/div[1]/div/div[4]/div/div[2]/input")).SendKeys("Touseef");
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("/html/body/div/div[1]/div[2]/div[2]/div/div/form/div[2]/button[2]")).Click();
            Thread.Sleep(3000);
        }
    }
}
