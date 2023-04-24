namespace AQA.Enver.Internship.WebDriverBasics.Utility;

internal static class ConfigManager
{
    public static ConfigData Config;

    private static string _configsettingsPath = Directory.GetParent(@"../../../")?.FullName +
                                               Path.DirectorySeparatorChar + "/Resources/configSettings.json";
    
    public static void InitializeConfigData()
    {
        Config = new ConfigData();
        ConfigurationBuilder builder = new ConfigurationBuilder();
        builder.AddJsonFile(_configsettingsPath);
        IConfigurationRoot configuration = builder.Build();
        configuration.Bind(Config);
    }
}

