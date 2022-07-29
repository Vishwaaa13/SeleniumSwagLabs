using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace SeleniumSwagLabs
{
    public class UtilityClass : ConfigClass
    {
        public void launchBrowser(string browser)
        {
            switch (browser)
            {
                case "CHROME": driver = new ChromeDriver(chromeDriverPath);
                    break;

                case "FIREFOX": driver = new FirefoxDriver(chromeDriverPath);
                    break;

                default: throw new ArgumentException("Error");
            }

        }
        //to maximize browser
        public void browserMaximize()
        {
            driver.Manage().Window.Maximize();
        }
        //to load the page
        public void pageLoad()
        {
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(PAGE_LOAD_TIMEOUT);
        }

        // to wait for certain measure of time
        public void implicitWait()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(IMPLICIT_WAIT);
        }

        public void threadSleep()
        {
            Thread.Sleep(3000);
        }

        //to launch app using application url
        public void launchApp(string url)
        {
            driver.Url = Url;
        }

        // to close the browser after performing activities
        public void closeBrowser()
        {
            driver.Quit();
        }

        public string validatePageTitle()
        {
            return driver.Title;
        }

        // to capture screenshot
        public void captureScreenshot()
        {
            ITakesScreenshot screenshotDriver = driver as ITakesScreenshot;
            Screenshot screenshot = screenshotDriver.GetScreenshot();
            screenshot.SaveAsFile(filePath + "/screenshot.png", ScreenshotImageFormat.Png);
        }
    }
}
