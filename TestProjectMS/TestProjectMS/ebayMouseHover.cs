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
    public class ebayMouseHover
    {
        [TestMethod]
        public void hover()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://www.ebay.com/");

            IWebElement myEbay = driver.FindElement(By.XPath("//a[text()='My eBay']"));            
            
            Actions act = new Actions(driver);

            act.MoveToElement(myEbay).Perform();

            driver.FindElement(By.XPath("//a[text()=' Buy Again']")).Click();
            Thread.Sleep(1000);

            driver.Quit();



        }
    }
}
