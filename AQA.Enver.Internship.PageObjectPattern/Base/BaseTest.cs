using AQA.Enver.Internship.PageObjectPattern.Browser;
using AQA.Enver.Internship.PageObjectPattern.Utility;

namespace AQA.Enver.Internship.PageObjectPattern.Base;

[TestFixture]
public abstract class BaseTest
{
    public OnlinerHomePage  HomePage { get; set; }

    [SetUp]
    public void SetUp()
    {
        ConfigManager.InitializeConfigData();
        BrowserFactory.GetDriver().Navigate().GoToUrl(ConfigManager.Config.Url);
        BrowserFactory.GetDriver().Manage().Window.Maximize();
        HomePage= new OnlinerHomePage(BrowserFactory.GetDriver());
    }

    [TearDown]
    public void TearDown()
    {
        BrowserFactory.GetDriver().Quit();
    }
}
