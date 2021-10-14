 using OpenQA.Selenium;

namespace RunnaTest2
{
    class Home
    {
        public const string Url = "https://www.hrblock.com/";
        readonly IWebDriver driver;
        IWebElement btn_signIn;
        IWebElement btn_createAccount;

        public Home(IWebDriver driver) 
        {
            this.driver = driver;
        }
            
        public void GoToRegistrationForm() 
        {
            // Localize elements
            btn_signIn = driver.FindElement(By.ClassName("login-li"));
            btn_createAccount = driver.FindElement(By.XPath("//span[contains(.,'Create Account')]"));

            btn_signIn.Click(); // Click over sign In button
            btn_createAccount.Click(); // Click over create account button
        }    
    }
}
