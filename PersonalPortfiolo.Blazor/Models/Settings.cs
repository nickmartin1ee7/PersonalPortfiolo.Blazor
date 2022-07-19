namespace PersonalPortfiolo.Blazor.Models;

public class Settings
{
    public bool NavBarEnabled { get; set; }
    public MainLayoutLink[]? MainLayoutLinks { get; set; }
}

public class MainLayoutLink
{
    public string? Title { get; set; }
    public string? Uri { get; set; }
}