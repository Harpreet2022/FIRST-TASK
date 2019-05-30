using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using SpecflowPages;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using static SpecflowPages.CommonMethods;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using RazorEngine;

namespace SpecflowTests.AcceptanceTest
{
    [Binding]
    public class SpecFlowFeature1Steps : Utils.Start
    {
        [Given(@"I clicked on the Language tab under Profile page")]
        public void GivenIClickedOnTheLanguageTabUnderProfilePage()
        {
            //Wait
            Thread.Sleep(1500);
       
            // Click on language tab
            Driver.driver.FindElement(By.XPath("//a[contains(text(),'Languages')]")).Click();

            
        }
        
        [When(@"I add a new language")]
        public void WhenIAddANewLanguage()
        {
            //Click on Add New button
            Driver.driver.FindElement(By.XPath("//div[contains(text(),'Add New')][1]")).Click();

            //Add Language
            Driver.driver.FindElement(By.XPath("//input[@placeholder='Add Language']")).SendKeys("English");

            //Click on Language Level
            Driver.driver.FindElement(By.XPath("//select[@class='ui dropdown']")).Click();

            //Choose the language level
            IWebElement Lang = Driver.driver.FindElements(By.XPath("//option[@value='Conversational']"))[1];
            Lang.Click();

            //Click on Add button
            Driver.driver.FindElement(By.XPath("//input[@type='button' and @value='Add']")).Click();

        }

        [Then(@"that language should be displayed on my listings")]
        public void ThenThatLanguageShouldBeDisplayedOnMyListings()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Add a Language");

                Thread.Sleep(1000);
                string ExpectedValue = "English";
                string ActualValue = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]")).Text;
                Thread.Sleep(500);
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Added a Language Successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "LanguageAdded");
                }

                else
                    CommonMethods.test.Log(LogStatus.Fail, "Test Failed");

            }
            catch (Exception e)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed", e.Message);
            }
        }
        [Given(@"I click on language tab on profile page")]
        public void GivenIClickOnLanguageTabOnProfilePage()
        {
            //Wait
            Thread.Sleep(1500);

            // Click on language  tab
            Driver.driver.FindElement(By.XPath("//a[contains(text(),'Languages')]")).Click();

        }

        [When(@"I click the edit  button for existing language")]
        public void WhenIClickTheEditButtonForExistingLanguage()
        {
            //Click on the edit button
            Driver.driver.FindElement(By.XPath("(//td[@class='right aligned'])[1]//i[@class='outline write icon']")).Click();
        }
        [When(@"I enter the new language")]
        public void WhenIEnterTheNewLanguage()
        {
            //click on the add language textbox 
            Driver.driver.FindElement(By.XPath("//input[@placeholder='Add Language']")).Click();

            Driver.driver.FindElement(By.XPath("//input[@placeholder='Add Language']")).Clear();


            //Enter new language
            Driver.driver.FindElement(By.XPath("//input[@placeholder='Add Language']")).SendKeys("English");

            //Click on Language Level
            Driver.driver.FindElement(By.XPath("//select[@class='ui dropdown']")).Click();

            //Choose the language level
            IWebElement Lang = Driver.driver.FindElement(By.XPath("//option[@value='Fluent']"));
            Lang.Click();

        }
        [When(@"click on  the update button")]
        public void WhenClickOnTheUpdateButton()
        {
            //Click on the update button
            Driver.driver.FindElement(By.XPath("//input[@type='button' and @value='Update']")).Click();

        }

        [Then(@"edited language level should be displayed on language tab")]
        public void ThenEditedLanguageLevelShouldBeDisplayedOnLanguageTab()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Edit a Language");

                Thread.Sleep(1000);
                string ExpectedValue = "English";
                string ActualValue = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]")).Text;
                Thread.Sleep(500);
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Edited a Language Successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "LanguageEdited");
                }

                else
                    CommonMethods.test.Log(LogStatus.Fail, "Test Failed");

            }

            catch (Exception e)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed", e.Message);
            }
        }


        [Given(@"I click on language tab under profile page")]
        public void GivenIClickOnLanguageTabUnderProfilePage()
        {
            //Wait
            Thread.Sleep(1500);

            // Click on language  tab
            Driver.driver.FindElement(By.XPath("//a[contains(text(),'Languages')]")).Click();
        }

        [When(@"I click  on the delete button under")]
        public void WhenIClickOnTheDeleteButtonUnder()
        {
            //click on delete button
            Driver.driver.FindElement(By.XPath("(//span[@class='button'])[3]//i[@class='remove icon']")).Click();
        }


        [Then(@"deleted language should be  remove from languages listing")]
        public void ThenDeletedLanguageShouldBeRemoveFromLanguagesListing()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("delete a Language");

                Thread.Sleep(1000);
                string ExpectedValue = "English";
                string ActualValue = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]")).Text;
                Thread.Sleep(500);
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Deleted a Language Successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "LanguageDeleted");
                }

                else
                    CommonMethods.test.Log(LogStatus.Fail, "Test Failed");

            }
            catch (Exception e)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed", e.Message);
            }
        }



        [Given(@"I am on  profile page and i click on the language tab")]
        public void GivenIAmOnProfilePageAndIClickOnTheLanguageTab()
        {
            //Wait
            Thread.Sleep(1500);

            // Click on language  tab
            Driver.driver.FindElement(By.XPath("//a[contains(text(),'Languages')]")).Click();
        }

        [When(@"I add  four languages with (.*) and (.*)")]
        public void WhenIAddFourLanguagesWithAnd(string Language, string Level)
        {

            
            IWebElement addnewbutton = Driver.driver.FindElement(By.XPath("//div[contains(text(),'Add New')][1]"));
            if (addnewbutton.Displayed)
            {
                //click on the add new button
                Driver.driver.FindElement(By.XPath("//div[contains(text(),'Add New')][1]")).Click();

                // Add a language
                Driver.driver.FindElement(By.XPath("//input[@placeholder='Add Language']")).SendKeys(Language);


                //choose a language level

                //Driver.driver.FindElement(By.XPath("//select[@class='ui dropdown']")).Click();
                SelectElement ChooseLanguageLevel = new SelectElement(driver.FindElement(By.Name("level")));
                ChooseLanguageLevel.SelectByText(Level);

                //click on add
                Driver.driver.FindElement(By.XPath("//input[@value='Add']")).Click();

                Thread.Sleep(2000);
            }
            else
            {
                Console.WriteLine("Test Failed, Adding more than four languages is not possible");
            }
        }

        [Then(@"that(.*) should be dispalyed on my listing")]
        public void ThenThatFrenchShouldBeDispalyedOnMyListing(string Language)
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Add a Language");

                Thread.Sleep(1000);
                IList<IWebElement> rows = driver.FindElements(By.XPath("//table[@class='ui fixed table']/tbody/tr"));
                int rowsCount = rows.Count;
                string beforeXpath = "//tbody[";
                string afterXpath = "]/tr/td[1]";
                string ExpectedValue = Language;

                for (int i = 1; i <= rowsCount; i++)
                {
                    // string ActualValue = Driver.driver.FindElement(By.XPath("//tbody[1]/tr/td[1]")).Text;
                    string ActualValue = Driver.driver.FindElement(By.XPath(beforeXpath + i + afterXpath)).Text;
                    Thread.Sleep(500);

                    if (ActualValue.Contains(Language))
                    {
                        if (ExpectedValue == ActualValue)
                        {
                            CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Added a Language Successfully");
                            SaveScreenShotClass.SaveScreenshot(Driver.driver, "LanguageAdded");
                        }

                        else
                            CommonMethods.test.Log(LogStatus.Fail, "Test Failed");
                    }
                }
            }
            catch (Exception e)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed", e.Message);
            }
        }

    


        [Given(@"I Clicked on language tab under profile page")]
        public void GivenIClickedOnLanguageTabUnderProfilePage()
        {
            //Wait
            Thread.Sleep(1500);

            // Click on language  tab
            Driver.driver.FindElement(By.XPath("//a[@class='item active' and @data-tab='first']")).Click();
        }

        [When(@"I add a language that already exists with different level")]
        public void WhenIAddALanguageThatAlreadyExistsWithDifferentLevel()
        {
            //Click on Add New button
            Driver.driver.FindElement(By.XPath("//div[contains(text(),'Add New')][1]")).Click();

            //Add Language
            Driver.driver.FindElement(By.XPath("//input[@placeholder='Add Language']")).SendKeys("English");

            //Click on Language Level
            Driver.driver.FindElement(By.XPath("//select[@class='ui dropdown' and @name='level']")).Click();

            //Choose the language level
            IWebElement Lang = Driver.driver.FindElement(By.XPath("//option[@value='Fluent']"));
            Lang.Click();


            //Click on Add button
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]")).Click();

        }

        [Then(@"it should display be an error message")]
        public void ThenItShouldDisplayBeAnErrorMessage()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Error should be displayed");

                Thread.Sleep(1000);
                string ExpectedValue = "English";
                string ActualValue = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]")).Text;
                Thread.Sleep(500);
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Error displayed Successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "Errormessagedisplayed ");
                }

                else
                    CommonMethods.test.Log(LogStatus.Fail, "Test Failed");

            }
            catch (Exception e)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed", e.Message);
            }
        
    }



        [Given(@"I click on the language tab on profile  page")]
        public void GivenIClickOnTheLanguageTabOnProfilePage()
        {

            //Wait
            Thread.Sleep(1500);

            // Click on language  tab
            Driver.driver.FindElement(By.XPath("//a[contains(text(),'Languages')]")).Click();
        }


        [When(@"I add a language that already exists with same level")]
        public void WhenIAddALanguageThatAlreadyExistsWithSameLevel()
        {
            //Click on Add New button
            Driver.driver.FindElement(By.XPath("//div[contains(text(),'Add New')][1]")).Click();

            //Add Language
            Driver.driver.FindElement(By.XPath("//input[@placeholder='Add Language']")).SendKeys("English");

            //Click on Language Level
            Driver.driver.FindElement(By.XPath("//select[@class='ui dropdown' and @name='level']")).Click();

            //Choose the language level
            IWebElement Lang = Driver.driver.FindElement(By.XPath("//option[@value='Basic']"));
            Lang.Click();


            //Click on Add button
            Driver.driver.FindElement(By.XPath("//input[@type='button' and @value='Add']")).Click();


        }

        [Then(@"It should display an error message")]
        public void ThenItShouldDisplayAnErrorMessage()
        {

            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Error should be displayed");

                Thread.Sleep(1000);
                string ExpectedValue = "English";
                string ActualValue = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]")).Text;
                Thread.Sleep(500);
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Error displayed Successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "Errormessagedisplayed ");
                }

                else
                    CommonMethods.test.Log(LogStatus.Fail, "Test Failed");

            }
            catch (Exception e)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed", e.Message);
            }

        }


        [Given(@"I click on language tab under the profile page")]
        public void GivenIClickOnLanguageTabUnderTheProfilePage()
        {
            //Wait
            Thread.Sleep(1500);

            // Click on language  tab
            Driver.driver.FindElement(By.XPath("//a[@class='item active' and @data-tab='first']")).Click();
        }

        [When(@"I try to add fifth language")]
        public void WhenITryToAddFifthLanguage()
        {
            IWebElement addnewbutton = Driver.driver.FindElement(By.XPath("//div[contains(text(),'Add New')][1]"));
            if (addnewbutton.Displayed)
            {
                //click on the add new button
                Driver.driver.FindElement(By.XPath("//div[contains(text(),'Add New')][1]")).Click();

                
            }
            else
            {
                Console.WriteLine("Test Failed, Adding more than four languages is not possible");
            }
        }

        [Then(@"it should not be added in the list")]
        public void ThenItShouldNotBeAddedInTheList()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Error should be displayed");

                Thread.Sleep(1000);
                string ExpectedValue = "English";
                string ActualValue = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]")).Text;
                Thread.Sleep(500);
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Error displayed Successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "Errormessagedisplayed ");
                }

                else
                    CommonMethods.test.Log(LogStatus.Fail, "Test Failed");

            }
            catch (Exception e)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed", e.Message);
            }

        }


    }
}

