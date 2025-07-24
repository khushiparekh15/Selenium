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

          
            driver.Navigate().GoToUrl("https://qedge.intaspharma.com/qedgedc_quality/");

           
            Thread.Sleep(2000);

            driver.FindElement(By.Id("username")).SendKeys("validation2");
            driver.FindElement(By.Id("password")).SendKeys("zxc123");
            driver.FindElement(By.Id("submit")).Click();

         
            Thread.Sleep(2000);
            Console.WriteLine("Login test completed.");

            driver.Quit();
        }
    }
}