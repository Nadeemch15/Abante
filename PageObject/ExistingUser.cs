using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbanteCart.PageObject
{
    class ExistingUser
    {
        public ExistingUser()
        {
            PageFactory.InitElements(BasePage.driver, this);
        }
        [FindsBy(How = How.XPath, Using = "//input[@id='loginFrm_loginname']")]
        public IWebElement LoginName { get; set; }

        [FindsBy(How = How.Name, Using = "password")]
        public IWebElement Password { get; set; }


        [FindsBy(How = How.XPath, Using = "//form[@id='loginFrm']//button[1]")]
        public IWebElement LoginButton {get; set;}

        public void ExistingUsers()
        {
            LoginName.SendKeys("tguru2713");
            Password.SendKeys("123qwe");
            LoginButton.Click();

        }
    }
}
