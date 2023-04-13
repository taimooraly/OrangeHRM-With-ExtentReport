using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OrangeHRM;
using System;
using System.Threading;

namespace OrangeHRM
{
    public class AddUser : BasePage
    {
        public void Adduser()
        {
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//*[@id='app']/div[1]/div[2]/div[2]/div/div[2]/div[1]/button")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("/html/body/div/div[1]/div[2]/div[2]/div/div/form/div[1]/div/div[1]/div/div[2]/div/div/div[1]")).SendKeys("e");
            driver.FindElement(By.XPath("/html/body/div/div[1]/div[2]/div[2]/div/div/form/div[1]/div/div[1]/div/div[2]/div/div/div[1]")).SendKeys(Keys.Enter);
            driver.FindElement(By.XPath("/html/body/div/div[1]/div[2]/div[2]/div/div/form/div[1]/div/div[2]/div/div[2]/div/div/input")).SendKeys("a");
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("/html/body/div/div[1]/div[2]/div[2]/div/div/form/div[1]/div/div[2]/div/div[2]/div/div/input")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("/html/body/div/div[1]/div[2]/div[2]/div/div/form/div[1]/div/div[2]/div/div[2]/div/div/input")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("/html/body/div/div[1]/div[2]/div[2]/div/div/form/div[1]/div/div[2]/div/div[2]/div/div/input")).SendKeys(Keys.Enter);
            driver.FindElement(By.XPath("/html/body/div/div[1]/div[2]/div[2]/div/div/form/div[1]/div/div[3]/div/div[2]/div/div/div[1]")).SendKeys("e");
            driver.FindElement(By.XPath("/html/body/div/div[1]/div[2]/div[2]/div/div/form/div[1]/div/div[3]/div/div[2]/div/div/div[1]")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("/html/body/div/div[1]/div[2]/div[2]/div/div/form/div[1]/div/div[3]/div/div[2]/div/div/div[1]")).SendKeys(Keys.Enter);
            driver.FindElement(By.XPath("/html/body/div/div[1]/div[2]/div[2]/div/div/form/div[1]/div/div[4]/div/div[2]/input")).SendKeys("Taimoor");
            driver.FindElement(By.XPath("/html/body/div/div[1]/div[2]/div[2]/div/div/form/div[2]/div/div[1]/div/div[2]/input")).SendKeys("Mujahidakberali@#@#121");
            driver.FindElement(By.XPath("/html/body/div/div[1]/div[2]/div[2]/div/div/form/div[2]/div/div[2]/div/div[2]/input")).SendKeys("Mujahidakberali@#@#121");
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("/html/body/div/div[1]/div[2]/div[2]/div/div/form/div[3]/button[2]")).Click();
            Thread.Sleep(3000);
        }
    }
}
