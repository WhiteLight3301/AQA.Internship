using AQA.Enver.Internship.WebDriverBasics.Browser;

namespace AQA.Enver.Internship.WebDriverBasics;

public class OnlinerHomePage
{
    private IWebElement MainPageLogo =>  BrowserFactory.GetDriver().FindElement(By.XPath("//img[@class='onliner_logo']"));
    private IWebElement MobilePhoneButton => BrowserFactory.GetDriver().FindElement(By.XPath("//span[contains(text(),'Мобильные телефоны')]"));
    private IWebElement AppleCheckBox => BrowserFactory.GetDriver().FindElement(By.XPath("//input[@value='apple']"));
    private IWebElement HonorCheckBox => BrowserFactory.GetDriver().FindElement(By.XPath("//input[@value='honor']"));
    private IWebElement FirstPick => BrowserFactory.GetDriver().FindElement(By.XPath("//label[@title='В сравнение']//span"));
    private IWebElement SecondPick => BrowserFactory.GetDriver().FindElement(By.XPath("/html/body/div[1]/div/div/div/div/div/div[2]/div[1]/div[4]/div[3]/div[4]/div[5]/div/div[1]/div[1]/div/label/span"));
    private IWebElement Comparing => BrowserFactory.GetDriver().FindElement(By.XPath("//span[contains(text(),'2 товара')]"));
    private IWebElement CompareButton => BrowserFactory.GetDriver().FindElement(By.XPath("//a[contains(@target,'_parent')]"));
    private IWebElement DescriptionButton => BrowserFactory.GetDriver().FindElement(By.XPath("//span[@data-tip-term='Описание']"));
    private IWebElement DescriptionField => BrowserFactory.GetDriver().FindElement(By.XPath("//span[contains(text(),'Описание')]/parent::td"));
    
    public bool IsMainPageOpened()
    {
        return MainPageLogo.Displayed;
    }

    public void ClickOnMobilePhoneLink()
    {
        MobilePhoneButton.Click();
    }

    public string DescriptionText()
    {
        String textInTheBox = DescriptionButton.GetAttribute("data-tip-text");
        return textInTheBox;
    }

    public void ReturnToPhonePage()
    {
        BrowserFactory.GetDriver().Navigate().Back();
    }
    
    public string PhonePageHeader()
    {
        string header = BrowserFactory.GetDriver().FindElement(By.XPath("//h1[contains(text(),'Мобильные телефоны')]")).Text;
        return header;
    }

    public void ExcludeHonorFromList()
    {
        IJavaScriptExecutor js = (IJavaScriptExecutor)BrowserFactory.GetDriver();
        js.ExecuteScript("arguments[0].click()", HonorCheckBox);
    }

    public void MoveToDescription()
    {
        Actions action = new Actions(BrowserFactory.GetDriver());
        action.MoveToElement(DescriptionField);
        action.Perform();
    }

    public bool HonorPhoneExcluded()
    {
        if (HonorCheckBox.Selected)
        {
            return false;
        }
        else return true;
    }

    public string GoodsComparer()
    {
        return Comparing.Text;
    }

    public void PickPhones()
    {
        IJavaScriptExecutor js = (IJavaScriptExecutor)BrowserFactory.GetDriver();
        js.ExecuteScript("arguments[0].click()", FirstPick);
        js.ExecuteScript("arguments[0].click()", SecondPick);
    }
    
    public void CheckBoxPhoneClick()
    { 
        IJavaScriptExecutor js = (IJavaScriptExecutor)BrowserFactory.GetDriver();
        js.ExecuteScript("arguments[0].click()", AppleCheckBox);
        js.ExecuteScript("arguments[0].click()", HonorCheckBox);
    }

    public void ClickCompareButton()
    {
        CompareButton.Click();
    }

    public void ClickOnDescriptionButton()
    {
        DescriptionButton.Click();
    }
}