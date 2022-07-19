namespace PersonalPortfiolo.Blazor.Models;

public class Settings
{
    public MainLayoutLink[]? MainLayoutLinks { get; set; }
}

public class MainLayoutLink
{
    public string? Title { get; set; }
    public string? Uri { get; set; }
}