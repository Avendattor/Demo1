using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    class LoginPage
    {
        private IWebDriver driver;
        public LoginPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
            this.driver = driver;

        }

        [FindsBy(How = How.XPath, Using = ".//*[@type='text']")]
        private IWebElement loginField;

        [FindsBy(How = How.XPath, Using = ".//*[@type='password']")]
        private IWebElement passwordField;

        [FindsBy(How = How.XPath, Using = ".//*[@type='submit']")]
        private IWebElement loginButton;

        public MainPage Login(String login, String password)
        {
            loginField.SendKeys(login);
            passwordField.SendKeys(password);
            loginButton.Click();

            return new MainPage(driver);
        }
    }
}
