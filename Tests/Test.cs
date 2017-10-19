using NUnit.Framework;
using PenkiosDioptrijos;
using OpenQA.Selenium;
using System.Threading;

namespace Test
{     [TestFixture]     public class UnitTests     {
        private TestBase testBase = new TestBase();
        private IWebDriver driver;
        
        [SetUp]
        public void TestInitialize()
        {
            driver = testBase.GetDriverInstance();
        }

        [Test]         public void TestMethod()         {
            var inputElement = driver.FindElement(By.Id("lst-ib"));
            inputElement.SendKeys("Google");
            inputElement.Submit();
            Thread.Sleep(5000);
        }

        [TearDown]
        public void Clean()
        {
            testBase.CleanUp();
        }
    }
} 