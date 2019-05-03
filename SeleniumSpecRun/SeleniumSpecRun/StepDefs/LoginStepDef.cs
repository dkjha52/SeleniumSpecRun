using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using SeleniumSpecRun.PageMethods;
using OpenQA.Selenium.Chrome;

namespace SeleniumSpecRun.StepDefs
{
    [Binding]
    public class LoginStepDef
    {
        IWebDriver driver;
        LoginPage loginPage;

        [Given(@"Launch browser and navigate url")]
        public void GivenLaunchBrowserAndNavigateUrl()
        {
            ChromeDriverService service = ChromeDriverService.CreateDefaultService("webdriver.chrome.driver", @"D:\\Automation\\WebDrivers\\chromedriver.exe");
            driver = new ChromeDriver(service);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            driver.Manage().Window.Maximize();
            loginPage = new LoginPage(driver);
            loginPage.goToPage();
        }

        [When(@"Enter username and password details")]
        public void WhenEnterUsernameAndPasswordDetails()
        {
            loginPage.goToLoginMenu();
            loginPage.goToLoginMenu();
            loginPage.enterUserName("John Doe");
            loginPage.enterPassword("ThisIsNotAPassword");
        }

        [Then(@"click on Sign In button")]
        public void ThenClickOnSignInButton()
        {
            loginPage.clickLoginBtn();
            loginPage.closeBrowser();
        }

    }
}
