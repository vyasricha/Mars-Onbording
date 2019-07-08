using MarsQA_1.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using RelevantCodes.ExtentReports;
using static MarsQA_1.Helpers.CommonMethods;
using MarsQA_1.Steps;

namespace MarsQA_1.Pages
{
    class Profile_Language
    {
        //Add New Language
        public void AddNewLanguage()
        {
            // populate the data from Excel sheet
            ExcelLibHelper.PopulateInCollection(@"C:\Users\nilay\Documents\Richa 2019\MVPStudio\Selfmade\MarsQA-1\MarsQA-1\Data\Data.xlsx", "Language");

            for (int i = 2; i <= 5; i++)
            {  
                //Click on Add button
                Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div")).Click();

                //Add new Language
                Driver.driver.FindElement(By.XPath("(//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input")).SendKeys(ExcelLibHelper.ReadData(i, "Language"));

                //Select language level
                Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select")).Click();

                //Choose the language level
                IWebElement Lang = Driver.driver.FindElements(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option"))[i];
                Lang.Click();

                //Click on Add button
                Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]")).Click();
                Thread.Sleep(1000);
               
            }
        }
        public void ValidateAddLanguage()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();

                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Add Laanguage");

                Thread.Sleep(1000);
                string Expected = ExcelLibHelper.ReadData(3, "Language");

                for (var i = 1; i <= 4; i++)
                {
                    string Actual = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td[1]")).Text;

                    if (Expected == Actual)
                    { 
                        CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Added Language Successfully");
                        SaveScreenShotClass.SaveScreenshot(Driver.driver, "Language Added");
                        return;
                    }
                }
            }
            catch (Exception e)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed", e.Message);
            }
        }
       
        public void EditLanguage()
        {
            var SelectedLanguage = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[1]")).Text;

            for (int i = 1; i <= 4; i++)
            {
                if (SelectedLanguage == "Chinese")
                {
                    //click on edit icon
                    Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td[3]/span[1]/i")).Click();
                   
                    //clear existing language
                    Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td/div/div[1]/input")).Clear();
                   
                    //edit language
                    Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td/div/div[1]/input")).SendKeys(ExcelLibHelper.ReadData(6, "Language"));
                   
                    //wait
                    Thread.Sleep(500);
                   
                    //click on edit button
                    Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td/div/span/input[1]")).Click();
                    return;
                }
            }
        }
        public void ValidateEditLanguage()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);

                CommonMethods.test = CommonMethods.extent.StartTest("Edit a Language");

                Thread.Sleep(1000);
                string Expected = ExcelLibHelper.ReadData(5, "Language");
                for (int i = 1; i <= 4; i++)
                {
                    var Actual = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td[1]")).Text;
                    if (Actual == Expected)
                    {
                        CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Edited Successfully");
                        SaveScreenShotClass.SaveScreenshot(Driver.driver, "Language edited");
                        Thread.Sleep(500);
                        return;
                    }

                }
            }
            catch (Exception e)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed", e.Message);
            }

        }
        public void DeleteLanguage()
        {
            for (int i = 1; i <= 4; i++)
            {
                var delete = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td[1]")).Text;
                Console.WriteLine(delete);
                if (delete == ExcelLibHelper.ReadData(6, "Language"))
                {
                    //click on delete icon
                    Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td[3]/span[2]/i")).Click();
                    return;
                }
            }
        }
        public void ValidateDeleteLanguage()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Delete Language");

                Thread.Sleep(1000);
                string deletedValue = ExcelLibHelper.ReadData(6, "Language");
                for (int i = 1; i <= 4; i++)
                {
                    var Actual = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td[1]")).Text;
                    if (Actual != deletedValue)
                    {
                        CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Deleted Language Successfully");
                        SaveScreenShotClass.SaveScreenshot(Driver.driver, "Language Deleted");
                        Thread.Sleep(500);
                        return;
                    }
                }
            }
            catch (Exception e)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed", e.Message);
            }
        }
    }
 }

