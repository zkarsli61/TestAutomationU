using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Reflection;
using System.IO;

namespace TestingWithNunit.Tests
{
    public class UITest
    {
        public IWebDriver driver { get; set; }
        [OneTimeSetUp]
        public void StarDriver()
        {
            string driverPath = Path.GetDirectoryName(
                Assembly.GetExecutingAssembly().Location);
            IWebDriver driver = new ChromeDriver(driverPath);
        }
        [OneTimeTearDown]
        public void QuitDriver()
        {
            driver.Quit();
        }
    }
}
