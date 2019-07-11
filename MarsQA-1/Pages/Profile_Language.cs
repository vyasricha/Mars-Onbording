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

namespace MarsQA_1.Pages
{
    class Profile_Language
    {
        //Add New Language
       /* public void AddNewLanguage(String language)
        {
            //Click on 'Add New' Button
            Driver.driver.FindElement(By.XPath("//div[@class='ui bottom attached tab segment active tooltip-target']//div[contains(@class,'ui teal button')][contains(text(),'Add New')]")).Click();
           
            //Add new Language
             Driver.driver.FindElement(By.XPath("//input[@placeholder='Add Language']")).SendKeys(language);
           
            //Select language level
            IWebElement Level = Driver.driver.FindElement(By.XPath("//select[@name='level']"));
            Level.Click();

            //Choose the language level
            SelectElement LevelSelect = new SelectElement(Level);
            LevelSelect.SelectByText("Basic");
            
            //Click on Add button
            Driver.driver.FindElement(By.XPath("//body//div[@id='account-profile-section']//div//div//div//div//div//div[3]//input[1]")).Click();
            Thread.Sleep(1000);
        }
        public void ValidateAddLanguage(String language)
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports(); 

                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.Extent.StartTest("Add Laanguage");

                Thread.Sleep(1000);
                string Expected = language;
                // html[1] / body[1] / div[1] / div[1] / section[2] / div[1] / div[1] / div[1] / div[3] / form[1] / div[2] / div[1] / div[2] / div[1] / table[1] / tbody[1] / tr[1] / td[1]
                ///html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/table[1]/tbody[2]/tr[1]/td[1]
                for (int i = 1; i <= 4; i++)
                {
                    string Actual = Driver.driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/table[1]/tbody[" + i + "]/tr[1]/td[1]")).Text;

                    Thread.Sleep(500);
                    if (Expected == Actual)
                    {
                        CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Added Language Successfully");
                        SaveScreenShotClass.SaveScreenshot(Driver.driver, "Language Added");
                    }
                    else
                        CommonMethods.test.Log(LogStatus.Fail, "Test Failed");
                }
            }
            catch (Exception e)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed", e.Message);
            }
        }*/
       
        public void EditLanguage()
        {
            var SelectedLanguage = Driver.driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[1]")).Text;
           
            for (int i = 1; i <= 4; i++)
            {
                if (SelectedLanguage == "French")
                {
                    //click on edit icon
                    Driver.driver.FindElement(By.XPath("//div[@class='ui bottom attached tab segment active tooltip-target']//tbody[" + i + "]//tr[1]//td[3]//span[1]//i[1]")).Click();
                   
                    //clear existing language
                    Driver.driver.FindElement(By.XPath("//input[@placeholder='Add Language']")).Clear();
                   
                    //edit language
                    Driver.driver.FindElement(By.XPath("//input[@placeholder='Add Language']")).SendKeys(ExcelLibHelper.ReadData(7, "Language"));
                   
                    //wait
                    Thread.Sleep(500);
                   
                    //click on edit button
                    Driver.driver.FindElement(By.XPath("//input[@class='ui teal button']")).Click();
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

                CommonMethods.test = CommonMethods.Extent.StartTest("Edit a Language");

                Thread.Sleep(1000);
                string Expected = ExcelLibHelper.ReadData(6, "Language");
                for (int i = 1; i <= 4; i++)
                {
                    var Actual = Driver.driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[1]")).Text;
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
            //Select Language
            var delete = Driver.driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[1]")).Text;
            for (int i = 1; i <= 4; i++)
            {
                
            //    Console.WriteLine(delete);
                if (delete == ExcelLibHelper.ReadData(7, "Language"))
                {
                    //click on delete icon
                    Driver.driver.FindElement(By.XPath("//div[@class='ui bottom attached tab segment active tooltip-target']//tbody[" + i + "]//tr[1]//td[3]//span[2]//i[1]")).Click();
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
                CommonMethods.test = CommonMethods.Extent.StartTest("Delete Language");

                Thread.Sleep(1000);
                string deletedValue = ExcelLibHelper.ReadData(6, "Language");
                for (int i = 1; i <= 4; i++)
                {
                    var Actual = Driver.driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[1]")).Text;
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

