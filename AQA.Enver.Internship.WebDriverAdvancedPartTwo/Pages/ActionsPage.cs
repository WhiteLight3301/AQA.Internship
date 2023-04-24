using AQA.Enver.Internship.WebDriverAdvancedPartTwo.Browser;

namespace AQA.Enver.Internship.WebDriverAdvancedPartTwo.Pages;

public class ActionsPage
{
    private static IWebElement SliderPageLabel => BrowserFactory.GetDriver().FindElement(By.XPath("//h3[contains(text(),'Horizontal')]"));
    private static IWebElement Slider => BrowserFactory.GetDriver().FindElement(By.XPath("//input[@type='range']"));
    private static IWebElement SliderNumber => BrowserFactory.GetDriver().FindElement(By.CssSelector("#range"));
    public bool IsMainPageDisplayed()
    {
        return SliderPageLabel.Displayed;
    }

    public void GoToUrl()
    {
        String URL = "http://the-internet.herokuapp.com/horizontal_slider";
        BrowserFactory.GetDriver().Navigate().GoToUrl(URL);
    }

    public void ShiftTheSlider()
    {
        Actions actions = new Actions(BrowserFactory.GetDriver());
        actions.DragAndDropToOffset(Slider,10,20).Perform();
    }

    public string SliderPoint()
    {
        return SliderNumber.Text;
    }



}