using Microsoft.Extensions.Configuration;
using PersonalPortfiolo.Blazor.Models;

namespace PersonalPortfiolo.Blazor.Services;

public interface ISettingsService
{
    Settings GetSettings();
}

public class SettingsService : ISettingsService
{
    private readonly Settings _settings;

    public SettingsService(IConfiguration configuration)
    {
        _settings = configuration.GetSection(nameof(Settings)).Get<Settings>() 
            ?? throw new Exception($"{nameof(Settings)} failed to instantiate");
    }

    public Settings GetSettings() => _settings;
}
