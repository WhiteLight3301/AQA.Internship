using AQA.Enver.Internship.WebDriverAdvancedPartTwo.Browser;

namespace AQA.Enver.Internship.WebDriverAdvancedPartTwo.Pages;

public class BasicAuthorization
{
    private static IWebElement PageScript =>
        BrowserFactory.GetDriver().FindElement(By.XPath("//p[contains(text(),'Congratulations')]"));

    private string _credentials = "admin";
    private string _url = "https://admin:admin@the-internet.herokuapp.com/basic_auth";

    public void GoToUrl()
    {
        String URL = "https://" + _credentials + ":" + _credentials + "@" + "the-internet.herokuapp.com/basic_auth";
        BrowserFactory.GetDriver().Navigate().GoToUrl(URL);
    }

    public string ScriptText()
    {
        return PageScript.Text;
    }

    public string CurrentUrl()
    {
        return _url;
    }
}