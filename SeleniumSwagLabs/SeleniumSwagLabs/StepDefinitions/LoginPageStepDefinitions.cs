using NUnit.Framework;
using TechTalk.SpecFlow;

namespace SeleniumSwagLabs
{
    [Binding]
    public class LoginPageStepDefinitions : ApplicationHooks
    {
        //To open the browser and launch the SwagLabs application
        [Given(@"Chrome is launched and SwagLabs application is launched")]
        public void GivenChromeIsLaunchedAndSwagLabsApplicationIsLaunched()
        {
            browserMaximize();
            implicitWait();
            string expectedTitle = "Swag Labs";
            string actualTitle = validatePageTitle();
            Assert.That(actualTitle, Is.EqualTo(expectedTitle));
            Console.WriteLine(actualTitle);
        }

           //User enters Valid inputs
        [When(@"user enters  ""([^""]*)"" and ""([^""]*)""")]
        public void WhenUserEntersAnd(string uname, string pword)
        {
            implicitWait();
            lp.loginUserName(uname);
            lp.loginPassword(pword);
        }

        //To enter into homepage user clicks on login button
        [When(@"user clicks on login-button")]
        public void WhenUserClicksOnLogin_Button()
        {
            threadSleep();
            hp = lp.loginButton();
        }

        [Then(@"It shows home page")]
        public void ThenItShowsHomePage()
        {
            threadSleep();
            String expectedTitle = "Swag Labs";
            String actualTitle = validatePageTitle();
            Assert.That(actualTitle, Is.EqualTo(expectedTitle));
            Console.WriteLine(actualTitle);
            captureScreenshot();
        }

        //user enters empty inputs 
        [When(@"user enters Username ""([^""]*)"" and Password ""([^""]*)""")]
        public void WhenUserEntersUsernameAndPassword(string uname, string pword)
        {
            implicitWait();
            lp.loginUserName(uname);
            lp.loginPassword(pword);
        }

        [Then(@"Message stating '([^']*)' is displayed on the screen\.")]
        public void ThenMessageStatingIsDisplayedOnThescreen_(string p0)
        {
            threadSleep();
            lp.errorFieldMessage();
            String expectedTitle = "Swag Labs";
            String actualTitle = validatePageTitle();
            Assert.That(actualTitle, Is.EqualTo(expectedTitle));
            Console.WriteLine(actualTitle);
        }

        [Then(@"Message stating '(.*)' is displayed on the Screen\.")]
        public void ThenMessagestatingIsDisplayedOnTheScreen_(string p0)
        {
            threadSleep();
            lp.errorFieldMessage();
            String expectedTitle = "Swag Labs";
            String actualTitle = validatePageTitle();
            Assert.That(actualTitle, Is.EqualTo(expectedTitle));
            Console.WriteLine(actualTitle);
        }

        [Then(@"Message stating '(.*)'  is Displayed on the screen\.")]
        public void ThenMessageStatingIsDisplayedOnTheScreen_(string p0)
        {
            threadSleep();
            lp.errorFieldMessage();
            String expectedTitle = "Swag Labs";
            String actualTitle = validatePageTitle();
            Assert.That(actualTitle, Is.EqualTo(expectedTitle));
            Console.WriteLine(actualTitle);
        }

        // user enters different combinations of inputs
        [When(@"user enters invalid ""([^""]*)"" and ""([^""]*)""")]
        public void WhenUserEntersInvalidAnd(string uname, string pword)
        {
            implicitWait();
            lp.loginUserName(uname);
            lp.loginPassword(pword);
        }

        [Then(@"Message stating '([^']*)' is displayed\.")]
        public void ThenMessageStatingIsDisplayed_(string p0)
        {
            threadSleep();
            lp.errorFieldMessage();
            String expectedTitle = "Swag Labs";
            String actualTitle = validatePageTitle();
            Assert.That(actualTitle, Is.EqualTo(expectedTitle));
            Console.WriteLine(actualTitle);
        }

        // to check username field is visible
        [Then(@"Username Field is visible\.")]
        public void ThenUsernameFieldIsVisible_()
        {
            threadSleep();
            bool flag = lp.validateUserField();
            Assert.That(flag, Is.True);
            Console.WriteLine(flag);
        }

        // to check password field is visible
        [Then(@"Password Field is visible\.")]
        public void ThenPasswordFieldIsVisible_()
        {
            threadSleep();
            bool flag = lp.validatePasswordField();
            Assert.That(flag, Is.True);
            Console.WriteLine(flag);
        }

        //to check logo 
        [Then(@"Swag Lab Logo is present")]
        public void ThenSwagLabLogoIsPresent()
        {
            threadSleep();
            bool flag = lp.validateLoginPageLogo();
            Assert.That(flag, Is.True);
            Console.WriteLine(flag);
        }

        //to check Login logo
        [Then(@"Swag Login-Logo is present")]
        public void ThenSwagLogin_LogoIsPresent()
        {
            threadSleep();
            bool flag = lp.validateLoginNameLogo();
            Assert.That(flag, Is.True);
            Console.WriteLine(flag);
        }

        //User enters Valid username
        [When(@"user Enters valid Username ""([^""]*)"" and Password ""([^""]*)""")]
        public void WhenUserEntersValidUsernameAndPassword(string uname, string pword)
        {
            implicitWait();
            lp.loginUserName(uname);
            lp.loginPassword(pword);
        }

        [Then(@"It shows message stating ""([^""]*)"" is displayed\.")]
        public void ThenItShowsMessageStatingIsDisplayed_(string p0)
        {
            lp.errorFieldMessage();
            String expectedTitle = "Swag Labs";
            String actualTitle = validatePageTitle();
            Assert.That(actualTitle, Is.EqualTo(expectedTitle));
            Console.WriteLine(actualTitle);
        }
    }
}
