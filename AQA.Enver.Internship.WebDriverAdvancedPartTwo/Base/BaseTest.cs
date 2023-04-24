using AQA.Enver.Internship.WebDriverAdvancedPartTwo.Browser;
using AQA.Enver.Internship.WebDriverAdvancedPartTwo.Utility;

namespace AQA.Enver.Internship.WebDriverAdvancedPartTwo.Base;

[TestFixture]
public abstract class BaseTest
{
    
    
    [SetUp]
    public void SetUp()
    {
        ConfigManager.InitializeConfigData();
        BrowserFactory.GetDriver().Manage().Window.Maximize();
    }

    [TearDown]
    public void TearDown()
    {
        BrowserFactory.GetDriver().Quit();
    }
}
