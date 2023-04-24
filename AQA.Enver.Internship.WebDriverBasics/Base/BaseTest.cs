using AQA.Enver.Internship.WebDriverBasics.Browser;
using AQA.Enver.Internship.WebDriverBasics.Utility;

namespace AQA.Enver.Internship.WebDriverBasics.Base;

[TestFixture]
public abstract class BaseTest
{
    [SetUp]
    public void SetUp()
    {
        ConfigManager.InitializeConfigData();
        BrowserFactory.GetDriver().Navigate().GoToUrl(ConfigManager.Config.Url);
        BrowserFactory.GetDriver().Manage().Window.Maximize();
    }

    [TearDown]
    public void TearDown()
    {
        BrowserFactory.GetDriver().Quit();
    }
}
