using AQA.Enver.Internship.WebDriverAdvancedPartTwo.Base;
using AQA.Enver.Internship.WebDriverAdvancedPartTwo.Pages;
using AQA.Enver.Internship.WebDriverAdvancedPartTwo.Utility;

namespace AQA.Enver.Internship.WebDriverAdvancedPartTwo.Tests;

public class UploadImage:BaseTest
{
    [Test]
    public void UploadTest()
    {
        Upload upload = new Upload();
        upload.GoToUrl();
        Assert.IsTrue(upload.IsFileUploadPageDisplayed());
        upload.BrowseFile();
        upload.UploadFile();
        Assert.AreEqual(ConfigManager.Config.FileUploadedText,upload.FileUploadText());
        Assert.AreEqual("NewFile.txt",upload.UploadedFileName());
    }
}