using AQA.Enver.Internship.WebDriverAdvancedPartTwo.Browser;

namespace AQA.Enver.Internship.WebDriverAdvancedPartTwo.Pages;

public class Upload
{
    private static IWebElement FileUploadLabel => BrowserFactory.GetDriver().FindElement(By.XPath("//h3[contains(text(),'File')]"));
    private static IWebElement UploadButton => BrowserFactory.GetDriver().FindElement(By.CssSelector("#file-submit"));
    private static IWebElement BrowseButton => BrowserFactory.GetDriver().FindElement(By.CssSelector("#file-upload"));
    private static IWebElement FileUploadScript => BrowserFactory.GetDriver().FindElement(By.XPath("//h3[contains(text(),'File')]"));

    private static IWebElement FileName =>   BrowserFactory.GetDriver().FindElement(By.XPath("//div[contains(text(),'NewFile')]"));
    public void GoToUrl()
    {
        String URL = "http://the-internet.herokuapp.com/upload";
        BrowserFactory.GetDriver().Navigate().GoToUrl(URL);
    }
    
    public bool IsFileUploadPageDisplayed()
    {
        return FileUploadLabel.Displayed;
    }

    public void UploadFile()
    {
        UploadButton.Click();
    }

    public void BrowseFile()
    {
        BrowseButton.SendKeys("C:\\Users\\enver\\Desktop\\NewFile.txt");
    }

    public string UploadedFileName()
    {
       return  FileName.Text;
    }

    public string FileUploadText()
    {
        return FileUploadScript.Text;
    }
}