using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectMS
{
    [TestClass]
    public class OpenChromeTest
    {
        [TestMethod]
        public void Browseropen()
            {
             IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://demo.guru99.com/test/newtours/register.php");
           
            driver.FindElement(By.Name("firstName")).SendKeys("sandhya");
            driver.FindElement(By.Name("lastName")).SendKeys("v");
            driver.FindElement(By.Name("phone")).SendKeys("1234567");
            driver.FindElement(By.Id("userName")).SendKeys("v@gmail.com");

            driver.FindElement(By.Name("address1")).SendKeys("123 main st");
            driver.FindElement(By.Name("city")).SendKeys("st pete");
            driver.FindElement(By.Name("state")).SendKeys("fl");
            driver.FindElement(By.Name("postalCode")).SendKeys("33321");

            IWebElement drop = driver.FindElement(By.Name("country"));
            SelectElement se = new SelectElement(drop);

            se.SelectByText("BURMA");

            driver.FindElement(By.Id("email")).SendKeys("v@gmail.com");
            driver.FindElement(By.Name("password")).SendKeys("2sg2f3");
            driver.FindElement(By.Name("confirmPassword")).SendKeys("2sg2f3");
            driver.FindElement(By.XPath("//a[text()='Selenium']"));
            driver.FindElement(By.XPath("//b[text()='Phone:']"));
            driver.FindElement(By.XPath("//td[@class='mouseOut']"));


            Thread.Sleep(1000);
            driver.FindElement(By.Name("submit")).Click();

            Thread.Sleep(6000);
            driver.Quit();

        }
    }
}
