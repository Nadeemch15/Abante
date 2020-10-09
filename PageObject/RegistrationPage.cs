using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbanteCart.PageObject
{
    class RegistrationPage
    {
        public RegistrationPage()
        {
            PageFactory.InitElements(BasePage.driver, this);
        }

        //[FindsBy(How = How.XPath, Using = "//a[contains(text(),'Login or register')]")]
        //public IWebElement Login_Register_Btn { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='accountFrm_accountregister']")]
        public IWebElement Register_Account_RadioBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='col-sm-6 newcustomer']//button[1]")]
        public IWebElement Rigister_ContinuBtn { get; set; }

        //Create Account Page
        //Personal Details
        [FindsBy(How = How.Id, Using = "AccountFrm_firstname")]
        public IWebElement Fname { get; set; }

        [FindsBy(How = How.Id, Using = "AccountFrm_lastname")]
        public IWebElement Lname { get; set; }

        [FindsBy(How = How.Id, Using = "AccountFrm_email")]
        public IWebElement Email { get; set; }

        [FindsBy(How = How.Id, Using = "AccountFrm_telephone")]
        public IWebElement TelePhone { get; set; }

        [FindsBy(How = How.Id, Using = "AccountFrm_fax")]
        public IWebElement Fax { get; set; }

        //Your Address
        [FindsBy(How = How.Id, Using = "AccountFrm_company")]
        public IWebElement Company { get; set; }

        [FindsBy(How = How.Id, Using = "AccountFrm_address_1")]
        public IWebElement Address1 { get; set; }

        [FindsBy(How = How.Id, Using = "AccountFrm_address_2")]
        public IWebElement Address2 { get; set; }

        [FindsBy(How = How.Id, Using = "AccountFrm_city")]
        public IWebElement City { get; set; }

        [FindsBy(How = How.Id, Using = "AccountFrm_zone_id")]
        public IWebElement RegionState { get; set; }

        [FindsBy(How = How.Id, Using = "AccountFrm_postcode")]
        public IWebElement ZipCode { get; set; }

        //Click on country's dropdown
        [FindsBy(How = How.XPath, Using = "//select[@id='AccountFrm_country_id']")]
        public IWebElement CountryDropDownClick { get; set; }

        [FindsBy(How = How.XPath, Using = "//select[@id='AccountFrm_country_id']")]
        public IWebElement Country_UK { get; set; }


        //Loging Details
        [FindsBy(How = How.Id, Using = "AccountFrm_loginname")]
        public IWebElement LoginName { get; set; }

        [FindsBy(How = How.Id, Using = "AccountFrm_password")]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.Id, Using = "AccountFrm_confirm")]
        public IWebElement ConfirmPass { get; set; }

        [FindsBy(How = How.Id, Using = "AccountFrm_newsletter0")]
        public IWebElement Suscribe { get; set; }

        [FindsBy(How = How.Id, Using = "AccountFrm_agree")]
        public IWebElement TermsCondition { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@class='btn btn-orange pull-right lock-on-click']")]
        public IWebElement ContinueBtn1 { get; set; }

        //assert my account
        [FindsBy(How = How.ClassName, Using = "maintext")]
        public IWebElement Confirm_MyAccount { get; set; }

        //Click on continue link
        [FindsBy(How = How.CssSelector, Using = "body.account-success:nth-child(2) div.container-fixed:nth-child(1) div.container-fluid div.col-md-9.col-xs-12.mt20 div.ct_padding_right div.contentpanel section.mb40 > a.btn.btn-default.mr10:nth-child(8)")]
        public IWebElement ContinueBtn2 { get; set; }

        //Click on the Home
        [FindsBy(How = How.XPath, Using = "//a[@class='active menu_home']")]
        public IWebElement HomeButton { get; set; }


        public void RegisterUserPage()
        {
            //Login_Register_Btn.Click();
            Register_Account_RadioBtn.Click();
            Rigister_ContinuBtn.Click();
        }
        public void Create_AccountPage()
        {
            Fname.SendKeys("Testing");
            Lname.SendKeys("Guru");
            Email.SendKeys("guru2713@gmail.com");
            TelePhone.SendKeys("07777777");
            Fax.SendKeys("012345");
            Company.SendKeys("IT_Tech");
            Address1.SendKeys("BFD");
            Address2.SendKeys("city road");
            City.SendKeys("Leeds");
            


            //DropDown list for Country
            SelectElement DropDown2 = new SelectElement(Country_UK);
            DropDown2.SelectByText("United Kingdom");
            BasePage.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //DropDown list for State/Region
            SelectElement DropDown1 = new SelectElement(RegionState);
            DropDown1.SelectByText("West Yorkshire");
            BasePage.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            ZipCode.SendKeys("12345");

           

            CountryDropDownClick.Click();
            //Country_UK.Click();

            LoginName.SendKeys("tguru2713");
            Password.SendKeys("123qwe");
            ConfirmPass.SendKeys("123qwe");
            Suscribe.Click();
            TermsCondition.Click();
            ContinueBtn1.Click();
            ContinueBtn2.Click();
            //Assert.IsTrue
        }

    }
}

    

 
