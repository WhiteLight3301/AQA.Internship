using AQA.Enver.Internship.BDDTDD.TDD.SeleniumTests;

namespace AQA.Enver.Internship.BDDTDD.BDD.UITests;

[Binding]
public class PriceSortSteps
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
    
    [Given(@"I am filling in Username field")]
    public void GivenIAmFillingInUsernameField()
    {
        _homePage.FillUsernameInput("standard_user");
    }

    [Given(@"I am filling in Password field")]
    public void GivenIAmFillingInPasswordField()
    {
        _homePage.FillPasswordInput("secret_sauce");
    }

    [When(@"I am clicking login button")]
    public void WhenIAmClickingLoginButton()
    {
        _homePage.ClickLoginIcon();
    }

    [When(@"I click the filter dropdowm menu")]
    public void WhenIClickTheFilterDropdowmMenu()
    {
        _homePage.ClickDropDownMenu();
    }

    [When(@"I choose Price\(high to low\)")]
    public void WhenIChoosePriceHighToLow()
    {
        _homePage.ClickOnSortPriceButton();
    }

    [Then(@"goods become sorted from highest price to lowest")]
    public void ThenGoodsBecomeSortedFromHighestPriceToLowest()
    {
        Assert.AreEqual(49.99,_homePage.HighestPriceItem());
    }
}