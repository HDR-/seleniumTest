using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTests
{
    [TestFixture]
    public class IdenticonInputTest
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;
        
        [SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            baseURL = "http://identicon.azurewebsites.net/";
            verificationErrors = new StringBuilder();
        }
        
        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }
        
        [Test]
        public void TheIdenticonInputTest()
        {
            driver.Navigate().GoToUrl(baseURL + "/");
            driver.FindElement(By.Name("c")).SendKeys("567890");
            driver.FindElement(By.CssSelector("input.sendButton")).Click();
            try
            {
                Assert.IsTrue(IsElementPresent(By.XPath("//*[@id=\"body\"]/section[2]/div[1]/div[1]/img")));
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.AreEqual("Don's Park's identicon of int input:567890", driver.FindElement(By.XPath("//*[@id=\"body\"]/section[2]/div[1]/div[1]/p")).Text);
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            driver.FindElement(By.Name("c")).SendKeys("abcdef");
            driver.FindElement(By.CssSelector("input.sendButton")).Click();
            try
            {
                Assert.IsTrue(IsElementPresent(By.XPath("//*[@id=\"body\"]/section[2]/div[1]/div[1]/img")));
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.AreEqual("Don's Park's identicon of int input:abcdef", driver.FindElement(By.XPath("//*[@id=\"body\"]/section[2]/div[1]/div[1]/p")).Text);
            }
            catch (AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
        
        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }
        
        private string CloseAlertAndGetItsText() {
            try {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert) {
                    alert.Accept();
                } else {
                    alert.Dismiss();
                }
                return alertText;
            } finally {
                acceptNextAlert = true;
            }
        }
    }
}
