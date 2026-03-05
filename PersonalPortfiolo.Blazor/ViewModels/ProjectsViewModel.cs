using PersonalPortfiolo.Blazor.Models;
using PersonalPortfiolo.Blazor.Services;

namespace PersonalPortfiolo.Blazor.ViewModels;

public class ProjectsViewModel : ViewModelBase
{
    private readonly Settings _settings;
    private bool _isLoading = true;

    public ProjectsViewModel(ISettingsService settingsService)
    {
        _settings = settingsService.GetSettings();
        IsLoading = false;
    }

    public bool IsLoading
    {
        get => _isLoading;
        set => SetProperty(ref _isLoading, value);
    }

    public string GitHubProfileUri => _settings.GitHubProfileUri ?? string.Empty;
    public string GitHubProfileApiUri => _settings.GitHubProfileApiUri ?? string.Empty;
}
