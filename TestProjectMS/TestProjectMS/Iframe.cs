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
    public class Iframe
    {
        [TestMethod]
        public void Frame() 
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://yatra.com");

           IWebElement hover=  driver.FindElement(By.XPath("//a[text()='Support ']"));
            Actions act = new Actions(driver);
            act.MoveToElement(hover).Perform();
            driver.FindElement(By.XPath("//a[text()='Talk To Us']")).Click();

            driver.SwitchTo().Frame("iframeChatBot");

            driver.FindElement(By.XPath("//button[text()='Invoices']")).Click();

            driver.SwitchTo().DefaultContent();

            driver.FindElement(By.Id("chatbot_close_button")).Click();




        }
    }
}
