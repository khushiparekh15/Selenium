using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace SeleniumFix
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();

            // Open the app
            driver.Navigate().GoToUrl("https://qedge.intaspharma.com/qedgedc_quality/");

            // Optional: wait for page to load
            Thread.Sleep(2000);

            // Find username, password fields, and login button
            driver.FindElement(By.Id("username")).SendKeys("your_username");
            driver.FindElement(By.Id("password")).SendKeys("your_password");
            driver.FindElement(By.Id("submit")).Click();

            // Optional: Validate login success
            Thread.Sleep(2000);
            Console.WriteLine("Login test completed.");

            driver.Quit();
        }
    }
}