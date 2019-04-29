using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    class MainPage
    {
        public MainPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);

        }

        [FindsBy(How = How.CssSelector, Using = ".panel-container__newPost")]
        private IWebElement newPostButton;

        public Boolean isMainPageOpened()
        {
            return newPostButton.Displayed;
        }
    }
}
