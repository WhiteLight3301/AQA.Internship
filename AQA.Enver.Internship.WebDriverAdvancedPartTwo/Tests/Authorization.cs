using AQA.Enver.Internship.WebDriverAdvancedPartTwo.Base;
using AQA.Enver.Internship.WebDriverAdvancedPartTwo.Browser;
using AQA.Enver.Internship.WebDriverAdvancedPartTwo.Pages;
using AQA.Enver.Internship.WebDriverAdvancedPartTwo.Utility;

namespace AQA.Enver.Internship.WebDriverAdvancedPartTwo.Tests;

public class Authorization:BaseTest
{
    [Test]
    public void AuthorizationTest()
    {
        BasicAuthorization authorization = new BasicAuthorization();
        authorization.GoToUrl();
        Assert.AreEqual(authorization.CurrentUrl(),BrowserFactory.GetDriver().Url);
        Assert.AreEqual(ConfigManager.Config.AuthorizationPageText,authorization.ScriptText());
    }
}