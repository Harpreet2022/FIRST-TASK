using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using SpecflowPages;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using static SpecflowPages.CommonMethods;

namespace SpecflowTests.AcceptanceTest.Steps
{
    [Binding]
    public class AddSkillsSteps
    {
        [Given(@"I am on profile page and i clicked on the skills tab")]
        public void GivenIAmOnProfilePageAndIClickedOnTheSkillsTab()
        {
            //Wait
            Thread.Sleep(1500);

            // Click on skills  tab
            Driver.driver.FindElement(By.XPath("//a[@class='item'][contains(.,'Skills')]")).Click();
        }

        [When(@"I Click on the add new button")]
        public void WhenIClickOnTheAddNewButton()
        {
            //click on add new button
            Driver.driver.FindElement(By.XPath("//div[@class='ui teal button'][contains(.,'Add New')]")).Click();

        }
        
        [When(@"I add the details to add skill")]
        public void WhenIAddTheDetailsToAddSkill()
        {
            //Add Skills
            Driver.driver.FindElement(By.XPath("//input[contains(@placeholder,'Add Skill')]")).SendKeys("ISTQB");

            //Click on Add Skills Level
            Driver.driver.FindElement(By.XPath("//select[contains(@class,'ui fluid dropdown')]")).Click();

            //Choose the Skill level
            IWebElement Skills = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option[2]"));
            Skills.Click();

        }

        [When(@"I click on the add button")]
        public void WhenIClickOnTheAddButton()
        {

            //Click on Add button
            Driver.driver.FindElement(By.XPath("//input[contains(@class,'ui teal button ')]")).Click();
        }
        
        [Then(@"the skill should be added in my profile")]
        public void ThenTheSkillShouldBeAddedInMyProfile()
        {

            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Add a Skill");

                Thread.Sleep(1000);
                string ExpectedValue = "ISTQB";
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
    }
}
