using AQA.Enver.Internship.WebDriverAdvancedPartTwo.Browser;

namespace AQA.Enver.Internship.WebDriverAdvancedPartTwo.Pages;

public class Download
{
    private static IWebElement DownloaderPageLabel => BrowserFactory.GetDriver().FindElement(By.XPath("//h3[contains(text(),'Downloader')]"));

    private static IWebElement DownloadedFile => BrowserFactory.GetDriver().FindElement(By.XPath("//a[contains(text(),'logo.jpeg')]"));    
    
    public void GoToUrl()
    {
        String URL = "http://the-internet.herokuapp.com/download";
        BrowserFactory.GetDriver().Navigate().GoToUrl(URL);
    }

    public bool IsDownloaderPageDisplayed()
    {
        return DownloaderPageLabel.Displayed;
    }

    public void DownloadFile()
    {
        DownloadedFile.Click();
        
    }
}