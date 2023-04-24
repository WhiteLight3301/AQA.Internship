using AQA.Enver.Internship.WebDriverAdvancedPartTwo.Base;
using AQA.Enver.Internship.WebDriverAdvancedPartTwo.Browser;
using AQA.Enver.Internship.WebDriverAdvancedPartTwo.Pages;

namespace AQA.Enver.Internship.WebDriverAdvancedPartTwo.Tests;

public class Hovers:BaseTest
{
    [Test]
    public void HoverTest()
    {
        HoversPage hovers = new HoversPage();
        hovers.GoToUrl();
        Assert.IsTrue(hovers.IsHoversLabelDisplayed());
        hovers.MoveCursorToTheFirstUser();
        Assert.AreEqual("name: user1",hovers.GetFirstUserName());
        hovers.IsFirstUserLinkDisplayed();
        hovers.ClickFirstUserProfile();
        Assert.IsTrue(BrowserFactory.GetDriver().Url.Contains("users/1"));
        hovers.ReturnToMainPage();
        Assert.IsTrue(hovers.IsHoversLabelDisplayed());
        hovers.MoveCursorToTheSecondUser();
        Assert.AreEqual("name: user2",hovers.GetSecondUserName());
        hovers.IsSecondUserLinkDisplayed();
        hovers.ClickSecondUserProfile();
        Assert.IsTrue(BrowserFactory.GetDriver().Url.Contains("users/2"));
        hovers.ReturnToMainPage();
        Assert.IsTrue(hovers.IsHoversLabelDisplayed());
        hovers.MoveCursorToTheThirdUser();
        Assert.AreEqual("name: user3",hovers.GetThirdUserName());
        hovers.IsThirdUserLinkDisplayed();
        hovers.ClickThirdUserProfile();
        Assert.IsTrue(BrowserFactory.GetDriver().Url.Contains("users/3"));
        hovers.ReturnToMainPage();
        Assert.IsTrue(hovers.IsHoversLabelDisplayed());
    }
}