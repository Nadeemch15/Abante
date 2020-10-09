
using AbanteCart.PageObject;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbanteCart.Test
{
    [TestFixture]
    public class AbanteTest
    {
        [SetUp]
        public void Initialise()
        {
            BasePage Bpage = new BasePage();
            Bpage.Web_Init();           
               
        }
        [Test]
        public void RegistrationPage()
        {
            RegistrationPage Rp = new RegistrationPage();
            Rp.RegisterUserPage();
            Rp.Create_AccountPage();
        }
        [Test]
        public void ExistingUser()
        {
            ExistingUser Eu = new ExistingUser();
            Eu.ExistingUsers();
        }
        [TearDown]
        public void Close()
        {
            BasePage Bpage = new BasePage();
            Bpage.CloseWeb();
        }
        

    }
}
