using AventStack.ExtentReports.Reporter.Configuration;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Policy;

namespace OrangeHRM
{
    public class  BasePage 
    {
        public static IWebDriver driver;
        public static ExtentReports extentReports;
        public static ExtentTest ParentTest;
        public static ExtentTest ChildTest;
        public static string dirpath;
        public static void SeleniumInitialization(string browser)
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }              
        public static void LogReport(string testcase)
        {
            extentReports = new ExtentReports();
            dirpath = @"..\..\ExtentReport\" + '_' + testcase;

            ExtentHtmlReporter htmlReporter = new ExtentHtmlReporter(dirpath);

            htmlReporter.Config.Theme = Theme.Standard;

            extentReports.AttachReporter(htmlReporter);
        }
        public static void TakeScreenshot(IWebDriver driver, Status status, string stepDetail)
        {
            string path = @"C:\ExtentReport\" + "ExtentReportLog_" + DateTime.Now.ToString("yyyyMMddHHmmss");
            Screenshot image_username = ((ITakesScreenshot)driver).GetScreenshot();
            image_username.SaveAsFile(path + ".png", ScreenshotImageFormat.Png);
            BasePage.ChildTest.Log(status, stepDetail, MediaEntityBuilder
                .CreateScreenCaptureFromPath(path + ".png").Build());
        }
        public void Write(By by, string data)
        {
            //try
            //{
                driver.FindElement(by).SendKeys(data);
            //    TakeScreenshot(driver, Status.Pass, "Enter ");
            //}
            //catch (Exception ex)
            //{
            //    TakeScreenshot(driver, Status.Fail, "Enter Failed" + ex);
            //}
        }
        public static void Click(By by)
        {
            //try
            //{
                driver.FindElement(by).Click();
            //    TakeScreenshot(driver, Status.Pass, "Click ");
            //}
            //catch (Exception ex)
            //{
            //    TakeScreenshot(driver, Status.Fail, "Click Failed" + ex);
            //}
        }
        public void Clear(By by)
        {
            try
            {
                driver.FindElement(by).Clear();
                TakeScreenshot(driver, Status.Pass, "Clear ");
            }
            catch (Exception ex)
            {
                TakeScreenshot(driver, Status.Fail, "Clear Failed" + ex);
            }
        }
        public void OpenUrl(string url)
        {
            try
            {
                driver.Url = url;
                TakeScreenshot(driver, Status.Pass, "Open url");
            }
            catch (Exception ex)
            {
                TakeScreenshot(driver, Status.Fail, "Open Url Failed " + ex);
            }
        }
        public static void SeleniumClose()
        {
            driver.Close();
        }
    }
}
