using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System.Threading;
using static System.Net.WebRequestMethods;
using OpenQA.Selenium.Support.UI;


namespace TESTTEST
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {


            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://staging.garageclothing.xyz/ca/profile/login";
            driver.Manage().Window.Maximize();
            //EdgeOptions options = new EdgeOptions();
            //options.AddArguments("--start-maximized");
            driver.FindElement(By.Name("login-email")).SendKeys("testaccount@QAtest1.com");
            driver.FindElement(By.Name("login-password")).SendKeys("Password_4321");
            driver.FindElement(By.XPath("//input[@value='Login']")).Submit();
            Thread.Sleep(5000);
            driver.Navigate().GoToUrl("https://staging.garageclothing.xyz/ca/g/new/new-this-week/");
            Thread.Sleep(10000);

           WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector("#react-Plp > div > div.tiles-container.css-18yislf.es68lx90 > div:nth-child(1) > div > div.css-w22jp4.e18cwdo918 > a > div.PLP_div_wishlist_btn.css-1ceduir.e18cwdo912 > button > svg")));

            driver.FindElement(By.CssSelector("#react-Plp > div > div.tiles-container.css-18yislf.es68lx90 > div:nth-child(1) > div > div.css-w22jp4.e18cwdo918 > a > div.PLP_div_wishlist_btn.css-1ceduir.e18cwdo912 > button > svg")).Click();

            IWebElement element1 = driver.FindElement(By.CssSelector("#react-Plp > div > div.tiles-container.css-18yislf.es68lx90 > div:nth-child(1) > div > div.css-w22jp4.e18cwdo918 > a > div.PLP_div_wishlist_btn.css-1ceduir.e18cwdo912 > button > svg"));
            string image = element1.GetCssValue("background-image");

            //Assert.IsTrue(image.Contains("https://staging.garageclothing.xyz/on/demandware.static/Sites-DynamiteGarageCA-Site/-/default/dw31f645be/images/svg-icons/icon-w-l-fill.svg"));

            WebDriverWait wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait2.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("(//p[text()='1'])[1]")));
        }
    }
}
