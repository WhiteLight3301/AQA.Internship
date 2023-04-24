using AQA.Enver.Internship.WebDriverAdvanced.Browser;

namespace AQA.Enver.Internship.WebDriverAdvanced.Utility;

public class AlertWork
{
    public static string GetAcceptAlertScript()
    {
        WebDriverWait wait = new WebDriverWait(BrowserFactory.GetDriver(), TimeSpan.FromSeconds(10));
        IAlert alert = wait.Until(ExpectedConditions.AlertIsPresent());
        string alertText = alert.Text;
        return alertText;

    }
    
    public static bool IsAcceptAlert()
    {
        WebDriverWait wait = new WebDriverWait(BrowserFactory.GetDriver(), TimeSpan.FromSeconds(10));

        IAlert alert = wait.Until(ExpectedConditions.AlertIsPresent());
        alert.Accept();
        try
        {
            IAlert alertFalse = BrowserFactory.GetDriver().SwitchTo().Alert();
            return true;

        }
        catch (NoAlertPresentException)
        {
            return false;
        }
    }

    public static string GetAlertTextScript()
    {
        IAlert alert = BrowserFactory.GetDriver().SwitchTo().Alert();
        string alertText = alert.Text;
        return alertText;
    }   
}