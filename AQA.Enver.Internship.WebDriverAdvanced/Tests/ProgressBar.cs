using AQA.Enver.Internship.WebDriverAdvanced.Base;

namespace AQA.Enver.Internship.WebDriverAdvanced.Tests;

public class ProgressBar:BaseTest
{
    [Test]
    public void ProgressBarTest()
    {
        Assert.IsTrue(ProgressBarPage.IsFormOpen());
        ProgressBarPage.WidgetsPageOpen();
        ProgressBarPage.ProgressBarPageOpen();
        ProgressBarPage.IsProgressBarPageDisplayed();
        ProgressBarPage.ClickStartButton();
        ProgressBarPage.WaitUntilNeccesaryPersent();
    }
}