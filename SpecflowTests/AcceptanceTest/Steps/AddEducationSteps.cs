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
    public class AddEducationSteps
    {
        [Given(@"I am on profile page and i clicked on the eductaion tab")]
        public void GivenIAmOnProfilePageAndIClickedOnTheEductaionTab()
        {
            //Wait
            Thread.Sleep(1500);

            // Click on Education  tab
            Driver.driver.FindElement(By.XPath("(//a[contains(.,'Education')])[1]")).Click();
        }

        [When(@"I click on the add new button")]
        public void WhenIClickOnTheAddNewButton()
        {
            //Click on Add New button
            Driver.driver.FindElement(By.XPath("(//div[contains(.,'Add New')])[21]")).Click();
        }
        
        [When(@"I add details to add education")]
        public void WhenIAddDetailsToAddEducation()
        {
            //Add College/university name
            Driver.driver.FindElement(By.XPath("//input[contains(@placeholder,'College/University Name')]")).SendKeys("MIT");

            Driver.driver.FindElement(By.XPath("//select[contains(@name,'country')]")).Click();

            //Choose the country
            IWebElement country = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select/option[102]"));
            country.Click();

            //click on the title dropdown
            Driver.driver.FindElement(By.XPath("//select[contains(@name,'title')]")).Click();

            //Choose the title
            IWebElement Title = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select/option[7]"));
            Title.Click();

            //Enter the degree
            Driver.driver.FindElement(By.XPath("//input[contains(@placeholder,'Degree')]")).SendKeys("Bachelor");

            //Add a year of graduation
            Driver.driver.FindElement(By.XPath("//select[contains(@name,'yearOfGraduation')]")).Click();

            // Choose a year of graduation
            IWebElement Year = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select/option[10]"));
            Year.Click();

        }

        [When(@"I clicked on the add button")]
        public void WhenIClickedOnTheAddButton()
        {
            //Click on Add button
            Driver.driver.FindElement(By.XPath("//input[contains(@class,'ui teal button ')]")).Click();
        }
        
        [Then(@"the eduction should be dispalyed in the profile")]
        public void ThenTheEductionShouldBeDispalyedInTheProfile()
        {

            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Add a Education");

                Thread.Sleep(1000);
                string ExpectedValue = "B.Tech";
                string ActualValue = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]")).Text;
                Thread.Sleep(500);
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Added a Education Successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "EducationAdded");
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
