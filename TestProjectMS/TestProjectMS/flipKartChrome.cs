using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectMS

{
    [TestClass]
    public class flipKartChrome
    {
        [TestMethod]
        public void BrowserOpen()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.flipkart.com/");



            driver.FindElement(By.XPath("//button[text()='✕']")).Click();

            Thread.Sleep(3000);

            IWebElement menu = driver.FindElement(By.XPath("//div[contains(text(),'Fashion')]"));

            Actions act = new Actions(driver);
            act.MoveToElement(menu).Perform();




            IWebElement ethnic = driver.FindElement(By.XPath("//a[contains(text(),'Women Ethnic')]"));

            act.MoveToElement(ethnic).Perform();

            driver.FindElement(By.XPath("//a[text()='Women Sarees']")).Click();

            



        }

        
    }
}
