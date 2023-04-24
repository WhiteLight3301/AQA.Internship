using AQA.Enver.Internship.BDDTDD.TDD.SeleniumTests;

namespace AQA.Enver.Internship.BDDTDD.BDD.UITests;

[Binding]
public class Login
{
    private HomePage _homePage;
    
    [Given(@"I go to website saucedemo\.com")]
    public void GivenIGoToWebsiteSaucedemoCom()
    {
        var webDriver = new ChromeDriver();
        webDriver.Manage().Window.Maximize();
        _homePage = new HomePage(webDriver);
        _homePage.Open("https://www.demoblaze.com/");
    }
    
    [Given(@"I fill in Username field")]
    public void GivenIFillInUsernameField()
    {
        _homePage.FillUsernameInput("field");
    }

    [Given(@"I fill in Password field")]
    public void GivenIFillInPasswordField()
    {
        _homePage.FillPasswordInput("field");
    }

    [When(@"I click login button")]
    public void WhenIClickLoginButton()
    {
        _homePage.ClickLoginIcon();
    }

    [Then(@"I should be logged in")]
    public void ThenIShouldBeLoggedIn()
    {
        _homePage.HomePageDisplayed();
    }
}