namespace AQA.Enver.Internship.BDDTDD.TDD.SeleniumTests;

public class Tests
{
    private IWebDriver _webDriver;
    [SetUp]
    public void SetUp()
    {
        _webDriver = new ChromeDriver();
        _webDriver.Manage().Window.Maximize();
    }

    [Test]
    public void AddMultipleItemsToCartTest()
    {
        var homePage = new HomePage(_webDriver);
        
        homePage.Open("https://www.demoblaze.com/");
        homePage.FillUsernameInput("userEmail");
        homePage.FillPasswordInput("password");
        homePage.ClickLoginIcon();
        homePage.AddItemsToCart();
        homePage.ClickOnCartIcon();
        Assert.Multiple(() =>
            {
                Assert.IsTrue(homePage.FirstItemInCartDisplayed());
                Assert.IsTrue(homePage.SecondItemInCartDisplayed());
            }
        );
    }
    
    [Test]
    public void AlphabeticFilterTest()
    {
        var homePage = new HomePage(_webDriver);
        
        homePage.Open("https://www.demoblaze.com/");
        homePage.FillUsernameInput("userEmail");
        homePage.FillPasswordInput("password");
        homePage.ClickLoginIcon();
        homePage.ClickDropDownMenu();
        homePage.ClickOnAlphabaticOrderButton();
        Assert.IsTrue(homePage.IsItemsSortAlphabaticaly());
    }
    
    [Test]
    public void LogOutButtonTest()
    {
        var homePage = new HomePage(_webDriver);
        
        homePage.Open("https://www.demoblaze.com/");
        homePage.FillUsernameInput("userEmail");
        homePage.FillPasswordInput("password");
        homePage.ClickLoginIcon();
        homePage.ClickOnRightSideMenu();
        homePage.ClickOnLogOutButton();
        Assert.IsTrue(homePage.HomePageDisplayed());
    }

    [TearDown]
    public void TearDown()
    {
        var homePage = new HomePage(_webDriver);
        homePage.CloseBrowser();
    }
}