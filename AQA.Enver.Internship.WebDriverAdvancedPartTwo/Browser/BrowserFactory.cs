using AQA.Enver.Internship.WebDriverAdvancedPartTwo.Utility;

namespace AQA.Enver.Internship.WebDriverAdvancedPartTwo.Browser;

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
                     EdgeOptions options = new EdgeOptions();
                     options.AddUserProfilePreference("download.default_directory",@"C:\\Users\\enver\\Desktop\\Newfolder");
                     _driver = new EdgeDriver(options);
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