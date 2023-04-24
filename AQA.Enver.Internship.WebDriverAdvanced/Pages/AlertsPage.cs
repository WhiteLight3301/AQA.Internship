using AQA.Enver.Internship.WebDriverAdvanced.Base;
using AQA.Enver.Internship.WebDriverAdvanced.Browser;

namespace AQA.Enver.Internship.WebDriverAdvanced.Pages;

public class AlertsPage:BasePage
{
    private static  IWebElement AlertFrameWindowsButton => BrowserFactory.GetDriver().FindElement(By.XPath("//h5[contains(text(), 'Alerts')]"));
    private static  IWebElement AlertButton => BrowserFactory.GetDriver().FindElement(By.CssSelector("#alertButton"));
    private static  IWebElement AlertsButton => BrowserFactory.GetDriver().FindElement(By.XPath("//span[contains(text(),'Alerts')]"));
    private static  IWebElement StartingPage => BrowserFactory.GetDriver().FindElement(By.XPath("//img[@class = 'banner-image']"));
    private static  IWebElement ConfirmBoxButton => BrowserFactory.GetDriver().FindElement(By.CssSelector("#confirmButton"));
    private static  IWebElement ConfirmBoxText =>  BrowserFactory.GetDriver().FindElement(By.CssSelector("#confirmResult"));
    private static  IWebElement PromptBoxClick => BrowserFactory.GetDriver().FindElement(By.CssSelector("#promtButton"));
    private static IWebElement PromptResultText => BrowserFactory.GetDriver().FindElement(By.CssSelector("#promptResult"));
    private static string RandomText => "asdfsdfDr";
    
    public AlertsPage(IWebDriver WebDriver) : base(StartingPage, "AlertsPage")
    {
    }
    
    public void ClickAlertFrameWindowsButton()
    {
        AlertFrameWindowsButton.Click();
    }

    public bool IsAlertFormDisplayed()
    {
        return AlertButton.Displayed;
    }

    public void ClickAlertsButton()
    {
        AlertsButton.Click();
    }
    
    public void ClickAlertButton()
    {
        AlertButton.Click();
    }
    
    public void ClickConfirmBoxButton()
    {
        ConfirmBoxButton.Click();
    }
    
    public void ClickOkButton()
    {
        IAlert alert = BrowserFactory.GetDriver().SwitchTo().Alert();
        alert.Accept();
    }

    public string  GetConfirmBoxText()
    {
        return ConfirmBoxText.Text;
    }

    public void ClickOnPromptBox()
    {
        PromptBoxClick.Click();
    }

    public string GetPromptBoxText()
    {
        IAlert alert = BrowserFactory.GetDriver().SwitchTo().Alert();
        return alert.Text;
    }

    public string GetRandomText()
    {
        return RandomText;
    }

    public static void PromptSendTextScript()
    {
        IAlert alert = BrowserFactory.GetDriver().SwitchTo().Alert();
        alert.SendKeys(RandomText);
    }

    public string ConfirmPromptBoxText()
    {
        return PromptResultText.Text;
    }
}