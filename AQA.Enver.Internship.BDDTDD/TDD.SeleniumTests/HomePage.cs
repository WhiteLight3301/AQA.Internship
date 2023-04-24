namespace AQA.Enver.Internship.BDDTDD.TDD.SeleniumTests;

public class HomePage
{
    public HomePage(IWebDriver webDriver)
    {
        WebDriver = webDriver;
    }

    private IWebDriver WebDriver { get; }

    private IWebElement LoginButton => WebDriver.FindElement(By.XPath("//input[@id='login-button']"));
    private IWebElement UsernameInput => WebDriver.FindElement(By.XPath("//input[@id='user-name']"));
    private IWebElement PasswordInput => WebDriver.FindElement(By.XPath("//input[@id='password']"));
    private IWebElement DropDownMenu => WebDriver.FindElement(By.XPath("//select[@class='product_sort_container']"));
    private IWebElement HomePageIcon => WebDriver.FindElement(By.XPath("//div[@class='app_logo']"));
    private IWebElement SortPriceButton => WebDriver.FindElement(By.XPath("//option[@value='hilo']"));
    private IWebElement HighestPrice => WebDriver.FindElement(By.XPath("//div[@class='inventory_item_price']"));
    private IWebElement FirstItem => WebDriver.FindElement(By.XPath("//button[@id='add-to-cart-sauce-labs-fleece-jacket']"));
    private IWebElement SecondItem => WebDriver.FindElement(By.XPath("//button[@id='add-to-cart-sauce-labs-bolt-t-shirt']"));
    private IWebElement  CartIcon => WebDriver.FindElement(By.XPath("//a[@class='shopping_cart_link']"));
    private IWebElement FirstRemoveButton =>   WebDriver.FindElement(By.XPath("//button[@id='remove-sauce-labs-backpack']"));
    private IWebElement SecondRemoveButton =>   WebDriver.FindElement(By.XPath("remove-sauce-labs-fleece-jacket']"));
    private IWebElement ContinueShoppingButton => WebDriver.FindElement(By.XPath("//button[@id='continue-shopping']"));
    private IWebElement FirstItemInCart => WebDriver.FindElement(By.XPath("//div[@class='inventory_item_name']"));
    private IWebElement SecondItemInCart => WebDriver.FindElement(By.XPath("//div[@class='inventory_item_name']"));
    private IWebElement AlphabeticSortButton => WebDriver.FindElement(By.XPath("//option[@value='za']"));
    private IWebElement RightSideMenuButton => WebDriver.FindElement(By.XPath("//button[@id='react-burger-menu-btn']"));
    private IWebElement LogOutButton => WebDriver.FindElement(By.XPath("//button[@id='logout_sidebar_link']"));
    private IWebElement FirstItemInARow => WebDriver.FindElement(By.XPath("//div[contains(text(),'Test.allTheThings() T-Shirt (Red)')]"));

    public void Open(string url)
    {
        WebDriver.Navigate().GoToUrl(url);
    }

    public void ClickLoginIcon()
    {
        LoginButton.Click();
    }

    public void FillUsernameInput(string user)
    {
        UsernameInput.SendKeys(user);
    }

    public void FillPasswordInput(string password)
    {
        PasswordInput.SendKeys(password);
    }


    public void CloseBrowser()
    {
        WebDriver.Quit();
    }

    public void AddItemsToCart()
    {
        FirstItem.Click();
        SecondItem.Click();
    }

    public void RemoveItems()
    {
        FirstRemoveButton.Click();
        SecondRemoveButton.Click();
    }
    
    public bool HomePageDisplayed()
    {
        return HomePageIcon.Displayed;
    }

    public void ClickDropDownMenu()
    {
        DropDownMenu.Click();
    }

    public void ClickOnSortPriceButton()
    {
        SortPriceButton.Click();
    }

    public string HighestPriceItem()
    {
        return HighestPrice.Text;
    }

    public void ClickOnCartIcon()
    {
        CartIcon.Click();
    }

    public bool FirstItemDisplayed()
    {
        return FirstItem.Displayed;
    }

    public void MainPageReturn()
    {
        ContinueShoppingButton.Click();
    }

    public bool FirstItemInCartDisplayed()
    {
        return FirstItemInCart.Displayed;
    }
    
    public bool SecondItemInCartDisplayed()
    {
        return SecondItemInCart.Displayed;
    }

    public void ClickOnAlphabaticOrderButton()
    {
        AlphabeticSortButton.Click();
    }

    public void ClickOnRightSideMenu()
    {
        RightSideMenuButton.Click();
    }

    public void ClickOnLogOutButton()
    {
        LogOutButton.Click();
    }
    
    public bool IsItemsSortAlphabaticaly()
    {
        return FirstItemInARow.Displayed;
    }
}