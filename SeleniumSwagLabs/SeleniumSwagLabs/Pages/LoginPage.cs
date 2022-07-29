using OpenQA.Selenium;
namespace SeleniumSwagLabs
{
    public class LoginPage : UtilityClass
    {
        //variables to store the elementlocators of the login page
        
        private IWebDriver driver;
        private By username = By.Id("user-name");
        private By password = By.Id("password");
        private By loginbutton = By.Id("login-button");
        private By errorField = By.XPath("//*[@id='login_button_container']/div/form/div[3]");
        private By userNameField = By.CssSelector("#user-name");
        private By passwordField = By.CssSelector("#password");
        private By loginPagelogo = By.XPath("//*[@id='root']/div/div[2]/div[1]/div[2]");
        private By loginNameLogo = By.XPath("//*[@id='root']/div/div[1]");

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

       public void loginUserName(string usernameValue)
        {
            driver.FindElement(username).SendKeys(usernameValue);
        }

        public void loginPassword(string passwordValue)
        {
            driver.FindElement(password).SendKeys(passwordValue);
        }

        public HomePage loginButton()
        {
            driver.FindElement(loginbutton).Click();
            return new HomePage(driver);
        }

        public void errorFieldMessage()
        {
            driver.FindElement(errorField).Click();
        }
        public bool validateUserField()
        {
           return driver.FindElement(userNameField).Displayed;
        }

        public bool validatePasswordField()
        {
            return driver.FindElement(passwordField).Displayed;
        }
        public bool validateLoginPageLogo()
        {
            return driver.FindElement(loginPagelogo).Displayed; 
        }
        public bool validateLoginNameLogo()
        {
            return driver.FindElement(loginNameLogo).Displayed;
        }
    }
}
