/*using OpenQA.Selenium;

namespace iTechArt.Enver.Internship.WebDriverAdvanced.Utility;

internal class StartingPage : BasePage
{
    private static Button alertFrameWindowsButton => new(By.XPath("//h5[contains(text(), 'Alerts')]"), "AlertFrameWindowsButton");
    private static Button webTablesButton => new(By.XPath("//span[normalize-space()='Web Tables']"), "AlertFrameWindowsButton");
    private static Button elementsStartButton => new(By.XPath("//h5[contains(text(), 'Elements')]"), "AlertFrameWindowsButton");


    public StartingPage() : base((new Label(By.XPath("//img[@class = 'banner-image']"), "startingMenu")), "Starting Page")
    {
    }
    public void MoveToElementButton()
    {
        elementsStartButton.MoveToElement();
    }

    public void MoveToAlertFrameWindowsButton()
    {
        alertFrameWindowsButton.MoveToElement();
    }

    public void ClickAlertFrameWindowsButton()
    {
        MoveToAlertFrameWindowsButton();
        alertFrameWindowsButton.Click();
    }
    public void ClickElementButton()
    {
        MoveToElementButton();
        elementsStartButton.Click();
    }
    public void MoveToWebTables()
    {
        webTablesButton.MoveToElement();
    }
    public void ClickWebTablesButton()
    {
        MoveToWebTables();
        webTablesButton.Click();
    }
}*/