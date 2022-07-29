using OpenQA.Selenium;


namespace SeleniumSwagLabs
{
    public class ConfigClass
    {

        public static IWebDriver driver;
        // drivers path
        public static string chromeDriverPath = @"C:\Users\Vishwa\source\repos\SeleniumSwagLabs\SeleniumSwagLabs\drivers\";
        public static string geckoDriverPath = @"C:\Users\Vishwa\source\repos\SeleniumSwagLabs\SeleniumSwagLabs\drivers\";
        // application Url
        public static string Url = "https://www.saucedemo.com/";
         //screenshot path
        public static string filePath = @"C:\Users\Vishwa\source\repos\SeleniumSwagLabs\SeleniumSwagLabs\Screenshots\";

        public static int PAGE_LOAD_TIMEOUT = 10;
        public static int IMPLICIT_WAIT = 10;

    }
}
