namespace AQA.Enver.Internship.Selenium;

public class UzMarketingPageTest
{
    public static IWebDriver Driver = new FirefoxDriver();
    [SetUp]
    public void SetUp()
    {
        Driver.Manage().Window.Maximize();
        Driver.Navigate().GoToUrl("https://uzmarketing.com/");
    }
    
    [Test]
    public void TestingUzMarketingPageVersion2()
    {
        Assert.IsTrue(Driver.FindElement(By.XPath("//img[contains(@alt,'UZ Marketing – Logo Designer')]")).Displayed);
        Driver.FindElement(By.Id("menu-item-1079")).Click();
        Assert.IsTrue(Driver.FindElement(By.XPath("//a[contains(text(),'Marketing Tools')]")).Displayed);
        Driver.FindElement(By.XPath("//a[contains(text(),'  Creative Executions')]")).Click();
        Assert.IsTrue(Driver.FindElement(By.XPath("//h4[contains(text(),'Graphic Design')]")).Displayed);
        Driver.FindElement(By.XPath("//strong[contains(text(),'Contact')]")).Click();
        Assert.AreEqual("Fax: (800) 217-9962",Driver.FindElement(By.XPath("//span[contains(text(),'Fax')]")).Text);
    }
    
    [TearDown]
    public void TearDown()
    {
        Driver.Close();
        Driver.Quit();
    }
}