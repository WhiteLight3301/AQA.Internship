using AQA.Enver.Internship.WebDriverAdvanced.Browser;
using AQA.Enver.Internship.WebDriverAdvanced.Pages;
using AQA.Enver.Internship.WebDriverAdvanced.Utility;

namespace AQA.Enver.Internship.WebDriverAdvanced.Base;

[TestFixture]
public abstract class BaseTest
{
    public AlertsPage      AlertsPage            { get; set; }
    public IframePage      IframePage            { get; set; }
    public ProgressBarPage ProgressBarPage       { get; set; }
    
    [SetUp]
    public void SetUp()
    {
        ConfigManager.InitializeConfigData();
        BrowserFactory.GetDriver().Navigate().GoToUrl(ConfigManager.Config.Url);
        BrowserFactory.GetDriver().Manage().Window.Maximize();
        AlertsPage= new AlertsPage(BrowserFactory.GetDriver());
        IframePage = new IframePage(BrowserFactory.GetDriver());
        ProgressBarPage = new ProgressBarPage(BrowserFactory.GetDriver());
    }

    [TearDown]
    public void TearDown()
    {
        BrowserFactory.GetDriver().Quit();
    }
}
