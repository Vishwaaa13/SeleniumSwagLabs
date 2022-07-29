using TechTalk.SpecFlow;
namespace SeleniumSwagLabs
{
    public class ApplicationHooks : UtilityClass
    {

        public LoginPage lp;
        public HomePage hp;
      // browser is launched and application is opened 
        [BeforeScenario]
        public void BeforeScenario()
        {
            launchBrowser("CHROME");
            launchApp(Url);

            lp = new LoginPage(driver);
            hp = new HomePage(driver);

            implicitWait();
        }
        //browser is closed
        [AfterScenario]
        public void AfterScenario()
        {
            implicitWait();
            closeBrowser();
        }

    }
}
