using WebApplication1.Infra;

namespace WebApplication1.Extensions;

public static class SettingsExtensions
{
    public static void AddSettings(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddTransient(p =>
        {
            var configuration = p.GetRequiredService<IConfiguration>();
            var settings = new Settings();
            configuration.Bind(settings);
            return settings;
        });
    }
}