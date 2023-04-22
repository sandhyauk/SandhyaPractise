using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Chromium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectMS
{
    [TestClass]
    public class DragDrop
    {
        [TestMethod]
        public void dragFun()

        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://demo.guru99.com/test/drag_drop.html");

            driver.Manage().Window.Maximize();

            IWebElement startingpoint = driver.FindElement(By.XPath("//a[text()=' SALES ']"));
            IWebElement target = driver.FindElement(By.Id("loan"));

            Actions act = new Actions(driver);
            act.DragAndDrop(startingpoint, target);

            //IWebElement startingpoint1 = driver.FindElement(By.XPath("//a[text()=' OWNER'S EQUITY']"));
            //IWebElement target1 = driver.FindElement(By.Id("bank"));
            //act.DragAndDrop(startingpoint1, target1);

            IWebElement startingpoint2 = driver.FindElement(By.XPath("//a[text()=' 5000 ']"));
            IWebElement target2 = driver.FindElement(By.Id("amt7"));
            act.DragAndDrop(startingpoint2, target2);

            IWebElement startingpoint3 = driver.FindElement(By.XPath("//a[text()=' SALES ']"));
            IWebElement target3 = driver.FindElement(By.Id("loan"));
            act.DragAndDrop(startingpoint3, target3);

            IWebElement startingpoint4 = driver.FindElement(By.XPath("//a[text()=' 5000 ']"));
            IWebElement target4 = driver.FindElement(By.Id("amt8"));
            act.DragAndDrop(startingpoint4, target4);

            Thread.Sleep(1000);

            driver.Quit();







        }
    }
}
