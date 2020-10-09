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

namespace AbanteCart.Test
{
    [TestFixture]
    class DragDrop
    {
        private ChromeDriver _driver;
        private Actions _action;
        private WebDriverWait _wait;

        [SetUp]
        public void SetUp()
        {
            _driver = new ChromeDriver();
            _action = new Actions(_driver);           
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(6));
        }
        
        [Test]
        public void DragDropExample1()
        {
            _driver.Navigate().GoToUrl("https://jqueryui.com/droppable/");
            _wait.Until(ExpectedConditions.FrameToBeAvailableAndSwitchToIt(By.ClassName("demo-frame")));

            IWebElement sourceElement = _driver.FindElement(By.Id("draggable"));
            IWebElement targetElement = _driver.FindElement(By.Id("droppable")); 
            _action.DragAndDrop(sourceElement, targetElement).Perform();
            Assert.AreEqual("Dropped!", targetElement.Text);
            Console.WriteLine(targetElement.Text);
        }
        [Test]
        public void DragDropExample2()
        {
            _driver.Navigate().GoToUrl("https://jqueryui.com/droppable/");
            _wait.Until(ExpectedConditions.FrameToBeAvailableAndSwitchToIt(By.ClassName("demo-frame")));

            IWebElement sourceElement = _driver.FindElement(By.Id("draggable"));
            IWebElement targetElement = _driver.FindElement(By.Id("droppable"));
            var drag = _action
                .ClickAndHold(sourceElement)
                .MoveToElement(targetElement)
                .Release(targetElement)
                .Build();
                drag.Perform();
            Assert.AreEqual("Dropped!", targetElement.Text);
        }
        [TearDown]
        public void Teardown()
        {
            //_driver.Close();
        }

    }
}
