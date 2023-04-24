using AQA.Enver.Internship.WebDriverAdvanced.Base;
using AQA.Enver.Internship.WebDriverAdvanced.Pages;
using AQA.Enver.Internship.WebDriverAdvanced.Utility;

namespace AQA.Enver.Internship.WebDriverAdvanced.Tests;

public class Alerts:BaseTest
{
   [Test]
   public void AlertsTest()
   {
      Assert.IsTrue(AlertsPage.IsFormOpen());
      AlertsPage.ClickAlertFrameWindowsButton(); 
      AlertsPage.ClickAlertsButton();
      AlertsPage.IsAlertFormDisplayed();
      AlertsPage.ClickAlertsButton();
      AlertsPage.ClickAlertButton();
      Assert.That(AlertWork.GetAcceptAlertScript().Contains("You clicked a button"));
      Assert.IsFalse(AlertWork.IsAcceptAlert());
      AlertsPage.ClickConfirmBoxButton();
      Assert.That(AlertWork.GetAlertTextScript().Contains("Do you confirm action?"));
      AlertsPage.ClickOkButton();
      Assert.AreEqual("You selected Ok",AlertsPage.GetConfirmBoxText());
      AlertsPage.ClickOnPromptBox();
      Assert.AreEqual("Please enter your name",AlertsPage.GetPromptBoxText());
      AlertsPage.PromptSendTextScript();
      AlertsPage.ClickOkButton();
      Assert.AreEqual($"You entered {AlertsPage.GetRandomText()}",AlertsPage.ConfirmPromptBoxText());
   }
}