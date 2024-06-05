namespace WebApplication1.Extensions;

public static class SettingsFilesExtensions
{
    public static void AddSettingsFiles(this IConfigurationBuilder configurationBuilder)
    {
        configurationBuilder.AddJsonFile("appsettings.json");
    }
}