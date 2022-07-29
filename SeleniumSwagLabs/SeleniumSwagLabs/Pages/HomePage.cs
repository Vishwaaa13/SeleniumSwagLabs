using OpenQA.Selenium;
namespace SeleniumSwagLabs
{
    public class HomePage : UtilityClass
    {
        private IWebDriver driver;
        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}
