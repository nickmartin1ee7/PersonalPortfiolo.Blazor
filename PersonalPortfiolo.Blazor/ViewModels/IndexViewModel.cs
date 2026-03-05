using PersonalPortfiolo.Blazor.Models;
using PersonalPortfiolo.Blazor.Services;

namespace PersonalPortfiolo.Blazor.ViewModels;

public class IndexViewModel : ViewModelBase
{
    private readonly Settings _settings;
    private bool _isLoading = true;

    public IndexViewModel(ISettingsService settingsService)
    {
        _settings = settingsService.GetSettings();
        IsLoading = false;
    }

    public bool IsLoading
    {
        get => _isLoading;
        set => SetProperty(ref _isLoading, value);
    }

    public string ResumeUri => _settings.ResumeUri ?? string.Empty;
    public string GitHubUri => _settings.GitHubProfileUri ?? string.Empty;
    public string LinkedInUri => _settings.MainLayoutLinks
        .FirstOrDefault(l => l.Title?.Equals("LinkedIn", StringComparison.OrdinalIgnoreCase) == true)?
        .Uri ?? string.Empty;
}
