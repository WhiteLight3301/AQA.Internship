using AQA.Enver.Internship.WebDriverAdvancedPartTwo.Base;
using AQA.Enver.Internship.WebDriverAdvancedPartTwo.Pages;

namespace AQA.Enver.Internship.WebDriverAdvancedPartTwo.Tests;

public class Actions:BaseTest
{
    [Test]
    public void SliderTest()
    {
        ActionsPage action = new ActionsPage();
        action.GoToUrl();
        Assert.IsTrue(action.IsMainPageDisplayed());
        action.ShiftTheSlider();
        Assert.IsTrue(action.SliderPoint().Contains("3"));
    }
}