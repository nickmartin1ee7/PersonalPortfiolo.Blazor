using PersonalPortfiolo.Blazor.Models;
using PersonalPortfiolo.Blazor.Services;

namespace PersonalPortfiolo.Blazor.ViewModels;

public class ContactViewModel : ViewModelBase
{
    private readonly Settings _settings;
    private bool _isLoading = true;

    public ContactViewModel(ISettingsService settingsService)
    {
        _settings = settingsService.GetSettings();
        IsLoading = false;
    }

    public bool IsLoading
    {
        get => _isLoading;
        set => SetProperty(ref _isLoading, value);
    }

    public IReadOnlyList<MainLayoutLink> ContactLinks => _settings.MainLayoutLinks;
    public string ResumeLink => _settings.ResumeUri ?? string.Empty;
}
