using System;
using MarsQA_1.Helpers;
using MarsQA_1.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;

namespace MarsQA_1.Steps
{
    [Binding]
    public class LanguagesTabSteps : Utils.Start
    {
        private Profile_Language langobj;
       
        [Given(@"I am on the Languages tab")]
        public void GivenIAmOnTheLanguagesTab()
        {
          //  setup();
            // Select Language Tab
            Driver.driver.FindElement(By.XPath("//A[@class='item active'][text()='Languages']")).Click();
        }

        [When(@"I click on Add New Button and I add new language and level")]
        public void WhenIClickOnAddNewButtonAndIAddNewLanguageAndLevel()
        {
           langobj = new Profile_Language();
           langobj.AddNewLanguage();
        }


        [Then(@"new language and level should display on my listing")]
        public void ThenNewLanguageAndLevelShouldDisplayOnMyListing()
        {
            langobj.ValidateAddLanguage();
            //TearDown();
        }

        
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
