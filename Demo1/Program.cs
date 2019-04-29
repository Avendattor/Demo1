using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        [Test]
        public void test1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://localhost:3030/admin";

            LoginPage loginPage = new LoginPage(driver);
            Boolean isLoginSuccessfull = loginPage.Login("admin", "admin").isMainPageOpened();
            Assert.IsTrue(isLoginSuccessfull, "Login Failed");
            //driver.Close();
        }
    }
}
