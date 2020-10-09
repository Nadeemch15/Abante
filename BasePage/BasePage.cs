using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbanteCart
{
    class BasePage
    {
        public static IWebDriver driver { get; set; }
        public void Web_Init()
        {
            driver=new ChromeDriver();
            driver.Navigate().GoToUrl("https://demo.abantecart.com/index.php?rt=account/login");
            driver.Manage().Window.Maximize(); 
        }
        public void CloseWeb()
        {
            driver.Close();
        }
    }
}
