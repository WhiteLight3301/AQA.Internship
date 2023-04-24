using AQA.Enver.Internship.WebDriverAdvanced.Base;
using AQA.Enver.Internship.WebDriverAdvanced.Browser;

namespace AQA.Enver.Internship.WebDriverAdvanced.Pages;

public class ProgressBarPage: BasePage
{
    private static IWebElement ProgressBarTabButton => BrowserFactory.GetDriver().FindElement(By.XPath("//span[contains(text(),'Progress Bar')]"));
    private static IWebElement ProgrssBarLabel      => BrowserFactory.GetDriver().FindElement(By.XPath("//div[contains(text(),'Progress Bar')]"));
    private static IWebElement StartStopButton => BrowserFactory.GetDriver().FindElement(By.CssSelector("#startStopButton"));
    private static IWebElement WidgetsPage => BrowserFactory.GetDriver().FindElement(By.XPath("//h5[contains(text(), 'Widgets')]"));
    private static  IWebElement StartingPage => BrowserFactory.GetDriver().FindElement(By.XPath("//img[@class = 'banner-image']"));
    private static IWebElement ProgressBar => BrowserFactory.GetDriver().FindElement(By.XPath("//div[@aria-valuenow]"));
   
    public ProgressBarPage(IWebDriver WebDriver) : base(StartingPage, "AlertsPage")
    {
    }

    public void WidgetsPageOpen()
    {
        WidgetsPage.Click();
    }

    public void ProgressBarPageOpen()
    {
        IJavaScriptExecutor jst = (IJavaScriptExecutor)BrowserFactory.GetDriver();
        jst.ExecuteScript("arguments[0].scrollIntoView(true);", ProgressBarTabButton);
        ProgressBarTabButton.Click();
    }

    public bool IsProgressBarPageDisplayed()
    {
        return ProgrssBarLabel.Displayed;
    }

    public void ClickStartButton()
    {
        StartStopButton.Click();
    }

    public void WaitUntilNeccesaryPersent()
    {
        for(int i = 0; i<= 1000; i++)
        {
            if (ProgressBar.GetAttribute("aria-valuenow").Equals("46"))
            {
                StartStopButton.Click();
                break;
            }
        }
    }
}