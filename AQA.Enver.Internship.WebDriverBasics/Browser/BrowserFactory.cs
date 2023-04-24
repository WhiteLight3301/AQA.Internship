using AQA.Enver.Internship.WebDriverBasics.Utility;

namespace AQA.Enver.Internship.WebDriverBasics.Browser;

 internal static class BrowserFactory
 {
     private static IWebDriver? _driver;

     internal static IWebDriver GetDriver()
     {
         if (_driver == null)
         {
             switch (ConfigManager.Config.BrowserType.ToLower())
             {
                 case "chrome":
                     new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
                     break;
                 case "firefox":
                     new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
                     _driver = new FirefoxDriver();
                     break;
                 case "edge":
                     new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
                     _driver = new EdgeDriver();
                     break;
                 default:
                     throw new ApplicationException("No such browser");
             }
         }
         return _driver;
     }
     
     public static void CloseDriver()
     {
         if (_driver is not null)
         {
             _driver.Quit();
             _driver = null;
         }
     }
 }