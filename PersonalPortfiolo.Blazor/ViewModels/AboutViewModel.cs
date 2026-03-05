using Microsoft.JSInterop;
using PersonalPortfiolo.Blazor.Models;
using PersonalPortfiolo.Blazor.Services;

namespace PersonalPortfiolo.Blazor.ViewModels;

public class AboutViewModel : ViewModelBase
{
    private readonly Settings _settings;
    private readonly IJSRuntime _jsRuntime;
    private bool _isLoading = true;

    public AboutViewModel(ISettingsService settingsService, IJSRuntime jsRuntime)
    {
        _settings = settingsService.GetSettings();
        _jsRuntime = jsRuntime;
        IsLoading = false;
    }

    public bool IsLoading
    {
        get => _isLoading;
        set => SetProperty(ref _isLoading, value);
    }

    public string ResumeUri => _settings.ResumeUri ?? string.Empty;

    public async Task OpenResume() =>
        await _jsRuntime.InvokeVoidAsync("open", ResumeUri);
}
