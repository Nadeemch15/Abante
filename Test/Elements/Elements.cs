using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbanteCart.Test.HyperLink
{
    [TestFixture]
    class Elements
    {
        [Test]
        public void ClickLink()
        {
            BasePage Bpage = new BasePage();
            Bpage.Web_Init();
            IWebElement element = BasePage.driver.FindElement(By.ClassName("menu_text"));
            element.Click();
        }
        [Test]
        public void EnterText()
        {
            BasePage Bpage = new BasePage();
            Bpage.Web_Init();
            IWebElement element = BasePage.driver.FindElement(By.XPath("//input[@id='loginFrm_loginname']"));
            element.SendKeys("tguru2713");

        }
        
    }
}
