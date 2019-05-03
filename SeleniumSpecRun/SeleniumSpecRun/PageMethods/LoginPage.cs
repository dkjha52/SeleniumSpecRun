using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumSpecRun.PageMethods
{
    class LoginPage
    {
        private IWebDriver driver;

        String toggle_menu = "//a[@id='menu-toggle']/i";
        String loginMenu = "//a[contains(text(),'Login')]";
        String userID = "//input[@id='txt-username']";
        String password = "//input[@id='txt-password']";
        String loginBtn = "//button[@id='btn-login']";

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void goToPage()
        {
            driver.Navigate().GoToUrl("http://demoaut.katalon.com/");
        }

        public void goToToggleMenu()
        {
            driver.FindElement(By.XPath(toggle_menu)).Click();
        }
        public void goToLoginMenu()
        {
            driver.FindElement(By.XPath(loginMenu)).Click();
        }
        public void enterUserName(string text)
        {
            driver.FindElement(By.XPath(userID)).SendKeys(text);
        }
        public void enterPassword(string text)
        {
            driver.FindElement(By.XPath(password)).SendKeys(text);
        }
        public void clickLoginBtn()
        {
            driver.FindElement(By.XPath(loginBtn)).Click();
        }
        public void closeBrowser()
        {
            driver.Quit();
        }
    }
}
