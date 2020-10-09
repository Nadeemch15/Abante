using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbanteCart.Test
{
    [TestFixture]
    class Webelement
    {
        IWebDriver driver = new ChromeDriver();
       
        [SetUp]
        public void Init()
        {
            
            driver.Navigate().GoToUrl("http://practice.automationtesting.in/");
            driver.Manage().Window.Maximize();

        }
        [Test]
        public void ClickMyAccount()
        {
            driver.FindElement(By.XPath("//a[contains(text(),'My Account')]")).Click();
        }
        [Test]
        public void Register()
        {

        }
        //[TearDown]
        //public void TestClose()
        //{
        //    driver.Close();
        //}
    }
}
