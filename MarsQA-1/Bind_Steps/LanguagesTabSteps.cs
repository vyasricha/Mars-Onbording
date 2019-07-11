using MarsQA_1.Helpers;
using MarsQA_1.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using RelevantCodes.ExtentReports;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using static MarsQA_1.Helpers.CommonMethods;

namespace MarsQA_1.Bind_Steps
{
    [Binding]
    public class LanguagesTabSteps
    {
        [Given(@"I am on the Languages tab")]
        public void GivenIAmOnTheLanguagesTab()
        {
            //Select Profile
            Driver.driver.FindElement(By.XPath("//div[@class='ui eight item menu']//a[@class='item'][contains(text(),'Profile')]")).Click();
            //Select Language Tab
            Driver.driver.FindElement(By.XPath("//a[@class='item active']")).Click();
        }
      //  Profile_Language languageObj;

        [When(@"I add new (.*) and level")]
        public void WhenIAddNewLanguageAndLevel(String language)
        {
            //   languageObj = new Profile_Language();
            // languageObj.AddNewLanguage(language);
           
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

        [Then(@"new (.*) and level should display on my listing")]
        public void ThenNewLanguageAndLevelShouldDisplayOnMyListing(String language)
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();

                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.Extent.StartTest("Add Laanguage");

                Thread.Sleep(1000);
                string Expected = language;
                for (int i = 1; i <= 4; i++)
                {
                    string Actual = Driver.driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/table[1]/tbody[" + i + "]/tr[1]/td[1]")).Text;

                    Thread.Sleep(500);
                    if (Expected == Actual)
                    {
                        CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Added Language Successfully");
                        SaveScreenShotClass.SaveScreenshot(Driver.driver, "Language Added");
                    }
                  /*  else
                        CommonMethods.test.Log(LogStatus.Fail, "Test Failed"); */
                }
            }
            catch (Exception e)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed", e.Message);
            }
            //  languageObj = new Profile_Language();
            //  languageObj.ValidateAddLanguage(language);
        }

        Profile_Language langobj;
        [Given(@"The language is alrady exist")]
        public void GivenTheLanguageIsAlradyExist()
        {
            // populate the data from Excel sheet
            ExcelLibHelper.PopulateInCollection(@"C:\Users\nilay\Documents\Richa 2019\MVPStudio\Selfmade\MarsQA-1\MarsQA-1\Data\Data.xlsx", "Language");

        }

        [When(@"I click on edit icon and edit selected language")]
        public void WhenIClickOnEditIconAndEditSelectedLanguage()
        {
            langobj = new Profile_Language();
            langobj.EditLanguage();
        }

        [Then(@"the edited language should display on my listings")]
        public void ThenTheEditedLanguageShouldDisplayOnMyListings()
        {
            langobj.ValidateEditLanguage();
        }

        [When(@"I click on delete icon and delete selected language")]
        public void WhenIClickOnDeleteIconAndDeleteSelectedLanguage()
        {
            langobj = new Profile_Language();
            langobj.DeleteLanguage();
        }
        
      [Then(@"the deleted language should not display on my listings")]
        public void ThenTheDeletedLanguageShouldNotDisplayOnMyListings()
        {
            langobj.ValidateDeleteLanguage();
        }
    }
}
