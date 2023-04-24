using AQA.Enver.Internship.WebDriverAdvanced.Base;
using AQA.Enver.Internship.WebDriverAdvanced.Browser;

namespace AQA.Enver.Internship.WebDriverAdvanced.Pages;

public class IframePage : BasePage
{
    private static  IWebElement AlertFrameWindowsButton => BrowserFactory.GetDriver().FindElement(By.XPath("//h5[contains(text(), 'Alerts')]"));
    private static  IWebElement ParentNestedFramesLabel => BrowserFactory.GetDriver().FindElement(By.XPath("//body[text()='Parent frame']"));
    private static  IWebElement NestedFramesButton => BrowserFactory.GetDriver().FindElement(By.XPath("//span[normalize-space()='Nested Frames']"));
    private static  IWebElement NestedFramesHeader => BrowserFactory.GetDriver().FindElement(By.XPath("//div[@class='main-header']"));
    private static  IWebElement StartingPage => BrowserFactory.GetDriver().FindElement(By.XPath("//img[@class = 'banner-image']"));
    private static  IWebElement ChildNestedFramesLabel => BrowserFactory.GetDriver().FindElement(By.XPath("//p[text()='Child Iframe']"));
    private static IWebElement FrameOne =>   BrowserFactory.GetDriver().FindElement(By.CssSelector("#frame1"));
    private static IWebElement SecondFrame => BrowserFactory.GetDriver().FindElement(By.CssSelector("#frame2"));
    private static IWebElement FramesTab =>  BrowserFactory.GetDriver().FindElement(By.XPath("//span[contains(text(),'Frames')]"));
    private static IWebElement FrameTwo =>   BrowserFactory.GetDriver().FindElement(By.XPath("//iframe[contains(@srcdoc, 'Child Iframe')]"));
    private static IWebElement BigFrameText => BrowserFactory.GetDriver().FindElement(By.CssSelector("#sampleHeading")); 
    private static IWebElement FramesPageLabel => BrowserFactory.GetDriver().FindElement(By.XPath("//div[contains(text(),'Frames')]"));

    public IframePage(IWebDriver WebDriver) : base(StartingPage, "Main page")
    {
    }

    public bool IsNestedFramesFormOpened()
    {
        return NestedFramesHeader.Displayed;
    }
    
    public void EnterFrames()
    {
        ReturnToMainFrame();
        IJavaScriptExecutor jst = (IJavaScriptExecutor)BrowserFactory.GetDriver();
        jst.ExecuteScript("arguments[0].scrollIntoView(true);", FramesTab);
        FramesTab.Click();
    }
    
    public string GetParentAndChildFramesText()
    {
        BrowserFactory.GetDriver().SwitchTo().Frame(FrameOne);
        string parentFrameText = ParentNestedFramesLabel.Text;
        BrowserFactory.GetDriver().SwitchTo().Frame(FrameTwo);
        string childFrameText = ChildNestedFramesLabel.Text;
        return parentFrameText + " " + childFrameText;
    }
    
    public static void ReturnToMainFrame()
    {
        var newWindowHandle = BrowserFactory.GetDriver().WindowHandles[0];
        BrowserFactory.GetDriver().SwitchTo().Window(newWindowHandle);
    }

    public bool IsFramesPageDisplayed()
    {
        return FramesPageLabel.Displayed;
    }
    
    public string GetFirstFrameText()
    {
        BrowserFactory.GetDriver().SwitchTo().Frame(FrameOne);
        string frame1Text = BigFrameText.Text;
        return frame1Text;
    }
    public string GetSecondFrameText()
    {
        ReturnToMainFrame();
        BrowserFactory.GetDriver().SwitchTo().Frame(SecondFrame);
        string frame2Text = BigFrameText.Text;
        return frame2Text;
    }

    public void ClickAlertFrameWindowsButton()
    {
        AlertFrameWindowsButton.Click();
    }
    
    public void ClickNestedFramesButton()
    {
        IJavaScriptExecutor jst = (IJavaScriptExecutor)BrowserFactory.GetDriver();
        jst.ExecuteScript("arguments[0].scrollIntoView(true);", NestedFramesButton);
        NestedFramesButton.Click();
    }
}