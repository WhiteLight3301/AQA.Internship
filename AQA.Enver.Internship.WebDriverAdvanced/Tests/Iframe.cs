using AQA.Enver.Internship.WebDriverAdvanced.Base;

namespace AQA.Enver.Internship.WebDriverAdvanced.Tests;

public class Iframe:BaseTest
{
    [Test]
    public void WorkingWithHandlesTest()
    {
        Assert.IsTrue(IframePage.IsFormOpen());
        IframePage.ClickAlertFrameWindowsButton(); 
        IframePage.ClickNestedFramesButton();
        IframePage.IsNestedFramesFormOpened();
        Assert.AreEqual("Parent frame Child Iframe", IframePage.GetParentAndChildFramesText());
        IframePage.EnterFrames();
        IframePage.IsFramesPageDisplayed();
        string firstFrameTxt = IframePage.GetFirstFrameText();
        string secondFrameTxt = IframePage.GetSecondFrameText();
        Assert.AreEqual(firstFrameTxt, secondFrameTxt);
    }
}