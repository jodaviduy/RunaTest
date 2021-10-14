using NUnit.Framework;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace RunnaTest2
{
    [TestFixture]
    public class RegistrationTestFixture
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            // Load dependencies and initialize chrome driver before each test execution
            var options = new ChromeOptions();
            options.AddArgument("start-maximized"); // Add option to open browser maximized
            driver = new ChromeDriver("../../../Dependencies/", options); // Create chrome driver
        }

        [TearDown]
        public void TearDown() 
        {
            driver.Quit(); // Quit chrome driver
        }
            
        [Test]
        public void CreateAccountUsingEmail()
        {
            var home = new Home(driver); // Create page representation
            driver.Navigate().GoToUrl(Home.Url); // Navigate to home
            home.GoToRegistrationForm(); 

            System.Threading.Thread.Sleep(3000);
        }

    }
}