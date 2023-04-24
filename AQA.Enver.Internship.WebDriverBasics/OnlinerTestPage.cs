using AQA.Enver.Internship.WebDriverBasics.Base;
using AQA.Enver.Internship.WebDriverBasics.Browser;
using AQA.Enver.Internship.WebDriverBasics.Utility;

namespace AQA.Enver.Internship.WebDriverBasics;

[TestFixture]
public class OnlinerTestPage:BaseTest
{
    [Test]
    public void OnlinerTest()
    {
        OnlinerHomePage homePage = new OnlinerHomePage();
        Assert.IsTrue(homePage.IsMainPageOpened());
        homePage.ClickOnMobilePhoneLink();
        Assert.AreEqual("Мобильные телефоны",homePage.PhonePageHeader());
        homePage.CheckBoxPhoneClick();
        homePage.ExcludeHonorFromList();
        Assert.IsTrue(homePage.HonorPhoneExcluded());
        homePage.PickPhones();
        Assert.AreEqual("2 товара",homePage.GoodsComparer());
        homePage.ClickCompareButton();
        Assert.IsTrue(BrowserFactory.GetDriver().Title.Contains("Сравнить"));
        homePage.MoveToDescription();
        homePage.ClickOnDescriptionButton();
        Assert.AreEqual(ConfigManager.Config.DescriptionText,homePage.DescriptionText());
        homePage.ReturnToPhonePage();
        Assert.IsTrue(BrowserFactory.GetDriver().Title.Contains("Apple"));
    }
}
