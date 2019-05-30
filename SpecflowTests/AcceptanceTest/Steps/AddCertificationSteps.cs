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
    public class AddCertificationSteps
    {
        [Given(@"I am on profile page and I clicked on the certification tab")]
        public void GivenIAmOnProfilePageAndIClickedOnTheCertificationTab()
        {
            //Wait
            Thread.Sleep(1500);

            // Click on Certification  tab
            Driver.driver.FindElement(By.XPath("//form//div[1]//a[4]")).Click();
        }
        
        [When(@"I clicked on the add new button")]
        public void WhenIClickedOnTheAddNewButton()
        {
            //Click on Add New button
            Driver.driver.FindElement(By.XPath("(//div[@class='ui teal button '][contains(.,'Add New')])[3]")).Click();
        }
        
        [When(@"I add all the detail for certification")]
        public void WhenIAddAllTheDetailForCertification()
        {
            //Add Certification
            Driver.driver.FindElement(By.XPath("(//input[contains(@type,'text')])[4]")).SendKeys("Testing Certification");


            // Certification From
            Driver.driver.FindElement(By.XPath("(//input[contains(@type,'text')])[5]")).SendKeys("MIT");

            //click on the Year dropdown
            Driver.driver.FindElement(By.XPath("//select[contains(@class,'ui fluid dropdown')]")).Click();

            //Choose the Year
            IWebElement Year = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select/option[4]"));
            Year.Click();
        }
        
        [When(@"I click on  add button")]
        public void WhenIClickOnAddButton()
        {

            //Click on Add button
            Driver.driver.FindElement(By.XPath("(//input[contains(@type,'button')])[1]")).Click();
        }
        
        [Then(@"the certification should be displayed in the profile")]
        public void ThenTheCertificationShouldBeDisplayedInTheProfile()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Add a Certification");

                Thread.Sleep(1000);
                string ExpectedValue = "Testing Certification";
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
