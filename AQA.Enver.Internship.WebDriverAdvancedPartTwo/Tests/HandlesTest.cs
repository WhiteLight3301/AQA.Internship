using AQA.Enver.Internship.WebDriverAdvancedPartTwo.Base;
using AQA.Enver.Internship.WebDriverAdvancedPartTwo.Browser;
using AQA.Enver.Internship.WebDriverAdvancedPartTwo.Pages;

namespace AQA.Enver.Internship.WebDriverAdvancedPartTwo.Tests;

public class HandlesTest:BaseTest
{
    [Test]
    public void TestHandles()
    {
        HandlesPage handles = new HandlesPage();
        handles.GoToUrl();
        Assert.IsTrue(handles.IsHandlesLabelDisplayed());
        handles.ClickOnClickHereButton();
        Assert.AreEqual(BrowserFactory.GetDriver().WindowHandles.Count,2);
        handles.SwitchWindow();
        Assert.AreEqual("New Window",handles.GetPageText());
        Assert.AreEqual("New Window",BrowserFactory.GetDriver().Title);
        handles.ReturnToTab();
        Assert.IsTrue(handles.IsHandlesLabelDisplayed());
        handles.ClickOnClickHereButton();
        handles.SwitchWindow();
        Assert.AreEqual(BrowserFactory.GetDriver().WindowHandles.Count,3);
        Assert.AreEqual("New Window",handles.GetPageText());
        Assert.AreEqual("New Window",BrowserFactory.GetDriver().Title);
        handles.CloseSecondTab();
        Assert.AreEqual(BrowserFactory.GetDriver().WindowHandles.Count, 2);
        handles.CloseMainTab();
        Assert.AreEqual(BrowserFactory.GetDriver().WindowHandles.Count, 1);
        handles.CloseThirdTab();
    }
}