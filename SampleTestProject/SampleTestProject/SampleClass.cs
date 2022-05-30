using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class SampleClass
    {
        private static IWebDriver _driver;

        [TestInitialize]
        public void Initialize()
        {
            _driver = new ChromeDriver();
            _driver.Navigate().GoToUrl("http://automationpractice.com");
        }

        [TestCleanup]
        public void Cleanup()
        {
            _driver.Quit();
        }

        [TestMethod]
        public void AddElementToCart()
        {
            IWebElement AddToCartButton = _driver.FindElement(By.CssSelector("#homefeatured [data-id-product='1'] > span"));
            AddToCartButton.Click();
            IWebElement AddedPopup = _driver.FindElement(By.CssSelector(".layer_cart_product"));
            Assert.IsNotNull(AddedPopup);
        }
    }
}
