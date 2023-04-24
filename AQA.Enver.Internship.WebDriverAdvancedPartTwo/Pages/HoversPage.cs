using AQA.Enver.Internship.WebDriverAdvancedPartTwo.Browser;

namespace AQA.Enver.Internship.WebDriverAdvancedPartTwo.Pages;

public class HoversPage
{
    private static  IWebElement HoversPageLabel => BrowserFactory.GetDriver().FindElement(By.XPath("//h3[contains(text(), 'Hovers')]"));
    private static IWebElement FirstUser => BrowserFactory.GetDriver().FindElement(By.XPath("//div[@class='figcaption']//h5[contains(text(),'user1')]"));
    private static IWebElement FirstUserLink => BrowserFactory.GetDriver().FindElement(By.XPath("//a[@href='/users/1']"));
    private static IWebElement SecondUserLink => BrowserFactory.GetDriver().FindElement(By.XPath("//a[@href='/users/2']"));
    private static IWebElement ThirdUserLink => BrowserFactory.GetDriver().FindElement(By.XPath("//a[@href='/users/3']"));
    private static IWebElement SecondUser => BrowserFactory.GetDriver().FindElement(By.XPath("//div[@class='figcaption']//h5[contains(text(),'user2')]"));
    private static IWebElement ThirdUser => BrowserFactory.GetDriver().FindElement(By.XPath("//div[@class='figcaption']//h5[contains(text(),'user3')]"));
    
    public void GoToUrl()
    { 
        String URL = "http://the-internet.herokuapp.com/hovers";
        BrowserFactory.GetDriver().Navigate().GoToUrl(URL);
    }

    public string GetFirstUserName()
    {
        return FirstUser.Text;
    }
    
    public string GetSecondUserName()
    {
        return SecondUser.Text;
    }
    
    public string GetThirdUserName()
    {
        return ThirdUser.Text;
    }
    
    public bool IsHoversLabelDisplayed()
    {
        return HoversPageLabel.Displayed;
    }
    
    public bool IsFirstUserLinkDisplayed()
    {
        return FirstUserLink.Displayed;
    }
    
    public bool IsThirdUserLinkDisplayed()
    {
        return ThirdUserLink.Displayed;
    }

    public void Coor()
    {
        int x = BrowserFactory.GetDriver().FindElement(By.XPath("/html/body/div[2]/div/div/div[3]")).Location.X;
        int y = BrowserFactory.GetDriver().FindElement(By.XPath("/html/body/div[2]/div/div/div[3]")).Location.Y;
        Console.WriteLine(x);
        Console.WriteLine(y);
    }


    public bool IsSecondUserLinkDisplayed()
    {
        return SecondUser.Displayed;
    }

    public void ClickFirstUserProfile()
    {
        FirstUserLink.Click();
    }
    
    public void ClickThirdUserProfile()
    {
        ThirdUserLink.Click();
    }
    
    public void ClickSecondUserProfile()
    {
        SecondUserLink.Click();
    }
    
    public void ReturnToMainPage()
    {
       BrowserFactory.GetDriver().Navigate().Back();
    }

    public void MoveCursorToTheFirstUser()
    {
        Actions action = new Actions(BrowserFactory.GetDriver());
        action.MoveByOffset(132,134).Perform();
    }
    
    public void MoveCursorToTheThirdUser()
    {
        Actions action = new Actions(BrowserFactory.GetDriver());
        action.MoveByOffset(492,134).Perform();
    }
    
    public void MoveCursorToTheSecondUser()
    {
        Actions action = new Actions(BrowserFactory.GetDriver());
        action.MoveByOffset(312,134).Perform();
    }
}