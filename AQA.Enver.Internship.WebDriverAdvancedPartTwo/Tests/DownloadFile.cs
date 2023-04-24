using AQA.Enver.Internship.WebDriverAdvancedPartTwo.Base;
using AQA.Enver.Internship.WebDriverAdvancedPartTwo.Pages;

namespace AQA.Enver.Internship.WebDriverAdvancedPartTwo.Tests;

public class DownloadFile:BaseTest
{
    [Test]
    public void DownloadTest()
    {
        Download download = new Download();
        download.GoToUrl();
        Assert.IsTrue(download.IsDownloaderPageDisplayed());
        download.DownloadFile();
    }
}