using AQA.Enver.Internship.BDDTDD.TDD.SeleniumTests;

namespace AQA.Enver.Internship.BDDTDD.BDD.UITests;

[Binding]
public class RemoveItemSteps
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

    [Then(@"I fill in login form")]
    public void ThenIFillInLoginForm()
    {
        _homePage.FillUsernameInput("standard_user");
        _homePage.FillPasswordInput("secret_sauce");
    }

    [Then(@"I click login button")]
    public void ThenIClickLoginButton()
    {
        _homePage.ClickLoginIcon();
    }

    [Then(@"I click on Add to cart on random item")]
    public void ThenIClickOnAddToCartOnRandomItem()
    {
        _homePage.AddItemsToCart();
    }

    [When(@"I go to cart page")]
    public void WhenIGoToCartPage()
    {
        _homePage.ClickOnCartIcon();
    }

    [When(@"I click remove button")]
    public void WhenIClickRemoveButton()
    {
       _homePage.RemoveItems();
    }

    [Then(@"the result is empty cart")]
    public void ThenTheResultIsEmptyCart()
    {
        _homePage.MainPageReturn();
    }
}