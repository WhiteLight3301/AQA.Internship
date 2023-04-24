using System.Collections.ObjectModel;
using AQA.Enver.Internship.WebDriverAdvancedPartTwo.Browser;

namespace AQA.Enver.Internship.WebDriverAdvancedPartTwo.Pages;

public class HandlesPage
{ 
    private static IWebElement HandlesLabel => BrowserFactory.GetDriver().FindElement(By.XPath("//h3[contains(text(),'Opening')]"));
    private static IWebElement PageText => BrowserFactory.GetDriver().FindElement(By.XPath("//h3[contains(text(),'Window')]"));
    private static IWebElement ClickHereButton => BrowserFactory.GetDriver().FindElement(By.XPath("//a[contains(text(),'Click Here')]"));
    private static ReadOnlyCollection<string> _windows = BrowserFactory.GetDriver().WindowHandles;
    private static readonly string FirstWindowId = BrowserFactory.GetDriver().CurrentWindowHandle;

    public void GoToUrl()
    {
        String URL = "http://the-internet.herokuapp.com/windows";
        BrowserFactory.GetDriver().Navigate().GoToUrl(URL);
        WebDriverWait wait = new WebDriverWait(BrowserFactory.GetDriver(), TimeSpan.FromSeconds(10));
        wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//h3[contains(text(),'Opening')]")));
    }

    public void CloseSecondTab()
    {
        var secondTab = BrowserFactory.GetDriver().WindowHandles[1];
        BrowserFactory.GetDriver().SwitchTo().Window(secondTab);
        BrowserFactory.GetDriver().Close();
    }

    public void CloseMainTab()
    {
        var mainTab = BrowserFactory.GetDriver().WindowHandles[0];
        BrowserFactory.GetDriver().SwitchTo().Window(mainTab);
        BrowserFactory.GetDriver().Close();
    }

    public void CloseThirdTab()
    {
        var thirdTab = BrowserFactory.GetDriver().WindowHandles[0];
        BrowserFactory.GetDriver().SwitchTo().Window(thirdTab);
        BrowserFactory.GetDriver().Close();
    }

    public void SwitchWindow()
    {
        foreach (var id in _windows)
        {
            if (!id.Contains(FirstWindowId))
            {
                BrowserFactory.GetDriver().SwitchTo().Window(id);
            }
        }
    }

    public void ReturnToTab()
    {
        var newWindowHandle = BrowserFactory.GetDriver().WindowHandles[0];
        BrowserFactory.GetDriver().SwitchTo().Window(newWindowHandle);
    }

    public bool IsHandlesLabelDisplayed()
    {
        
        return HandlesLabel.Displayed;
    }

    public void ClickOnClickHereButton()
    {
        ClickHereButton.Click();
    }

    public string GetPageText()
    {
        return PageText.Text;
    }
}