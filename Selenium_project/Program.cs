using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium_project
{
    class Program
    {
        static void Main(string[] args)
        {
            using (IWebDriver driver = new ChromeDriver(@"D:\"))
            {
                string url = "http://localhost:57854";
                driver.Navigate().GoToUrl(url);
                Thread.Sleep(5000);

                IWebElement element = driver.FindElement(By.Id("1"));
                element.Click();
                Thread.Sleep(3000);

                IWebElement button = driver.FindElement(By.Id("proceed"));
                button.Click();

                Thread.Sleep(5000);
                driver.Quit();
            }
        }
    }
}
