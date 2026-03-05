using PersonalPortfiolo.Blazor.Models;
using PersonalPortfiolo.Blazor.Services;

namespace PersonalPortfiolo.Blazor.ViewModels;

public class AchievementsViewModel : ViewModelBase
{
    private readonly Settings _settings;
    private bool _isLoading = true;

    public AchievementsViewModel(ISettingsService settingsService)
    {
        _settings = settingsService.GetSettings();
        IsLoading = false;
    }

    public bool IsLoading
    {
        get => _isLoading;
        set => SetProperty(ref _isLoading, value);
    }

    public IReadOnlyList<AchievementItem> AchievementItems => _settings.AchievementItems;
}
